// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2025 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Markdown.Examples.CSharp
{
    using System.IO;

    public static class Constants
    {
        static Constants()
        {
            if (!Directory.Exists(OutputPath))
                Directory.CreateDirectory(OutputPath);

            if (!Directory.Exists(ImageFolderPath))
                Directory.CreateDirectory(ImageFolderPath);
        }

        public const string ResourcesPath = @".\Resources\";

        public static readonly string LicenseFilePath = @"C:\Work\License\GroupDocs.Markdown.Product.Family.lic";

        public static readonly string InputPath = Path.Combine(ResourcesPath, @"SampleFiles");
        public static readonly string OutputPath = Path.Combine(ResourcesPath, @"SampleFiles\Output");
        public static readonly string ImageFolderPath = Path.Combine(ResourcesPath, @"SampleFiles\Images");


        public static readonly string InputAzw3 = Path.Combine(InputPath, "input.azw3");
        public static readonly string InputChm = Path.Combine(InputPath, "input.chm");
        public static readonly string InputDoc = Path.Combine(InputPath, "input.doc");
        public static readonly string InputDocx = Path.Combine(InputPath, "input.docx");
        public static readonly string InputEpub = Path.Combine(InputPath, "input.epub");
        public static readonly string InputMobi = Path.Combine(InputPath, "input.mobi");
        public static readonly string InputPdf = Path.Combine(InputPath, "input.pdf");
        public static readonly string InputTxt = Path.Combine(InputPath, "input.txt");
        public static readonly string InputXls = Path.Combine(InputPath, "input.xls");
        public static readonly string InputXml = Path.Combine(InputPath, "input.xml");


        public static readonly string OutputAzw3Md = Path.Combine(OutputPath, "output_azw3.md");
        public static readonly string OutputChmMd = Path.Combine(OutputPath, "output_chm.md");
        public static readonly string OutputDocMd = Path.Combine(OutputPath, "output_doc.md");
        public static readonly string OutputDocxMd = Path.Combine(OutputPath, "output_docx.md");
        public static readonly string OutputEpubMd = Path.Combine(OutputPath, "output_epub.md");
        public static readonly string OutputMobiMd = Path.Combine(OutputPath, "output_mobi.md");
        public static readonly string OutputPdfMd = Path.Combine(OutputPath, "output_pdf.md");
        public static readonly string OutputTxtMd = Path.Combine(OutputPath, "output_txt.md");
        public static readonly string OutputXlsMd = Path.Combine(OutputPath, "output_xls.md");
        public static readonly string OutputXmlMd = Path.Combine(OutputPath, "output_xml.md");

    }
}

