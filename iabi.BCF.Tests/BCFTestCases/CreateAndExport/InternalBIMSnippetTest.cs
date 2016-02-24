﻿using iabi.BCF.BCFv2;
using iabi.BCF.Test.BCFTestCases.CreateAndExport.Factory;
using Xunit;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;

namespace iabi.BCF.Test.BCFTestCases.CreateAndExport
{
     
    public class InternalBIMSnippetTest
    {
        public static BCFv2Container CreatedContainer;

        public static ZipArchive CreatedArchive;

                public static void Create()
        {
            CreatedContainer = BCFTestCaseFactory.GetContainerByTestName(TestCaseEnum.InternalBIMSnippet);
            CreatedArchive = ZipArchiveFactory.ReturnAndWriteIfRequired(CreatedContainer, BCFTestCaseData.InternalBIMSnippet_TestCaseName, BCFTestCaseData.InternalBIMSnippet_Readme);
        }

        [Fact]
        public void ContainerPresent()
        {
            Assert.NotNull(CreatedContainer);
        }

        [Fact]
        public void ZipPresent()
        {
            Assert.NotNull(CreatedArchive);
        }

        public string[] ExpectedFiles
        {
            get
            {
                return new string[]
                {
                    "bcf.version",
                    BCFTestCaseData.InternalBIMSnippet_TopicGuid + "/markup.bcf",
                    BCFTestCaseData.InternalBIMSnippet_TopicGuid + "/JsonElement.json", // Data element of the BIM Snippet
                };
            }
        }

        [Fact]
        public void CheckIfFilesPresent()
        {
            foreach (var ExpectedFile in ExpectedFiles)
            {
                if (CreatedArchive.Entries.All(Curr => Curr.FullName != ExpectedFile))
                {
                    Assert.True(false, "Did not find expected file in archive: " + ExpectedFile);
                }
            }
        }

        [Fact]
        public void CheckIfNoAdditionalFilesPresent()
        {
            foreach (var CurrentEntry in CreatedArchive.Entries)
            {
                if (!ExpectedFiles.Contains(CurrentEntry.FullName))
                {
                    Assert.True(false, "Zip Archive should not contain entry " + CurrentEntry.FullName);
                }
            }
        }

        [Fact]
        public void CheckIfFilesAreAllValidXml()
        {
            foreach (var CurrentEntry in CreatedArchive.Entries)
            {
                if (CurrentEntry.FullName.Contains(".bcfp")
                    || CurrentEntry.FullName.Contains(".version")
                    || CurrentEntry.FullName.Contains(".bcf")
                    || CurrentEntry.FullName.Contains(".bcfv")
                    || CurrentEntry.FullName.Contains(".xsd"))
                {
                    using (StreamReader Rdr = new StreamReader(CurrentEntry.Open()))
                    {
                        var Text = Rdr.ReadToEnd();
                        var Xml = XElement.Parse(Text);
                        // No exception no cry!
                    }
                }
            }
        }

        [Fact]
        public void CheckIfFileDataIsEqual_JsonElement()
        {
            var DataExpected = BCFTestCaseData.JsonElement;
            using (MemoryStream MemStream = new MemoryStream())
            {
                CreatedArchive.Entries.FirstOrDefault(Curr => Curr.FullName == BCFTestCaseData.InternalBIMSnippet_TopicGuid + "/JsonElement.json").Open().CopyTo(MemStream);
                var DataActual = MemStream.ToArray();
                Assert.True(DataExpected.SequenceEqual(DataActual));
            }
        }

        [Fact]
        public void VersionTagCorrect()
        {
            var ExpectedVersionId = "2.0";
            var ExpectedDetailedVersion = "2.0";
            var VersionXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, "bcf.version");
            var ActualVersionId = VersionXml.Attribute("VersionId").Value;
            var ActualDetailedVersion = ((XText)((XElement)VersionXml.FirstNode).FirstNode).Value;

            Assert.True(VersionXml.Nodes().Count() == 1 && ((XElement)VersionXml.FirstNode).Name.LocalName == "DetailedVersion");
            Assert.Equal(ExpectedVersionId, ActualVersionId);
            Assert.Equal(ExpectedDetailedVersion, ActualDetailedVersion);
        }

        [Fact]
        public void VerifySnippetPresent()
        {
            var MarkupXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, BCFTestCaseData.InternalBIMSnippet_TopicGuid + "/markup.bcf");
            var SnippetXml = MarkupXml.Descendants("BimSnippet").FirstOrDefault() as XElement;
            Assert.NotNull(SnippetXml);
        }

        [Fact]
        public void VerifySnippetIsNotExternal()
        {
            var MarkupXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, BCFTestCaseData.InternalBIMSnippet_TopicGuid + "/markup.bcf");
            var SnippetXml = MarkupXml.Descendants("BimSnippet").FirstOrDefault() as XElement;
            // Null means false by default
            if (SnippetXml.Attribute("isExternal") != null)
            {
                var Expected = "false";
                var Actual = SnippetXml.Attribute("isExternal").Value;
                Assert.Equal(Expected, Actual);
            }
        }

        [Fact]
        public void WriteReadAgainAndCompare()
        {
            using (var MemStream = new MemoryStream())
            {
                CreatedContainer.WriteStream(MemStream);
                MemStream.Position = 0;

                var ReadContainer = BCFv2Container.ReadStream(MemStream);

                var ReadMemStream = new MemoryStream();
                ReadContainer.WriteStream(ReadMemStream);
                var WrittenZipArchive = new ZipArchive(ReadMemStream);

                CompareTool.CompareContainers(CreatedContainer, ReadContainer, CreatedArchive, WrittenZipArchive);

                //TestUtilities.CompareBCFv2Container(CreatedContainer, ReadContainer);
            }
        }
    }
}
