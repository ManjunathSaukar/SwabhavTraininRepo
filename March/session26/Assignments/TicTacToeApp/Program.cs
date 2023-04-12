namespace TicTacToeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            char currentPlayer = 'X';
            bool gameFinished = false;

            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine();

            while (!gameFinished)
            {
                DrawBoard(board);

                Console.WriteLine($"Player {currentPlayer}, it's your turn.");

                int row = GetRow();
                int column = GetColumn();

                if (IsValidMove(board, row, column))
                {
                    board[row, column] = currentPlayer;

                    if (HasWon(board, currentPlayer))
                    {
                        DrawBoard(board);
                        Console.WriteLine($"Player {currentPlayer} wins!");
                        gameFinished = true;
                    }
                    else if (IsDraw(board))
                    {
                        DrawBoard(board);
                        Console.WriteLine("It's a draw!");
                        gameFinished = true;
                    }
                    else
                    {
                        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }
            }
        }

        static void DrawBoard(char[,] board)
        {
            Console.WriteLine("   0  1  2");
            Console.WriteLine("0  " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine("  ---------");
            Console.WriteLine("1  " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine("  ---------");
            Console.WriteLine("2  " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2]);
            Console.WriteLine();
        }

        static int GetRow()
        {
            Console.Write("Enter row number (0-2): ");
            return int.Parse(Console.ReadLine());
        }

        static int GetColumn()
        {
            Console.Write("Enter column number (0-2): ");
            return int.Parse(Console.ReadLine());
        }

        static bool IsValidMove(char[,] board, int row, int column)
        {
            return board[row, column] == ' ';
        }

        static bool HasWon(char[,] board, char player)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == player && board[row, 1] == player && board[row, 2] == player)
                {
                    return true;
                }
            }

            // Check columns
            for (int column = 0; column < 3; column++)
            {
                if (board[0, column] == player && board[1, column] == player && board[2, column] == player)
                {
                    return true;
                }
            }

            // Check diagonals
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }

            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                return true;
            }
            return false;
        }
        static bool IsDraw(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board[row, column] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}