using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args) // this line means main method with a string array of arguments
        {

            //int[] myFirstArray; // declaring array without initializing
            //string[] myStringArray = { "first", "second", "third", "fourth" }; // declaring & initializing array
            //char[] myLastName = { 'd', 'e', 'l', 'u', 'c', 'a' }; // declaring & initializing a char array with the letters of my last name // remember char is single quotes

            //// print 3 elements of my array
            //Console.WriteLine(myLastName[0]); // tells console which index to print; console prints the element of the 0 index
            //Console.WriteLine(myLastName[3]);
            //Console.WriteLine(myLastName[1]);

            // create the following arrays and print using the correct index numbers;

            // array of top ten vacation spots; print the first and last vacation spots

            //string[] vacationSpots = { "Australia", "Dubai", "Hawaii", "Iceland", "Cleveland", "Los Angeles", "San Diego", "Aruba", "Jamaica", "Cancun" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);

            // array of the ages of 3 children you know; print each child's age

            // int[] childAge = { 5, 10, 2 };
            //Console.WriteLine(childAge[0]);
            //Console.WriteLine(childAge[1]);
            //Console.WriteLine(childAge[2]);

            // Console.WriteLine(childAge[0] + childAge[1] + childAge[2]); // this will add the numbers together
            // Console.WriteLine(childAge[0] + " " + childAge[1] + " " + childAge[2]); // this will print them on the same line with spaces between the two

            //// array of GPA's on a 4.0 scale of 8 students (you don't have to print)

            //double[] gpa = { 2.5, 3.0, 4.0, 2.7, 3.5, 3.2, 3.9, 3.2 };

            // array of the first letter of 4 of your classmates' names who are sitting near you; print all four on the same line

            // char[] classmateNames = { 'j', 'f', 'j', 'm' };

            // Console.WriteLine(classmateNames); // this only works with characters & there will not be spaces between the characters

            // Console.Write(classmateNames[0]); // remove "Line" in "WriteLine" to print characters on the same line; line break is after the "Write" or "WriteLine"
            // Console.Write(classmateNames[1]);
            // Console.Write(classmateNames[2]);
            // Console.Write(classmateNames[3]);

            // Console.WriteLine("{0}, {1}, {2}, {3}", classmateNames[0], classmateNames[1], classmateNames[2], classmateNames[3]); // prints them on the same line; commas inbetween {} print commas between the characters

            // dataType[] nameOfArray = new dataType[#ofElements];
            //int[] numberOfSeats = new int[21]; // new int[21] is read as "new int array object with 21 spots"
            //string[] studentsInClass = new string[21];

            //// nameOfArray[index] = Element;
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter in the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);

            //Console.WriteLine("Please enter the age of the person in the first seat.");

            //// create new int array with 21 spots and call it ageOfStudentsInClass
            //int[] ageOfStudentsInClass = new int[21];

            //// assign the value of the int at the 0 index of ageOfStudentsInClass to the user's input converted into an int
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]);

            //// Create a new string variable and set it equal to the int at the index of 0 and convert it into a string
            //string firstIndex = ageOfStudentsInClass[0].ToString();

            // string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick-fil-A" };
            // Console.WriteLine(restaurantsInMall.Length); // print the number of elements to the console

            // declare any array but do not initialize (don't know elements)
            // int[] myIntArrayAgain;

            // declare & initialize an array when I know the elements
            // char[] lettersInFirstName = { 'd', 'a', 'n', 'i', 'e', 'l' };

            // declare & initialize an array when I don't know the elements but I know how many there will be
            // string[] variableName = new string[42];

            // to practice using .Length, create a char array of the letters in your middle name; print number of char's to console

            // char[] myMiddleName = { 'r', 'a', 'e' };
            // Console.WriteLine(myMiddleName.Length);

            // declare & initialize a string array; using the Length property, print the second to last element in the array

            // string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick-fil-A" };
            // int numRest = restaurantsInMall.Length; // length is not 0-indexed; it just counts how many there are
            // Console.WriteLine(restaurantsInMall[numRest - 2]); // Red Lobster is index 3; 5 elements so "- 2" gets to the third element

            // IndexOf is a method used to search an array for a specified value and returns the index position of the first matching value found
            // int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            // Console.WriteLine(Array.IndexOf(bestYearsEver, 1985)); // IndexOf asks for parameters & returns first matching value (0 in this example); Array is an object here because it is capitalized

            // LastOf is a method used to search an array for a specified value and returns the index position of the last matching value found
            // Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //// Reserve method
            //int[] palidromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palidromeNumbers[0]);
            //Console.WriteLine(palidromeNumbers[2]);
            //Array.Reverse(palidromeNumbers); // reverses the order of the elements
            //Console.WriteLine(palidromeNumbers[0]);
            //Console.WriteLine(palidromeNumbers[2]);

            //// Sort - will sort numbers in an array from lowest to highest; will sort characters & strings in alph order from A-Z
            //string[] powerRangers = { "Green", "Yellow", "Pink", "Blue", "Red", "Black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            //string[] powerRangers = { "Green", "Yellow", "Pink", "Blue", "Red", "Black", "black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]); // if one string is lowercase and another is uppercase, the lowercase string will always appear in the order first

            // Declare and initialize a string array of first names; choose a name to find and print the IndexOf
            // string[] firstNames = { "Jim", "Joe", "John", "Jennifer" };
            // Console.WriteLine(Array.IndexOf(firstNames, "John"));

            // Create an array of lucky numbers; each number should repeat at least once; choose a lucky number; find and print the last index of it
            // int[] luckyNumbers = { 2, 12, 14, 32, 67, 2, 12, 14, 32, 67 };
            // Console.WriteLine(Array.LastIndexOf(luckyNumbers, 12));

            // Create an array of alphabet characters; print the first index of the array
            // char[] alphabetCharacters = { 'A', 'B', 'C', 'D', 'E', 'F' };
            // Console.WriteLine(alphabetCharacters[1]);

            // Now reverse the array and print the first index
            // Array.Reverse(alphabetCharacters);
            // Console.WriteLine(alphabetCharacters[1]);

            // Create an array of student names in random order; order the students’ names using the sort method
            // string[] studentNames = { "Jim Smith", "Joe Miller", "John Stevens", "Jennifer Meyer" };
            // Array.Sort(studentNames);
            // print the first and last students’ names
            // Console.WriteLine(studentNames[0]);
            // Console.WriteLine(studentNames[3]);

            // int lengthOfStudentNames = studentNames.Length;
            // Console.WriteLine(studentNames[lengthOfStudentNames - 1]);

            // Ask 10 people for their favorite numbers and create an array of those numbers; order the numbers using the sort method
            // int[] favoriteNumbers = { 2, 12, 14, 32, 67, 10, 6, 8, 22, 23 };
            // Array.Sort(favoriteNumbers);
            // print the first and last numbers

            // Console.WriteLine(favoriteNumbers[0]);

            // int lengthOfFavoriteNumbers = favoriteNumbers.Length;
            // Console.WriteLine(favoriteNumbers[lengthOfFavoriteNumbers - 1]);

            // Console.WriteLine(favoriteNumbers[0]);
            // Console.WriteLine(favoriteNumbers[9]);

            //Console.WriteLine("Enter your favorite number.");
            //int person1FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person2FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person3FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person4FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person5FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person6FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person7FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person8FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person9FavoriteNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your favorite number.");
            //int person10FavoriteNumber = int.Parse(Console.ReadLine());

            //int[] favoriteNumbers = { person1FavoriteNumber, person2FavoriteNumber, person3FavoriteNumber, person4FavoriteNumber, person5FavoriteNumber, person6FavoriteNumber, person7FavoriteNumber, person8FavoriteNumber, person9FavoriteNumber, person10FavoriteNumber };

            //Array.Sort(favoriteNumbers);

            //// Console.WriteLine(favoriteNumbers[0]);

            // int lengthOfFavoriteNumbers = favoriteNumbers.Length;
            // Console.WriteLine(favoriteNumbers[lengthOfFavoriteNumbers - 1]);


        }
    }
}
