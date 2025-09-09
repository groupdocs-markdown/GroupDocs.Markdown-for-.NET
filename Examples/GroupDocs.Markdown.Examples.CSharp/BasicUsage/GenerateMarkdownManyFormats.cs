// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2025 GroupDocs. All Rights Reserved.
// </copyright>

using System.IO;

namespace GroupDocs.Markdown.Examples.CSharp.BasicUsage
{
    using System;

    /// <summary>
    /// This example demonstrates how to generate markdown from other formats.
    /// </summary>
    public static class GenerateMarkdownManyFormats
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # GenerateMarkdownManyFormats : How to generate markdown from other formats\n");
            foreach (string file in Directory.GetFiles(Constants.InputPath))
            {
                using (var converter = new MarkdownConverter(file))
                {
                    var outputPath = Path.Combine(Constants.OutputPath, "output_" + Path.GetExtension(file).Replace(".","") + ".md");
                    var result = converter.Convert(outputPath);

                    Console.WriteLine("Path: " + outputPath);
                    Console.WriteLine("Result: " + result.IsSuccess);
                }
            }
        }
    }
}
