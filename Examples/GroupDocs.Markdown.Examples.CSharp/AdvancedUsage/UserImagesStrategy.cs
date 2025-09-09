// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2025 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Markdown.Examples.CSharp.AdvancedUsage
{
    using System;

    /// <summary>
    /// This example demonstrates how to generate markdown from pdf and save image as file using custom function.
    /// </summary>
    public static class UserImagesStrategy
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # UserImagesStrategy : How to generate markdown from pdf and save image as file using custom function.\n");
            using (var converter = new MarkdownConverter(Constants.InputPdf))
            {
                var options = new DocumentConverterOptions
                {
                    ImageExportStrategy = new CustomImagesStrategy(Constants.ImageFolderPath, RenameImageHandler),
                };

                var result = converter.Convert(Constants.OutputPdfMd, options);

                Console.WriteLine("Result: " + result.IsSuccess);
            }
        }

        private static int _index = 0;
        private static void RenameImageHandler(CustomImageSavingArgs args)
        {
            args.SetOutputImageFileName($"rename_{_index}_{args.ImageFileName}");
            _index++;
        }
    }
}
