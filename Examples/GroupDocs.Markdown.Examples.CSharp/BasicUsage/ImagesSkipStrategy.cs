// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2025 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Markdown.Examples.CSharp.BasicUsage
{
    using System;

    /// <summary>
    /// This example demonstrates how to generate markdown from pdf and ignore image.
    /// </summary>
    public static class ImagesSkipStrategy
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # ImagesSkipStrategy : How to generate markdown from pdf and ignore image.\n");
            using (var converter = new MarkdownConverter(Constants.InputPdf))
            {
                var options = new DocumentConverterOptions
                {
                    ImageExportStrategy = new SkipImagesStrategy()
                };

                var result = converter.Convert(Constants.OutputPdfMd, options);

                Console.WriteLine("Result: " + result.IsSuccess);
            }
        }
    }
}