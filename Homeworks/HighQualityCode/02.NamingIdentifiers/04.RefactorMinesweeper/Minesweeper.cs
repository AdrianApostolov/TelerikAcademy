namespace RefactorMinesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minesweeper
    {
        public static void Main()
        {
            const int MaxPoints = 35;
            string command = string.Empty;
            char[,] gameFiled = CreateGameFiled();
            char[,] mines = PutMines();
            int counter = 0;
            int row = 0;
            int column = 0;
            bool isStartGame = true;
            bool isDead = false;
            bool isWinner = false;
            List<GameScore> highScorePlayers = new List<GameScore>(6);

            do
            {
                if (isStartGame)
                {
                    Console.WriteLine("Let's play 'Minesweepers'. Try stepping only on the mine-free fields.\n" +
                    "Command 'top' shows the highscores, 'restart' starts a new game, 'exit' quits the game!");
                    PrintPlayground(gameFiled);
                    isStartGame = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= gameFiled.GetLength(0) - 1 && column <= gameFiled.GetLength(1) - 1)
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        RankList(highScorePlayers);
                        break;
                    case "restart":
                        gameFiled = CreateGameFiled();
                        mines = PutMines();
                        PrintPlayground(gameFiled);
                        isDead = false;
                        isStartGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye bye!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                Turn(gameFiled, mines, row, column);
                                counter++;
                            }

                            if (MaxPoints == counter)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                PrintPlayground(gameFiled);
                            }
                        }
                        else
                        {
                            isDead = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (isDead)
                {
                    PrintPlayground(mines);
                    Console.Write("\nGame over with {0} scores. Enter your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    GameScore gameScore = new GameScore(nickname, counter);
                    if (highScorePlayers.Count < 5)
                    {
                        highScorePlayers.Add(gameScore);
                    }
                    else
                    {
                        for (int i = 0; i < highScorePlayers.Count; i++)
                        {
                            if (highScorePlayers[i].Score < gameScore.Score)
                            {
                                highScorePlayers.Insert(i, gameScore);
                                highScorePlayers.RemoveAt(highScorePlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    highScorePlayers.Sort((GameScore firstPlayer, GameScore secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    highScorePlayers.Sort((GameScore firstPlayer, GameScore secondPlayer) => secondPlayer.Score.CompareTo(firstPlayer.Score));
                    RankList(highScorePlayers);

                    gameFiled = CreateGameFiled();
                    mines = PutMines();
                    counter = 0;
                    isDead = false;
                    isStartGame = true;
                }

                if (isWinner)
                {
                    Console.WriteLine("\nCongratulations! You WIN!\n");
                    PrintPlayground(mines);
                    Console.WriteLine("Plase, enter your name: ");
                    string playerName = Console.ReadLine();
                    GameScore score = new GameScore(playerName, counter);
                    highScorePlayers.Add(score);
                    RankList(highScorePlayers);
                    gameFiled = CreateGameFiled();
                    mines = PutMines();
                    counter = 0;
                    isDead = false;
                    isStartGame = true;
                }
            }
            while (command != "exit");
            {
                Console.WriteLine("Made in Bulgaria!");
                Console.WriteLine("Ai siktir!");
                Console.Read();
            }
        }

        private static void RankList(List<GameScore> scores)
        {
            Console.WriteLine("\nPoints:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, scores[i].Name, scores[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No high-scores yet!\n");
            }
        }

        private static void Turn(char[,] gameField, char[,] mines, int row, int column)
        {
            char minesCount = CountMines(mines, row, column);
            mines[row, column] = minesCount;
            gameField[row, column] = minesCount;
        }

        private static void PrintPlayground(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameFiled()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameFiled = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameFiled[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / cols;
                int row = mine % cols;
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameFiled[col, row - 1] = '*';
            }

            return gameFiled;
        }

        private static void CalculateFieldValues(char[,] gameFiled)
        {
            int cols = gameFiled.GetLength(0);
            int rows = gameFiled.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (gameFiled[i, j] != '*')
                    {
                        char minesCount = CountMines(gameFiled, i, j);
                        gameFiled[i, j] = minesCount;
                    }
                }
            }
        }

        private static char CountMines(char[,] gameFiled, int row, int col)
        {
            int counter = 0;
            int rows = gameFiled.GetLength(0);
            int cols = gameFiled.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameFiled[row - 1, col] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameFiled[row + 1, col] == '*')
                {
                    counter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameFiled[row, col - 1] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < cols)
            {
                if (gameFiled[row, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameFiled[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameFiled[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameFiled[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameFiled[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}
