using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace SortingWordsByLetters.Logic
{
    public interface IWordSorter
    {
        /// <summary>
        /// Sorts words
        /// </summary>
        /// <param name="words">List of preseperated words</param>
        /// <returns>new List of seperated words in order</returns>
        List<string> Sort(List<string> words);
    }

    public class EuropeanOrdering : IWordSorter
    {
        /// <summary>
        /// Sorts words in accordance to European Ordering Rules (EN 13710) <see href="https://en.wikipedia.org/wiki/European_ordering_rules">Here</see>
        /// </summary>
        /// <param name="words">List of preseperated words<</param>
        /// <returns>new List of seperated words in ascending order</returns>
        public List<string> Sort(List<string> words)
        {
            //set current culture to european country to ensure sorting follows correct rules
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo("en-GB");

            //create a new list with the sorted values
            List<Word> result = new List<Word>();
            foreach (var w in words)
            {
                result.Add(new Word(w));
            }
            result.Sort((w1, w2) => w1.CompareTo(w2));

            //put culture back to oringinal culture
            CultureInfo.CurrentCulture = currentCulture;

            //return the sorted list showing the original strings 
            return result.Select(x => x.Name).ToList();
        }
    }
}
