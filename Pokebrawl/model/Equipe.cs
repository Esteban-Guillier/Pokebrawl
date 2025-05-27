using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Equipe
    {
        public List<Pokemon> Pokemons { get; set; } = new();
        public int PointsUtilises => Pokemons.Sum(p => p.CoutEquipe);
        public static int MaxPokemons { get; } = 6;
        public static int MaxPoints { get; } = 10;
    }
}
