
using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';
    static bool gameEnd = false;

    static void Main()
    {

        int playerPosition = 0;
        Console.Clear();
        BoardView();

        while (!gameEnd)
        {
            Console.Write($"Player {currentPlayer}, choose a position: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out playerPosition) && playerPosition >= 1 && playerPosition <= 9)
            {
                if (board[playerPosition - 1] == 'X' || board[playerPosition - 1] == 'O')
                {
                    Console.WriteLine("Cell already taken! Press any key");
                    Console.ReadKey(true);
                    continue;
                }
                board[playerPosition - 1] = currentPlayer; //Робиться хід
                Console.Clear() ;
                BoardView();

                if (VictoryCheck())
                {
                    Console.WriteLine($"Congratulations!!! Player {currentPlayer} has won!");
                    gameEnd = true;
                    continue;
                }
                if (DrawCheck())
                {
                    Console.WriteLine("It's a drow. Friendship has won.");
                    gameEnd = true;
                    continue;
                }
                if (currentPlayer == 'X') // Зміна гравця
                {
                    currentPlayer = 'O';
                }
                else
                {
                    currentPlayer = 'X';
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Press any key");
                Console.ReadKey(true);
            }
        }
    }




    static void BoardView()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]}");
    }


    static bool VictoryCheck()
    {
        int[,] victoryCondition = new[,]
        {
        {0,1,2}, {3,4,5}, {6,7,8 },
        {0,3,6}, {1,4,7}, {2,5,8},
        {0,4,8}, {2,4,6}
    };
        for (int i = 0; i < victoryCondition.GetLength(0); i++)
        {
            if (board[victoryCondition[i, 0]] == currentPlayer && board[victoryCondition[i, 1]] == currentPlayer && board[victoryCondition[i, 2]] == currentPlayer)
            {
                return true;
            }
        }
        return false;
    }

    static bool DrawCheck()
    {
        foreach (char currentValue in board)
        {
            if (currentValue != 'X' && currentValue != 'O')
            {
                return false;
            }
        }
        return true;
    }
}

