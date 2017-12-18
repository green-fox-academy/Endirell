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
        public static void Mapmaker(FoxDraw Soil, int size)
        {            
            for (int i = 0; i < (50 * size); i += 50)
            {
                for (int j = 0; j < (50 * size); j += 50)
                {
                    Soil.AddImage("Asset/floor.png", i, j);
                }
            }
        }

    }
}
