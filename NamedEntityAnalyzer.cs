using System;
using System.Text.RegularExpressions;

namespace APAProcessing
{
    public static class NamedEntityAnalyzer
    {
        // Counts capitalized words as an approximation of named entities.
        public static int CountNamedEntities(string sentence)
        {
            var matches = Regex.Matches(sentence, @"\b[A-Z][a-z]+\b");
            return matches.Count;
        }

        public static double CalculateNamedEntityWeight(string sentence)
        {
            int entityCount = CountNamedEntities(sentence);
            int wordCount = sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount == 0 ? 0 : (double)entityCount / wordCount;
        }
    }
}
