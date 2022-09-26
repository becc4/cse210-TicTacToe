using System;

// See https://aka.ms/new-console-template for more information
namespace Test
{
    public class Program
    {

        private void displayScreen(List<String> answers) { //void says no return
        // creates image (performer)
        {
            Console.WriteLine($"{answers[0]}|{answers[1]}|{answers[2]}");
            Console.WriteLine($"{answers[3]}|{answers[4]}|{answers[5]}");
            Console.WriteLine($"{answers[6]}|{answers[7]}|{answers[8]}");
        }
        }  
        private String getInput(String turn) {
            Console.Write($"{turn}'s turn to choose a square (1-9): ");
            String answer = Console.ReadLine();

            return answer;
        }
        private List<String> calculateBoard(List<String> answers, String choice, String turn) {
            // Calculates the answers list, which X and O goes where
            // inputs: choice (location), turn (X or O)
            int location = Convert.ToInt32(choice) - 1;
            if (answers[location] != "X" && answers[location] != "O") {
                answers[location] = turn;
            }
            return answers;
        }

        private Boolean gameOver(List<String> answers) {
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
                return true;
            } else {
                return false;
            }
        }

        public static void Main(string[] arg) {
            // Making list
            List<String> answers = new List<String>();
            answers.Add("1"); answers.Add("2"); answers.Add("3"); 
            answers.Add("4"); answers.Add("5"); answers.Add("6"); 
            answers.Add("7"); answers.Add("8"); answers.Add("9");

            Boolean gameOver = false;
            String turn = "X";
            string choice;

            // Director - Calls everything
            Program prog = new Program();
            while (!gameOver) {
                prog.displayScreen(answers);
                choice = prog.getInput(turn);
                prog.calculateBoard(answers, choice, turn);
                //prog.displayScreen(answers);
                gameOver = prog.gameOver(answers);

                if (gameOver) {
                    Console.WriteLine($"{turn} has won!");
                }

                if (turn == "X") {
                    turn = "O";
                } else {
                    turn = "X";
                }
            }
            Console.WriteLine($"Good game. Thanks for playing!");
        }
     }
};

// Console.WriteLine("Hello, World!");