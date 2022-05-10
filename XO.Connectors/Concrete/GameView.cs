using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XO.Game.Engine;
using XO.Game.Player;

namespace XO.Connectors
{
    public partial class GameView : Form, IBaseView
    {
        public GameView()
        {
            InitializeComponent();
        }

        public void CountSizeOfMark(GamePlayer p1, GamePlayer p2, bool control)
        {
            if (control == true)
            {
                MessageBox.Show(p1.GetName() + " " + "is winner" + "\t" + Environment.NewLine + p1.GetName() + "'s Score :" + p1.GetScore() + "\t" + Environment.NewLine + p2.GetName() + "'s Score :" + p2.GetScore() + "\t");
              
            }

            else if (control == false)
            {
                MessageBox.Show(p2.GetName() + " " + "is winner" + "\t" + Environment.NewLine + p1.GetName() + "'s Score :" + p1.GetScore() + "\t" + Environment.NewLine + p2.GetName() + "'s Score :" + p2.GetScore() + "\t");

            }
        }

        public void drawCheck()
        {
            MessageBox.Show("GAME IS DRAW");
        }

        public void DrawMatrix(string[,] matrix, int dimension)
        {
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    lbl_matrix.Text=(matrix[i, j] + "\t");
                }
                
            }
        }

        public void ReplacementGameViewClear()
        {
            lbl_matrix.Text = "";
        }

        private void btn_gamePlay_Click(object sender, EventArgs e)
        {
            
            lbl_matrix.Text = "test";
        }
    }
}
