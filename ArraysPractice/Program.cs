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





        }
    }
}
