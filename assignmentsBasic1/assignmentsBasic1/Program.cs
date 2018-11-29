﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Assignment 1: Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array, adding the user’s text to the string. 
        // Then create a loop that prints off each string in the Array on a separate line.
        string[] names = { "Jesse", "Jerry", "Tom" };
        Console.WriteLine("Say \"Hi\" to eaveryone");
        string greet = Console.ReadLine();

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(greet + " " + names[i] + "!");
        }

        // ASsignment 2: Create an infinite loop.
        // Assignment 3: Fix the infinite loop so it will execute.
        Console.WriteLine("\nGuess my number?");
        int number = Convert.ToInt32(Console.ReadLine());
        bool myNumber = number == 7;

        do
        {
            switch (number)
            {
                case 7:
                    Console.WriteLine("Your guess is right! \n");
                    myNumber = true;
                    break;
                default:
                    Console.WriteLine("Your guess is wrong. Try again!");
                    Console.WriteLine("Guess my number?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

        while (!myNumber);

        // Assignment 4: Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

        Console.WriteLine("Your test result: ");
        int[] myScores = { 70, 50, 45, 80, 90 };
        int failScore = 70;

        for (int j = 0; j < myScores.Length; j++)
        {
            if (myScores[j] < failScore)
            {
                Console.WriteLine("You failed with your score " + myScores[j] + "!");
            }
        }

        // Assignment 5: Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

        Console.WriteLine("\nHow many treasures have you found?");
        int myTreasures = Convert.ToInt32(Console.ReadLine());

        while (myTreasures <= 3)
        {
            Console.WriteLine("\nKeep working! How many treasures have you found?");
            myTreasures = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Good jobs, you have found enough treasures!");

        // Assignment 6: Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
        // Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
        // Assignment 7: Add code to that above loop that tells a user if they put in text that isn’t in the List.
        // Assignment 8: Add code to that above loop that stops it from executing once a match has been found.

        string[] fruits = { "apple", "banana", "orange", "pear", "grape" };
        Console.WriteLine("\nChoose what fruit you want in my fruit container?");
        string choice = Console.ReadLine();

        while (! fruits.Contains(choice))
        {
            Console.WriteLine("Your choice is not valid");
            Console.WriteLine("\nChoose what fruit you want in my fruit container?");
            choice = Console.ReadLine();
        }

        for (int k = 0; k < fruits.Length; k++)
        {
            if (fruits[k] == choice)
            {
                Console.WriteLine("Yes I have " + fruits[k] + ".");
                break;
            }
        }

        // Assignment 9: Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. 
        // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
        // Assignment 10: Add code to that above loop that tells a user if they put in text that isn’t in the List.

        string[] city = { "seattle", "portland", "chicago", "newyork", "seattle" };
        Console.WriteLine("\nChoose a city you would like to visit?");
        string cityChoice = Console.ReadLine();

        while (! city.Contains(cityChoice))
        {
            Console.WriteLine("Your choice is not valid");
            Console.WriteLine("\nChoose a city you would like to visit?");
            cityChoice = Console.ReadLine();
        }

        for (int l = 0; l < city.Length; l++)
        {
            if (city[l] == cityChoice)
            {
                Console.WriteLine("Your choice of city " + city[l] + " in our list.");
            }
        }

        // Assignment 11: Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and
        // displays a message showing the string and whether or not it has already appeared in the list.

        List<string> Names = new List<string>() { "Jesse", "Jerry", "Tom", "Jesse" };
        Console.WriteLine("\nHere everyone's name.");

        foreach (string name in Names)
        {
            Console.WriteLine(name);
        }

        foreach (string name in Names)
        {
            if (name.Count() > 1)
            {
                Console.WriteLine("\nLook the name " + name + " is in the list repeatedly");
                break;
            }
        }

        Console.ReadLine();
    }
}