using System;
using System.Collections.Generic;
using System.Text;

namespace TextLineShuffler
{
    class UX
    {
        public static string PromptAndGetFileName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the file name to shuffle:");

            Console.ForegroundColor = ConsoleColor.White;
            string fileName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Searching for file named " + fileName + "...");
            return (fileName);
        }

        public static bool NotifyFileFailure()
        {
            bool response;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("File does not exist in this directory!");

            response = PromptAndGetYesNo("Would you like to try again?");
            return (response);
        }
        public static void NotifySuccess(string fileName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success! Shuffled contents written to new file " + fileName);

        }
        public static bool PromptAndGetYesNo(string prompt)
        {
            bool response;
            string input;
            char firstInputChar;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(prompt + " (Y/N):");
            Console.ForegroundColor = ConsoleColor.White;
            input = Console.ReadLine();
            input = input.ToUpper();
            firstInputChar = input[0];

            if (firstInputChar == 'Y')
            {
                response = true;
            }
            else if (firstInputChar == 'N')
            {
                response = false;
            }
            else
            {
                response = PromptAndGetYesNo(prompt);
            }

            return (response);
        }
    }
}
