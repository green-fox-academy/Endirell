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

        private FoxDraw Enemypicture;

        Hero Heroguy = new Hero();

        List<Enemy> bestiary = new List<Enemy>();

        
        public MainWindow()
        {
            InitializeComponent();
            Heropicture = new FoxDraw(canvas);

            Enemypicture = new FoxDraw(canvas);

            FoxDraw Floor = new FoxDraw(canvas);

            //FoxDraw Enemypic = new FoxDraw(canvas);

            Map.Mapmaker(Floor, 10);

            Hero.Herodrawer(Heropicture, Heroguy);

            Enemy.BestiaryBuilder(bestiary);

            Map.Enemydrawer(Enemypicture, bestiary);

            if (bestiary[0].hp <= 0)
            {
                Map.Mapmaker(Floor, 10);
                Enemy.BestiaryBuilder(bestiary);
                Map.Enemydrawer(Enemypicture, bestiary);
            }

        }


        private void KeyDownEvent(object sender, KeyEventArgs e)
        {

            //if (Combat situation){Key.Space under}

            if (e.Key == Key.Space)
            {
                double x = Heropicture.GetLeft(Heropicture.Tiles[0]);
                double y = Heropicture.GetTop(Heropicture.Tiles[0]);

                for (int i = 0; i < bestiary.Count; i++)
                {
                    double enemyx = Enemypicture.GetLeft(Enemypicture.Tiles[i]);
                    double enemyy = Enemypicture.GetTop(Enemypicture.Tiles[i]);


                    if (enemyx == x && enemyy == y + 50 || enemyx == x && enemyy == y - 50 || enemyx + 50 == x && enemyy == y || enemyx - 50 == x && enemyy == y)
                    {
                        Heroguy.Fight(bestiary[i]);

                        if (bestiary[i].hp <= 0)
                        {
                            Enemypicture.Tiles[i].Source = new BitmapImage(new Uri(" ", UriKind.Relative));
                            Enemypicture.SetPosition(Enemypicture.Tiles[i], -50, -50);
                        }
                    }

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
                

                if (x >= 0 && (Map.MapLayout[yy, xx] == 0 || Map.MapLayout[yy, xx] == 2))
                {

                    Heropicture.SetPosition(Heropicture.Tiles[0], x, y);
                    Heroguy.x--;


                    for (int i = 0; i < bestiary.Count; i++)
                    {
                        double enemyx = Enemypicture.GetLeft(Enemypicture.Tiles[i]);
                        double enemyy = Enemypicture.GetTop(Enemypicture.Tiles[i]);


                        if (enemyx == x && enemyy == y)
                        {
                            Heropicture.SetPosition(Heropicture.Tiles[0], (x + 50), y);
                            Heroguy.x++;
                        }

                    }

                }
            }

            if (e.Key == Key.Right)
            {
                double x = Heropicture.GetLeft(Heropicture.Tiles[0]) + 50;
                double y = Heropicture.GetTop(Heropicture.Tiles[0]);
                Heropicture.Tiles[0].Source = new BitmapImage(new Uri("Asset/hero-right.png", UriKind.Relative));

                int xx = Convert.ToInt32(x) / 50;
                int yy = Convert.ToInt32(y) / 50;

                if (x < 500 && (Map.MapLayout[yy, xx] == 0 || Map.MapLayout[yy, xx] == 2))
                {
                    Heropicture.SetPosition(Heropicture.Tiles[0], x, y);
                    Heroguy.x++;

                    for (int i = 0; i < bestiary.Count; i++)
                    {
                        double enemyx = Enemypicture.GetLeft(Enemypicture.Tiles[i]);
                        double enemyy = Enemypicture.GetTop(Enemypicture.Tiles[i]);


                        if (enemyx == x && enemyy == y)
                        {
                            Heropicture.SetPosition(Heropicture.Tiles[0], (x - 50), y);
                            Heroguy.x++;
                        }

                    }
                }

                //for (int i = 0; i < bestiary.Count; i++)
                //{
                //    if (Heroguy.y == bestiary[i].y && Heroguy.x + 1 != bestiary[i].x)
                //    {
                //        Heropicture.SetPosition(Heropicture.Tiles[0], (x - 50), y);
                //        Heroguy.x--;
                //    }
                //}
                

            }


            if (e.Key == Key.Down)
            {

                double x = Heropicture.GetLeft(Heropicture.Tiles[0]);
                double y = Heropicture.GetTop(Heropicture.Tiles[0]) + 50;
                Heropicture.Tiles[0].Source = new BitmapImage(new Uri("Asset/hero-down.png", UriKind.Relative));

                int xx = Convert.ToInt32(x) / 50;
                int yy = Convert.ToInt32(y) / 50;

                if (y < 550 && (Map.MapLayout[yy, xx] == 0 || Map.MapLayout[yy, xx] == 2))
                {
                    Heropicture.SetPosition(Heropicture.Tiles[0], x, y);
                    Heroguy.y++;

                    for (int i = 0; i < bestiary.Count; i++)
                    {
                        double enemyx = Enemypicture.GetLeft(Enemypicture.Tiles[i]);
                        double enemyy = Enemypicture.GetTop(Enemypicture.Tiles[i]);


                        if (enemyx == x && enemyy == y)
                        {
                            Heropicture.SetPosition(Heropicture.Tiles[0], x, (y - 50));
                            Heroguy.x++;
                        }

                    }
                }

            }

            if (e.Key == Key.Up)
            {
                double x = Heropicture.GetLeft(Heropicture.Tiles[0]);
                double y = Heropicture.GetTop(Heropicture.Tiles[0]) - 50;
                Heropicture.Tiles[0].Source = new BitmapImage(new Uri("Asset/hero-up.png", UriKind.Relative));

                int xx = Convert.ToInt32(x) / 50;
                int yy = Convert.ToInt32(y) / 50;

                if (y >= 0 && (Map.MapLayout[yy, xx] == 0 || Map.MapLayout[yy, xx] == 2))
                {
                    Heropicture.SetPosition(Heropicture.Tiles[0], x, y);
                    Heroguy.y--;

                    for (int i = 0; i < bestiary.Count; i++)
                    {
                        double enemyx = Enemypicture.GetLeft(Enemypicture.Tiles[i]);
                        double enemyy = Enemypicture.GetTop(Enemypicture.Tiles[i]);


                        if (enemyx == x && enemyy == y)
                        {
                            Heropicture.SetPosition(Heropicture.Tiles[0], x, (y + 50));
                            Heroguy.x++;
                        }

                    }
                }
            }


        }
    }
}