using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSGame
{
    public class GameBoard
    {
        public List<Square> Squares { get; set; }

        public GameBoard()
        {
            Squares = new List<Square>();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Squares.Add(new Square(i, j));
                }
            }
        }
    }

}