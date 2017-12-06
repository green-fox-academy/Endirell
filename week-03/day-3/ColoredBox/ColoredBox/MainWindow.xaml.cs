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

namespace ColoredBox
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

            foxDraw.StrokeColor(Colors.DarkKhaki);
            foxDraw.DrawLine(10, 10, 200, 10);

            foxDraw.StrokeColor(Colors.ForestGreen);
            foxDraw.DrawLine(10, 10, 10, 100);

            foxDraw.StrokeColor(Colors.HotPink);
            foxDraw.DrawLine(10, 100, 200, 100);

            foxDraw.StrokeColor(Colors.BlueViolet);
            foxDraw.DrawLine(200, 10, 200, 100);
        }
    }
}
