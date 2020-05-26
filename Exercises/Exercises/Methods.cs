using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class Methods
    {
        public string YesOrNoValidation(string input)
        {
            input = input.ToLower();
            string go = "y";

            do
            {
                if (input == "y" || input == "n")
                {
                    go = "n";
                }
                else
                {
                    Console.WriteLine("Please enter valid input (y/n)");
                    input = Console.ReadLine();
                }
            } while (go == "y");

            return input;
        }
    }
}
