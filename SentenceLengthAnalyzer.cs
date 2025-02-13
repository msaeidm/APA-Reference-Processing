using System;
using System.Linq;

namespace APAProcessing
{
    public static class SentenceLengthAnalyzer
    {
        // Calculates the average sentence length (in words) for an array of sentences.
        public static double CalculateAverageLength(string[] sentences)
        {
            if (sentences.Length == 0) return 0;
            return sentences.Average(s => s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);
        }

        // Computes the weight of a sentence based on its deviation from the average length.
        public static double CalculateSentenceLengthWeight(string sentence, double averageLength)
        {
            int wordCount = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            return Math.Abs(wordCount - averageLength);
        }
    }
}
