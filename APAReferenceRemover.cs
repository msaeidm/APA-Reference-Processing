using System;
using System.Text.RegularExpressions;

namespace APAProcessing
{
    public static class APAReferenceRemover
    {
        // Removes APA references from a given text.
        public static string RemoveAPAReferences(string input)
        {
            // Simplified regex to capture patterns like (Author, YYYY) or (Author, YYYY:Page)
            string pattern = @"\(\s*[\p{L}\s,.-]+,\s*\d{4}(?:\s*:\s*\d{1,4})?(?:;\s*\d{1,4})?\s*\)";
            return Regex.Replace(input, pattern, "").Trim();
        }
    }
}
