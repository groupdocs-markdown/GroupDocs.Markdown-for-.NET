// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2025 GroupDocs. All Rights Reserved.
// </copyright>


using System;
using GroupDocs.Markdown.Examples.CSharp.AdvancedUsage;
using GroupDocs.Markdown.Examples.CSharp.BasicUsage;
using GroupDocs.Markdown.Examples.CSharp.QuickStart;

namespace GroupDocs.Markdown.Examples.CSharp.Net
{
    internal class RunExamples
    {
        private static void Main()
        {
            Console.WriteLine("Open RunExamples.cs.");
            Console.WriteLine("In Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            #region Quick Start

            SetLicenseFromFile.Run();
            //SetLicenseFromStream.Run();
            //SetMeteredLicense.Run();

            #endregion

            #region Basic Usage

            GenerateMarkdownManyFormats.Run();
            ImagesExportAsBase64Strategy.Run();
            ImagesExportToFileSystemStrategy.Run();
            ImagesSkipStrategy.Run();

            #endregion

            #region Advanced Usage

            UserImagesStrategy.Run();

            #endregion

            Console.WriteLine();
            Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}
