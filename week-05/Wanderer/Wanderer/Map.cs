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
        public static void Mapmaker(FoxDraw Newmap, int size)
        {

            int tilesize = 50;

            for (int i = 0; i < (50 * size); i += 50)
            {
                for (int j = 0; j < (50 * size + 1); j += 50)
                {
                    Newmap.AddImage("Asset/floor.png", i, j);
                }
            }

            Newmap.AddImage("Asset/wall.png", 0, 4 * tilesize);
            Newmap.AddImage("Asset/wall.png", tilesize, 2 * tilesize);
            Newmap.AddImage("Asset/wall.png", tilesize, 4 * tilesize);
            Newmap.AddImage("Asset/wall.png", tilesize, 5 * tilesize);
            Newmap.AddImage("Asset/wall.png", tilesize, 6 * tilesize);
            Newmap.AddImage("Asset/wall.png", tilesize, 8 * tilesize);
            Newmap.AddImage("Asset/wall.png", tilesize, 10 * tilesize);
            Newmap.AddImage("Asset/wall.png", 2 * tilesize, 2 * tilesize);
            Newmap.AddImage("Asset/wall.png", 2 * tilesize, 4 * tilesize);
            Newmap.AddImage("Asset/wall.png", 2 * tilesize, 8 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 0 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 1 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 2 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 4 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 5 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 6 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 8 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 9 * tilesize);
            Newmap.AddImage("Asset/wall.png", 3 * tilesize, 10 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 0 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 1 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 2 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 3 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 4 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 6 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 7 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 9 * tilesize);
            Newmap.AddImage("Asset/wall.png", 5 * tilesize, 10 * tilesize);
            Newmap.AddImage("Asset/wall.png", 6 * tilesize, 4 * tilesize);
            Newmap.AddImage("Asset/wall.png", 6 * tilesize, 6 * tilesize);
            Newmap.AddImage("Asset/wall.png", 6 * tilesize, 7 * tilesize);
            Newmap.AddImage("Asset/wall.png", 6 * tilesize, 9 * tilesize);
            Newmap.AddImage("Asset/wall.png", 7 * tilesize, 1 * tilesize);
            Newmap.AddImage("Asset/wall.png", 7 * tilesize, 2 * tilesize);
            Newmap.AddImage("Asset/wall.png", 7 * tilesize, 4 * tilesize);
            Newmap.AddImage("Asset/wall.png", 8 * tilesize, 1 * tilesize);
            Newmap.AddImage("Asset/wall.png", 8 * tilesize, 2 * tilesize);
            Newmap.AddImage("Asset/wall.png", 8 * tilesize, 4 * tilesize);
            Newmap.AddImage("Asset/wall.png", 8 * tilesize, 5 * tilesize);
            Newmap.AddImage("Asset/wall.png", 8 * tilesize, 6 * tilesize);
            Newmap.AddImage("Asset/wall.png", 8 * tilesize, 7 * tilesize);
            Newmap.AddImage("Asset/wall.png", 8 * tilesize, 8 * tilesize);
            Newmap.AddImage("Asset/wall.png", 8 * tilesize, 9 * tilesize);
        }

    }
}
