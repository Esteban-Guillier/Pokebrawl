using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public enum TypeCombat
    {
        Sauvage,
        Boss
    }

    public class Combat
    {
        public Pokemon PokemonJoueur { get; set; }
        public Pokemon PokemonAdverse { get; set; }
        public Joueur Joueur { get; set; }
        public TypeCombat TypeCombat { get; set; }
        public bool Victoire { get; set; }
    }
}
