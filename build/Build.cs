﻿using System;
using System.Linq;
using Nuke.CoberturaConverter;
using Nuke.Common;
using Nuke.Common.Git;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.GitVersion;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.CoberturaConverter.CoberturaConverterTasks;

class Build : NukeBuild
{
    // Console application entry point. Also defines the default target.
    public static int Main() => Execute<Build>(x => x.Compile);

    // Auto-injection fields:

    // [GitVersion] readonly GitVersion GitVersion;
    // Semantic versioning. Must have 'GitVersion.CommandLine' referenced.

    // [GitRepository] readonly GitRepository GitRepository;
    // Parses origin, branch name and head from git config.

    // [Parameter] readonly string MyGetApiKey;
    // Returns command-line arguments and environment variables.

    // [Solution] readonly Solution Solution;
    // Provides access to the structure of the solution.

    Target Clean => _ => _
        .Executes(() =>
        {
            DeleteDirectories(GlobDirectories(SolutionDirectory, "**/bin", "**/obj"));
            EnsureCleanDirectory(OutputDirectory);
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(s => DefaultDotNetRestore);
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(s => DefaultDotNetBuild);
        });

    Target Coverage => _ => _
        .DependsOn(Compile)
        .Executes(async () =>
        {
            var openCoverSettings = new ToolSettings()
                .SetToolPath(ToolPathResolver.GetPackageExecutable("OpenCover", @"tools\OpenCover.Console.exe"))
                .SetArgumentConfigurator(args => args
                    .Add("-register:user")
                    .Add("-target:dotnet.exe")
                    .Add("-targetargs:{value}", $"xunit -nobuild -xml \"{OutputDirectory / "testresult.xml"}\"")
                    .Add("-targetdir:{value}", SolutionDirectory / "test" / "iabi.BCF.Tests")
                    .Add("-returntargetcode")
                    .Add("-output:{value}", OutputDirectory / "OpenCover.coverageresults")
                    .Add("-mergeoutput")
                    .Add("-oldStyle")
                    .Add("-excludebyattribute:System.CodeDom.Compiler.GeneratedCodeAttribute")
                    .Add("\"-filter:+[iabi.BCF]* -[*.Tests]* -[*.Tests.*]*\""));

            var coverageProcess = ProcessTasks.StartProcess(openCoverSettings);
            coverageProcess?.WaitForExit();

            await OpenCoverToCobertura(x => x
                .SetInputFile(OutputDirectory / "OpenCover.coverageresults")
                .SetOutputFile(OutputDirectory / "Cobertura.coverageresults"));
        });
}