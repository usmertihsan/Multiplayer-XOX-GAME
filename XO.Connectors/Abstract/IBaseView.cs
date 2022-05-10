using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.Game.Player;

namespace XO.Game.Engine
{
    public interface IBaseView
    {
        void DrawMatrix(string[,] matrix, int dimension);
        void ReplacementGameViewClear();
        void CountSizeOfMark(GamePlayer p1, GamePlayer p2, bool control);
        void drawCheck();

       
    }
}
