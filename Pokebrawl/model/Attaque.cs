using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Attaque
    {
        public string Nom { get; set; }
        public TypePokemon Type { get; set; }
        public int Puissance { get; set; }
        public int PPMax { get; set; }
        public int PP { get; set; }
        public string Description { get; set; }

        public static System.Collections.Generic.List<Attaque> GetBossAttaques()
        {
            return new System.Collections.Generic.List<Attaque>
            {
                new Attaque { Nom = "Ultralaser", Type = TypePokemon.Normal, Puissance = 15, PP = 5, PPMax = 5, Description = "Attaque très puissante." }
            };
        }
    }
}
