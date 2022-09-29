using System;
using System.Threading;

namespace TicTakToe
{
    public class Program
    {
            static char[] arr = {'1', '2', '3', '3', '4', '5', '6', '7', '8', '9'};
            static int player_turn = 1;
            static int choice;
            static int winner = 0;
        public static void Main(string[] args)
        {
            do
            {

            
                Console.Clear();
                Console.WriteLine("Player1:X and Player2:O \n");
                if (player_turn % 2 == 0)
                {
                Console.Write("Player 2 Turn: ");
                }
                else
                {
                Console.Write("Player 1 Turn: ");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    
                    if (player_turn % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player_turn++;
                    }
                    
                    else
                    {
                        arr[choice] = 'X';
                        player_turn++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry this space {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                    
                winner = CheckWin();
            
            }
            while (winner != 1 && winner != -1);

            Console.Clear();
            Board();
            if (winner == 1)
            {
                Console.WriteLine("Player {0} has won", (player_turn % 2) + 1);
            }

            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();            
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
           
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion

            #region vertical Winning Condtion
            
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Draw Condition

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    } 
} 