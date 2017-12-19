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

        public static readonly int[,] MapLayout = new int[,] {  {0, 0, 0, 1, 0, 1, 0, 0, 0, 0},
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
