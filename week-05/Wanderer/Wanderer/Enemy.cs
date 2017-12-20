using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace Wanderer
{
    class Enemy : Character
    {
        public static Random rnd = new Random();

        public Enemy()
        {
            x = 0;
            y = 0;

        }

        public static void BestiaryBuilder(List<Enemy> enemylist)
        {            
            int howmany = rnd.Next(3, 7);

            enemylist.Add(new Boss());

            for (int i = 0; i < howmany; i++)
            {
                enemylist.Add(new Skeleton());
            }
            
            Enemyplacer(enemylist, enemylist.Count);
            
        }

        public static void Enemyplacer(List<Enemy> monsterlist, int numberofenemies)
        {
            int y = 0;

            int x = 0;

            for (int i = 0; i < numberofenemies; i++)            
            {
                y = rnd.Next(0, 11);

                x = rnd.Next(0, 10);

                if (Map.MapLayout[y, x] == 0)
                {
                    monsterlist[i].y = y;

                    monsterlist[i].x = x;
                }

                else
                {
                    Enemyreplacer(monsterlist[i]);
                }
                               
            }

            for (int i = 0; i < 1000; i++)
            {
                Nosameplace(monsterlist);
            }
           

        }

        public static void Enemyreplacer(Enemy enemy)
        {
            int y = rnd.Next(0, 11);

            int x = rnd.Next(0, 10);

            if (Map.MapLayout[y, x] == 0)
            {
                enemy.y = y;

                enemy.x = x;
            }

            else
            {
                Enemyreplacer(enemy);
            }
            
        }

        public static void Nosameplace(List<Enemy> monsterlist)
        {            
            for (int k = 0; k < monsterlist.Count; k++)
            {
                for (int l = 0; l < monsterlist.Count; l++)
                {
                    if (monsterlist[k].y == monsterlist[l].y && monsterlist[k].x == monsterlist[l].x)
                    {
                        Enemyreplacer(monsterlist[k]);
                        //Nosameplace(monsterlist);
                    }
                }
            }
        }
        
    }
}
