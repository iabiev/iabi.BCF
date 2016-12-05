﻿using System.IO;
using System.IO.Compression;
using iabi.BCF.BCFv2;

namespace iabi.BCF.Tests.BCFTestCases.v2.CreateAndExport
{
    public static class ZipArchiveFactory
    {
        public const string FOLDERNAME = @"";

        public static ZipArchive ReturnAndWriteIfRequired(BCFv2Container Container, string TestCaseName, string ReadmeText)
        {
            var MemStream = new MemoryStream();
            Container.WriteStream(MemStream);
            MemStream.Position = 0;
            var CreatedArchive = new ZipArchive(MemStream, ZipArchiveMode.Read);

            if (string.IsNullOrWhiteSpace(FOLDERNAME))
            {
                return CreatedArchive;
            }

            if (!Directory.Exists(FOLDERNAME + @"\" + TestCaseName))
            {
                Directory.CreateDirectory(FOLDERNAME + @"\" + TestCaseName);
            }

            var FilePath = FOLDERNAME + @"\" + TestCaseName + @"\" + TestCaseName + ".bcfzip";
            using (var FileStream = File.Create(FilePath))
            {
                Container.WriteStream(FileStream);
            }

            FilePath = FOLDERNAME + @"\" + TestCaseName + @"\Readme.md";
            using (var StreamWriter = new StreamWriter(File.Create(FilePath)))
            {
                StreamWriter.Write(ReadmeText);
            }

            return CreatedArchive;
        }
    }
}