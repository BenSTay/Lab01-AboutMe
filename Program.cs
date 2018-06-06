using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe
{
    class Program
    {
        // This method is used to get an integer input from the user.
        static int HandleNumberInput()
        {
            // This runs until an integer gets returned.
            while (true)
            {
                // Gets user input, and tries to convert the input to an integer and return it.
                try
                {
                    Console.Write("Your guess: ");
                    return Convert.ToInt32(Console.ReadLine());
                }
                // Displays an error message if anything other than a whole number is entered.
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.\n");
                }
            }
        }

        // This method formats the output for each question.
        static string ResultString(string response, bool isCorrect)
        {
            return $"Your answer was: {response}. This is {(isCorrect ? "correct" : "incorrect")}!\n";
        }

        // This method is used to ask the user a question whose answer is a word or phrase.
        static bool Question(string questionText, string answer)
        {
            // Prompts the user for input
            Console.WriteLine($"{questionText}\n");
            Console.Write("Your guess: ");

            // Gets the input, checks it against the correct answer, and displays the result.
            string response = Console.ReadLine();
            bool isCorrect = response.ToUpper() == answer;
            Console.WriteLine(ResultString(response, isCorrect));

            return isCorrect;
        }

        // This method is used to ask the user a question whose answer is a number.
        static bool Question(string questionText, int answer)
        {
            // Prompts the user for input
            Console.WriteLine($"{questionText}\n");

            // Gets the input, checks it against the correct answer, and displays the result.
            int response = HandleNumberInput();
            bool isCorrect = response == answer;
            Console.WriteLine(ResultString(response.ToString(), isCorrect));

            return isCorrect;
        }

        // This method asks the user all of the quiz questions and keeps track of their score.
        static void RunQuiz()
        {
            int score = 0;
            if (Question("How many years did I attend a Summer Camp?", 10)) score++;
            if (Question("What is the name of my favorite Digimon?", "GABUMON")) score++;
            if (Question("How many cats have I lived with?", 6)) score++;
            if (Question("What is my favorite breed of dog?", "NEWFOUNDLAND")) score++;
            if (Question("How many miles away from Code Fellows do I live?", 12)) score++;
            Console.WriteLine($"Thank you for playing! You answered {score} out of 5 questions correctly!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the About Me game!");
            RunQuiz();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
