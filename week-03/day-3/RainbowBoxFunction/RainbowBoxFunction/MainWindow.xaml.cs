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
using GreenFox;

namespace RainbowBoxFunction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random r = new Random();

            for (int i = 0; i <= 10; i++)
            {
                               
                Rainbower(foxDraw, (1000 - (i * 100)), Color.FromRgb((byte)r.Next(0, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            }
                               
            
        }
        static void Rainbower(FoxDraw foxDraw, int size, Color col)
        {
            foxDraw.FillColor(col);
            foxDraw.StrokeColor(col);
            foxDraw.DrawRectangle((500 - (size / 2)), (500 - (size / 2)), size, size);
        }
    }
}
