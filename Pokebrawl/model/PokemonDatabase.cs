using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pokebrawl.model.Pokemon;

namespace Pokebrawl.model
{
    public static class PokemonDatabase
    {
        public static Dictionary<string, Pokemon> Data = new()
        {
            ["Bulbizarre"] = new Pokemon
            {
                Nom = "Bulbizarre",
                Niveau = 5,
                PV = 20,
                PVMax = 20,
                ImageFace = "pack://application:,,,/view/image/Pokemon/bulbizarre_face.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon/bulbizarre_dos.png",
                NiveauEvolution = 16,
                Evolution = "Herbizarre",
                Attaques = new List<Attaque>
                {
                    new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5 },
                    new Attaque { Nom = "Fouet Lianes", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 8 }
                },
                LevelUpMoves = new List<LevelUpMove>
                {
                    new LevelUpMove { Level = 7, Move = new Attaque{ Nom = "Vampigraine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 10 } },
                    new LevelUpMove { Level = 13, Move = new Attaque{ Nom = "Tranch'Herbe", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 15 } }
                }
            }
            // Ajoute d'autres pokémons ici...
        };

        public static Pokemon GetData(string nom)
        {
            return Data.ContainsKey(nom) ? Data[nom] : null;
        }

        public static List<Pokemon> GetWildPokemons()
        {
            return new List<Pokemon>
            {
                new Pokemon {
                    Nom = "Rattata", Niveau = 3, PV = 12, PVMax = 12,
                    ImageFace = "pack://application:,,,/view/image/Pokemon/rattata_face.png",
                    ImageDos = "pack://application:,,,/view/image/Pokemon/rattata_dos.png",
                    Attaques = new List<Attaque>
                    {
                        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 6 }
                    }
                }
            };
        }
    }
}
