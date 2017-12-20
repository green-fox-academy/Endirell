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

        private FoxDraw Bosspicture;

        Character Heroguy = new Hero();
        Character Bossguy = new Boss();

        public MainWindow()
        {
            InitializeComponent();
            Heropicture = new FoxDraw(canvas);

            Bosspicture = new FoxDraw(canvas);

            FoxDraw Floor = new FoxDraw(canvas);

            FoxDraw Enemy = new FoxDraw(canvas);

            FoxDraw Boss = new FoxDraw(canvas);

            Bossguy.x = 1;

            Bossguy.y = 1;

            Map.Mapmaker(Floor, 10);

            Bosspicture.AddImage("Asset/boss.png", Bossguy.x * 50, Bossguy.y * 50);

            Heropicture.AddImage("Asset/hero-down.png", Heroguy.x, Heroguy.y);

            Map.Skeletonplacer(Enemy);

            //Map.Bossplacer(Boss);

            
        




        }


        private void KeyDownEvent(object sender, KeyEventArgs e)
        {

            //if (Combat situation){Key.Space under}

            if (e.Key == Key.Space)
            {
                Heroguy.Fight(Bossguy);

                if (Bossguy.hp <= 0)
                {
                    Bosspicture.Tiles[0].Source = new BitmapImage(new Uri(" ", UriKind.Relative));
                }

            }

            //if (Not combat situation){everything under}

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
                    Heroguy.x--;
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
                    Heroguy.x++;
                }

                if (Heroguy.y == Bossguy.y && Heroguy.x + 1 != Bossguy.x)
                {
                    Heropicture.SetPosition(Heropicture.Tiles[0], (x - 50), y);
                    Heroguy.x--;
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
                    Heroguy.y++;
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
                    Heroguy.y--;
                }
            }


        }
    }
}