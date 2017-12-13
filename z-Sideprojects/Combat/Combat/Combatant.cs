using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    class Combatant
    {
        public static Random rnd = new Random();

        // 1: very bad, 2: bad, 3: normal, 4: good, 5: very good
        public int strength { get; set; }
        public int speed { get; set; }
        public int dexterity { get; set; }
        public int agility { get; set; }
        public int stamina { get; set; }


        public int damage { get; set; }
        public int initiative { get; set; }
        public int attack { get; set; }
        public int defense { get; set; } 
        public int hp { get; set; }

        public void Charcreator()
        {
            strength = rnd.Next(1, 6);
            speed = rnd.Next(1, 6);
            dexterity = rnd.Next(1, 6);
            agility = rnd.Next(1, 6);
            stamina = rnd.Next(1, 6);

            if ((strength + speed + dexterity + agility + stamina) != 15)
            {
                Charcreator();
            }
            
        }

        public void Attributes()
        {
            damage = 15 + (strength * 5);
            initiative = speed;
            attack = dexterity + 7;
            defense = agility + 17;
            hp = 150 + (stamina * 50);
            
        }

        public void GetChar()
        {
            Console.WriteLine("Strength: " + strength + ", Speed: " + speed + ", Dexterity: " + dexterity + ", Agility: " + agility + ", Stamina: " + stamina);
        }



    }

    
}
