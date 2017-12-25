using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace Wanderer
{
    class Hero : Character
    {
        
        public Hero()
        {            
            hp = 20;
        }

        public static void Herodrawer(FoxDraw Newhero, Hero Champion)
        {
            Newhero.AddImage("Asset/hero-down.png", Champion.x * 50, Champion.y * 50);
        }



    }
}
