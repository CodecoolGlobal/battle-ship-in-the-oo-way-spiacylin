using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSGame
{
    public class Square
{
    public CurrentStatus CurrentStatus { get; set; }
    public Coordinates Coordinates { get; set; }

    public Square(int row, int column)
    {
        Coordinates = new Coordinates(row, column);
        CurrentStatus = CurrentStatus.Empty;
    }
}

}