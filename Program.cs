using System;
using System.IO;

namespace APAProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read sample input text from the tests folder.
            string filePath = "tests/sample_input.txt";
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                Console.WriteLine("Original Text:");
                Console.WriteLine(text);
                Console.WriteLine("\n---\n");

                // Remove APA references.
                string cleanedText = APAReferenceRemover.RemoveAPAReferences(text);
                Console.WriteLine("Text after removing APA references:");
                Console.WriteLine(cleanedText);
                Console.WriteLine("\n---\n");

                // Split text into sentences (simple split by period).
                string[] sentences = cleanedText.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                double avgLength = SentenceLengthAnalyzer.CalculateAverageLength(sentences);
                Console.WriteLine($"Average sentence length: {avgLength:F2} words\n");

                foreach (var sentence in sentences)
                {
                    var trimmed = sentence.Trim();
                    if (string.IsNullOrEmpty(trimmed)) continue;
                    double namedEntityWeight = NamedEntityAnalyzer.CalculateNamedEntityWeight(trimmed);
                    double sentenceLengthWeight = SentenceLengthAnalyzer.CalculateSentenceLengthWeight(trimmed, avgLength);
                    double numericEntityWeight = NumericEntityAnalyzer.CalculateNumericEntityWeight(trimmed);
                    Console.WriteLine($"Sentence: {trimmed}");
                    Console.WriteLine($"Named Entity Weight: {namedEntityWeight:F3}");
                    Console.WriteLine($"Sentence Length Weight: {sentenceLengthWeight:F3}");
                    Console.WriteLine($"Numeric Entity Weight: {numericEntityWeight:F3}\n");
                }
            }
            else
            {
                Console.WriteLine($"File not found: {filePath}");
            }
        }
    }
}
