using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Player1 = "X";
            string Player2 = "O";
            bool win = false;
            string[,] array = { {"1", "2", "3"},
                                {"4", "5", "6"},
                                {"7", "8", "9"}
            };

            for(int i = 1; i <= 9; i++)
            {
                if(i % 2 != 0)
                {
                    win = ChangePlayer(Player1, array);
                }
                else if(i % 2 == 0)
                {
                    win = ChangePlayer(Player2, array);
                }

                if (win)
                    return;
               
            }

        }


        public static bool CheckField(string position, string[,] array)
        {
            bool result = true;
            if (position == "1")
            {
                if (array[0, 0] == "X" || array[0, 0] == "O")
                    result =  false;
                else
                    result =  true;
            }
            if (position == "2")
            {
                if (array[0, 1] == "X" || array[0, 1] == "O")
                    result = false;
                else 
                    result =  true;
            }
            if (position == "3")
            {
                if (array[0, 2] == "X" || array[0, 2] == "O")
                    result = false;
                else
                    result = true;
            }
            if (position == "4")
            {
                if (array[1, 0] == "X" || array[1, 0] == "O")
                    result =  false;
                else
                    result = true;
            }
            if (position == "5")
            {
                if (array[1, 1] == "X" || array[1, 1] == "O")
                    result = false;
                else
                    result = true;
            }
            if (position == "6")
            {
                if (array[1, 2] == "X" || array[1, 2] == "O")
                    result = false;
                else
                    result = true;
            }
            if (position == "7")
            {
                if (array[2, 0] == "X" || array[2, 0] == "O")
                    result = false;
                else
                    result = true;
            }
            if (position == "8")
            {
                if (array[2, 1] == "X" || array[2, 1] == "O")
                    result = false;
                else
                    result =  true;
            }
            if (position == "9")
            {
                if (array[2, 2] == "X" || array[2, 2] == "O")
                    result = false;
                else
                    result =  true;
            }

            return result;
        }
        public static void ChangeField(string player, string[,] array, string position)
        {
            if (CheckField(position, array))
            {
                if (position == "1")
                    array[0, 0] = player;
                else if (position == "2")
                    array[0, 1] = player;
                else if (position == "3")
                    array[0, 2] = player;
                else if (position == "4")
                    array[1, 0] = player;
                else if (position == "5")
                    array[1, 1] = player;
                else if (position == "6")
                    array[1, 2] = player;
                else if (position == "7")
                    array[2, 0] = player;
                else if (position == "8")
                    array[2, 1] = player;
                else if(position == "9")
                    array[2, 2] = player;
            }
            else
            {
                Console.WriteLine("Please enter another field.");
                position = Console.ReadLine();
                ChangeField(player, array, position);
            }
        }

        public static bool CheckForWin(string[,] array)
        {
            for(int x = 0; x < 3; x++)
            {
                if(array[x, 0] == array[x, 1] && array[x, 1] == array[x, 2])
                {
                    if(array[x,0] == "X")
                    {
                        Console.WriteLine("Player 1 wins!!!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Player 2 wins!!!");
                        return true;
                    }
                }
                if(array[0, x] == array[1, x] && array[1, x] == array[2, x])
                {
                    if (array[0, x] == "X")
                    {
                        Console.WriteLine("Player 1 wins!!!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Player 2 wins!!!");
                        return true;
                    }
                }
            }

            if(array[0,0] == array[1,1] && array[1, 1] == array[2,2])
            {
                if (array[0, 0] == "X")
                {
                    Console.WriteLine("Player 1 wins!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Player 2 wins!!!");
                    return true;
                }
            }
            if(array[0,2] == array[1,1] && array[1, 1] == array[2,0])
            {
                if (array[0, 2] == "X")
                {
                    Console.WriteLine("Player 1 wins!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Player 2 wins!!!");
                    return true;
                }
            }
            return false;
        }

        public static bool ChangePlayer(string player, string[,] array)
        {

            string position;
            bool win;
            Console.Clear();
            Console.WriteLine($"     |     |     \n  {array[0, 0]}  |  {array[0, 1]}  |  {array[0, 2]}  \n_____|_____|_____\n" +
               $"     |     |      \n  {array[1, 0]}  |  {array[1, 1]}  |  {array[1, 2]}  \n_____|_____|_____\n" +
               $"     |     |      \n  {array[2, 0]}  |  {array[2, 1]}  |  {array[2, 2]}  \n     |     |     \n");
            if (player == "X")
            {
                Console.WriteLine("Player 1: Choose your field");
                position = Console.ReadLine();
                
                ChangeField(player, array, position);
                Console.Clear();
                Console.WriteLine($"     |     |     \n  {array[0, 0]}  |  {array[0, 1]}  |  {array[0, 2]}  \n_____|_____|_____\n" +
              $"     |     |      \n  {array[1, 0]}  |  {array[1, 1]}  |  {array[1, 2]}  \n_____|_____|_____\n" +
              $"     |     |      \n  {array[2, 0]}  |  {array[2, 1]}  |  {array[2, 2]}  \n     |     |     \n");
                win = CheckForWin(array);
                return win;
            }
            else
            {
                Console.WriteLine("Player 2: Choose your field");
                position = Console.ReadLine();
                
                ChangeField(player, array, position);
                Console.Clear();
                Console.WriteLine($"     |     |     \n  {array[0, 0]}  |  {array[0, 1]}  |  {array[0, 2]}  \n_____|_____|_____\n" +
              $"     |     |      \n  {array[1, 0]}  |  {array[1, 1]}  |  {array[1, 2]}  \n_____|_____|_____\n" +
              $"     |     |      \n  {array[2, 0]}  |  {array[2, 1]}  |  {array[2, 2]}  \n     |     |     \n");
                win = CheckForWin(array);
                return win;
            }

   
        }
    }
}         