using DBDemo.Entities;
using DBDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBDemo.Repositories
{
    public class SuperheroRepository
    {
        public SuperheroContext SuperheroContext { get; set; }

        public SuperheroRepository(SuperheroContext superheroContext)
        {
            SuperheroContext = superheroContext;
        }

        public List<Superhero> HeroList()
        {
            List<Superhero> ListOfHeroes = new List<Superhero>();

            foreach (var hero in SuperheroContext.Superheroes)
            {
                ListOfHeroes.Add(hero);
            }

            return ListOfHeroes;
        }
    }
}
