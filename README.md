# SortingWordsByLetters

Small Project to showcase my development knowledge.

Task: 
Create code which, given a list of strings, sorts the list based on the earliest alphabetic
character in each word. For example, “dog, fox, snake” would be ordered “snake, dog, fox”
because snake contains the letter A, dog the letter D and fox the letter F.
● Where more than one word contains the same earliest letter, the next earliest letter 
  should be considered in the same way that a dictionary considers the second letter of
  a word. For example “dog, snake, dolphin” would be ordered “snake, dolphin, dog”
  since “I” is earlier in the alphabet than “O”.
  ○ This should continue to the 3rd, 4th…Nth letter as required
● The code should sort based on the European ordering rules (EOR / EN 13710)
  ○ Note that the built-in string comparison methods in C# adhere to these rules
    fully and can therefore be used safely in your code
● The design and testing should account for the code being used to sort large
  collections. As such, consideration should be given to complexity and performance.

About the Application:
I created an interface to handle word sorting named IWordSorter with a method to sort a given 
list of strings and return the sorted version of this. This was done to make updating and 
replacing the sorting method as simple as possible. This would also allow us to do some more 
intricate testing later as required.
Using the interface I then created the EuropeanOrdering class which changes the list of strings
to a list of words and sorts them using the built in sorting method and passing the required
details.
The Object 'Word' was made to contain the original word and a string where the letters within the 
string is sorted. Respectively I named these 'Name' and 'SortedWord' I also created an override 
to convert the word back to a string and implemented the IComparable interface to allow for easy 
comparisons
As by default the C# sort placed the following characters [.,!? ] at the start when sorting words.
These are invalid characters according to the sorting as it is only meant to be run on words not 
multiple, created a string extension to remove these characters to prevent incorrect ordering of 
characters.

Tests Details:
I created tests to cover a variety of different scenarios. I covered:
If Words Are Correctly Sorted By Earliest Letter Without Duplicate Letters or Punctuation
If Words Are Correctly Sorted By Earliest Letter With Duplicate Letters but Without Punctuation
If Words Are Correctly Sorted By Earliest Letter using Duplicate Letters and Punctuation
Testing Null Data

Each test was given a variety of different test cases to ensure that the tests did not succeed
on a specific example.

Another possible test I could have created would have been testing whether the 'SortedWord' 
was returned as expected but I deemed this out of scope as the 'SortedWord' is not required 
for the end product.
