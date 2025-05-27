using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Equipe
    {
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
        public int PointsUtilises => Pokemons.Sum(p => p.CoutEquipe);
        public const int MaxPokemons = 6;
        public const int MaxPoints = 10;
    }
}
