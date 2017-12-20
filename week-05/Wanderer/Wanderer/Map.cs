using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace Wanderer
{
    class Map
    {
        public static Random rnd = new Random();

        public static readonly int[,] MapLayout = new int[11,10] {  {2, 2, 2, 1, 0, 1, 0, 0, 0, 0},
                                                                    {2, 2, 2, 1, 0, 1, 0, 1, 1, 0},
                                                                    {2, 1, 1, 1, 0, 1, 0, 1, 1, 0},
                                                                    {0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                                                                    {1, 1, 1, 1, 0, 1, 1, 1, 1, 0},
                                                                    {0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
                                                                    {0, 1, 0, 1, 0, 1, 1, 0, 1, 0},
                                                                    {0, 0, 0, 0, 0, 1, 1, 0, 1, 0},
                                                                    {0, 1, 1, 1, 0, 0, 0, 0, 1, 0},
                                                                    {0, 0, 0, 1, 0, 1, 1, 0, 1, 0},
                                                                    {0, 1, 0, 1, 0, 1, 0, 0, 0, 0}};

        //public static readonly int[,] MapLayout = new int[y, x]   { {0, 0, 0, 1, 0, 1, 0, 0, 0, 0},
        //                                                            {0, 0, 0, 1, 0, 1, 0, 1, 1, 0},
        //                                                            {0, 1, 1, 1, 0, 1, 0, 1, 1, 0},
        //                                                            {0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
        //                                                            {1, 1, 1, 1, 0, 1, 1, 1, 1, 0},
        //                                                            {0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
        //                                                            {0, 1, 0, 1, 0, 1, 1, 0, 1, 0},
        //                                                            {0, 0, 0, 0, 0, 1, 1, 0, 1, 0},
        //                                                            {0, 1, 1, 1, 0, 0, 0, 0, 1, 0},
        //                                                            {0, 0, 0, 1, 0, 1, 1, 0, 1, 0},
        //                                                            {0, 1, 0, 1, 0, 1, 0, 0, 0, 0}};


        //Heropicture.AddImage("Asset/hero-down.png", Heroguy.x, Heroguy.y);


        public static void Enemydrawer(FoxDraw Newenemy, List<Enemy> enemylist)
        {
            Newenemy.AddImage("Asset/boss.png", enemylist[0].x * 50, enemylist[0].y * 50);

            for (int i = 1; i < enemylist.Count; i++)
            {
                Newenemy.AddImage("Asset/skeleton.png", enemylist[i].x * 50, enemylist[i].y * 50);
            }
            
        }
        
        public static void Mapmaker(FoxDraw Newmap, int size)
        {

            int tilesize = 50;
            

            for (int i = 0; i < size + 1; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Map.MapLayout[i, j] == 1)
                    {
                        Newmap.AddImage("Asset/wall.png", j * tilesize, i * tilesize);
                    }

                    else
                    {
                        Newmap.AddImage("Asset/floor.png", j * tilesize, i * tilesize);
                    }                    
                }
            }
            
        }

    }
}
