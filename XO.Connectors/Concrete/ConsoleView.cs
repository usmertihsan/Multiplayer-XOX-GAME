using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.Game.Player;

namespace XO.Game.Engine
{
    public class ConsoleView : IBaseView
    {
       public void DrawMatrix(string[,] matrix, int dimension)
        {
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
       public void ReplacementGameViewClear()
        {
            Console.Clear();
        }
       public void CountSizeOfMark(GamePlayer p1, GamePlayer p2,bool control)
        {
            if(control==true)
            {
                Console.WriteLine(p1.GetName() + " " + "is winner"+ "\t");
                Console.WriteLine(p1.GetName() + "'s Score :" + p1.GetScore()+ "\t");
                Console.WriteLine(p2.GetName() + "'s Score :" + p2.GetScore()+ "\t");
            }
            
            else if(control == false)
            {
                Console.WriteLine(p2.GetName() + " " + "is winner"+ "\t");
                Console.WriteLine(p1.GetName() + "'s Score :" + p1.GetScore()+ "\t");
                Console.WriteLine(p2.GetName() + "'s Score :" + p2.GetScore()+ "\t");
            }
          
        }

       public void drawCheck()
        {
            Console.WriteLine("GAME IS DRAW");

        }
    }
}
