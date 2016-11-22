﻿using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;
using iabi.BCF.BCFv2;
using iabi.BCF.Tests.BCFTestCases.v2.CreateAndExport.Factory;
using Xunit;

namespace iabi.BCF.Tests.BCFTestCases.v2.CreateAndExport
{
    public class ExternalBIMSnippetTest
    {
        public static BCFv2Container CreatedContainer;

        public static ZipArchive CreatedArchive;

        public ExternalBIMSnippetTest()
        {
            if (CreatedContainer == null)
            {
                CreatedContainer = BCFTestCaseFactory.GetContainerByTestName(TestCaseEnum.ExternalBIMSnippet);
            }
            if (CreatedArchive == null)
            {
                CreatedArchive = ZipArchiveFactory.ReturnAndWriteIfRequired(CreatedContainer, BCFTestCaseData.ExternalBIMSnippet_TestCaseName, BCFTestCaseData.ExternalBIMSnippet_Readme);
            }
        }

        public string[] ExpectedFiles
        {
            get
            {
                return new[]
                {
                    "bcf.version",
                    BCFTestCaseData.ExternalBIMSnippet_TopicGuid + "/markup.bcf"
                };
            }
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
                    using (var Rdr = new StreamReader(CurrentEntry.Open()))
                    {
                        var Text = Rdr.ReadToEnd();
                        var Xml = XElement.Parse(Text);
                        // No exception no cry!
                    }
                }
            }
        }

        [Fact]
        public void VersionTagCorrect()
        {
            var ExpectedVersionId = "2.0";
            var ExpectedDetailedVersion = "2.0";
            var VersionXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, "bcf.version");
            var ActualVersionId = VersionXml.Attribute("VersionId").Value;
            var ActualDetailedVersion = ((XText) ((XElement) VersionXml.FirstNode).FirstNode).Value;

            Assert.True(VersionXml.Nodes().Count() == 1 && ((XElement) VersionXml.FirstNode).Name.LocalName == "DetailedVersion");
            Assert.Equal(ExpectedVersionId, ActualVersionId);
            Assert.Equal(ExpectedDetailedVersion, ActualDetailedVersion);
        }

        [Fact]
        public void VerifySnippetPresent()
        {
            var MarkupXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, BCFTestCaseData.ExternalBIMSnippet_TopicGuid + "/markup.bcf");
            var SnippetXml = MarkupXml.Descendants("BimSnippet").FirstOrDefault();
            Assert.NotNull(SnippetXml);
        }

        [Fact]
        public void VerifySnippetReferenceCorrect()
        {
            var MarkupXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, BCFTestCaseData.ExternalBIMSnippet_TopicGuid + "/markup.bcf");
            var SnippetXml = MarkupXml.Descendants("BimSnippet").FirstOrDefault();
            var Expected = CreatedContainer.Topics.First().Markup.Topic.BimSnippet.Reference;
            var Actual = SnippetXml.Descendants("Reference").First().Value;
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void VerifySnippetIsExternal()
        {
            var MarkupXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, BCFTestCaseData.ExternalBIMSnippet_TopicGuid + "/markup.bcf");
            var SnippetXml = MarkupXml.Descendants("BimSnippet").FirstOrDefault();
            var Expected = "true";
            var Actual = SnippetXml.Attribute("isExternal").Value;
            Assert.Equal(Expected, Actual);
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