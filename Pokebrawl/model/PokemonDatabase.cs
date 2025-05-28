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
                    new Attaque { Nom = "Charge", PP = 35, PPMax = 35, Power = 5, Type = "Normal" },
                    new Attaque { Nom = "Fouet Lianes", PP = 10, PPMax = 10, Power = 8, Type = "Plante" }
                },
                LevelUpMoves = new List<LevelUpMove>
                {
                    new LevelUpMove { Level = 7, Move = new Attaque{ Nom = "Vampigraine", PP = 10, PPMax = 10, Power = 10, Type = "Plante" } },
                    new LevelUpMove { Level = 13, Move = new Attaque{ Nom = "Tranch'Herbe", PP = 10, PPMax = 10, Power = 15, Type = "Plante" } }
                }
            },
            ["Herbizarre"] = new Pokemon
            {
                Nom = "Herbizarre",
                Niveau = 16,
                PV = 40,
                PVMax = 40,
                ImageFace = "pack://application:,,,/view/image/Pokemon/herbizarre_face.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon/herbizarre_dos.png",
                NiveauEvolution = 32,
                Evolution = "Florizarre",
                Attaques = new List<Attaque>
                {
                    new Attaque { Nom = "Charge", PP = 35, PPMax = 35, Power = 5, Type = "Normal" },
                    new Attaque { Nom = "Fouet Lianes", PP = 15, PPMax = 15, Power = 8, Type = "Plante" }
                },
                LevelUpMoves = new List<LevelUpMove>
                {
                    new LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Canon Graine", PP = 10, PPMax = 10, Power = 20, Type = "Plante" } }
                }
            },
            // Ajoute Carapuce, Salamèche, etc. de la même façon
        };

        public static Pokemon GetData(string nom)
        {
            return Data.ContainsKey(nom) ? Data[nom] : null;
        }

        public static List<Pokemon> GetWildPokemons()
        {
            // Retourne une liste d'exemplaires de pokémons sauvages
            return new List<Pokemon>
            {
                new Pokemon {
                    Nom = "Rattata", Niveau = 3, PV = 12, PVMax = 12,
                    ImageFace = "pack://application:,,,/view/image/Pokemon/rattata_face.png",
                    ImageDos = "pack://application:,,,/view/image/Pokemon/rattata_dos.png",
                    Attaques = new List<Attaque>
                    {
                        new Attaque { Nom = "Charge", PP = 35, PPMax = 35, Power = 6, Type = "Normal" }
                    }
                },
                // Ajoute d'autres pokémons sauvages...
            };
        }
    }
}
