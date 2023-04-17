using System;

namespace SortingWordsByLetters.Logic
{
    internal class Word : IComparable<Word>
    {
        /// <summary>
        /// original string
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Letters sorted
        /// </summary>
        public string SortedWord { get; } 


        public Word(string word) {
            //Remove uneeded White Space
            word = word.Trim();
            Name = word;

            // Cut out invalid word data for the sorting
            word = word.RemoveInvalidWordCharacters();

            //Sorting the letters
            char[] sortedChars = word.ToCharArray();
            Array.Sort(sortedChars, (x, y) => string.Compare(x.ToString(), y.ToString(), StringComparison.CurrentCulture));
            SortedWord = new string(sortedChars);
        }

        /// <summary>
        /// Compares against the <see cref="SortedWord"/> 
        /// </summary>
        /// <param name="other">another instantance of <see cref="SortedWord"/>
        public int CompareTo(Word other)
        {
            return SortedWord.CompareTo(other.SortedWord);
        }

        /// <returns>the <see cref="Name"/> as a string</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
