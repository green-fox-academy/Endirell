﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Combatant Bill = new Combatant();

            Bill.Charcreator();

            Bill.GetChar();

            Console.ReadLine();
        }
    }
}
