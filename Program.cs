using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();

            // Type your code below
            string[] questions = new string[] { "John Wick is cool?", "Hason is cool?", "Is apple a verb?", "Is apple a noun?", "Is country 'CoolLandia' exist?" };
            bool[] answers = new bool[] { true, true, false, true, false };
            //
            Console.WriteLine(RunQuiz(questions, answers));
            Console.ReadLine();
        }

        static string RunQuiz(string[] QuestionArray, bool[] AnswersArray)
        {

            bool[] responses = new bool[QuestionArray.Length];
            if (QuestionArray.Length != AnswersArray.Length)
            {
                Console.WriteLine("Warning BLABLA");
            }

            int askingIndex = 0;


            foreach (string question in QuestionArray)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);
                //Console.WriteLine(isBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in AnswersArray)
            {
                bool UserAnswer = responses[scoringIndex];
                Console.WriteLine($"Input: {UserAnswer} | Answer: {answer}");

                if (UserAnswer == answer)
                {

                    score++;

                }
                scoringIndex++;
            }
            return $"You got {score} out of {AnswersArray.Length} correct!";
        }
    }
}
