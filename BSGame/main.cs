using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Battle Ship Game");
            GameBoard myboard = new GameBoard();  //instancja klasy GameBoard
            Console.WriteLine("Player No 1 enter a secret ships placement on board");
            ShipsLocation mylocation = new ShipsLocation(); //instancja klasy ShipsLocation
            
            // Placement ships on board
            foreach (Ship item in mylocation.Ships)
            {
                int counter = 0;
                foreach (string elem in item.Cover)
                {
                    Char srow = elem[0];
                    int d = 0;
                    counter = 0;
                    if (srow == 'A'){d = 0;}
                    else if (srow == 'B') {d = 10;}
                    else if (srow == 'C') {d = 20;}
                    else if (srow == 'D') {d = 30;}
                    else if (srow == 'E') {d = 40;}
                    else if (srow == 'F') {d = 50;}
                    else if (srow == 'G') {d = 60;}
                    else if (srow == 'H') {d = 70;}
                    else if (srow == 'I') {d = 80;}
                    else if (srow == 'J') {d = 90;}
                    Char scol= elem[1];
                    int j = scol - '0';
                    counter = 0;
                    counter = d + j;
                    myboard.Squares[counter].CurrentStatus = item.CurrentStatus;
                    counter = 0;
                }
            }
            DisplayBoard(myboard.Squares);
            Console.WriteLine("please press any button");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Player No 2 start uncoding placement");
            GameBoard fireboard = new GameBoard();
            DisplayBoard(fireboard.Squares);
            //Console.WriteLine( mylocation.Ships[0].Cover[0]); //wyświetla pierwszy coord Cover
            //Console.WriteLine(myboard.Squares[12].CurrentStatus.ToString()); //wyświetla status instancji Square
            
        }

        static void DisplayBoard(List<Square> a)
        {
            
            Console.WriteLine("   0 1 2 3 4 5 6 7 8 9 ");
            Console.WriteLine("  |--------------------|");
            string line = "";
            for (int i = 0; i < 100; i = i +10)
            {
                for (int j = 0; j <10; j++)
                {
                    string s = a[i+j].CurrentStatus.ToString();
                    if (s == "Empty")
                    {
                        line += "~ ";
                    }
                    else if (s == "Battleship")
                    {
                        line += "B ";
                    }
                    else if (s == "Carrier")
                    {
                        line += "A ";
                    }
                    else if (s == "Cruiser")
                    {
                        line += "C ";
                    }
                    else if (s == "Submarine")
                    {
                        line += "S ";
                    }
                    else if (s == "Destroyer")
                    {
                        line += "D ";
                    }
                    else if (s == "Miss")
                    {
                        line += "o ";
                    }
                    else if (s == "Hit")
                    {
                        line += "X ";
                    }
                    
                }
                Console.Write("{0}", (char)(65+i/10));
                Console.WriteLine(" |" + line +"|");
                line = "";
            }
            Console.WriteLine("  |--------------------|");
        }

    }
}
