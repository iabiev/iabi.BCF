﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iabi.BCF.Tests.BCFTestCases.v21.CreateAndExport {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class BCFTestCaseData {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BCFTestCaseData() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("iabi.BCF.Tests.BCFTestCases.v21.CreateAndExport.BCFTestCaseData", typeof(BCFTestCaseData).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ComponentCollection_Snapshot_01 {
            get {
                object obj = ResourceManager.GetObject("ComponentCollection_Snapshot_01", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die true ähnelt.
        /// </summary>
        internal static string ComponentSelection_DefaultVisibilityComponents {
            get {
                return ResourceManager.GetString("ComponentSelection_DefaultVisibilityComponents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die true ähnelt.
        /// </summary>
        internal static string ComponentSelection_DefaultVisibilityOpenings {
            get {
                return ResourceManager.GetString("ComponentSelection_DefaultVisibilityOpenings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die false ähnelt.
        /// </summary>
        internal static string ComponentSelection_DefaultVisibilitySpaceBoundaries {
            get {
                return ResourceManager.GetString("ComponentSelection_DefaultVisibilitySpaceBoundaries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die false ähnelt.
        /// </summary>
        internal static string ComponentSelection_DefaultVisibilitySpaces {
            get {
                return ResourceManager.GetString("ComponentSelection_DefaultVisibilitySpaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # Component Selection
        ///
        ///This test case verifies support of components that are marked as selected within a viewpoint.
        ///
        ///## Testing process
        ///
        ///1. Import _ComponentSelection.bcf_.
        ///2. Verify the bcf was imported correctly:
        ///&gt; 1. Exactly three components are selected in your application.
        ///&gt; 2. All other components are being displayed with their default settings.
        ///
        ///3. Export the topic you imported to _exported.bcf_.
        ///4. Verify that no information was lost during the export ähnelt.
        /// </summary>
        internal static string ComponentSelection_Readme {
            get {
                return ResourceManager.GetString("ComponentSelection_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Component Selection ähnelt.
        /// </summary>
        internal static string ComponentSelection_TestCaseName {
            get {
                return ResourceManager.GetString("ComponentSelection_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 42929e02-f00f-4db8-918e-0fbbc64a45d3 ähnelt.
        /// </summary>
        internal static string ComponentSelection_TopicGuid {
            get {
                return ResourceManager.GetString("ComponentSelection_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 817b50b5-f6b2-4e5d-8a37-b692d67cdd91 ähnelt.
        /// </summary>
        internal static string ComponentSelection_ViewpointGuid {
            get {
                return ResourceManager.GetString("ComponentSelection_ViewpointGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # Document Reference External
        ///
        ///This test case verifies support of a document reference that is external to the BCF file, referenced with an absolute URL.
        ///
        ///## Testing process
        ///
        ///1. Import _DocumentReferenceExternal.bcf_.
        ///2. Verify the bcf was imported correctly:
        ///&gt; 1. Your application is aware of the absolute reference to the document outside of the BCFzip as given in the _DocumentReferences_ property in the _markup.bcf_ file.
        ///&gt; 2. The .xsd file attachment can be retrieved (public download from buildin [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string DocumentReferenceExternal_Readme {
            get {
                return ResourceManager.GetString("DocumentReferenceExternal_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Document Reference External ähnelt.
        /// </summary>
        internal static string DocumentReferenceExternal_TestCaseName {
            get {
                return ResourceManager.GetString("DocumentReferenceExternal_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 1b66b5cb-18b4-4edd-a700-d02c3a673710 ähnelt.
        /// </summary>
        internal static string DocumentReferenceExternal_TopicGuid {
            get {
                return ResourceManager.GetString("DocumentReferenceExternal_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        /// </summary>
        internal static byte[] Estructura {
            get {
                object obj = ResourceManager.GetObject("Estructura", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # Extension Schema
        ///
        ///This test case verifies support of an embedded extension schema withing a BCF file.
        ///
        ///## Testing process
        ///
        ///1. Import _ExtensionSchema.bcf_.
        ///2. Verify the bcf was imported correctly:
        ///&gt; 1. Your application is aware of the relative reference to _extensions.xsd_ as given in the _ProjectExtension_&apos;s _ExtensionSchema_ property in the _project.bcfp_ file.
        ///&gt; 2. The values within the _extensions.xsd_ are imported into your application&apos;s issue management interface and presented as selectabl [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string ExtensionSchema_Readme {
            get {
                return ResourceManager.GetString("ExtensionSchema_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die ExtensionSchema ähnelt.
        /// </summary>
        internal static string ExtensionSchema_TestCaseName {
            get {
                return ResourceManager.GetString("ExtensionSchema_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 844496EA-0E0A-4071-A3EA-6EDF97458734 ähnelt.
        /// </summary>
        internal static string ExtensionSchema_TopicGuid {
            get {
                return ResourceManager.GetString("ExtensionSchema_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # External BIM Snippet
        ///
        ///This test case verifies support of an external BIM Snippet reference within a BCF file.
        ///
        ///## Testing process
        ///
        ///1. Import _ExternalBIMSnippet.bcf_.
        ///2. Verify the bcf was imported correctly:
        ///&gt; 1. Your application is aware of the relative reference to _http://bimfiles.example.com/JsonElement.json_ as given in the _Topic_s _BIMSnippet_ property in the _markup.bcf_ file. The reference is marked as external to indicate that the actual snippet data is not contained within the BCFZip.        /// [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string ExternalBIMSnippet_Readme {
            get {
                return ResourceManager.GetString("ExternalBIMSnippet_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die ExternalBIMSnippet ähnelt.
        /// </summary>
        internal static string ExternalBIMSnippet_TestCaseName {
            get {
                return ResourceManager.GetString("ExternalBIMSnippet_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die c26df753-b8af-42f2-b7cf-81a70b49f362 ähnelt.
        /// </summary>
        internal static string ExternalBIMSnippet_TopicGuid {
            get {
                return ResourceManager.GetString("ExternalBIMSnippet_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        /// </summary>
        internal static byte[] IfcPile {
            get {
                object obj = ResourceManager.GetObject("IfcPile", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        /// </summary>
        internal static byte[] IfcPile1 {
            get {
                object obj = ResourceManager.GetObject("IfcPile1", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # Internal BIM Snippet
        ///
        ///This test case verifies support of an internal BIM Snippet reference within a BCF file.
        ///
        ///## Testing process
        ///
        ///1. Import _InternalBIMSnippet.bcf_.
        ///2. Verify the bcfzip was imported correctly:
        ///&gt; 1. Your application is aware of the relative reference to _JsonElement.json_ as given in the _Topic_s _BIMSnippet_ property in the _markup.bcf_ file.
        ///&gt; 2. The _JsonElement.json_ file has been imported successfully.
        ///3. Export the topic you imported to _exported.bcf_.
        ///4. Verify that no  [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string InternalBIMSnippet_Readme {
            get {
                return ResourceManager.GetString("InternalBIMSnippet_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die InternalBIMSnippet ähnelt.
        /// </summary>
        internal static string InternalBIMSnippet_TestCaseName {
            get {
                return ResourceManager.GetString("InternalBIMSnippet_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 84D4A28C-0638-4813-AA4B-BCD62FE5FC93 ähnelt.
        /// </summary>
        internal static string InternalBIMSnippet_TopicGuid {
            get {
                return ResourceManager.GetString("InternalBIMSnippet_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        /// </summary>
        internal static byte[] JsonElement {
            get {
                object obj = ResourceManager.GetObject("JsonElement", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        /// </summary>
        internal static byte[] MarkupSchema {
            get {
                object obj = ResourceManager.GetObject("MarkupSchema", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die true ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_01_DefaultVisibilityComponents {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_01_DefaultVisibilityComponents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die true ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_01_DefaultVisibilityOpenings {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_01_DefaultVisibilityOpenings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die true ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_01_DefaultVisibilitySpaceBoundaries {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_01_DefaultVisibilitySpaceBoundaries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die true ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_01_DefaultVisibilitySpaces {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_01_DefaultVisibilitySpaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die false ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_02_DefaultVisibilityComponents {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_02_DefaultVisibilityComponents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die false ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_02_DefaultVisibilityOpenings {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_02_DefaultVisibilityOpenings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die false ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_02_DefaultVisibilitySpaceBoundaries {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_02_DefaultVisibilitySpaceBoundaries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die false ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_02_DefaultVisibilitySpaces {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_02_DefaultVisibilitySpaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die true ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_03_DefaultVisibilityComponents {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_03_DefaultVisibilityComponents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die true ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_03_DefaultVisibilityOpenings {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_03_DefaultVisibilityOpenings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die false ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_03_DefaultVisibilitySpaceBoundaries {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_03_DefaultVisibilitySpaceBoundaries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die false ähnelt.
        /// </summary>
        internal static string MaximimumInformation_Viewpoint_03_DefaultVisibilitySpaces {
            get {
                return ResourceManager.GetString("MaximimumInformation_Viewpoint_03_DefaultVisibilitySpaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap MaximumInfo_Snapshot_01 {
            get {
                object obj = ResourceManager.GetObject("MaximumInfo_Snapshot_01", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap MaximumInfo_Snapshot_02 {
            get {
                object obj = ResourceManager.GetObject("MaximumInfo_Snapshot_02", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap MaximumInfo_Snapshot_03 {
            get {
                object obj = ResourceManager.GetObject("MaximumInfo_Snapshot_03", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # Maximum Information
        ///
        ///This test case verifies support of a BCFzip file that contains all information available in the schema.
        ///
        ///## Testing process
        ///
        ///1. Import _MaximumInformation.bcfzip_.
        ///2. Verify the bcfzip was imported correctly:
        ///&gt; 1. There are two topics within the zip file:
        ///&gt; &gt; Maximum Content - 63E78882-7C6A-4BF7-8982-FC478AFB9C97
        ///&gt; &gt; Referenced topic - 5019D939-62A4-45D9-B205-FAB602C98FE8
        ///&gt; 2. Verify that all information can be processed.
        ///
        ///3. Export the topic you imported to _exported.bcf [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string MaximumInformation_Readme {
            get {
                return ResourceManager.GetString("MaximumInformation_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 5019D939-62A4-45D9-B205-FAB602C98FE8 ähnelt.
        /// </summary>
        internal static string MaximumInformation_ReferencedTopicGuid {
            get {
                return ResourceManager.GetString("MaximumInformation_ReferencedTopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die MaximumInformation ähnelt.
        /// </summary>
        internal static string MaximumInformation_TestCaseName {
            get {
                return ResourceManager.GetString("MaximumInformation_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 63E78882-7C6A-4BF7-8982-FC478AFB9C97 ähnelt.
        /// </summary>
        internal static string MaximumInformation_TopicGuid {
            get {
                return ResourceManager.GetString("MaximumInformation_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 8dc86298-9737-40b4-a448-98a9e953293a ähnelt.
        /// </summary>
        internal static string MaximumInformation_ViewpointGuid_01 {
            get {
                return ResourceManager.GetString("MaximumInformation_ViewpointGuid_01", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 21dd4807-e9af-439e-a980-04d913a6b1ce ähnelt.
        /// </summary>
        internal static string MaximumInformation_ViewpointGuid_02 {
            get {
                return ResourceManager.GetString("MaximumInformation_ViewpointGuid_02", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 81daa431-bf01-4a49-80a2-1ab07c177717 ähnelt.
        /// </summary>
        internal static string MaximumInformation_ViewpointGuid_03 {
            get {
                return ResourceManager.GetString("MaximumInformation_ViewpointGuid_03", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # Minimum Information
        ///
        ///This test case verifies support of a minimal BCFzip file.
        ///
        ///## Testing process
        ///
        ///1. Import _MinimumInformation.bcfzip_.
        ///2. Verify the bcfzip was imported correctly:
        ///&gt; 1. The imported topic does have the following properties:
        ///&gt;&gt; * Guid: 9898DE65-C0CE-414B-857E-1DF97FFAED8D
        ///&gt;&gt; * Title: Minimum information BCFZip topic.
        ///&gt;&gt; * CreationDate: 2015-07-15T13:12:42Z (Z indicating an UTC timestamp)
        ///&gt;&gt; * CreationAuthor: Developer@example.com
        ///3. Export the topic you imported to _exporte [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string MinimumInformation_Readme {
            get {
                return ResourceManager.GetString("MinimumInformation_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die MinimumInformation ähnelt.
        /// </summary>
        internal static string MinimumInformation_TestCaseName {
            get {
                return ResourceManager.GetString("MinimumInformation_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 9898DE65-C0CE-414B-857E-1DF97FFAED8D ähnelt.
        /// </summary>
        internal static string MinimumInformation_TopicGuid {
            get {
                return ResourceManager.GetString("MinimumInformation_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # Orthogonal Camera
        ///
        ///This test case verifies support of a BCF file that contains a single viewpoint with an orthogonal camera.
        ///
        ///## Testing process
        ///
        ///1. Import _OrthogonalCamera.bcf_.
        ///2. Verify the bcf was imported correctly:
        ///&gt; 1. There is one topic within the zip file:
        ///&gt; &gt; Orthogonal Camera - 97881cb2-6462-4161-8d57-3d179b280755
        ///&gt; 2. Verify that all information can be processed.
        ///
        ///3. Export the topic you imported to _exported.bcf_.
        ///4. Verify that no information was lost during the export ähnelt.
        /// </summary>
        internal static string OrthogonalCamera_Readme {
            get {
                return ResourceManager.GetString("OrthogonalCamera_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die OrthogonalCamera ähnelt.
        /// </summary>
        internal static string OrthogonalCamera_TestCaseName {
            get {
                return ResourceManager.GetString("OrthogonalCamera_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 97881cb2-6462-4161-8d57-3d179b280755 ähnelt.
        /// </summary>
        internal static string OrthogonalCamera_TopicGuid {
            get {
                return ResourceManager.GetString("OrthogonalCamera_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # PDF File
        ///
        ///This test case verifies support of an embedded .pdf file attachment, referenced as document in the topic.
        ///
        ///## Testing process
        ///
        ///1. Import _PDFFile.bcf_.
        ///2. Verify the bcf was imported correctly:
        ///&gt; 1. Your application is aware of the relative reference to _Requirements.pdf_ in the BCF root directory as given in the _DocumentReferences_ property in the _markup.bcf_ file.
        ///&gt; 2. The .pdf file attachment is present.
        ///
        ///3. Export the topic you imported to _exported.bcf_.
        ///4. Verify that no info [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string PDFFile_Readme {
            get {
                return ResourceManager.GetString("PDFFile_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die PDFFile ähnelt.
        /// </summary>
        internal static string PDFFile_TestCaseName {
            get {
                return ResourceManager.GetString("PDFFile_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 8e46d831-4603-4bd1-ae0c-d1817ca50bf0 ähnelt.
        /// </summary>
        internal static string PDFFile_TopicGuid {
            get {
                return ResourceManager.GetString("PDFFile_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die # Perspective Camera
        ///
        ///This test case verifies support of a BCF file that contains a single viewpoint with a perspective camera.
        ///
        ///## Testing process
        ///
        ///1. Import _PerspectiveCamera.bcf_.
        ///2. Verify the bcfzip was imported correctly:
        ///&gt; 1. There is one topic within the zip file:
        ///&gt; &gt; Perspective Camera - 3153ceb9-0d9b-4f89-9670-dc95768836af
        ///&gt; 2. Verify that all information can be processed.
        ///
        ///3. Export the topic you imported to _exported.bcf_.
        ///4. Verify that no information was lost during the export ähnelt.
        /// </summary>
        internal static string PerspectiveCamera_Readme {
            get {
                return ResourceManager.GetString("PerspectiveCamera_Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap PerspectiveCamera_Snapshot_01 {
            get {
                object obj = ResourceManager.GetObject("PerspectiveCamera_Snapshot_01", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die PerspectiveCamera ähnelt.
        /// </summary>
        internal static string PerspectiveCamera_TestCaseName {
            get {
                return ResourceManager.GetString("PerspectiveCamera_TestCaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 3153ceb9-0d9b-4f89-9670-dc95768836af ähnelt.
        /// </summary>
        internal static string PerspectiveCamera_TopicGuid {
            get {
                return ResourceManager.GetString("PerspectiveCamera_TopicGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        /// </summary>
        internal static byte[] Requirements {
            get {
                object obj = ResourceManager.GetObject("Requirements", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
