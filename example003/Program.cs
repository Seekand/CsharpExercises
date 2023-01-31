//Rock-Paper-Scissors

using System;

namespace rock_paper_scissors{

    class Program{

        static void Main(string[] args){

            int player1, player2;
            string winner;
            string[] hands = new string[] {"ROCK", "PAPER", "SCISSORS"};

            Console.Clear();
            Console.WriteLine("Rock Paper Scissors\n");
            Console.WriteLine("    ROCK: 1\n   PAPER: 2\nSCISSORS: 3");
            
            Console.WriteLine("\nPlayer 1 report your move: ");
            player1 = getValidMove();

            Console.WriteLine("\nPlayer 2 report your move: ");
            player2 = getValidMove();

            if(player1 == player2){
                Console.WriteLine("DRAW");
            }else{
                winner = determineWinner(player1, player2);
                Console.WriteLine($"Player 1 played {hands[player1-1]}, Player 2 played {hands[player2-1]}\n{winner} WIN");
            }
        }

        static int getValidMove(){
            int move;
            //while the entry did not live up to expectations
            while(!int.TryParse(Console.ReadLine(), out move) || move < 1 || move > 3){
                Console.WriteLine("Invalid input, please enter a number between 1 and 3.");
            }
            return move;
        }

        static string determineWinner(int player1, int player2){
            int winningHand;
            int[] results = {0, 0, 2, 2, 3};
            winningHand = results[player1+player2];


            return (player1 == winningHand) ? "Player 1" : "Player 2";
        }
    }
}