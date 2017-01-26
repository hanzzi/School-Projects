using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Ekstraopgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please Select an Option: {Environment.NewLine}" +
                              $"1: Get the length of a string{Environment.NewLine}" +
                              $"2: Get the amount of a single character in a string{Environment.NewLine}" +
                              $"3: Get the percentage of a character in a string");

            string ChosenOption = Console.ReadLine();

            StringAnalysisAdvanced Analyze = new StringAnalysisAdvanced();


            // TODO: Find out how to use local variables inside a switch so i do not have to change their names
            switch (ChosenOption)
            {
                case "1":
                    Console.WriteLine("Please Insert a string to analyze.");

                    string toBeAnalysed = Console.ReadLine();
                    Analyze.AssignString(toBeAnalysed);
                    Console.WriteLine($"The Length of \"{toBeAnalysed}\" is {Analyze.GetLength()}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("Please insert a string to analyze.");

                    // Assigns the string to be counted against
                    string fullString = Console.ReadLine();
                    Analyze.AssignString(fullString);

                    Console.WriteLine("Please insert a char to count");

                    // Assigns the Character to be counted
                    char charToBeCounted = Console.ReadKey().KeyChar;
                    Analyze.AssignCharacter(charToBeCounted);

                    double NumberOfCharactersOutput = Analyze.GetNumberOfCharacters();

                    Console.WriteLine($"There are: {NumberOfCharactersOutput} \"{charToBeCounted}\" in {fullString}");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Please insert a string to analyze.");

                    // Assigns the string to be counted against
                    string UserInput = Console.ReadLine();
                    Analyze.AssignString(UserInput);

                    Console.WriteLine("Please insert a char to count");

                    // Assigns the Character to be counted
                    char UserChar = Console.ReadKey().KeyChar;
                    Analyze.AssignCharacter(UserChar);

                    string PercentageOutput = Analyze.PercentageOfChars();

                    Console.WriteLine($"{PercentageOutput}% of {UserInput} is {UserChar}");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
