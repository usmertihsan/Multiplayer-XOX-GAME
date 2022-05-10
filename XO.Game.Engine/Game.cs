using System;
using XO.Game.Player;


namespace XO.Game.Engine
{
    public class GameStart
    {
        private IBaseView ViewInstance;
        public GameStart(IBaseView view, GamePlayer p1, GamePlayer p2)
        {
            ViewInstance = view;
            gamePlayerOne = p1;
            gamePlayerTwo = p2;
            this.drawCheck = 0;
            this.checker = false;
        }


        private int n { get; set; }
        private int player1MarkCounter;
        private int player2MarkCounter;
        private int drawCheck;
        private bool checker;
        private bool control;
        private string input;
        private string playerMark;
        private string[,] matrix;
        GamePlayer gamePlayerOne;
        GamePlayer gamePlayerTwo;

        public bool GetChecker()
        {
            return checker;
        }

        public void SetInput(string input)
        {
            this.input = input;
        }
        public void SetPlayerMark(string playerMark)
        {
            this.playerMark = playerMark;
        }
        public void CreateMatrix()
        {

            this.matrix = new string[n, n];

        }
        public void SetSize(int size)
        {
            this.n = size;
        }
        public void ClearPlayerMarkCount()
        {
            player1MarkCounter = 0;
            player2MarkCounter = 0;

        }
        public void FillMatrix()
        {
            int a = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this.matrix[i, j] = Convert.ToString(a++);

                }

            }
        }
        public void PrintMatrix()
        {
            ViewInstance.DrawMatrix(this.matrix, n);
        }
        public void Replacement()
        {
            ViewInstance.ReplacementGameViewClear();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == input)
                    {
                        matrix[i, j] = playerMark;
                    }
                }
            }
            drawCheck++;
            PrintMatrix();
        }
        public void CountChecker()
        {
            if (player1MarkCounter == n)
            {

                gamePlayerOne.IncreaseScore();
                checker = true;
                control = true;
                ViewInstance.CountSizeOfMark(gamePlayerOne, gamePlayerTwo, control);

            }


            if (player2MarkCounter == n)
            {
                gamePlayerTwo.IncreaseScore();
                checker = true;
                control = false;
                ViewInstance.CountSizeOfMark(gamePlayerOne, gamePlayerTwo, control);
            }
        }
        public void CheckWinner()
        {
            if (drawCheck <= n * n)
            {
                // yatay 
                for (int i = 0; i < n; i++)
                {
                    ClearPlayerMarkCount();
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == "X")
                            player1MarkCounter++;
                        else if (matrix[i, j] == "O")
                            player2MarkCounter++;
                    }
                    CountChecker();
                }
                ClearPlayerMarkCount();
                //çapraz 1
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, i] == "X")
                        player1MarkCounter++;
                    else if (matrix[i, i] == "O")
                        player2MarkCounter++;

                    CountChecker();
                }
                ClearPlayerMarkCount();
                //çapraz 2
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, ((n - 1) - i)] == "X")
                        player1MarkCounter++;
                    else if (matrix[i, ((n - 1) - i)] == "O")
                        player2MarkCounter++;

                    CountChecker();
                }
                ClearPlayerMarkCount();
                // dikey
                for (int i = 0; i < n; i++)
                {
                    ClearPlayerMarkCount();
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[j, i] == "X")
                            player1MarkCounter++;
                        else if (matrix[j, i] == "O")
                            player2MarkCounter++;
                    }
                    CountChecker();
                }
                ClearPlayerMarkCount();

                if (drawCheck == n * n && checker != true)
                {
                    checker = true;
                    ViewInstance.drawCheck();
                }

            }

        }
    }
}

