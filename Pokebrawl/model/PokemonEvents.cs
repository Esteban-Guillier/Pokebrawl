using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public static class PokemonEvents
    {
        /// <summary>
        /// Quand un Pokémon veut apprendre une 5e capacité, la UI doit demander au joueur laquelle remplacer.
        /// </summary>
        public static Action<Pokemon, Attaque> OnDemandeRemplacementCapacite;
    }
}
