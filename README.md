# SortingWordsByLetters

Small Project to showcase my development knowledge.

Task: 
Create code which, given a list of strings, sorts the list based on the earliest alphabetic</br>
character in each word. For example, “dog, fox, snake” would be ordered “snake, dog, fox”</br>
because snake contains the letter A, dog the letter D and fox the letter F.</br>
* Where more than one word contains the same earliest letter, the next earliest letter </br>
  should be considered in the same way that a dictionary considers the second letter of</br>
  a word. For example “dog, snake, dolphin” would be ordered “snake, dolphin, dog”</br>
  since “I” is earlier in the alphabet than “O”.</br>
  * This should continue to the 3rd, 4th…Nth letter as required</br>
* The code should sort based on the European ordering rules (EOR / EN 13710)</br>
  * Note that the built-in string comparison methods in C# adhere to these rules</br>
    fully and can therefore be used safely in your code</br>
* The design and testing should account for the code being used to sort large</br>
  collections. As such, consideration should be given to complexity and performance.</br>
</br>
About the Application:</br>
I created an interface to handle word sorting named IWordSorter with a method to sort a given </br>
list of strings and return the sorted version of this. This was done to make updating and </br>
replacing the sorting method as simple as possible. This would also allow us to do some more </br>
intricate testing later as required.</br>
Using the interface I then created the EuropeanOrdering class which changes the list of strings</br>
to a list of words and sorts them using the built in sorting method and passing the required</br>
details.</br>
The Object 'Word' was made to contain the original word and a string where the letters within the </br>
string is sorted. Respectively I named these 'Name' and 'SortedWord' I also created an override </br>
to convert the word back to a string and implemented the IComparable interface to allow for easy </br>
comparisons</br>
As by default the C# sort placed the following characters [.,!? ] at the start when sorting words.</br>
These are invalid characters according to the sorting as it is only meant to be run on words not </br>
multiple, created a string extension to remove these characters to prevent incorrect ordering of </br>
characters.</br>
</br>
Tests Details:</br>
I created tests to cover a variety of different scenarios. I covered:</br>
If Words Are Correctly Sorted By Earliest Letter Without Duplicate Letters or Punctuation</br>
If Words Are Correctly Sorted By Earliest Letter With Duplicate Letters but Without Punctuation</br>
If Words Are Correctly Sorted By Earliest Letter using Duplicate Letters and Punctuation</br>
Testing Null Data</br>
</br>
Each test was given a variety of different test cases to ensure that the tests did not succeed</br>
on a specific example.</br>
</br>
Another possible test I could have created would have been testing whether the 'SortedWord' </br>
was returned as expected but I deemed this out of scope as the 'SortedWord' is not required </br>
for the end product.</br>
