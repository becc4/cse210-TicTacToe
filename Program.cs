using System;

// See https://aka.ms/new-console-template for more information
namespace Test
{
    public class Program
    {
        public static void Main(string[] arg)
        {
        // Making list
        List<string> answers = new List<string>();
        answers.Add("1"); answers.Add("2"); answers.Add("3"); 
        answers.Add("4"); answers.Add("5"); answers.Add("6"); 
        answers.Add("7"); answers.Add("8"); answers.Add("9");

        string turn;
        string choice;
        bool continueGame = false;

            class displayScreen(answers); {
                // creates image (performer)
                {
                    Console.WriteLine($"{answers[0]}|{answers[1]}|{answers[2]}");
                    Console.WriteLine($"{answers[3]}|{answers[4]}|{answers[5]}");
                    Console.WriteLine($"{answers[6]}|{answers[7]}|{answers[8]}");
                }
            }
            // Get's user input on which X or O
            class getInput(turn);
            {
                Console.WriteLine($"{turn}'s turn to choose a square (1-9): ");
                string answer = Console.ReadLine();

                return choice;
            }

            public calculateBoard(answers, string choice, string turn, bool continueGame); {
                // Calculates the answers list, which X and O goes where
                // inputs: choice (location), turn (X or O)

                int location = Convert.ToInt32(choice) - 1;
                while (continueGame) {

                }
                if (answers[location] != "X" || answers[location] != "O") {
                    answers.Insert(location, turn);
                }
                return choice;
            }
            gameOver(answers, turn); {
                // Makes sure game is still going
                // inputs: answers, player
                if (answers[0] == answers[1] && answers[1] == answers[2] 
                || answers[3] == answers[4] && answers[4] == answers[5]
                || answers[6] == answers[7] && answers[7] == answers[8]

                || answers[0] == answers[3] && answers[3] == answers[6]
                || answers[1] == answers[4] && answers[4] == answers[7]
                || answers[2] == answers[5] && answers[5] == answers[8]
                
                || answers[0] == answers[4] && answers[4] == answers[8]
                || answers[2] == answers[4] && answers[4] == answers[6]) 
                {
                    Console.WriteLine($"{turn} has won!");
                    Console.WriteLine($"Good game. Thanks for playing!");
                    return true;
                } elif {
                    return false;
                }
            }
        // Director - Calls everything
        do {
            displayScreen(answers);
            choice = getInput("O");
            calculateBoard(answers, choice, "0", continueGame);
            continueGame = gameOver(answers,turn);

            displayScreen(answers);
            choice = getInput("X");
            calculateBoard(answers, choice, "X", continueGame);
            continueGame = gameOver(answers,turn);
        } while (continueGame != true);
        }
     }
};

// Console.WriteLine("Hello, World!");