using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
        }

        private static char GetTurn()
        {
            var countX = 0;
            var countO = 0;
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    if (board[r, c] == 'X') countX++;
                    if (board[r, c] == 'O') countO++;
                }
            }

            return countX == countO ? 'X' : 'O';
        }

        private static void DrawTurn(int x, int y)
        {
            if (board[x, y] == ' ')
                board[x, y] = GetTurn();
            DisplayBoard();
        }

        private static bool IsWinningCombination()
        {
            return ((board[0, 0] == 'X' &&
                     board[0, 1] == 'X' &&
                     board[0, 2] == 'X') ||
                    (board[1, 0] == 'X' &&
                     board[1, 1] == 'X' &&
                     board[1, 2] == 'X') ||
                    (board[2, 0] == 'X' &&
                     board[2, 1] == 'X' &&
                     board[2, 2] == 'X') ||
                    (board[0, 0] == 'X' &&
                     board[1, 0] == 'X' &&
                     board[2, 0] == 'X') ||
                    (board[0, 1] == 'X' &&
                     board[1, 1] == 'X' &&
                     board[2, 1] == 'X') ||
                    (board[0, 2] == 'X' &&
                     board[1, 2] == 'X' &&
                     board[2, 2] == 'X') ||
                    (board[0, 2] == 'X' &&
                     board[1, 1] == 'X' &&
                     board[2, 0] == 'X') ||
                    (board[0, 0] == 'X' &&
                     board[1, 1] == 'X' &&
                     board[2, 2] == 'X')) ||
                   (board[0, 0] == 'O' &&
                    board[0, 1] == 'O' &&
                    board[0, 2] == 'O') ||
                   (board[1, 0] == 'O' &&
                    board[1, 1] == 'O' &&
                    board[1, 2] == 'O') ||
                   (board[2, 0] == 'O' &&
                    board[2, 1] == 'O' &&
                    board[2, 2] == 'O') ||
                   (board[0, 0] == 'O' &&
                    board[1, 0] == 'O' &&
                    board[2, 0] == 'O') ||
                   (board[0, 1] == 'O' &&
                    board[1, 1] == 'O' &&
                    board[2, 1] == 'O') ||
                   (board[0, 2] == 'O' &&
                    board[1, 2] == 'O' &&
                    board[2, 2] == 'O') ||
                   (board[0, 2] == 'O' &&
                    board[1, 1] == 'O' &&
                    board[2, 0] == 'O') ||
                   (board[0, 0] == 'O' &&
                    board[1, 1] == 'O' &&
                    board[2, 2] == 'O');
        }

        private static void ShowWinner()
        {
            var previousTurn = "";
            previousTurn = GetTurn() == 'X' ? "O" : "X";
            var winner = "";


            if (IsWinningCombination() && char.Parse(previousTurn) == 'X')
            {
                winner = "X";
            }

            if (IsWinningCombination() && char.Parse(previousTurn) == 'O')
            {
                winner = "O";
            }

            if (winner != "X" && winner != "O") return;
            Console.WriteLine($"winner is {winner}\nWant to play again? y/n");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                InitBoard();
                DisplayBoard();
            }
            else System.Environment.Exit(1);
        }

        private static void IsTie()
        {
            var tie = false;
            var emptyFieldCount = 9;

            foreach (var i in board)
            {
                if (i != ' ') emptyFieldCount--;
            }

            if (emptyFieldCount == 0)
            {
                tie = true;
            }

            if (tie != true) return;
            Console.WriteLine("It's a tie!\nWant to play again? y/n");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                InitBoard();
                DisplayBoard();
            }
            else System.Environment.Exit(1);
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        public static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine($"   {board[0, 0]}|{board[0, 1]}|{board[0, 2]}");
            Console.WriteLine("  --+-+--");
            Console.WriteLine($"   {board[1, 0]}|{board[1, 1]}|{board[1, 2]}");
            Console.WriteLine("  --+-+--");
            Console.WriteLine($"   {board[2, 0]}|{board[2, 1]}|{board[2, 2]}");
            Console.WriteLine("  --+-+--");

            ShowWinner();
            IsTie();
            Console.WriteLine($"\nIt is {GetTurn()}'s turn\n\nEnter coordinate on X axis: ");
            int.TryParse(Console.ReadLine(), out var x);


            while (x > 2 || x < 0)
            {
                Console.WriteLine("Not a valid position. Use 0, 1 or 2");
                int.TryParse(Console.ReadLine(), out x);
            }

            Console.WriteLine("Enter coordinate on Y axis: \n");
            int.TryParse(Console.ReadLine(), out var y);
            while (y > 2 || y < 0)
            {
                Console.WriteLine("Not a valid position. Use 0, 1 or 2");
                int.TryParse(Console.ReadLine(), out y);
            }

            DrawTurn(x, y);
        }
    }
}