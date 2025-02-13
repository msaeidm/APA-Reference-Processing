using System;
using System.Text.RegularExpressions;

namespace APAProcessing
{
    public static class NumericEntityAnalyzer
    {
        // Counts numeric entities in the sentence.
        public static int CountNumericEntities(string sentence)
        {
            var matches = Regex.Matches(sentence, @"\b\d+\b");
            return matches.Count;
        }

        public static double CalculateNumericEntityWeight(string sentence)
        {
            int numericCount = CountNumericEntities(sentence);
            int wordCount = sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount == 0 ? 0 : (double)numericCount / wordCount;
        }
    }
}
