using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XO.Connectors;
using XO.Game.Engine;
using XO.Game.Player;

namespace XO.Game.UI.WinForm
{
    public partial class MainForm : Form
    {
        GameView GameViewInstance;

        public MainForm()
        {
            InitializeComponent();
            InitGame();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        private void InitGame()
        {
           
            GameViewInstance = new GameView();
            GamePlayer player1 = new GamePlayer()
            {
                playerName = "MERT",
                playerScore = 0,
                playerMark = "X"
            };

            GamePlayer player2 = new GamePlayer()
            {
                playerName = "ANIL",
                playerScore = 0,
                playerMark = "O"
            };

            GameStart XOGame = new GameStart(GameViewInstance, player1, player2);

            XOGame.SetSize(3);
            XOGame.CreateMatrix();
            XOGame.FillMatrix();
            XOGame.PrintMatrix();


            string location;
            do
            {
                location = GameViewInstance.txt_Choice1.Text;
                XOGame.SetInput(location);
                XOGame.SetPlayerMark(player1.GetPlayerMark());
                XOGame.Replacement();
                XOGame.CheckWinner();
                
                if (XOGame.GetChecker() != true)
                {
                    location = GameViewInstance.txt_Choice1.Text;
                    XOGame.SetInput(location);
                    XOGame.SetPlayerMark(player2.GetPlayerMark());
                    XOGame.Replacement();
                    XOGame.CheckWinner();
                }

            } while (XOGame.GetChecker() != true);


        }
    }
}
