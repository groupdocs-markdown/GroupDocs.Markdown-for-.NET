// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2025 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Markdown.Examples.CSharp.BasicUsage
{
    using System;

    /// <summary>
    /// This example demonstrates how to generate markdown from docx on page number.
    /// </summary>
    public static class PagesDocx
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # PagesDocx : How to generate markdown from docx on page number.\n");
            using (var converter = new MarkdownConverter(Constants.InputDocx))
            {
                var options = new DocumentConverterOptions
                {
                    ImageExportStrategy = new SkipImagesStrategy(),
                    PageNumbers = new []{1, 3}
                };

                var result = converter.Convert(Constants.OutputPdfMd, options);

                Console.WriteLine("Result: " + result.IsSuccess);
            }
        }
    }
}