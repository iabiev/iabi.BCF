﻿using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;
using iabi.BCF.BCFv21;
using iabi.BCF.Tests.BCFTestCases.v21.CreateAndExport.Factory;
using Xunit;

namespace iabi.BCF.Tests.BCFTestCases.v21.CreateAndExport
{
    public class PDFFileTest
    {
        public static BCFv21Container CreatedContainer;

        public static ZipArchive CreatedArchive;

        public PDFFileTest()
        {
            if (CreatedContainer == null)
            {
                CreatedContainer = BCFTestCaseFactory.GetContainerByTestName(TestCaseEnum.PDFFile);
            }
            if (CreatedArchive == null)
            {
                CreatedArchive = ZipArchiveFactory.ReturnAndWriteIfRequired(CreatedContainer, BCFv21TestCaseData.PDFFile_TestCaseName, TestCaseResourceFactory.GetReadmeForV21(BcfTestCaseV21.PDFFile));
            }
        }

        public string[] ExpectedFiles
        {
            get
            {
                return new[]
                {
                    "bcf.version",
                    "Requirements.pdf", // Attached PDF file
                    BCFv21TestCaseData.PDFFile_TopicGuid + "/markup.bcf"
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
        public void CheckIfFileDataIsEqual_PDFAttachment()
        {
            var DataExpected = TestCaseResourceFactory.GetFileAttachment(FileAttachments.RequirementsPdf);
            using (var MemStream = new MemoryStream())
            {
                CreatedArchive.Entries.FirstOrDefault(Curr => Curr.FullName == "Requirements.pdf").Open().CopyTo(MemStream);
                var DataActual = MemStream.ToArray();
                Assert.True(DataExpected.SequenceEqual(DataActual));
            }
        }

        [Fact]
        public void VersionTagCorrect()
        {
            var ExpectedVersionId = "2.1";
            var ExpectedDetailedVersion = "2.1";
            var VersionXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, "bcf.version");
            var ActualVersionId = VersionXml.Attribute("VersionId").Value;
            var ActualDetailedVersion = ((XText) ((XElement) VersionXml.FirstNode).FirstNode).Value;

            Assert.True(VersionXml.Nodes().Count() == 1 && ((XElement) VersionXml.FirstNode).Name.LocalName == "DetailedVersion");
            Assert.Equal(ExpectedVersionId, ActualVersionId);
            Assert.Equal(ExpectedDetailedVersion, ActualDetailedVersion);
        }

        [Fact]
        public void VerifySnippetNotPresent()
        {
            var MarkupXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, BCFv21TestCaseData.PDFFile_TopicGuid + "/markup.bcf");
            var SnippetXml = MarkupXml.Descendants("BimSnippet").FirstOrDefault();
            Assert.Null(SnippetXml);
        }

        [Fact]
        public void VeryfyDocumentReferenceSet()
        {
            var MarkupXml = XmlUtilities.GetElementFromZipFile(CreatedArchive, BCFv21TestCaseData.PDFFile_TopicGuid + "/markup.bcf");

            var DocumentRefsXml = MarkupXml.Descendants("DocumentReference").First();

            Assert.NotNull(DocumentRefsXml);
            Assert.Equal(DocumentRefsXml.Descendants("ReferencedDocument").First().Value, "../Requirements.pdf");
            Assert.Equal(DocumentRefsXml.Descendants("Description").First().Value, "Project requirements (pdf)");
        }

        [Fact]
        public void WriteReadAgainAndCompare()
        {
            using (var MemStream = new MemoryStream())
            {
                CreatedContainer.WriteStream(MemStream);
                MemStream.Position = 0;

                var ReadContainer = BCFv21Container.ReadStream(MemStream);

                var ReadMemStream = new MemoryStream();
                ReadContainer.WriteStream(ReadMemStream);
                var WrittenZipArchive = new ZipArchive(ReadMemStream);

                CompareTool.CompareContainers(CreatedContainer, ReadContainer, CreatedArchive, WrittenZipArchive);
            }
        }

        [Fact]
        public void CheckXmlBrandingCommentsArePresent()
        {
            using (var MemStream = new MemoryStream())
            {
                CreatedContainer.WriteStream(MemStream);
                CompareTool.CheckBrandingCommentPresenceInEveryFile(MemStream.ToArray());
            }
        }
    }
}