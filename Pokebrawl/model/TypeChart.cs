using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public static class TypeChart
    {
        public static readonly Dictionary<TypePokemon, Dictionary<TypePokemon, double>> Degats = new()
        {
            { TypePokemon.Normal, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Roche, 0.5}, {TypePokemon.Spectre, 0}, {TypePokemon.Acier, 0.5}
                }
            },

            { TypePokemon.Feu, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Plante, 2}, {TypePokemon.Glace, 2}, {TypePokemon.Insecte, 2}, {TypePokemon.Acier, 2}, {TypePokemon.Feu, 0.5}, {TypePokemon.Eau, 0.5}, {TypePokemon.Roche, 0.5}, {TypePokemon.Dragon, 0.5}
                }
            },

            { TypePokemon.Eau, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Feu, 2}, {TypePokemon.Sol, 2}, {TypePokemon.Roche, 2}, {TypePokemon.Eau, 0.5}, {TypePokemon.Plante, 0.5}, {TypePokemon.Dragon, 0.5}
                }
            },

            { TypePokemon.Plante, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Eau, 2}, {TypePokemon.Sol, 2}, {TypePokemon.Roche, 2}, {TypePokemon.Feu, 0.5}, {TypePokemon.Plante, 0.5}, {TypePokemon.Poison, 0.5}, {TypePokemon.Vol, 0.5}, {TypePokemon.Insecte, 0.5}, {TypePokemon.Dragon, 0.5}, {TypePokemon.Acier, 0.5}
                }
            },

            { TypePokemon.Electrik, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Eau, 2}, {TypePokemon.Vol, 2}, {TypePokemon.Electrik, 0.5}, {TypePokemon.Plante, 0.5}, {TypePokemon.Dragon, 0.5}, {TypePokemon.Sol, 0}
                }
            },

            { TypePokemon.Glace, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Plante, 2}, {TypePokemon.Sol, 2}, {TypePokemon.Vol, 2}, {TypePokemon.Dragon, 2}, {TypePokemon.Feu, 0.5}, {TypePokemon.Eau, 0.5}, {TypePokemon.Glace, 0.5}, {TypePokemon.Acier, 0.5}
                }
            },

            { TypePokemon.Combat, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Normal, 2}, {TypePokemon.Roche, 2}, {TypePokemon.Acier, 2}, {TypePokemon.Glace, 2}, {TypePokemon.Ténèbres, 2}, {TypePokemon.Poison, 0.5}, {TypePokemon.Vol, 0.5}, {TypePokemon.Psy, 0.5}, {TypePokemon.Insecte, 0.5}, {TypePokemon.Fée, 0.5}, {TypePokemon.Spectre, 0}
                 }
            },

            { TypePokemon.Poison, new Dictionary<TypePokemon, double>
                {
            {TypePokemon.Plante, 2}, {TypePokemon.Fée, 2}, {TypePokemon.Poison, 0.5}, {TypePokemon.Sol, 0.5}, {TypePokemon.Roche, 0.5}, {TypePokemon.Spectre, 0.5}, {TypePokemon.Acier, 0}
                }
            },

            { TypePokemon.Sol, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Feu, 2}, {TypePokemon.Electrik, 2}, {TypePokemon.Poison, 2}, {TypePokemon.Roche, 2}, {TypePokemon.Acier, 2}, {TypePokemon.Plante, 0.5}, {TypePokemon.Insecte, 0.5}, {TypePokemon.Vol, 0}
                }
            },

            { TypePokemon.Vol, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Plante, 2}, {TypePokemon.Combat, 2}, {TypePokemon.Insecte, 2}, {TypePokemon.Electrik, 0.5}, {TypePokemon.Roche, 0.5}, {TypePokemon.Acier, 0.5}
                }
            },

            { TypePokemon.Psy, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Combat, 2}, {TypePokemon.Poison, 2}, {TypePokemon.Psy, 0.5}, {TypePokemon.Acier, 0.5}, {TypePokemon.Ténèbres, 0}
                }
            },

            { TypePokemon.Insecte, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Plante, 2}, {TypePokemon.Psy, 2}, {TypePokemon.Ténèbres, 2},{TypePokemon.Feu, 0.5}, {TypePokemon.Combat, 0.5}, {TypePokemon.Poison, 0.5},{TypePokemon.Vol, 0.5}, {TypePokemon.Spectre, 0.5}, {TypePokemon.Acier, 0.5}, {TypePokemon.Fée, 0.5}
                }
            },

            { TypePokemon.Roche, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Feu, 2}, {TypePokemon.Glace, 2}, {TypePokemon.Vol, 2}, {TypePokemon.Insecte, 2}, {TypePokemon.Combat, 0.5}, {TypePokemon.Sol, 0.5}, {TypePokemon.Acier, 0.5}
                }
            },

            { TypePokemon.Spectre, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Psy, 2}, {TypePokemon.Spectre, 2}, {TypePokemon.Ténèbres, 0.5}, {TypePokemon.Normal, 0}, {TypePokemon.Combat, 0}
                }
            },

            { TypePokemon.Dragon, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Dragon, 2}, {TypePokemon.Acier, 0.5}, {TypePokemon.Fée, 0}
                }
            },

            { TypePokemon.Ténèbres, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Psy, 2}, {TypePokemon.Spectre, 2}, {TypePokemon.Combat, 0.5}, {TypePokemon.Ténèbres, 0.5}, {TypePokemon.Fée, 0.5}
                }
            },

            { TypePokemon.Acier, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Glace, 2}, {TypePokemon.Roche, 2}, {TypePokemon.Fée, 2}, {TypePokemon.Feu, 0.5}, {TypePokemon.Eau, 0.5}, {TypePokemon.Electrik, 0.5}, {TypePokemon.Acier, 0.5}
                }
            },

            { TypePokemon.Fée, new Dictionary<TypePokemon, double>
                {
                    {TypePokemon.Combat, 2}, {TypePokemon.Dragon, 2}, {TypePokemon.Ténèbres, 2}, {TypePokemon.Feu, 0.5}, {TypePokemon.Poison, 0.5}, {TypePokemon.Acier, 0.5}
                }
            }
        };

        public static double GetCoef(TypePokemon attaque, TypePokemon defense)
        {
            if (Degats.ContainsKey(attaque) && Degats[attaque].ContainsKey(defense))
                return Degats[attaque][defense];
            return 1.0;
        }
    }
}
