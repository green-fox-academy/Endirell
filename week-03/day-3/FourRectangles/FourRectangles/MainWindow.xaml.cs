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

namespace FourRectangles
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

            foxDraw.StrokeColor(Colors.DeepPink);
            foxDraw.FillColor(Colors.DeepPink);
            foxDraw.DrawRectangle(0, 0, 30, 20);

            foxDraw.StrokeColor(Colors.CadetBlue);
            foxDraw.FillColor(Colors.CadetBlue);
            foxDraw.DrawRectangle(40, 40, 70, 70);

            foxDraw.StrokeColor(Colors.IndianRed);
            foxDraw.FillColor(Colors.IndianRed);
            foxDraw.DrawRectangle(130, 10, 150, 170);

            foxDraw.StrokeColor(Colors.GreenYellow);
            foxDraw.FillColor(Colors.GreenYellow);
            foxDraw.DrawRectangle(260, 240, 300, 300);

        }
    }
}
