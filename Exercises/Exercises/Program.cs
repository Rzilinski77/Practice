using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            #region Excercise 1 √
            // Prompt the user to enter a string. After the user enters a string, output the same string back to
            //the console.

            //Console.WriteLine("Enter in a string");
            //string input = Console.ReadLine();
            //Console.WriteLine($"{input}");

            #endregion

            #region Excercise 2 √
            //Prompt the user to enter a number. After the user enters a number, add 1 to the number and
            //output it back to the console.

            //Console.WriteLine("enter a number");
            //int input = int.Parse(Console.ReadLine()) + 1;
            //Console.WriteLine(input);


            #endregion

            #region Excercise 3 √
            // Prompt the user to enter a number. After the user enters a number, add .5 to the number and
            //output it back to the console.

            //Console.WriteLine("Enter a number");
            //double input = double.Parse(Console.ReadLine()) + .5;
            //Console.WriteLine($"Your new number is {input}");


            #endregion

            #region Excercise 4 √
            // Prompt the user to enter two numbers. After the user enters the numbers, add them together
            //and output the sum back to the console.

            //Console.WriteLine("Enter two numbers");
            //int one = int.Parse(Console.ReadLine());
            //int two = int.Parse(Console.ReadLine());
            //int sum = one + two;
            //Console.WriteLine(sum);

            #endregion

            #region Excercise 5 √
            // Prompt the user to enter two numbers. After the user enters the numbers, multiply them and
            //output the product back to the console.

            //Console.WriteLine("Enter two numbers");
            //int one = int.Parse(Console.ReadLine());
            //int two = int.Parse(Console.ReadLine());
            //int product = one * two;
            //Console.WriteLine(product);

            #endregion

            #region Excercise 6 √
            // Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World!"
            //ask the user whether they would like to continue.

            //string more = "y";

            //do
            //{
            //    Console.WriteLine("Hello, World!");
            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    more = Console.ReadLine();

            //} while (more == "y");



            #endregion

            #region Excercise 7 √
            // Use a do-while loop to run exercise 1 in a loop. Each time you run the code ask the user
            //whether they would like to continue.

            //string more = "y";

            //do
            //{
            //    Console.WriteLine("Enter in a string");
            //    string input = Console.ReadLine();
            //    Console.WriteLine($"{input}");
            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    more = Console.ReadLine();
            //} while (more == "y");

            #endregion

            #region Excercise 8 √
            // Make exercises 2-5 run in a loop. Use a do-while loop to run the code in a loop. Each time you
            //run the code ask the user whether they would like to continue.

            //string more = "y";

            //do
            //{
            //    Console.WriteLine("enter a number");
            //    int input = int.Parse(Console.ReadLine()) + 1;
            //    Console.WriteLine(input);
            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    more = Console.ReadLine();

            //} while (more == "y");

            //more = "y";

            //do
            //{
            //    Console.WriteLine("Enter a number");
            //    double input = double.Parse(Console.ReadLine()) + .5;
            //    Console.WriteLine($"Your new number is {input}");
            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    more = Console.ReadLine();

            //} while (more == "y");

            //more = "y";

            //do
            //{
            //    Console.WriteLine("Enter two numbers");
            //    int one = int.Parse(Console.ReadLine());
            //    int two = int.Parse(Console.ReadLine());
            //    int sum = one + two;
            //    Console.WriteLine(sum);
            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    more = Console.ReadLine();

            //} while (more == "y");

            //more = "y";

            //do
            //{
            //    Console.WriteLine("Enter two numbers");
            //    int won = int.Parse(Console.ReadLine());
            //    int too = int.Parse(Console.ReadLine());
            //    int product = won * too;
            //    Console.WriteLine(product);
            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    more = Console.ReadLine();

            //} while (more == "y");
            #endregion

            #region Excercise 9 √
            // Prompt the user to enter a language. Based on the language the user input, display "Hello,
            //World!" in that language. Use a switch statement to choose what to display.

            //Console.WriteLine("enter a language (english/spanish/french)");
            //string language = Console.ReadLine().ToLower();

            //switch (language)
            //{
            //    case "english":
            //        Console.WriteLine("Hello!");
            //        break;
            //    case "spanish":
            //        Console.WriteLine("Hola!");
            //        break;
            //    case "french":
            //        Console.WriteLine("Bonjour");
            //        break;
            //}
            #endregion

            #region Excercise 10 √
            // Determine whether the user is tall enough to ride a roller coaster. Prompt the user to enter
            //her height in inches. If she is less than 54 inches tall, notify her that she cannot ride the
            //Raptor. If she is at least 54 inches tall, notify her that she can ride the Raptor.

            //Console.WriteLine("What is your height? (in inches)");
            //int height = int.Parse(Console.ReadLine());

            //if (height >= 54)
            //{
            //    Console.WriteLine("You can ride the Raptor!");
            //}
            //else
            //{
            //    Console.WriteLine("I'm sorry, you cannot ride the raptor");
            //}

            #endregion

            #region Excercise 11 √
            // Use a for loop to output all the numbers from 0 to 9.

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Excercise 12 √
            // Output all the numbers from 9 to 0. Use a for loop to output all the numbers from 9 to 0

            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Excercise 13 √
            // Prompt the user for a number. Use a for loop to output all the numbers from that number to
            //0.

            //Console.WriteLine("Enter a number");
            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine("Countdown");
            //for (int i = input; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Excercise 14 √
            // Prompt the user for a number. Use a for loop to output the squares of all the numbers from 1
            //to that number.

            //Console.Write("Enter a number:");
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input; i++)
            //{
            //    Console.WriteLine(i * i);
            //}
            #endregion

            #region Excercise 15 √
            // Prompt the user for a number. Use a for loop to output the cubes of all the numbers from 1 to
            //that number.

            //Console.Write("Enter a number:");
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input; i++)
            //{
            //    Console.WriteLine(i * i * i);
            //}
            #endregion

            #region Excercise 16 √
            // Use a for loop to output a triangle of asterisks with a height of ten.
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********
            //**********

            //string star = "*";
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(star);
            //    star = star + "*";
            //}
            #endregion

            #region Excercise 17 √
            // Use a for loop to output a triangle of asterisks with a height of ten.
            //         *
            //        * * 
            //       * * *
            //      * * * * 
            //     * * * * *
            //    * * * * * *
            //   * * * * * * *
            //  * * * * * * * *
            // * * * * * * * * *
            //* * * * * * * * * *

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 9-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < i+1; k++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Excercise 18 √

            // Prompt the user to enter a number. Use a for-loop to calculate the sum of all the numbers
            //from 1 to the number entered.

            //Console.WriteLine("Enter a number");
            //int input = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i <= input; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Excercise 19 √
            // Prompt the user to enter two numbers. Use a for-loop to calculate the sum of all the numbers
            //from the first number entered to the second.

            //Console.WriteLine("Enter two numbers");
            //int inputOne = int.Parse(Console.ReadLine());
            //int inputTwo = int.Parse(Console.ReadLine());
            //int sum = 0;

            //if (inputOne < inputTwo)
            //{
            //    for (int i = inputOne; i <= inputTwo; i++)
            //    {
            //        sum += i;
            //    }
            //}
            //else
            //{
            //    for (int i = inputTwo; i <= inputOne; i++)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Excercise 20 √
            // Prompt the user to enter a number. Use a for-loop to calculate the product of the number
            //and the two preceding numbers.

            //Console.WriteLine("Enter a number");
            //int input = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i <= input; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Excercise 21 √
            // Prompt the user to enter a series of words. Once the user is done entering the words, output
            //a sentence containing all the words

            //List<String> sentence = new List<String>();
            //string more = "y";

            //do
            //{
            //    Console.WriteLine("Please enter a word");
            //    string awnser = Console.ReadLine();
            //    sentence.Add(awnser);
            //    Console.WriteLine("Do you want to add another word? (y/n)");
            //    more = methods.YesOrNoValidation(Console.ReadLine());
            //} while (more == "y");

            //foreach (string word in sentence)
            //{
            //    Console.Write($"{word} ");
            //}

            #endregion

            #region Excercise 22 √
            // Prompt the user to enter two numbers that will determine a range. Then prompt the user to
            //enter another number and check if it is in the range.

            //string more = "y";

            //do
            //{
            //    Console.WriteLine("Enter two numbers");
            //    int numOne = int.Parse(Console.ReadLine());
            //    int numTwo = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter another number, and we'll check if it's in range of the other numbers");
            //    int numThree = int.Parse(Console.ReadLine());

            //    if (numOne < numTwo)
            //    {
            //        if (numThree > numOne && numThree < numTwo)
            //        {
            //            Console.WriteLine($"{numThree} is in Range of {numOne} and {numTwo}!");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{numThree} is not in Range of {numOne} and {numTwo}!");
            //        }
            //    }
            //    else
            //    {
            //        if (numThree > numTwo && numThree < numOne)
            //        {
            //            Console.WriteLine($"{numThree} is in Range of {numTwo} and {numOne}!");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{numThree} is not in Range of {numTwo} and {numOne}!");
            //        }
            //    }

            //    Console.WriteLine("Do you want to continue? (y/n)");
            //    more = methods.YesOrNoValidation(Console.ReadLine());

            //} while (more == "y");

            //Console.WriteLine("Goodbye!");
            #endregion

            #region Excercise 23 √
            // Prompt the user to enter a string. Extract and output the first ten characters of the string.

            //Console.WriteLine("Enter in a string");
            //string word = Console.ReadLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}

            #endregion

            #region Excercise 24 √
            // Prompt the user to enter a string. Extract and output the last ten characters of the string.

            //Console.WriteLine("Enter in a string");
            //string word = Console.ReadLine();
            //for (int i = word.Length-10; i <= word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}
            #endregion

            #region Excercise 25 √
            // Prompt the user to enter a sentence. Split the sentence into individual words and display each
            //word on its own line.

            //Console.WriteLine("Enter a sentence");
            //string sentence = Console.ReadLine();
            //String[] sentenceArray = sentence.Split(" ", sentence.Length);
            //foreach (string word in sentenceArray)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region Excercise 26 √
            // Prompt the user to enter text. Count and output how many vowels were in the string

            //Console.WriteLine("Enter some text");
            //string text = Console.ReadLine();
            //int vowels = 0;
            //foreach (char character in text)
            //{
            //    if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' )
            //    {
            //        vowels++;
            //    }
            //}
            //Console.WriteLine($"There are {vowels} vowels in your sentence");

            #endregion

            #region Excercise 27 √ Try again with Linq
            // Prompt the user to enter text. Count and output how many consonants were in the string

            //Console.WriteLine("Enter some text");
            //string text = Console.ReadLine().ToLower();
            //int consonants = 0;
            //foreach (char character in text)
            //{
            //    if (character != 'a' && character != 'e' && character != 'i' && character != 'o' && character != 'u')
            //    {
            //        consonants++;
            //    }
            //}
            //Console.WriteLine($"There are {consonants} consonants in your sentence");
            #endregion

            #region Excercise 28 √ Try again with Linq
            // Prompt the user to enter text. Remove all the vowels and output the text.

            //Console.WriteLine("Enter some text");
            //string text = Console.ReadLine();

            //foreach (char character in text)
            //{
            //    if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //    {
            //        text= text.Replace(character, ' ');
            //        text = text.Replace(" ", String.Empty);
            //    }
            //}
            //Console.WriteLine(text);
            #endregion

            #region Excercise 29 Maybe try something with Regex?
            // Prompt the user to enter text. Remove all the vowels in the middle of the word, but leave any
            //that start or end the word.

            //Console.WriteLine("Enter some text");
            //string text = Console.ReadLine();

            //for (int i = 1; i < text.Length - 2; i++)
            //{
            //    if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
            //    {
            //        text = text.Replace(text[i], ' ');
            //    }
            //}
            //foreach (Char character in text)
            //{
            //    text = text.Replace(" ", String.Empty);
            //}
            //Console.WriteLine(text);

            #endregion

            #region Excercise 30 √
            // Prompt the user to enter text. Reverse the text.

            //string input = Console.ReadLine();

            //for (int i = input.Length-1; i >= 0; i--)
            //{
            //    Console.Write(input[i]);
            //}
            #endregion

            #region Excercise 31 √
            // Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Prompt the user
            //to enter an index. Display the element in the array at that index.

            //int[] intArray = { 2, 8, 0, 24, 51 };
            //Console.WriteLine("Pick a number from 1-5");
            //int input = int.Parse(Console.ReadLine()) - 1;
            //Console.WriteLine($"The number in that index of the array is {intArray[input]}");
            #endregion

            #region Excercise 32 √
            // Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Prompt the user
            //to enter a number. If the number is in the array, display the index at which it is located

            //int[] intArray = { 2, 8, 0, 24, 51 };
            //Console.WriteLine("Pick a number");
            //int input = int.Parse(Console.ReadLine());
            //for (int i = 0; i < intArray.Length - 1; i++)
            //{
            //    if (intArray[i] == input)
            //    {
            //        Console.WriteLine($"The index {i} of the Array contains {input}");
            //    }
            //}

            #endregion

            #region Excercise 33 √
            // Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Let the user
            //change the array by specifying an index and a replacement number.

            //int[] intArray = { 2, 8, 0, 24, 51 };
            //Console.WriteLine("Select and index from 0-4");
            //int index = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pick a number to replace the current number in that index");
            //int replacement = int.Parse(Console.ReadLine());
            //int original = intArray[index];

            //intArray[index] = replacement;

            //Console.WriteLine($"The old index of {index} was worth {original}, the new index of {index} is {intArray[index]}");

            #endregion

            #region Excercise 34 √
            // Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256. Prompt the
            //user to enter a command, 'half' or 'double'.If the user enters 'half', half all the elements in the
            //array.If the user enters 'double', double all the elements in the array.

            //int[] intArray = { 2, 8, 0, 24, 51 };
            //string cont = "go";
            //do
            //{
            //    foreach (int number in intArray)
            //    {
            //        Console.Write($"{number} ");
            //    }

            //    Console.WriteLine("\n");
            //    Console.WriteLine("Enter a command: half or double, type STOP to close the program");
            //    string choice = Console.ReadLine().ToLower();
            //    if (choice == "half")
            //    {
            //        for (int i = 0; i < intArray.Length; i++)
            //        {
            //            intArray[i] = intArray[i] / 2;
            //        }
            //    }
            //    else if (choice == "double")
            //    {
            //        for (int i = 0; i < intArray.Length; i++)
            //        {
            //            intArray[i] = intArray[i] * 2;
            //        }
            //    }
            //    else if (choice == "stop")
            //    {
            //        cont = "stop";
            //    }
            //} while (cont == "go");
            #endregion

            #region Excercise 35 √
            // Create an array of size 5 and fill it with the following strings: "cow", "elephant", "jaguar", "horse",
            //"crow".Prompt the user to enter two indices separated by a space. The first index will specify
            //the word, and the second will specify a letter in that word. Display the corresponding word
            //and letter.

            //string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };
            //Console.WriteLine("Pick two numbers from 0-4 seperated by a space. ex (1 4)");
            //string choice = Console.ReadLine();
            //string[] choices = choice.Split(" ");
            //try
            //{
            //    int wordIndex = int.Parse(choices[0]);
            //    int letterIndex = int.Parse(choices[1]);
            //    string animalChoice = animals[wordIndex];
            //    char letterChoice = animalChoice[letterIndex];
            //    Console.WriteLine($"Your animal is {animalChoice}, and your letter is {letterChoice}");
            //} 
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("You picked an index too far because the words is too small");
            //}




            //DO LAB 8
            #endregion

            #region Excercise 36
            //DO LAB 8

            // Create two arrays, each of size 5. Fill the first array with the numbers: 12, 11, 10, 9, 8. Fill the
            //second array with the strings: "Drummers Drumming", "Pipers Piping", "Lords a-Leaping",
            //"Ladies Dancing", "Maids a-Milking".Combine both arrays to display a piece of the Christmas
            //song
            #endregion

            #region Excercise 37
            // Prompt the user to enter five numbers. Store these numbers in an array and output their
            //sum.

            #endregion

            #region Excercise 38
            // Prompt the user to enter five numbers. Store these numbers in an array and output their
            //average.

            #endregion

            #region Excercise 39
            // Prompt the user to enter five numbers. Store these numbers in an array and output them in
            //ascending order.

            //DO LAB 9
            #endregion

            #region Excercise 40
            // Prompt the user to enter five numbers. Store these numbers in an array and output the
            //median.

            #endregion

            #region Excercise 41
            // Prompt the user to enter two numbers. Divide the two numbers and show only two decimal
            //places.

            #endregion

            #region Excercise 42
            // Create a class called Point, that has two properties, X and Y. Let the user enter an X and Y value to create a Point object.

            #endregion

            #region Excercise 43
            // Enhance the point class in the previous exercise by adding a CalculateDistance method. The
            //distance method will calculate the distance of a point from the origin, (0, 0).

            #endregion

            #region Excercise 44
            // Enhance the point class in the previous exercise by adding a CalculateMidpoint method. The
            //CalculateMidpoint will take as an argument another point and return the midpoint between
            //the current('this') object and the point passed in. Its method signature will look like: Point
            //CalculateMidpoint(Point other)

            #endregion

            #region Excercise 45
            // Create a class Square, that has one property, SideLength. The class should have two methods,
            //CalculatePerimeter, and CalculateArea. Let the user enter the length of the square's side.
            //Create an object based on that length and output details of the square.

            #endregion

            #region Excercise 46
            // Create a class Triangle, that has three properties, Side1Length, Side2Length, Side3Length. The
            //class should have two methods, CalculatePerimeter, and CalculateArea.Let the user enter the
            //length of the triangle's sides. Create an object based on those lengths and output the
            //triangle's details. Hint: Google Heron's Formula.

            #endregion

            #region Excercise 47
            // Prompt the user to enter a string. Store the string in a list and display the contents of the list with each element separated by a space.

            #endregion

            #region Excercise 48
            // Prompt the user to enter as many numbers as she wants. Store these numbers in a list and
            //output their sum.

            //DO LAB 10

            #endregion

            #region Excercise 49
            // Create a list of squares. Use the Square class you built in Lab 9. Then display some statistics for the collection of squares.

            #endregion

            #region Excercise 50
            // Create a list of triangles. Use the Triangle class you built in Lab 9. Then display some statistics for the collection of Triangles.

            #endregion

            #region Excercise 51
            // Create a dictionary with the following key value pairs: hello => hola, food => comida, world =>mundo, computer => computadora, exercise => ejercicio.Prompt the user to enter a word and output the translation.
            #endregion

            #region Excercise 52
            // Prompt the user to enter data for a collection of shapes. Display aggregate information about
            //the shapes.

            //DO LAB 11
            #endregion

            #region Excercise 53
            // Use the Square, Triangle, and Circle class from Lab 9 to extract an abstract class Shape. Find
            //the methods they all have in common and put them into a base class. All three classes should
            //then inherit from this base class.

            #endregion

            #region Excercise 54
            // Enhance the shape hierarchy you built with different kinds of shapes. Try building in rectangles, pentagons, hexagons, trapezoids, parallelograms, rhombi, ellipses, etc.

            #endregion

            #region Excercise 55
            // Create a class hierarchy using animals. Think about: Which properties and methods do all
            //animals share? Which properties and methods do only some animals share? Which properties
            //and methods are unique to a single animal?
            #endregion

            #region Excercise 56
            // Here's a short guide to help you get started on Lab 11. Start with the Student class. Create all the properties including name and address. Then create the Staff class with all the properties including name and address.Once you have completed both classes examine them and note what is different and what is similar.Take the similar components and move them into a base class. This process should be just like extracting the Shape class.

            //DO LAB 12
            #endregion

            #region Excercise 57
            // Prompt the user for rock, paper, scissors input and display the winner. Player 2 can see Player 1's choice so it's not a very fun game yet.Try hiding the user's input with an asterisk, like when you type a password. Then you'll be able to play with a friend.

            #endregion

            #region Excercise 58
            // Create the following Enumerations to practice the syntax:

            //Suit => Diamonds, Hearts, Clubs, Spades
            //Browser => Chrome, Firefox, IE, Opera
            //Brand => Polo, Gucci, Armani, Athleta
            //Day => Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday

            //Think about the contexts these enums would be used in.

            #endregion

            #region Excercise 59
            // Define a card class with two properties, Rank and Suit. For these properties, define two enums, Rank(Ace, King Queen, etc.) and Suit(Spades, Diamonds, Hearts, Clubs).

            #endregion

            #region Excercise 60
            // Use the class defined in the previous exercise to make a deck of 52 cards combining the 4 suits with the 13 ranks.Use a random number generator to shuffle the deck and display the topmost card.

            #endregion

            #region Excercise 61
            // Change Lab 11's Shape class from an abstract class into an interface. Why were you able to do this ? What are the differences between an interface and an abstract class? Can you convert Lab 12's Player class into an interface? Why or why not?

            #endregion

            #region Excercise 62
            //Enhance your Card class by having it implement the IComparable interface. Now draw two cards and determine which is higher.
            //Spades > Hearts > Diamonds > Clubs.

            #endregion

            #region Excercise 63
            // The String class in C# is like any other class you have written. It has just been written for you by someone else. Using your knowledge of the String class start writing the code for the string class. You don't have to fill out the methods. Just get a sense of what the class looks like

            #endregion

            #region Excercise 64
            // Define a Validator class. Add a method IsInt that takes a string and returns true if the string can be parsed as an int.

            #endregion

            #region Excercise 65
            // Enhance the Validator class. Overload the method IsInt to take an input string and a min and max value. Return true if the string can be parsed as an integer and is between the min and max value. For this application, pass IsInt 3 and 12 as the min and max value.

            #endregion

            #region Excercise 66
            // Enhance the Validator class to determine whether the user entered method ParseYesNo that takes a string and returns an enum YesNoResponse. The enum can be one of three values: YES, NO, NOT_RECOGNIZED.


            #endregion

            #region Excercise 67
            // Read a list of numbers from a file, and output their sum.
            //Create a file named numbers.txt with the following contents:
            //7
            //12
            //13
            //15
            //12
            //11
            #endregion

            #region Excercise 68
            // Read translations from a file, and store them in a dictionary. Create a file named dictionary.txt with the following contents:
            //hello,hola
            //food, comida
            //world,mundo
            //computer, computadora
            //exercise,ejercicio
            #endregion

            #region Excercise 69
            // Create a list of numbers and output them to a file.

            #endregion

            #region Excercise 70
            // Create a dictionary of translations and append them to an existing file

            #endregion

            #region Excercise 71
            // Read a list of triangles from a file. Create a file named triangles.txt with the following contents:
            //3 4 5
            //5 12 13
            #endregion

            #region Excercise 72
            // Determine whether a number is prime or not.
            #endregion

            #region Excercise 73
            // Output the first 100 prime numbers

            #endregion

            #region Excercise 74
            // Output the first 500 prime numbers. Measure how long it takes. Try optimizing the algorithm and tracking your progress. Every time you make a change that lowers your time, check in the code and put the statistics in your commit comment.Just Google It if you run out of ideas to optimize your algorithm.

            #endregion

            #region Excercise 75
            // Write an algorithm that calculates the square root of a number. Just Google It if you are stuck. Do not use the built in Math.Sqrt method. The algorithm initially only needs to work for perfect squares.

            #endregion

            #region Excercise 76
            // Determine whether a number is even or odd.


            #endregion
        }
    }
}
