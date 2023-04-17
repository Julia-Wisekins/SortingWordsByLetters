using System.Text.RegularExpressions;

namespace SortingWordsByLetters.Logic
{
    public static class StringExtensions
    {
        public static string RemoveInvalidWordCharacters(this string s) {
            return Regex.Replace(s, @"[ ,.!?\0]+", "");
        }
    }
}
