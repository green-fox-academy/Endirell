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

namespace graphic
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

            //int original = 600;

            //int ax1 = original - original;
            //int ay1 = original / 3;
            //int ax2 = original;
            //int ay2 = original / 3;

            //int bx1 = original - original;
            //int by1 = (original / 3) * 2;
            //int bx2 = original;
            //int by2 = (original / 3) * 2;

            //int cx1 = original / 3;
            //int cy1 = original - original;
            //int cx2 = original / 3;
            //int cy2 = original;

            //int dx1 = (original / 3) * 2;
            //int dy1 = original - original;
            //int dx2 = (original / 3) * 2;
            //int dy2 = original;


            //foxDraw.StrokeColor(Colors.Black);
            //foxDraw.DrawLine(ax1, ay1, ax2, ay2);

            //foxDraw.StrokeColor(Colors.Black);
            //foxDraw.DrawLine(bx1, by1, bx2, by2);

            //foxDraw.StrokeColor(Colors.Black);
            //foxDraw.DrawLine(cx1, cy1, cx2, cy2);

            //foxDraw.StrokeColor(Colors.Black);
            //foxDraw.DrawLine(dx1, dy1, dx2, dy2);

            int width = 600;

            int height = 600;

            int counter = 4; 

            int columnx1 = 0 + width / 3;
            int columny1 = height;

            int columnx2 = 0 + width / 3;
            int columny2 = 0 + height;




            








        }
        static int Height(int H, int C)
        {
            if (C > 1)
            {



                return H;
            }
            else
            {
                return 0;
            }
        }



    }
}
