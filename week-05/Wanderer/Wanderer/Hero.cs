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
        string upimage;
        string downimage;
        string leftimage;
        string rightimage;

        public Hero(FoxDraw Newhero)
        {
            downimage = "Asset/hero-down.png";
            upimage = "Asset/hero-up.png";
            leftimage = "Asset/hero-left.png";
            rightimage = "Asset/hero-right.png";

            Newhero.AddImage(downimage, 0, 0);
        }



    }
}
