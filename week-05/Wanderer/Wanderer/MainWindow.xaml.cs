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

namespace Wanderer
{
    public partial class MainWindow : Window
    {
        private FoxDraw Heropicture;

        public MainWindow()
        {
            InitializeComponent();
            Heropicture = new FoxDraw(canvas);

            FoxDraw Floor = new FoxDraw(canvas);

            FoxDraw Enemy = new FoxDraw(canvas);

            FoxDraw Boss = new FoxDraw(canvas);

            Map.Mapmaker(Floor, 10);

            Heropicture.AddImage("Asset/hero-down.png", 0, 0);

            Map.Skeletonplacer(Enemy);

            Map.Bossplacer(Boss);




        }


        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
           
            if (e.Key == Key.Left)
            {
                double x = Heropicture.GetLeft(Heropicture.Tiles[0]) - 50;
                double y = Heropicture.GetTop(Heropicture.Tiles[0]);
                Heropicture.Tiles[0].Source = new BitmapImage(new Uri("Asset/hero-left.png", UriKind.Relative));
                
                int xx = Convert.ToInt32(x) / 50;
                int yy = Convert.ToInt32(y) / 50;

                if (x >= 0 && Map.MapLayout[yy, xx] == 0)
                {
                    Heropicture.SetPosition(Heropicture.Tiles[0], x, y);
                }                
            }

            if (e.Key == Key.Right)
            {
                double x = Heropicture.GetLeft(Heropicture.Tiles[0]) + 50;
                double y = Heropicture.GetTop(Heropicture.Tiles[0]);
                Heropicture.Tiles[0].Source = new BitmapImage(new Uri("Asset/hero-right.png", UriKind.Relative));

                int xx = Convert.ToInt32(x) / 50;
                int yy = Convert.ToInt32(y) / 50;

                if (x < 500 && Map.MapLayout[yy, xx] == 0)
                {
                    Heropicture.SetPosition(Heropicture.Tiles[0], x, y);
                }
            }


            if (e.Key == Key.Down)
            {
                double x = Heropicture.GetLeft(Heropicture.Tiles[0]);
                double y = Heropicture.GetTop(Heropicture.Tiles[0]) + 50;
                Heropicture.Tiles[0].Source = new BitmapImage(new Uri("Asset/hero-down.png", UriKind.Relative));

                int xx = Convert.ToInt32(x) / 50;
                int yy = Convert.ToInt32(y) / 50;

                if (y < 550 && Map.MapLayout[yy, xx] == 0)
                {
                    Heropicture.SetPosition(Heropicture.Tiles[0], x, y);
                }
            }

            if (e.Key == Key.Up)
            {
                double x = Heropicture.GetLeft(Heropicture.Tiles[0]);
                double y = Heropicture.GetTop(Heropicture.Tiles[0]) - 50;
                Heropicture.Tiles[0].Source = new BitmapImage(new Uri("Asset/hero-up.png", UriKind.Relative));

                int xx = Convert.ToInt32(x) / 50;
                int yy = Convert.ToInt32(y) / 50;

                if (y >= 0 && Map.MapLayout[yy, xx] == 0)
                {
                    Heropicture.SetPosition(Heropicture.Tiles[0], x, y);
                }
            }


        }
    }
}