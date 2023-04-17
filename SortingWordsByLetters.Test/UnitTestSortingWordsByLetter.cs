using SortingWordsByLetters.Logic;
using SortingWordsByLetters.Test.Properties;

namespace SortingWordsByLetters.Test
{
    public class Tests
    {
        public static readonly object[] CorrectlySortedNoDuplicateLettersAndNoPunctuation =
        {
            new object[] { "Crwth, vox, zaps, qi, gym, fjeld, bunk", "zaps, bunk, Crwth, fjeld, gym, qi, vox" },
            new object[] { "Jock, nymphs, waqf, drug, vex, blitz", "waqf, blitz, Jock, drug, vex, nymphs" },
            new object[] { "abc, ced, dfg", "abc, ced, dfg" },
            new object[] { "abd, abc", "abc, abd" },
        };
        public static readonly object[] CorrectlySortedDuplicateLettersAndNoPunctuation =
        {
            new object[] { "The, quick, brown, fox, jumps, over, a, lazy, dog", "a, lazy, brown, quick, dog, The, over, fox, jumps" },
            new object[] { "Jived, fox, nymph, grabs, quick, waltz", "grabs, waltz, quick, Jived, fox, nymph" },
        };
        public static readonly object[] CorrectlySortedDuplicateLettersAndPunctuation =
        {
            new object[] { Resources.BigString, Resources.ExpectedBigString },
            new object[] { "Mr., Jock's, TV, quiz, Ph.D, bags, few, lynx", "Jock's, bags, Ph.D, few, quiz, lynx, Mr., TV" },
        };
        public static readonly object[] NullData =
        {
            new object[] { "", "" },
            new object[] { "                      ", "" },
            new object[] { "\n\r", "" },
            new object[] { "\0", "\0" },
        };
        public static readonly object[] SingleData =
        {
            new object[] { "apple", "apple" },
            new object[] { "              orange", "orange" },
            new object[] { "\n\r pear", "pear" },
        };

        IWordSorter _sorter;
        [SetUp]
        public void Setup()
        {
            //Sorter set with britsh cutlure
            _sorter = new EuropeanOrdering();
        }
        /// <summary>
        /// Basic Happy Day Senario, given a Sentance Where no Letter Is Duplicated, The words are ordered by the lowest letter
        /// </summary>
        [Test]
        [TestCaseSource(nameof(CorrectlySortedNoDuplicateLettersAndNoPunctuation))]
        public void TestWordsAreCorrectalySortedByEarlestLetterWithoutNoDuplicateLettersNoPuctuation(string s, string expResult)
        {
            List<string> inputData = s.Split(',').ToList();

            List<string> outputData = _sorter.Sort(inputData);
            Assert.That(outputData == null || outputData.Count == 0, Is.False, "No data was returned");

            string returnedData = string.Join(", ", outputData);
            Assert.Multiple(() =>
            {
                Assert.That(outputData, Has.Count.EqualTo(inputData.Count), "Returned data does not match the count of words originally sent in");
                Assert.That(returnedData.ToLower(), Is.EqualTo(expResult.ToLower()), "Returned data does not match the original (case insensitive)");
                Assert.That(returnedData, Is.EqualTo(expResult), "Returned data does not match the original (case sensitive)");
            });
            Assert.Pass(s);
        }

        [Test]
        [TestCaseSource(nameof(CorrectlySortedDuplicateLettersAndNoPunctuation))]
        public void TestWordsAreCorrectalySortedByEarlestLetterWithDuplicateLettersNoPuctuation(string s, string expResult)
        {
            List<string> inputData = s.Split(',').ToList();

            List<string> outputData = _sorter.Sort(inputData);
            Assert.That(outputData == null || outputData.Count == 0, Is.False, "No data was returned");

            string returnedData = string.Join(", ", outputData);

            Assert.That(outputData, Has.Count.EqualTo(inputData.Count), "Returned data does not match the count of words originally sent in");
            Assert.Multiple(() =>
            {
                Assert.That(returnedData.ToLower(), Is.EqualTo(expResult.ToLower()), "Returned data does not match the original (case insensitive)");
                Assert.That(returnedData, Is.EqualTo(expResult), "Returned data does not match the original (case sensitive)");
            });
            Assert.Pass(s);
        }

        [Test]
        [TestCaseSource(nameof(CorrectlySortedDuplicateLettersAndPunctuation))]
        public void TestWordsAreCorrectalySortedByEarlestLetterDuplicateLettersWithPunctuation(string s, string expResult)
        {
            List<string> inputData = s.Split(',').ToList();

            List<string> outputData = _sorter.Sort(inputData);
            Assert.That(outputData == null || outputData.Count == 0, Is.False, "No data was returned");

            string returnedData = string.Join(", ", outputData);
            Assert.Multiple(() =>
            {
                Assert.That(outputData, Has.Count.EqualTo(inputData.Count), "Returned data does not match the count of words originally sent in");
                Assert.That(returnedData.ToLower(), Is.EqualTo(expResult.ToLower()), "Returned data does not match the original (case insensitive)");
                Assert.That(returnedData, Is.EqualTo(expResult), "Returned data does not match the original (case sensitive)");
            });
            Assert.Pass(s);
        }

        [Test]
        [TestCaseSource(nameof(NullData))]
        public void TestNullData(string s, string expResult)
        {
            List<string> inputData = s.Split(',').ToList();

            List<string> outputData = _sorter.Sort(inputData);


            Assert.That(outputData == null || outputData.Count == 0, Is.False, "No data was returned");

            string returnedData = string.Join(", ", outputData);
            Assert.Multiple(() =>
            {
                Assert.That(outputData, Has.Count.EqualTo(inputData.Count), "Returned data does not match the count of words originally sent in");
                Assert.That(returnedData.ToLower(), Is.EqualTo(expResult.ToLower()), "Returned data does not match the original (case insensitive)");
                Assert.That(returnedData, Is.EqualTo(expResult), "Returned data does not match the original (case sensitive)");
            });
            Assert.Pass(s);
        }

        [Test]
        [TestCaseSource(nameof(SingleData))]
        public void TestSingleWord(string s, string expResult)
        {
            List<string> inputData = s.Split(',').ToList();

            List<string> outputData = _sorter.Sort(inputData);
            Assert.That(outputData == null || outputData.Count == 0, Is.False, "No data was returned");

            string returnedData = string.Join(", ", outputData);
            Assert.Multiple(() =>
            {
                Assert.That(outputData, Has.Count.EqualTo(inputData.Count), "Returned data does not match the count of words originally sent in");
                Assert.That(returnedData.ToLower(), Is.EqualTo(expResult.ToLower()), "Returned data does not match the original (case insensitive)");
                Assert.That(returnedData, Is.EqualTo(expResult), "Returned data does not match the original (case sensitive)");
            });
            Assert.Pass(s);
        }
    }
}