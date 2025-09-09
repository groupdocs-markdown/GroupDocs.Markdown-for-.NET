// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2025 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Markdown.Examples.CSharp.BasicUsage
{
    using System;

    /// <summary>
    /// This example demonstrates how to generate markdown from pdf and save image as byte string.
    /// </summary>
    public static class ImagesExportAsBase64Strategy
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # ImagesExportAsBase64Strategy : How to generate markdown from pdf and save image as byte string.\n");
            using (var converter = new MarkdownConverter(Constants.InputPdf))
            {
                var options = new DocumentConverterOptions
                {
                    ImageExportStrategy = new ExportImagesAsBase64Strategy()
                };

                var result = converter.Convert(Constants.OutputPdfMd, options);

                Console.WriteLine("Result: " + result.IsSuccess);
            }
        }
    }
}
