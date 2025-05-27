using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public static class TypeChart
    {
        // Tableau simplifié, à compléter selon le besoin
        public static readonly Dictionary<TypePokemon, Dictionary<TypePokemon, double>> Degats = new()
        {
            { TypePokemon.Feu, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Plante, 2.0}, {TypePokemon.Eau, 0.5}, {TypePokemon.Feu, 0.5}, {TypePokemon.Glace, 2.0}
                }
            },
            { TypePokemon.Eau, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Feu, 2.0}, {TypePokemon.Plante, 0.5}, {TypePokemon.Eau, 0.5}, {TypePokemon.Roche, 2.0}
                }
            },
            // ... Complète pour chaque type selon la table officielle
        };

        public static double GetCoef(TypePokemon attaque, TypePokemon defense)
        {
            if (Degats.ContainsKey(attaque) && Degats[attaque].ContainsKey(defense))
                return Degats[attaque][defense];
            return 1.0;
        }
    }
}
