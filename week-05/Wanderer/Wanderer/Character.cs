using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wanderer
{
    class Character
    {
        public int x;

        public int y;

        public int hp;

        public Character()
        {
            x = 0;
            y = 0;
                        
        }

        public int Fight(Character sufferer)
        {
            sufferer.hp--;
            return sufferer.hp;
        }


    }
}
