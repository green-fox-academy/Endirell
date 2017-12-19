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

        public static readonly int[,] MapLayout = new int[11,10] {  {0, 0, 0, 1, 0, 1, 0, 0, 0, 0},
                                                                    {0, 0, 0, 1, 0, 1, 0, 1, 1, 0},
                                                                    {0, 1, 1, 1, 0, 1, 0, 1, 1, 0},
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







        public static void Skeletonplacer(FoxDraw Newenemy)
        {
            int x = 0;

            int y = 0;

            int howmany = rnd.Next(3, 7);

            for (int i = 0; i < howmany; i++)
            {
                Newenemy.AddImage("Asset/skeleton.png", 0, 0);

                Enemyreplacer(x, y, Newenemy, i);
            }
        }

        public static void Bossplacer(FoxDraw Newenemy)
        {
            int x = 0;

            int y = 0;

            Newenemy.AddImage("Asset/boss.png", 0, 0);

            Enemyreplacer(x, y, Newenemy, 0);
                        
        }

        public static void Enemyreplacer(int z, int w, FoxDraw Newmap, int u)
        {
            z = rnd.Next(0, 11);

            w = rnd.Next(0, 10);

            if (Map.MapLayout[z, w] == 0)
            {
                Newmap.SetPosition(Newmap.Tiles[u], w * 50, z * 50);
            }

            else
            {
                Enemyreplacer(z, w, Newmap, u);
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
