using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;


namespace chessgame1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buba();

        }

        public Btn prevbutton;
        public bool ismoving = false;
        public void buba() { 
            string bking = System.IO.Path.GetFullPath("images\\Bking.png");
            string bqueen = System.IO.Path.GetFullPath("images\\Bqueen.png");
            string bknight = System.IO.Path.GetFullPath("images\\Bknight.png");
            string brook = System.IO.Path.GetFullPath("images\\Brook.png");
            string bbishop = System.IO.Path.GetFullPath("images\\Bbishop.png");
            string bpawn = System.IO.Path.GetFullPath("images\\Bpawn.png");

            string wking = System.IO.Path.GetFullPath("images\\Wking.png");
            string wqueen = System.IO.Path.GetFullPath("images\\Wqueen.png");
            string wknight = System.IO.Path.GetFullPath("images\\Wknight.png");
            string wrook = System.IO.Path.GetFullPath("images\\Wrook.png");
            string wbishop = System.IO.Path.GetFullPath("images\\Wbishop.png");
            string wpawn = System.IO.Path.GetFullPath("images\\Wpawn.png");

            

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


            string[,] states = new string[8, 8]
                        {
                        { "B_rook", "B_knight", "B_bishop", "B_queen", "B_king", "B_bishop", "B_knight", "B_rook" },
                        { "B_pawn", "B_pawn", "B_pawn", "B_pawn", "B_pawn", "B_pawn", "B_pawn", "B_pawn", },
                        { "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty" },
                        { "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty" },
                        { "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty" },
                        { "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty" },
                        { "W_pawn", "W_pawn", "W_pawn", "W_pawn", "W_pawn", "W_pawn", "W_pawn", "W_pawn" },
                        { "W_rook", "W_knight", "W_bishop", "W_queen", "W_king", "W_bishop", "W_knight", "W_rook" },
                        };


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Btn butt = new Btn();
                    butt.Height = 60;
                    butt.Width = 60;
                    butt.Name = "b" + i.ToString() + j.ToString();

                    if ((i + j) % 2 == 0)
                    {
                        butt.Background = new SolidColorBrush(Color.FromRgb(0x50,0x58,0x52));
                        
                    }
                    else
                    {
                        butt.Background = new SolidColorBrush(Colors.Wheat);
                    }
                    
                    BitmapImage bitimg = new BitmapImage();
                    bitimg.BeginInit();
                    bitimg.UriSource = new Uri(arr[i, j], UriKind.RelativeOrAbsolute);
                    bitimg.EndInit();

                    Image img = new Image();
                    img.Source = bitimg;
                    butt.Content = img;
                    butt.Click += Button_Click;
                    butt.state = states[i, j];
                    butt.position_x = i;
                    butt.position_y = j;

                    grid.Children.Add(butt);
                }
                
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Image img = new Image();
            Btn curr_button = (e.Source as Btn);
            if (prevbutton != null & ismoving )
            {
                string pos = curr_button.position_x.ToString() + curr_button.position_y.ToString();
                if (curr_button.state[0] != prevbutton.state[0])
                {
                    if (prevbutton.moves(prevbutton).Contains(pos))
                    {
                        curr_button.Content = prevbutton.Content;
                        prevbutton.Content = img;
                        curr_button.state = prevbutton.state;
                        prevbutton.state = "empty";
                        ismoving = false;
                    }
                }

                else 
                {
                    ismoving = false;
                }
            }
            else if (curr_button.state != "empty")
            {
                prevbutton = curr_button;
                ismoving = true;
            }
                
        }

    }
    public class Btn : Button
    {
        public string state;
        public int position_x;
        public int position_y;
        public List<string> moves(Btn btn)
        {
            return new List<string> { "00", "01","43", };
            
        }
    }

}
