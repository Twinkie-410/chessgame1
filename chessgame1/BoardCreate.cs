using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Controls.Button;

namespace chessgame1
{
    internal class BoardCreate
    {
        public void RunBoard()
        {
            string bking = System.IO.Path.GetFullPath("images\\BKing.png");
            string bqueen = System.IO.Path.GetFullPath("images\\BQueen.png");
            string bknight = System.IO.Path.GetFullPath("images\\BKnight.png");
            string brook = System.IO.Path.GetFullPath("images\\BRook.png");
            string bbishop = System.IO.Path.GetFullPath("images\\BBishop.png");
            string bpawn = System.IO.Path.GetFullPath("images\\BPawn.png");

            string wking = System.IO.Path.GetFullPath("images\\WKing.png");
            string wqueen = System.IO.Path.GetFullPath("images\\WQueen.png");
            string wknight = System.IO.Path.GetFullPath("images\\WKnight.png");
            string wrook = System.IO.Path.GetFullPath("images\\WRook.png");
            string wbishop = System.IO.Path.GetFullPath("images\\WBishop.png");
            string wpawn = System.IO.Path.GetFullPath("images\\WPawn.png");

            string[,] arr = new string[8, 8]
                        {
                        { brook, bknight, bbishop, bqueen, bking, bbishop, bknight, brook },
                        { bpawn, bpawn,bpawn, bpawn, bpawn, bpawn, bpawn, bpawn },
                        { "0", "0", "0", "0", "0", "0", "0", "0" },
                        { "0", "0", "0", "0", "0", "0", "0", "0" },
                        { "0", "0", "0", "0", "0", "0", "0", "0" },
                        { "0", "0", "0", "0", "0", "0", "0", "0" },
                        { wpawn, wpawn, wpawn, wpawn, wpawn, wpawn, wpawn, wpawn },
                        { wrook, wknight, wbishop, wqueen, wking, wbishop, wknight, wrook },
                        };

            

        }
       

        
    }
}
