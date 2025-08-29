// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2025 GroupDocs. All Rights Reserved.
// </copyright>

using System.IO;

namespace GroupDocs.Markdown.Examples.CSharp.BasicUsage
{
    using GroupDocs.Markdown.DocumentConversion.ImageExport.ImageExportStrategy;
    using GroupDocs.Markdown.DocumentConversion;
    using System;

    /// <summary>
    /// This example demonstrates how to generate markdown from pdf and save image as file.
    /// </summary>
    public static class ImagesExportToFileSystemStrategy
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # ImagesExportToFileSystemStrategy : How to generate markdown from pdf and save image as file.\n");
            using (var converter = new MarkdownConverter(Constants.InputPdf))
            {
                var options = new DocumentConverterOptions
                {
                    ImageExportStrategy = new ExportImagesToFileSystemStrategy(Constants.ImageFolderPath),
                };

                var result = converter.Convert(Constants.OutputPdfMd, options);

                Console.WriteLine("Result: " + result.IsSuccess);
            }
        }
    }
}
