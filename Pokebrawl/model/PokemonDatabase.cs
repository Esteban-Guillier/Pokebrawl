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
                Numero = 1,
                Nom = "Bulbizarre",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 20,
                PVMax = 20,
                Attaque = 8,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/001.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/001.png",
                Description = "Un Pokémon de type Plante/Poison.",
                Exp = 0,
                ExpDonnee = 64,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 16,
                Evolution = "Herbizarre",
                Attaques = new List<Attaque>
                {
                    new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
                    new Attaque { Nom = "Fouet Lianes", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 8, Description = "Attaque de type Plante." }
                },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
                {
                    new Pokemon.LevelUpMove { Level = 7, Move = new Attaque{ Nom = "Vampigraine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 10, Description = "Vole des PV à l'adversaire." } },
                    new Pokemon.LevelUpMove { Level = 13, Move = new Attaque{ Nom = "Tranch'Herbe", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 15, Description = "Coup critique augmenté." } }
                }
            },
            ["Herbizarre"] = new Pokemon
            {
                Numero = 2,
                Nom = "Herbizarre",
                Niveau = 16,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 30,
                PVMax = 30,
                Attaque = 12,
                Defense = 12,
                AttaqueSpe = 15,
                DefenseSpe = 15,
                Vitesse = 10,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/002.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/002.png",
                Description = "Évolution de Bulbizarre.",
                Exp = 0,
                ExpDonnee = 142,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 32,
                Evolution = "Florizarre",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Fouet Lianes", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Plante améliorée." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Canon Graine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 20, Description = "Décharge de graines puissantes." } }
    }
            },
            ["Florizarre"] = new Pokemon
            {
                Numero = 3,
                Nom = "Florizarre",
                Niveau = 32,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 40,
                PVMax = 40,
                Attaque = 16,
                Defense = 16,
                AttaqueSpe = 20,
                DefenseSpe = 20,
                Vitesse = 14,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/003.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/003.png",
                Description = "Évolution finale de Bulbizarre.",
                Exp = 0,
                ExpDonnee = 236,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Lance-Soleil", Type = TypePokemon.Plante, PP = 5, PPMax = 5, Puissance = 30, Description = "Attaque Plante très puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Tempête Verte", Type = TypePokemon.Plante, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de Plante." } }
    }
            },
            ["Salamèche"] = new Pokemon
            {
                Numero = 4,
                Nom = "Salamèche",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 18,
                PVMax = 18,
                Attaque = 10,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 8,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/004.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/004.png",
                Description = "Un Pokémon de type Feu.",
                Exp = 0,
                ExpDonnee = 62,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 16,
                Evolution = "Reptincel",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque physique rapide." },
        new Attaque { Nom = "Flammèche", Type = TypePokemon.Feu, PP = 25, PPMax = 25, Puissance = 10, Description = "Petite attaque de feu." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Flamme", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de feu améliorée." } }
    }
            },
            ["Reptincel"] = new Pokemon
            {
                Numero = 5,
                Nom = "Reptincel",
                Niveau = 16,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 28,
                PVMax = 28,
                Attaque = 14,
                Defense = 12,
                AttaqueSpe = 15,
                DefenseSpe = 12,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/005.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/005.png",
                Description = "Évolution de Salamèche.",
                Exp = 0,
                ExpDonnee = 142,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 36,
                Evolution = "Dracaufeu",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque physique rapide." },
        new Attaque { Nom = "Flammèche", Type = TypePokemon.Feu, PP = 25, PPMax = 25, Puissance = 12, Description = "Attaque de feu plus puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 24, Move = new Attaque{ Nom = "Lance-Flammes", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque de feu très puissante." } }
    }
            },
            ["Dracaufeu"] = new Pokemon
            {
                Numero = 6,
                Nom = "Dracaufeu",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Feu, TypePokemon.Vol },
                PV = 40,
                PVMax = 40,
                Attaque = 18,
                Defense = 15,
                AttaqueSpe = 22,
                DefenseSpe = 15,
                Vitesse = 17,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/006.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/006.png",
                Description = "Évolution finale de Salamèche.",
                Exp = 0,
                ExpDonnee = 240,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Lance-Flammes", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque de feu très puissante." },
        new Attaque { Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 18, Description = "Attaque de type Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 46, Move = new Attaque{ Nom = "Déflagration", Type = TypePokemon.Feu, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de feu." } }
    }
            },
            ["Carapuce"] = new Pokemon
            {
                Numero = 7,
                Nom = "Carapuce",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 21,
                PVMax = 21,
                Attaque = 7,
                Defense = 10,
                AttaqueSpe = 8,
                DefenseSpe = 10,
                Vitesse = 6,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/007.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/007.png",
                Description = "Un Pokémon de type Eau.",
                Exp = 0,
                ExpDonnee = 63,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 16,
                Evolution = "Carabaffe",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Ecume", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 12, Description = "Attaque de type Eau améliorée." } }
    }
            },
            ["Carabaffe"] = new Pokemon
            {
                Numero = 8,
                Nom = "Carabaffe",
                Niveau = 16,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 31,
                PVMax = 31,
                Attaque = 10,
                Defense = 14,
                AttaqueSpe = 10,
                DefenseSpe = 14,
                Vitesse = 9,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/008.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/008.png",
                Description = "Évolution de Carapuce.",
                Exp = 0,
                ExpDonnee = 142,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 36,
                Evolution = "Tortank",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 12, Description = "Attaque de type Eau améliorée." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 24, Move = new Attaque{ Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." } }
    }
            },
            ["Tortank"] = new Pokemon
            {
                Numero = 9,
                Nom = "Tortank",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 41,
                PVMax = 41,
                Attaque = 13,
                Defense = 18,
                AttaqueSpe = 15,
                DefenseSpe = 18,
                Vitesse = 11,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/009.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/009.png",
                Description = "Évolution finale de Carapuce.",
                Exp = 0,
                ExpDonnee = 239,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." },
        new Attaque { Nom = "Morsure", Type = TypePokemon.Ténèbres, PP = 25, PPMax = 25, Puissance = 18, Description = "Attaque de type Ténèbres." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 48, Move = new Attaque{ Nom = "Coud'Krâne", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque physique très puissante." } }
    }
            },
            ["Chenipan"] = new Pokemon
            {
                Numero = 10,
                Nom = "Chenipan",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Insecte },
                PV = 12,
                PVMax = 12,
                Attaque = 5,
                Defense = 4,
                AttaqueSpe = 4,
                DefenseSpe = 4,
                Vitesse = 6,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/010.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/010.png",
                Description = "Un Pokémon de type Insecte.",
                Exp = 0,
                ExpDonnee = 39,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 7,
                Evolution = "Chrysacier",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 7, Move = new Attaque{ Nom = "Sécrétion", Type = TypePokemon.Insecte, PP = 40, PPMax = 40, Puissance = 0, Description = "Baisse la vitesse de l'adversaire." } }
    }
            },
            ["Chrysacier"] = new Pokemon
            {
                Numero = 11,
                Nom = "Chrysacier",
                Niveau = 7,
                Types = new List<TypePokemon> { TypePokemon.Insecte },
                PV = 16,
                PVMax = 16,
                Attaque = 5,
                Defense = 8,
                AttaqueSpe = 5,
                DefenseSpe = 8,
                Vitesse = 4,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/011.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/011.png",
                Description = "Évolution de Chenipan.",
                Exp = 0,
                ExpDonnee = 72,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 10,
                Evolution = "Papilusion",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Armure", Type = TypePokemon.Normal, PP = 40, PPMax = 40, Puissance = 0, Description = "Augmente la défense." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." } }
    }
            },
            ["Papilusion"] = new Pokemon
            {
                Numero = 12,
                Nom = "Papilusion",
                Niveau = 10,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Vol },
                PV = 22,
                PVMax = 22,
                Attaque = 8,
                Defense = 8,
                AttaqueSpe = 14,
                DefenseSpe = 10,
                Vitesse = 12,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/012.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/012.png",
                Description = "Évolution finale de Chenipan.",
                Exp = 0,
                ExpDonnee = 178,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Poudre Dodo", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 0, Description = "Endort l’adversaire." },
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Vent Argenté", Type = TypePokemon.Insecte, PP = 5, PPMax = 5, Puissance = 15, Description = "Attaque Insecte spéciale." } }
    }
            },
            ["Aspicot"] = new Pokemon
            {
                Numero = 13,
                Nom = "Aspicot",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Poison },
                PV = 12,
                PVMax = 12,
                Attaque = 5,
                Defense = 4,
                AttaqueSpe = 4,
                DefenseSpe = 4,
                Vitesse = 6,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/013.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/013.png",
                Description = "Un Pokémon de type Insecte/Poison.",
                Exp = 0,
                ExpDonnee = 39,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 7,
                Evolution = "Coconfort",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Picpic", Type = TypePokemon.Insecte, PP = 35, PPMax = 35, Puissance = 5, Description = "Attaque de type Insecte." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 7, Move = new Attaque{ Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Poison." } }
    }
            },
            ["Coconfort"] = new Pokemon
            {
                Numero = 14,
                Nom = "Coconfort",
                Niveau = 7,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Poison },
                PV = 16,
                PVMax = 16,
                Attaque = 5,
                Defense = 8,
                AttaqueSpe = 5,
                DefenseSpe = 8,
                Vitesse = 4,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/014.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/014.png",
                Description = "Évolution de Aspicot.",
                Exp = 0,
                ExpDonnee = 72,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 10,
                Evolution = "Dardargnan",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Armure", Type = TypePokemon.Normal, PP = 40, PPMax = 40, Puissance = 0, Description = "Augmente la défense." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Picpic", Type = TypePokemon.Insecte, PP = 35, PPMax = 35, Puissance = 5, Description = "Attaque de type Insecte." } }
    }
            },
            ["Dardargnan"] = new Pokemon
            {
                Numero = 15,
                Nom = "Dardargnan",
                Niveau = 10,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Poison },
                PV = 22,
                PVMax = 22,
                Attaque = 13,
                Defense = 8,
                AttaqueSpe = 8,
                DefenseSpe = 8,
                Vitesse = 15,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/015.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/015.png",
                Description = "Évolution finale de Aspicot.",
                Exp = 0,
                ExpDonnee = 178,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Dard-Nuée", Type = TypePokemon.Insecte, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque de type Insecte." },
        new Attaque { Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de type Poison." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Direct Toxik", Type = TypePokemon.Poison, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque ultime de type Poison." } }
    }
            },
            ["Roucool"] = new Pokemon
            {
                Numero = 16,
                Nom = "Roucool",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Normal, TypePokemon.Vol },
                PV = 15,
                PVMax = 15,
                Attaque = 7,
                Defense = 7,
                AttaqueSpe = 6,
                DefenseSpe = 6,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/016.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/016.png",
                Description = "Un Pokémon de type Normal/Vol.",
                Exp = 0,
                ExpDonnee = 50,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 18,
                Evolution = "Rattatac",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Tornade", Type = TypePokemon.Vol, PP = 35, PPMax = 35, Puissance = 7, Description = "Attaque de type Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 12, Move = new Attaque{ Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque de type Vol améliorée." } }
    }
            },

            ["Roucoups"] = new Pokemon
            {
                Numero = 17,
                Nom = "Roucoups",
                Niveau = 18,
                Types = new List<TypePokemon> { TypePokemon.Normal, TypePokemon.Vol },
                PV = 25,
                PVMax = 25,
                Attaque = 12,
                Defense = 11,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/017.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/017.png",
                Description = "Évolution de Roucool.",
                Exp = 0,
                ExpDonnee = 122,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 36,
                Evolution = "Roucarnage",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Tornade", Type = TypePokemon.Vol, PP = 35, PPMax = 35, Puissance = 10, Description = "Attaque Vol de base." },
        new Attaque { Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 25, PPMax = 25, Puissance = 15, Description = "Attaque physique Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 27, Move = new Attaque{ Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque rapide." } }
    }
            },
            ["Roucarnage"] = new Pokemon
            {
                Numero = 18,
                Nom = "Roucarnage",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Normal, TypePokemon.Vol },
                PV = 38,
                PVMax = 38,
                Attaque = 18,
                Defense = 15,
                AttaqueSpe = 14,
                DefenseSpe = 13,
                Vitesse = 19,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/018.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/018.png",
                Description = "Évolution finale de Roucool.",
                Exp = 0,
                ExpDonnee = 211,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 25, PPMax = 25, Puissance = 20, Description = "Attaque physique Vol." },
        new Attaque { Nom = "Tornade", Type = TypePokemon.Vol, PP = 35, PPMax = 35, Puissance = 12, Description = "Attaque Vol de base." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 45, Move = new Attaque{ Nom = "Aéropique", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 25, Description = "Attaque Vol puissante et précise." } }
    }
            },
            ["Rattata"] = new Pokemon
            {
                Numero = 19,
                Nom = "Rattata",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 12,
                PVMax = 12,
                Attaque = 8,
                Defense = 6,
                AttaqueSpe = 6,
                DefenseSpe = 6,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/019.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/019.png",
                Description = "Un Pokémon de type Normal.",
                Exp = 0,
                ExpDonnee = 51,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 20,
                Evolution = "Rattatac",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Morsure", Type = TypePokemon.Ténèbres, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Ténèbres." } }
    }
            },
            ["Rattatac"] = new Pokemon
            {
                Numero = 20,
                Nom = "Rattatac",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 22,
                PVMax = 22,
                Attaque = 12,
                Defense = 10,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 16,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/020.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/020.png",
                Description = "Évolution de Rattata.",
                Exp = 0,
                ExpDonnee = 145,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Morsure", Type = TypePokemon.Ténèbres, PP = 25, PPMax = 25, Puissance = 15, Description = "Attaque de type Ténèbres." },
        new Attaque { Nom = "Coup D'Boule", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque physique puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Damoclès", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque physique très puissante." } }
    }
            },
            ["Piafabec"] = new Pokemon
            {
                Numero = 21,
                Nom = "Piafabec",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Normal, TypePokemon.Vol },
                PV = 14,
                PVMax = 14,
                Attaque = 9,
                Defense = 7,
                AttaqueSpe = 6,
                DefenseSpe = 6,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/021.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/021.png",
                Description = "Un Pokémon de type Normal/Vol.",
                Exp = 0,
                ExpDonnee = 52,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 20,
                Evolution = "Rapasdepic",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Picpic", Type = TypePokemon.Vol, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque de type Vol." },
        new Attaque { Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque de type Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." } }
    }
            },
            ["Rapasdepic"] = new Pokemon
            {
                Numero = 22,
                Nom = "Rapasdepic",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal, TypePokemon.Vol },
                PV = 28,
                PVMax = 28,
                Attaque = 15,
                Defense = 10,
                AttaqueSpe = 13,
                DefenseSpe = 10,
                Vitesse = 14,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/022.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/022.png",
                Description = "Évolution de Piafabec.",
                Exp = 0,
                ExpDonnee = 155,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Bec Vrille", Type = TypePokemon.Vol, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque de type Vol puissante." },
        new Attaque { Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque de type Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Frénésie", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 18, Description = "Attaque physique continue." } }
    }
            },
            ["Abo"] = new Pokemon
            {
                Numero = 23,
                Nom = "Abo",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 13,
                PVMax = 13,
                Attaque = 8,
                Defense = 7,
                AttaqueSpe = 7,
                DefenseSpe = 7,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/023.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/023.png",
                Description = "Un Pokémon de type Poison.",
                Exp = 0,
                ExpDonnee = 58,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 22,
                Evolution = "Arbok",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Ligotage", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 6, Description = "Attaque physique continue." },
        new Attaque { Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Poison." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 12, Move = new Attaque{ Nom = "Jet de Poison", Type = TypePokemon.Poison, PP = 20, PPMax = 20, Puissance = 12, Description = "Projette du poison." } }
    }
            },
            ["Arbok"] = new Pokemon
            {
                Numero = 24,
                Nom = "Arbok",
                Niveau = 22,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 28,
                PVMax = 28,
                Attaque = 14,
                Defense = 11,
                AttaqueSpe = 11,
                DefenseSpe = 11,
                Vitesse = 14,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/024.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/024.png",
                Description = "Évolution de Abo.",
                Exp = 0,
                ExpDonnee = 153,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Morsure", Type = TypePokemon.Ténèbres, PP = 25, PPMax = 25, Puissance = 15, Description = "Attaque de type Ténèbres." },
        new Attaque { Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de type Poison." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Direct Toxik", Type = TypePokemon.Poison, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Poison très puissante." } }
    }
            },
            ["Pikachu"] = new Pokemon
            {
                Numero = 25,
                Nom = "Pikachu",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Electrik },
                PV = 16,
                PVMax = 16,
                Attaque = 9,
                Defense = 7,
                AttaqueSpe = 10,
                DefenseSpe = 8,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/025.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/025.png",
                Description = "Un Pokémon de type Electrik.",
                Exp = 0,
                ExpDonnee = 112,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Raichu",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Eclair", Type = TypePokemon.Electrik, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque de type Electrik." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 8, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Cage-Eclair", Type = TypePokemon.Electrik, PP = 20, PPMax = 20, Puissance = 0, Description = "Paralyse l’adversaire." } }
    }
            },
            ["Raichu"] = new Pokemon
            {
                Numero = 26,
                Nom = "Raichu",
                Niveau = 25,
                Types = new List<TypePokemon> { TypePokemon.Electrik },
                PV = 32,
                PVMax = 32,
                Attaque = 15,
                Defense = 12,
                AttaqueSpe = 18,
                DefenseSpe = 14,
                Vitesse = 18,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/026.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/026.png",
                Description = "Évolution de Pikachu.",
                Exp = 0,
                ExpDonnee = 218,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Fatal-Foudre", Type = TypePokemon.Electrik, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque Electrik très puissante." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Tonnerre", Type = TypePokemon.Electrik, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque Electrik puissante." } }
    }
            },
            ["Sabelette"] = new Pokemon
            {
                Numero = 27,
                Nom = "Sabelette",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Sol },
                PV = 16,
                PVMax = 16,
                Attaque = 8,
                Defense = 10,
                AttaqueSpe = 6,
                DefenseSpe = 8,
                Vitesse = 8,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/027.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/027.png",
                Description = "Un Pokémon de type Sol.",
                Exp = 0,
                ExpDonnee = 60,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 22,
                Evolution = "Sablaireau",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque physique rapide." },
        new Attaque { Nom = "Jet de Sable", Type = TypePokemon.Sol, PP = 15, PPMax = 15, Puissance = 0, Description = "Baisse la précision de l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 14, Move = new Attaque{ Nom = "Tunnel", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Sol puissante." } }
    }
            },
            ["Sablaireau"] = new Pokemon
            {
                Numero = 28,
                Nom = "Sablaireau",
                Niveau = 22,
                Types = new List<TypePokemon> { TypePokemon.Sol },
                PV = 32,
                PVMax = 32,
                Attaque = 15,
                Defense = 18,
                AttaqueSpe = 10,
                DefenseSpe = 14,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/028.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/028.png",
                Description = "Évolution de Sabelette.",
                Exp = 0,
                ExpDonnee = 158,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Tunnel", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 18, Description = "Attaque Sol puissante." },
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 10, Description = "Attaque physique rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Coup d'Boule", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque puissante." } }
    }
            },
            ["Nidoran♀"] = new Pokemon
            {
                Numero = 29,
                Nom = "Nidoran♀",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 14,
                PVMax = 14,
                Attaque = 8,
                Defense = 8,
                AttaqueSpe = 8,
                DefenseSpe = 8,
                Vitesse = 8,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/029.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/029.png",
                Description = "Un Pokémon de type Poison.",
                Exp = 0,
                ExpDonnee = 55,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 16,
                Evolution = "Nidorina",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Attaque physique rapide." },
        new Attaque { Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Poison." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 12, Move = new Attaque{ Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." } }
    }
            },
            ["Nidorina"] = new Pokemon
            {
                Numero = 30,
                Nom = "Nidorina",
                Niveau = 16,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 28,
                PVMax = 28,
                Attaque = 14,
                Defense = 12,
                AttaqueSpe = 12,
                DefenseSpe = 12,
                Vitesse = 12,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/030.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/030.png",
                Description = "Évolution de Nidoran♀.",
                Exp = 0,
                ExpDonnee = 128,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Nidoqueen",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 10, Description = "Attaque physique rapide." },
        new Attaque { Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 12, Description = "Attaque de type Poison." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Coup d'Boule", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque puissante." } }
    }
            },
            ["Nidoqueen"] = new Pokemon
            {
                Numero = 31,
                Nom = "Nidoqueen",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Poison, TypePokemon.Sol },
                PV = 38,
                PVMax = 38,
                Attaque = 20,
                Defense = 16,
                AttaqueSpe = 15,
                DefenseSpe = 15,
                Vitesse = 13,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/031.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/031.png",
                Description = "Évolution finale de Nidoran♀.",
                Exp = 0,
                ExpDonnee = 227,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Mégacorne", Type = TypePokemon.Insecte, PP = 10, PPMax = 10, Puissance = 25, Description = "Puissante attaque Insecte." },
        new Attaque { Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Giga Impact", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime." } }
    }
            },
            ["Nidoran♂"] = new Pokemon
            {
                Numero = 32,
                Nom = "Nidoran♂",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 14,
                PVMax = 14,
                Attaque = 9,
                Defense = 7,
                AttaqueSpe = 8,
                DefenseSpe = 7,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/032.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/032.png",
                Description = "Un Pokémon de type Poison.",
                Exp = 0,
                ExpDonnee = 55,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 16,
                Evolution = "Nidorino",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Picpic", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque de type Poison." },
        new Attaque { Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 12, Move = new Attaque{ Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Poison." } }
    }
            },
            ["Nidorino"] = new Pokemon
            {
                Numero = 33,
                Nom = "Nidorino",
                Niveau = 16,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 28,
                PVMax = 28,
                Attaque = 14,
                Defense = 11,
                AttaqueSpe = 12,
                DefenseSpe = 12,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/033.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/033.png",
                Description = "Évolution de Nidoran♂.",
                Exp = 0,
                ExpDonnee = 128,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Nidoking",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Picpic", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 10, Description = "Attaque de type Poison." },
        new Attaque { Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Coup d'Boule", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque puissante." } }
    }
            },
            ["Nidoking"] = new Pokemon
            {
                Numero = 34,
                Nom = "Nidoking",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Poison, TypePokemon.Sol },
                PV = 38,
                PVMax = 38,
                Attaque = 20,
                Defense = 16,
                AttaqueSpe = 15,
                DefenseSpe = 15,
                Vitesse = 13,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/034.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/034.png",
                Description = "Évolution finale de Nidoran♂.",
                Exp = 0,
                ExpDonnee = 227,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Mégacorne", Type = TypePokemon.Insecte, PP = 10, PPMax = 10, Puissance = 25, Description = "Puissante attaque Insecte." },
        new Attaque { Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Giga Impact", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime." } }
    }
            },
            ["Mélofée"] = new Pokemon
            {
                Numero = 35,
                Nom = "Mélofée",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Fée },
                PV = 18,
                PVMax = 18,
                Attaque = 7,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/035.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/035.png",
                Description = "Un Pokémon de type Fée.",
                Exp = 0,
                ExpDonnee = 113,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Mélodelfe",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Ecras'Face", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Attaque physique basique." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 8, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Berceuse", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 0, Description = "Endort l’adversaire." } }
    }
            },
            ["Mélodelfe"] = new Pokemon
            {
                Numero = 36,
                Nom = "Mélodelfe",
                Niveau = 15,
                Types = new List<TypePokemon> { TypePokemon.Fée },
                PV = 28,
                PVMax = 28,
                Attaque = 12,
                Defense = 12,
                AttaqueSpe = 15,
                DefenseSpe = 15,
                Vitesse = 12,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/036.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/036.png",
                Description = "Évolution de Mélofée.",
                Exp = 0,
                ExpDonnee = 217,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Météores", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Normal qui ne rate jamais." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Pouvoir Lunaire", Type = TypePokemon.Fée, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque Fée puissante." } }
    }
            },
            ["Goupix"] = new Pokemon
            {
                Numero = 37,
                Nom = "Goupix",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 15,
                PVMax = 15,
                Attaque = 7,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 8,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/037.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/037.png",
                Description = "Un Pokémon de type Feu.",
                Exp = 0,
                ExpDonnee = 60,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Feunard",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Flammèche", Type = TypePokemon.Feu, PP = 25, PPMax = 25, Puissance = 10, Description = "Petite attaque de feu." },
        new Attaque { Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 12, Move = new Attaque{ Nom = "Danseflamme", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de feu continue." } }
    }
            },
            ["Feunard"] = new Pokemon
            {
                Numero = 38,
                Nom = "Feunard",
                Niveau = 15,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 28,
                PVMax = 28,
                Attaque = 14,
                Defense = 13,
                AttaqueSpe = 16,
                DefenseSpe = 15,
                Vitesse = 16,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/038.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/038.png",
                Description = "Évolution de Goupix.",
                Exp = 0,
                ExpDonnee = 177,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Lance-Flammes", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque de feu très puissante." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Déflagration", Type = TypePokemon.Feu, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de feu." } }
    }
            },
            ["Rondoudou"] = new Pokemon
            {
                Numero = 39,
                Nom = "Rondoudou",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Fée, TypePokemon.Normal },
                PV = 22,
                PVMax = 22,
                Attaque = 6,
                Defense = 5,
                AttaqueSpe = 10,
                DefenseSpe = 6,
                Vitesse = 5,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/039.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/039.png",
                Description = "Un Pokémon de type Fée/Normal.",
                Exp = 0,
                ExpDonnee = 95,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Grodoudou",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Ecras'Face", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Attaque physique basique." },
        new Attaque { Nom = "Berceuse", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 0, Description = "Endort l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Roulade", Type = TypePokemon.Roche, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque de type Roche." } }
    }
            },
            ["Grodoudou"] = new Pokemon
            {
                Numero = 40,
                Nom = "Grodoudou",
                Niveau = 15,
                Types = new List<TypePokemon> { TypePokemon.Fée, TypePokemon.Normal },
                PV = 42,
                PVMax = 42,
                Attaque = 12,
                Defense = 10,
                AttaqueSpe = 18,
                DefenseSpe = 12,
                Vitesse = 12,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/040.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/040.png",
                Description = "Évolution de Rondoudou.",
                Exp = 0,
                ExpDonnee = 196,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Roulade", Type = TypePokemon.Roche, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque de type Roche." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Bomb'Beurk", Type = TypePokemon.Poison, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Poison puissante." } }
    }
            },
            ["Nosferapti"] = new Pokemon
            {
                Numero = 41,
                Nom = "Nosferapti",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Poison, TypePokemon.Vol },
                PV = 14,
                PVMax = 14,
                Attaque = 8,
                Defense = 7,
                AttaqueSpe = 8,
                DefenseSpe = 7,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/041.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/041.png",
                Description = "Un Pokémon de type Poison/Vol.",
                Exp = 0,
                ExpDonnee = 49,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 22,
                Evolution = "Nosferalto",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Ultrason", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 0, Description = "Rend confus l’adversaire." },
        new Attaque { Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque de type Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 13, Move = new Attaque{ Nom = "Vampirisme", Type = TypePokemon.Insecte, PP = 15, PPMax = 15, Puissance = 6, Description = "Vole des PV à l’adversaire." } }
    }
            },
            ["Nosferalto"] = new Pokemon
            {
                Numero = 42,
                Nom = "Nosferalto",
                Niveau = 22,
                Types = new List<TypePokemon> { TypePokemon.Poison, TypePokemon.Vol },
                PV = 28,
                PVMax = 28,
                Attaque = 14,
                Defense = 12,
                AttaqueSpe = 13,
                DefenseSpe = 12,
                Vitesse = 16,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/042.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/042.png",
                Description = "Évolution de Nosferapti.",
                Exp = 0,
                ExpDonnee = 159,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque de type Vol." },
        new Attaque { Nom = "Vampirisme", Type = TypePokemon.Insecte, PP = 15, PPMax = 15, Puissance = 10, Description = "Vole des PV à l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." } }
    }
            },
            ["Mystherbe"] = new Pokemon
            {
                Numero = 43,
                Nom = "Mystherbe",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 14,
                PVMax = 14,
                Attaque = 7,
                Defense = 7,
                AttaqueSpe = 12,
                DefenseSpe = 8,
                Vitesse = 6,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/043.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/043.png",
                Description = "Un Pokémon de type Plante/Poison.",
                Exp = 0,
                ExpDonnee = 64,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 21,
                Evolution = "Ortide",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Poudre Toxik", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 0, Description = "Empoisonne l’adversaire." },
        new Attaque { Nom = "Vol-Vie", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 10, Description = "Vole des PV à l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 12, Move = new Attaque{ Nom = "Poudre Dodo", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 0, Description = "Endort l’adversaire." } }
    }
            },
            ["Ortide"] = new Pokemon
            {
                Numero = 44,
                Nom = "Ortide",
                Niveau = 21,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 28,
                PVMax = 28,
                Attaque = 10,
                Defense = 10,
                AttaqueSpe = 16,
                DefenseSpe = 12,
                Vitesse = 8,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/044.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/044.png",
                Description = "Évolution de Mystherbe.",
                Exp = 0,
                ExpDonnee = 138,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Rafflesia",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Vol-Vie", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 12, Description = "Vole des PV à l’adversaire." },
        new Attaque { Nom = "Poudre Toxik", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 0, Description = "Empoisonne l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Pétale", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque Plante puissante." } }
    }
            },
            ["Rafflesia"] = new Pokemon
            {
                Numero = 45,
                Nom = "Rafflesia",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 38,
                PVMax = 38,
                Attaque = 14,
                Defense = 14,
                AttaqueSpe = 20,
                DefenseSpe = 16,
                Vitesse = 8,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/045.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/045.png",
                Description = "Évolution finale de Mystherbe.",
                Exp = 0,
                ExpDonnee = 221,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pétale", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque Plante puissante." },
        new Attaque { Nom = "Poudre Toxik", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 0, Description = "Empoisonne l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Tempête Verte", Type = TypePokemon.Plante, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque Plante ultime." } }
    }
            },
            ["Paras"] = new Pokemon
            {
                Numero = 46,
                Nom = "Paras",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Plante },
                PV = 13,
                PVMax = 13,
                Attaque = 8,
                Defense = 8,
                AttaqueSpe = 8,
                DefenseSpe = 8,
                Vitesse = 6,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/046.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/046.png",
                Description = "Un Pokémon de type Insecte/Plante.",
                Exp = 0,
                ExpDonnee = 57,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 24,
                Evolution = "Parasect",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Attaque physique rapide." },
        new Attaque { Nom = "Vol-Vie", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 8, Description = "Vole des PV à l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 12, Move = new Attaque{ Nom = "Poudre Toxik", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 0, Description = "Empoisonne l’adversaire." } }
    }
            },
            ["Parasect"] = new Pokemon
            {
                Numero = 47,
                Nom = "Parasect",
                Niveau = 24,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Plante },
                PV = 28,
                PVMax = 28,
                Attaque = 13,
                Defense = 13,
                AttaqueSpe = 12,
                DefenseSpe = 15,
                Vitesse = 8,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/047.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/047.png",
                Description = "Évolution de Paras.",
                Exp = 0,
                ExpDonnee = 142,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Vol-Vie", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 14, Description = "Vole des PV à l’adversaire." },
        new Attaque { Nom = "Lame Feuille", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 18, Description = "Attaque Plante puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Poudre Dodo", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 0, Description = "Endort l’adversaire." } }
    }
            },
            ["Mimitoss"] = new Pokemon
            {
                Numero = 48,
                Nom = "Mimitoss",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Poison },
                PV = 13,
                PVMax = 13,
                Attaque = 8,
                Defense = 8,
                AttaqueSpe = 8,
                DefenseSpe = 8,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/048.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/048.png",
                Description = "Un Pokémon de type Insecte/Poison.",
                Exp = 0,
                ExpDonnee = 61,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 31,
                Evolution = "Aéromite",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Poudre Toxik", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 0, Description = "Empoisonne l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Vampirisme", Type = TypePokemon.Insecte, PP = 15, PPMax = 15, Puissance = 10, Description = "Vole des PV à l’adversaire." } }
    }
            },
            ["Aéromite"] = new Pokemon
            {
                Numero = 49,
                Nom = "Aéromite",
                Niveau = 31,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Poison },
                PV = 27,
                PVMax = 27,
                Attaque = 13,
                Defense = 13,
                AttaqueSpe = 17,
                DefenseSpe = 13,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/049.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/049.png",
                Description = "Évolution de Mimitoss.",
                Exp = 0,
                ExpDonnee = 158,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Vampirisme", Type = TypePokemon.Insecte, PP = 15, PPMax = 15, Puissance = 15, Description = "Vole des PV à l’adversaire." },
        new Attaque { Nom = "Poudre Dodo", Type = TypePokemon.Plante, PP = 15, PPMax = 15, Puissance = 0, Description = "Endort l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 17, Description = "Attaque Psy puissante." } }
    }
            },
            ["Taupiqueur"] = new Pokemon
            {
                Numero = 50,
                Nom = "Taupiqueur",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Sol },
                PV = 10,
                PVMax = 10,
                Attaque = 10,
                Defense = 8,
                AttaqueSpe = 7,
                DefenseSpe = 7,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/050.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/050.png",
                Description = "Un Pokémon de type Sol.",
                Exp = 0,
                ExpDonnee = 53,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 26,
                Evolution = "Triopikeur",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Tunnel", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Sol puissante." },
        new Attaque { Nom = "Jet de Sable", Type = TypePokemon.Sol, PP = 15, PPMax = 15, Puissance = 0, Description = "Baisse la précision de l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Tranche", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque physique puissante." } }
    }
            },
            ["Triopikeur"] = new Pokemon
            {
                Numero = 51,
                Nom = "Triopikeur",
                Niveau = 26,
                Types = new List<TypePokemon> { TypePokemon.Sol },
                PV = 26,
                PVMax = 26,
                Attaque = 15,
                Defense = 10,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 16,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/051.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/051.png",
                Description = "Évolution de Taupiqueur.",
                Exp = 0,
                ExpDonnee = 149,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Tunnel", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 18, Description = "Attaque Sol puissante." },
        new Attaque { Nom = "Tranche", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque physique puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol très puissante." } }
    }
            },
            ["Miaouss"] = new Pokemon
            {
                Numero = 52,
                Nom = "Miaouss",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 14,
                PVMax = 14,
                Attaque = 8,
                Defense = 7,
                AttaqueSpe = 8,
                DefenseSpe = 7,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/052.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/052.png",
                Description = "Un Pokémon de type Normal.",
                Exp = 0,
                ExpDonnee = 58,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 28,
                Evolution = "Persian",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque physique rapide." },
        new Attaque { Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 10, Move = new Attaque{ Nom = "Combo-Griffe", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque physique à répétition." } }
    }
            },
            ["Persian"] = new Pokemon
            {
                Numero = 53,
                Nom = "Persian",
                Niveau = 28,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 28,
                PVMax = 28,
                Attaque = 14,
                Defense = 12,
                AttaqueSpe = 13,
                DefenseSpe = 12,
                Vitesse = 16,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/053.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/053.png",
                Description = "Évolution de Miaouss.",
                Exp = 0,
                ExpDonnee = 154,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Combo-Griffe", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 14, Description = "Attaque physique à répétition." },
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 10, Description = "Attaque physique rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 35, Move = new Attaque{ Nom = "Météores", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Normal qui ne rate jamais." } }
    }
            },
            ["Psykokwak"] = new Pokemon
            {
                Numero = 54,
                Nom = "Psykokwak",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 16,
                PVMax = 16,
                Attaque = 8,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 8,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/054.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/054.png",
                Description = "Un Pokémon de type Eau.",
                Exp = 0,
                ExpDonnee = 64,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 33,
                Evolution = "Akwakwak",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 8, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 16, Move = new Attaque{ Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Psy." } }
    }
            },
            ["Akwakwak"] = new Pokemon
            {
                Numero = 55,
                Nom = "Akwakwak",
                Niveau = 33,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 32,
                PVMax = 32,
                Attaque = 14,
                Defense = 12,
                AttaqueSpe = 18,
                DefenseSpe = 14,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/055.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/055.png",
                Description = "Évolution de Psykokwak.",
                Exp = 0,
                ExpDonnee = 175,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." },
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 12, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Surf", Type = TypePokemon.Eau, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque Eau puissante." } }
    }
            },
            ["Férosinge"] = new Pokemon
            {
                Numero = 56,
                Nom = "Férosinge",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Combat },
                PV = 15,
                PVMax = 15,
                Attaque = 10,
                Defense = 7,
                AttaqueSpe = 7,
                DefenseSpe = 7,
                Vitesse = 11,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/056.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/056.png",
                Description = "Un Pokémon de type Combat.",
                Exp = 0,
                ExpDonnee = 61,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 28,
                Evolution = "Colossinge",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Karaté", Type = TypePokemon.Combat, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Combat." },
        new Attaque { Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Coup-Croix", Type = TypePokemon.Combat, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Combat puissante." } }
    }
            },
            ["Colossinge"] = new Pokemon
            {
                Numero = 57,
                Nom = "Colossinge",
                Niveau = 28,
                Types = new List<TypePokemon> { TypePokemon.Combat },
                PV = 30,
                PVMax = 30,
                Attaque = 18,
                Defense = 12,
                AttaqueSpe = 12,
                DefenseSpe = 12,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/057.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/057.png",
                Description = "Évolution de Férosinge.",
                Exp = 0,
                ExpDonnee = 159,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Coup-Croix", Type = TypePokemon.Combat, PP = 20, PPMax = 20, Puissance = 18, Description = "Attaque Combat puissante." },
        new Attaque { Nom = "Karaté", Type = TypePokemon.Combat, PP = 25, PPMax = 25, Puissance = 12, Description = "Attaque de type Combat." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Poing de Feu", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 18, Description = "Attaque Combat qui brûle." } }
    }
            },
            ["Caninos"] = new Pokemon
            {
                Numero = 58,
                Nom = "Caninos",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 15,
                PVMax = 15,
                Attaque = 9,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 8,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/058.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/058.png",
                Description = "Un Pokémon de type Feu.",
                Exp = 0,
                ExpDonnee = 70,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Arcanin",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Flammèche", Type = TypePokemon.Feu, PP = 25, PPMax = 25, Puissance = 10, Description = "Petite attaque de feu." },
        new Attaque { Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Crocs Feu", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de feu mordante." } }
    }
            },
            ["Arcanin"] = new Pokemon
            {
                Numero = 59,
                Nom = "Arcanin",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 35,
                PVMax = 35,
                Attaque = 18,
                Defense = 14,
                AttaqueSpe = 20,
                DefenseSpe = 16,
                Vitesse = 18,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/059.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/059.png",
                Description = "Évolution de Caninos.",
                Exp = 0,
                ExpDonnee = 194,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Lance-Flammes", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque de feu très puissante." },
        new Attaque { Nom = "Crocs Feu", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de feu mordante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Déflagration", Type = TypePokemon.Feu, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de feu." } }
    }
            },
            ["Ptitard"] = new Pokemon
            {
                Numero = 60,
                Nom = "Ptitard",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 14,
                PVMax = 14,
                Attaque = 7,
                Defense = 7,
                AttaqueSpe = 8,
                DefenseSpe = 8,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/060.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/060.png",
                Description = "Un Pokémon de type Eau.",
                Exp = 0,
                ExpDonnee = 60,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 25,
                Evolution = "Têtarte",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." },
        new Attaque { Nom = "Hypnose", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Endort l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Bulles d'O", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque Eau qui peut ralentir." } }
    }
            },
            ["Têtarte"] = new Pokemon
            {
                Numero = 61,
                Nom = "Têtarte",
                Niveau = 25,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 28,
                PVMax = 28,
                Attaque = 11,
                Defense = 11,
                AttaqueSpe = 14,
                DefenseSpe = 13,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/061.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/061.png",
                Description = "Évolution de Ptitard.",
                Exp = 0,
                ExpDonnee = 135,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 36,
                Evolution = "Tartard",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Bulles d'O", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque Eau qui peut ralentir." },
        new Attaque { Nom = "Hypnose", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Endort l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Surf", Type = TypePokemon.Eau, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque Eau puissante." } }
    }
            },
            ["Tartard"] = new Pokemon
            {
                Numero = 62,
                Nom = "Tartard",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Combat },
                PV = 38,
                PVMax = 38,
                Attaque = 18,
                Defense = 16,
                AttaqueSpe = 16,
                DefenseSpe = 16,
                Vitesse = 15,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/062.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/062.png",
                Description = "Évolution finale de Ptitard.",
                Exp = 0,
                ExpDonnee = 230,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." },
        new Attaque { Nom = "Dynamopoing", Type = TypePokemon.Combat, PP = 10, PPMax = 10, Puissance = 18, Description = "Attaque de type Combat." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Ultimapoing", Type = TypePokemon.Combat, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque Combat ultime." } }
    }
            },
            ["Abra"] = new Pokemon
            {
                Numero = 63,
                Nom = "Abra",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Psy },
                PV = 12,
                PVMax = 12,
                Attaque = 6,
                Defense = 6,
                AttaqueSpe = 13,
                DefenseSpe = 8,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/063.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/063.png",
                Description = "Un Pokémon de type Psy.",
                Exp = 0,
                ExpDonnee = 62,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 16,
                Evolution = "Kadabra",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Téléport", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Fuit le combat." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 16, Move = new Attaque{ Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Psy." } }
    }
            },
            ["Kadabra"] = new Pokemon
            {
                Numero = 64,
                Nom = "Kadabra",
                Niveau = 16,
                Types = new List<TypePokemon> { TypePokemon.Psy },
                PV = 20,
                PVMax = 20,
                Attaque = 9,
                Defense = 8,
                AttaqueSpe = 20,
                DefenseSpe = 13,
                Vitesse = 16,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/064.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/064.png",
                Description = "Évolution d'Abra.",
                Exp = 0,
                ExpDonnee = 140,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Alakazam",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 12, Description = "Attaque Psy." },
        new Attaque { Nom = "Téléport", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Fuit le combat." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Psyko", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Psy puissante." } }
    }
            },
            ["Alakazam"] = new Pokemon
            {
                Numero = 65,
                Nom = "Alakazam",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Psy },
                PV = 28,
                PVMax = 28,
                Attaque = 12,
                Defense = 10,
                AttaqueSpe = 25,
                DefenseSpe = 15,
                Vitesse = 20,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/065.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/065.png",
                Description = "Évolution finale d'Abra.",
                Exp = 0,
                ExpDonnee = 225,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Psyko", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Psy puissante." },
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 12, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Ball'Ombre", Type = TypePokemon.Spectre, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque Spectre puissante." } }
    }
            },
            ["Machoc"] = new Pokemon
            {
                Numero = 66,
                Nom = "Machoc",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Combat },
                PV = 16,
                PVMax = 16,
                Attaque = 10,
                Defense = 8,
                AttaqueSpe = 6,
                DefenseSpe = 7,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/066.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/066.png",
                Description = "Un Pokémon de type Combat.",
                Exp = 0,
                ExpDonnee = 61,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 28,
                Evolution = "Machopeur",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Karaté", Type = TypePokemon.Combat, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Combat." },
        new Attaque { Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Poing-Karaté", Type = TypePokemon.Combat, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Combat puissante." } }
    }
            },
            ["Machopeur"] = new Pokemon
            {
                Numero = 67,
                Nom = "Machopeur",
                Niveau = 28,
                Types = new List<TypePokemon> { TypePokemon.Combat },
                PV = 32,
                PVMax = 32,
                Attaque = 18,
                Defense = 14,
                AttaqueSpe = 10,
                DefenseSpe = 12,
                Vitesse = 11,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/067.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/067.png",
                Description = "Évolution de Machoc.",
                Exp = 0,
                ExpDonnee = 142,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Mackogneur",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Poing-Karaté", Type = TypePokemon.Combat, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Combat puissante." },
        new Attaque { Nom = "Karaté", Type = TypePokemon.Combat, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Combat." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Ultimapoing", Type = TypePokemon.Combat, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de Combat." } }
    }
            },
            ["Mackogneur"] = new Pokemon
            {
                Numero = 68,
                Nom = "Mackogneur",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Combat },
                PV = 40,
                PVMax = 40,
                Attaque = 24,
                Defense = 18,
                AttaqueSpe = 12,
                DefenseSpe = 15,
                Vitesse = 13,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/068.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/068.png",
                Description = "Évolution finale de Machoc.",
                Exp = 0,
                ExpDonnee = 227,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Ultimapoing", Type = TypePokemon.Combat, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de Combat." },
        new Attaque { Nom = "Poing-Karaté", Type = TypePokemon.Combat, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Combat puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Poing de Feu", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 18, Description = "Attaque Combat qui brûle." } }
    }
            },
            ["Chétiflor"] = new Pokemon
            {
                Numero = 69,
                Nom = "Chétiflor",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 13,
                PVMax = 13,
                Attaque = 8,
                Defense = 7,
                AttaqueSpe = 10,
                DefenseSpe = 8,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/069.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/069.png",
                Description = "Un Pokémon de type Plante/Poison.",
                Exp = 0,
                ExpDonnee = 60,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 21,
                Evolution = "Boustiflor",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Vampigraine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 10, Description = "Vole des PV à l’adversaire." },
        new Attaque { Nom = "Fouet Lianes", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 8, Description = "Attaque de type Plante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Poudre Toxik", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 0, Description = "Empoisonne l’adversaire." } }
    }
            },
            ["Boustiflor"] = new Pokemon
            {
                Numero = 70,
                Nom = "Boustiflor",
                Niveau = 21,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 23,
                PVMax = 23,
                Attaque = 13,
                Defense = 10,
                AttaqueSpe = 16,
                DefenseSpe = 12,
                Vitesse = 10,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/070.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/070.png",
                Description = "Évolution de Chétiflor.",
                Exp = 0,
                ExpDonnee = 137,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Empiflor",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Vampigraine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 12, Description = "Vole des PV à l’adversaire." },
        new Attaque { Nom = "Fouet Lianes", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 10, Description = "Attaque de type Plante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Tranch'Herbe", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 15, Description = "Coup critique augmenté." } }
    }
            },
            ["Empiflor"] = new Pokemon
            {
                Numero = 71,
                Nom = "Empiflor",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Poison },
                PV = 33,
                PVMax = 33,
                Attaque = 18,
                Defense = 14,
                AttaqueSpe = 20,
                DefenseSpe = 16,
                Vitesse = 15,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/071.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/071.png",
                Description = "Évolution finale de Chétiflor.",
                Exp = 0,
                ExpDonnee = 221,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Tranch'Herbe", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 15, Description = "Coup critique augmenté." },
        new Attaque { Nom = "Bomb'Beurk", Type = TypePokemon.Poison, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Poison puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Tempête Verte", Type = TypePokemon.Plante, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque Plante ultime." } }
    }
            },
            ["Tentacool"] = new Pokemon
            {
                Numero = 72,
                Nom = "Tentacool",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Poison },
                PV = 13,
                PVMax = 13,
                Attaque = 7,
                Defense = 7,
                AttaqueSpe = 12,
                DefenseSpe = 10,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/072.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/072.png",
                Description = "Un Pokémon de type Eau/Poison.",
                Exp = 0,
                ExpDonnee = 67,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 30,
                Evolution = "Tentacruel",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Picpic", Type = TypePokemon.Poison, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque de type Poison." },
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Poison." } }
    }
            },
            ["Tentacruel"] = new Pokemon
            {
                Numero = 73,
                Nom = "Tentacruel",
                Niveau = 30,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Poison },
                PV = 28,
                PVMax = 28,
                Attaque = 13,
                Defense = 13,
                AttaqueSpe = 18,
                DefenseSpe = 16,
                Vitesse = 18,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/073.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/073.png",
                Description = "Évolution de Tentacool.",
                Exp = 0,
                ExpDonnee = 180,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Dard-Venin", Type = TypePokemon.Poison, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de type Poison." },
        new Attaque { Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Bomb'Beurk", Type = TypePokemon.Poison, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Poison puissante." } }
    }
            },
            ["Racaillou"] = new Pokemon
            {
                Numero = 74,
                Nom = "Racaillou",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Sol },
                PV = 16,
                PVMax = 16,
                Attaque = 10,
                Defense = 12,
                AttaqueSpe = 5,
                DefenseSpe = 6,
                Vitesse = 6,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/074.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/074.png",
                Description = "Un Pokémon de type Roche/Sol.",
                Exp = 0,
                ExpDonnee = 60,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 25,
                Evolution = "Gravalanch",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Jet de Pierre", Type = TypePokemon.Roche, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Roche." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Éboulement", Type = TypePokemon.Roche, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Roche puissante." } }
    }
            },
            ["Gravalanch"] = new Pokemon
            {
                Numero = 75,
                Nom = "Gravalanch",
                Niveau = 25,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Sol },
                PV = 28,
                PVMax = 28,
                Attaque = 15,
                Defense = 17,
                AttaqueSpe = 7,
                DefenseSpe = 10,
                Vitesse = 9,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/075.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/075.png",
                Description = "Évolution de Racaillou.",
                Exp = 0,
                ExpDonnee = 137,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Grolem",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Éboulement", Type = TypePokemon.Roche, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Roche puissante." },
        new Attaque { Nom = "Jet de Pierre", Type = TypePokemon.Roche, PP = 15, PPMax = 15, Puissance = 12, Description = "Attaque de type Roche." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 35, Move = new Attaque{ Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol très puissante." } }
    }
            },
            ["Grolem"] = new Pokemon
            {
                Numero = 76,
                Nom = "Grolem",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Sol },
                PV = 38,
                PVMax = 38,
                Attaque = 20,
                Defense = 20,
                AttaqueSpe = 10,
                DefenseSpe = 15,
                Vitesse = 12,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/076.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/076.png",
                Description = "Évolution finale de Racaillou.",
                Exp = 0,
                ExpDonnee = 218,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol très puissante." },
        new Attaque { Nom = "Éboulement", Type = TypePokemon.Roche, PP = 10, PPMax = 10, Puissance = 20, Description = "Attaque Roche puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Explosion", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque Normal très puissante." } }
    }
            },
            ["Ponyta"] = new Pokemon
            {
                Numero = 77,
                Nom = "Ponyta",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 14,
                PVMax = 14,
                Attaque = 9,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 8,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/077.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/077.png",
                Description = "Un Pokémon de type Feu.",
                Exp = 0,
                ExpDonnee = 82,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 40,
                Evolution = "Galopa",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Rugissement", Type = TypePokemon.Normal, PP = 40, PPMax = 40, Puissance = 0, Description = "Baisse l’attaque de l’adversaire." },
        new Attaque { Nom = "Flammèche", Type = TypePokemon.Feu, PP = 25, PPMax = 25, Puissance = 10, Description = "Petite attaque de feu." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque rapide." } }
    }
            },
            ["Galopa"] = new Pokemon
            {
                Numero = 78,
                Nom = "Galopa",
                Niveau = 40,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 28,
                PVMax = 28,
                Attaque = 16,
                Defense = 14,
                AttaqueSpe = 18,
                DefenseSpe = 14,
                Vitesse = 18,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/078.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/078.png",
                Description = "Évolution de Ponyta.",
                Exp = 0,
                ExpDonnee = 192,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Flamme", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de feu améliorée." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 12, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Déflagration", Type = TypePokemon.Feu, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de feu." } }
    }
            },
            ["Ramoloss"] = new Pokemon
            {
                Numero = 79,
                Nom = "Ramoloss",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Psy },
                PV = 16,
                PVMax = 16,
                Attaque = 8,
                Defense = 10,
                AttaqueSpe = 8,
                DefenseSpe = 10,
                Vitesse = 4,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/079.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/079.png",
                Description = "Un Pokémon de type Eau/Psy.",
                Exp = 0,
                ExpDonnee = 63,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 37,
                Evolution = "Flagadoss",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." },
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Amnésie", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Augmente la défense spéciale." } }
    }
            },
            ["Flagadoss"] = new Pokemon
            {
                Numero = 80,
                Nom = "Flagadoss",
                Niveau = 37,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Psy },
                PV = 32,
                PVMax = 32,
                Attaque = 14,
                Defense = 18,
                AttaqueSpe = 16,
                DefenseSpe = 18,
                Vitesse = 8,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/080.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/080.png",
                Description = "Évolution de Ramoloss.",
                Exp = 0,
                ExpDonnee = 172,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Psyko", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Psy puissante." },
        new Attaque { Nom = "Surf", Type = TypePokemon.Eau, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque Eau puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Blabla Dodo", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 0, Description = "Attaque pendant le sommeil." } }
    }
            },

            ["Magnéti"] = new Pokemon
            {
                Numero = 81,
                Nom = "Magnéti",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Electrik },
                PV = 13,
                PVMax = 13,
                Attaque = 9,
                Defense = 11,
                AttaqueSpe = 12,
                DefenseSpe = 10,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/081.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/081.png",
                Description = "Un Pokémon de type Électrik qui flotte grâce au magnétisme.",
                Exp = 0,
                ExpDonnee = 65,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 30,
                Evolution = "Magnéton",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Éclair", Type = TypePokemon.Electrik, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque de type Électrik." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Onde de Choc", Type = TypePokemon.Electrik, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque rapide de type Électrik." } }
    }
            },
            ["Magnéton"] = new Pokemon
            {
                Numero = 82,
                Nom = "Magnéton",
                Niveau = 30,
                Types = new List<TypePokemon> { TypePokemon.Electrik },
                PV = 28,
                PVMax = 28,
                Attaque = 14,
                Defense = 15,
                AttaqueSpe = 19,
                DefenseSpe = 14,
                Vitesse = 10,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/082.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/082.png",
                Description = "Évolution de Magnéti.",
                Exp = 0,
                ExpDonnee = 163,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Éclair", Type = TypePokemon.Electrik, PP = 30, PPMax = 30, Puissance = 15, Description = "Attaque de type Électrik." },
        new Attaque { Nom = "Sonicboom", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 20, Description = "Attaque qui inflige des dégâts fixes." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Fatal-Foudre", Type = TypePokemon.Electrik, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque électrique puissante." } }
    }
            },
            ["Canarticho"] = new Pokemon
            {
                Numero = 83,
                Nom = "Canarticho",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal, TypePokemon.Vol },
                PV = 18,
                PVMax = 18,
                Attaque = 10,
                Defense = 11,
                AttaqueSpe = 11,
                DefenseSpe = 10,
                Vitesse = 13,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/083.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/083.png",
                Description = "Un Pokémon qui se bat avec un poireau.",
                Exp = 0,
                ExpDonnee = 94,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Tranche", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque coupante rapide." },
        new Attaque { Nom = "Cru-Aile", Type = TypePokemon.Vol, PP = 25, PPMax = 25, Puissance = 12, Description = "Attaque Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Danse-Lames", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 0, Description = "Augmente l'attaque." } }
    }
            },
            ["Doduo"] = new Pokemon
            {
                Numero = 84,
                Nom = "Doduo",
                Niveau = 10,
                Types = new List<TypePokemon> { TypePokemon.Normal, TypePokemon.Vol },
                PV = 15,
                PVMax = 15,
                Attaque = 12,
                Defense = 9,
                AttaqueSpe = 7,
                DefenseSpe = 7,
                Vitesse = 15,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/084.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/084.png",
                Description = "Un Pokémon à deux têtes qui court très vite.",
                Exp = 0,
                ExpDonnee = 96,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 31,
                Evolution = "Dodrio",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Picpic", Type = TypePokemon.Vol, PP = 35, PPMax = 35, Puissance = 10, Description = "Attaque Vol de base." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque rapide." } }
    }
            },
            ["Dodrio"] = new Pokemon
            {
                Numero = 85,
                Nom = "Dodrio",
                Niveau = 31,
                Types = new List<TypePokemon> { TypePokemon.Normal, TypePokemon.Vol },
                PV = 27,
                PVMax = 27,
                Attaque = 19,
                Defense = 13,
                AttaqueSpe = 11,
                DefenseSpe = 11,
                Vitesse = 20,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/085.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/085.png",
                Description = "Évolution de Doduo, possède trois têtes.",
                Exp = 0,
                ExpDonnee = 158,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Bec Vrille", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 20, Description = "Attaque Vol puissante." },
        new Attaque { Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 15, Description = "Attaque rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Triplattaque", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque spéciale à trois effets." } }
    }
            },
            ["Otaria"] = new Pokemon
            {
                Numero = 86,
                Nom = "Otaria",
                Niveau = 12,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 18,
                PVMax = 18,
                Attaque = 9,
                Defense = 10,
                AttaqueSpe = 10,
                DefenseSpe = 11,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/086.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/086.png",
                Description = "Un Pokémon phoque joyeux.",
                Exp = 0,
                ExpDonnee = 100,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 34,
                Evolution = "Lamantine",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Coud'Krâne", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque physique." } }
    }
            },
            ["Lamantine"] = new Pokemon
            {
                Numero = 87,
                Nom = "Lamantine",
                Niveau = 34,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Glace },
                PV = 30,
                PVMax = 30,
                Attaque = 14,
                Defense = 14,
                AttaqueSpe = 16,
                DefenseSpe = 15,
                Vitesse = 12,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/087.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/087.png",
                Description = "Évolution d'Otaria, nage très bien dans les eaux glacées.",
                Exp = 0,
                ExpDonnee = 176,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." },
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 12, Description = "Attaque Eau améliorée." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Blizzard", Type = TypePokemon.Glace, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de glace." } }
    }
            },
            ["Tadmorv"] = new Pokemon
            {
                Numero = 88,
                Nom = "Tadmorv",
                Niveau = 15,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 16,
                PVMax = 16,
                Attaque = 12,
                Defense = 10,
                AttaqueSpe = 8,
                DefenseSpe = 9,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/088.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/088.png",
                Description = "Un Pokémon constitué de boue toxique.",
                Exp = 0,
                ExpDonnee = 90,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 38,
                Evolution = "Grotadmorv",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Dégommage", Type = TypePokemon.Poison, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque Poison." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 25, Move = new Attaque{ Nom = "Gaz Toxik", Type = TypePokemon.Poison, PP = 40, PPMax = 40, Puissance = 0, Description = "Empoisonne l'adversaire." } }
    }
            },
            ["Grotadmorv"] = new Pokemon
            {
                Numero = 89,
                Nom = "Grotadmorv",
                Niveau = 38,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 29,
                PVMax = 29,
                Attaque = 18,
                Defense = 15,
                AttaqueSpe = 13,
                DefenseSpe = 13,
                Vitesse = 10,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/089.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/089.png",
                Description = "Évolution de Tadmorv, plus gros et plus toxique.",
                Exp = 0,
                ExpDonnee = 175,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Bomb'Beurk", Type = TypePokemon.Poison, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Poison puissante." },
        new Attaque { Nom = "Dégommage", Type = TypePokemon.Poison, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Poison améliorée." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 45, Move = new Attaque{ Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol très puissante." } }
    }
            },
            ["Kokiyas"] = new Pokemon
            {
                Numero = 90,
                Nom = "Kokiyas",
                Niveau = 10,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 12,
                PVMax = 12,
                Attaque = 10,
                Defense = 15,
                AttaqueSpe = 8,
                DefenseSpe = 9,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/090.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/090.png",
                Description = "Sa coquille est très dure.",
                Exp = 0,
                ExpDonnee = 97,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 30,
                Evolution = "Crustabri",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." },
        new Attaque { Nom = "Armure", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 0, Description = "Augmente la défense." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Picpic", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque normale." } }
    }
            },
            ["Crustabri"] = new Pokemon
            {
                Numero = 91,
                Nom = "Crustabri",
                Niveau = 30,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Glace },
                PV = 24,
                PVMax = 24,
                Attaque = 14,
                Defense = 22,
                AttaqueSpe = 12,
                DefenseSpe = 15,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/091.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/091.png",
                Description = "Évolution de Kokiyas, possède une coquille quasi impénétrable.",
                Exp = 0,
                ExpDonnee = 184,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." },
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 15, Description = "Attaque Eau améliorée." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 45, Move = new Attaque{ Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." } }
    }
            },
            ["Fantominus"] = new Pokemon
            {
                Numero = 92,
                Nom = "Fantominus",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Spectre, TypePokemon.Poison },
                PV = 13,
                PVMax = 13,
                Attaque = 7,
                Defense = 7,
                AttaqueSpe = 13,
                DefenseSpe = 9,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/092.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/092.png",
                Description = "Un Pokémon de type Spectre/Poison.",
                Exp = 0,
                ExpDonnee = 62,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 25,
                Evolution = "Spectrum",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Léchouille", Type = TypePokemon.Spectre, PP = 30, PPMax = 30, Puissance = 10, Description = "Peut paralyser l'adversaire." },
        new Attaque { Nom = "Hypnose", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Endort l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Onde Folie", Type = TypePokemon.Spectre, PP = 20, PPMax = 20, Puissance = 0, Description = "Rend confus l'adversaire." } }
    }
            },
            ["Spectrum"] = new Pokemon
            {
                Numero = 93,
                Nom = "Spectrum",
                Niveau = 25,
                Types = new List<TypePokemon> { TypePokemon.Spectre, TypePokemon.Poison },
                PV = 23,
                PVMax = 23,
                Attaque = 11,
                Defense = 11,
                AttaqueSpe = 17,
                DefenseSpe = 13,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/093.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/093.png",
                Description = "Évolution de Fantominus.",
                Exp = 0,
                ExpDonnee = 142,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Ectoplasma",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Léchouille", Type = TypePokemon.Spectre, PP = 30, PPMax = 30, Puissance = 15, Description = "Peut paralyser l'adversaire." },
        new Attaque { Nom = "Hypnose", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Endort l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 35, Move = new Attaque{ Nom = "Ball'Ombre", Type = TypePokemon.Spectre, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque Spectre puissante." } }
    }
            },
            ["Ectoplasma"] = new Pokemon
            {
                Numero = 94,
                Nom = "Ectoplasma",
                Niveau = 36,
                Types = new List<TypePokemon> { TypePokemon.Spectre, TypePokemon.Poison },
                PV = 33,
                PVMax = 33,
                Attaque = 16,
                Defense = 16,
                AttaqueSpe = 24,
                DefenseSpe = 17,
                Vitesse = 18,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/094.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/094.png",
                Description = "Évolution finale de Fantominus.",
                Exp = 0,
                ExpDonnee = 225,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Ball'Ombre", Type = TypePokemon.Spectre, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque Spectre puissante." },
        new Attaque { Nom = "Hypnose", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Endort l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Exploforce", Type = TypePokemon.Combat, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque Combat très puissante." } }
    }
            },
            ["Onix"] = new Pokemon
            {
                Numero = 95,
                Nom = "Onix",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Sol },
                PV = 15,
                PVMax = 15,
                Attaque = 7,
                Defense = 16,
                AttaqueSpe = 5,
                DefenseSpe = 7,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/095.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/095.png",
                Description = "Un Pokémon de type Roche/Sol.",
                Exp = 0,
                ExpDonnee = 77,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Étreinte", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque physique continue." },
        new Attaque { Nom = "Jet de Pierre", Type = TypePokemon.Roche, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Roche." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol très puissante." } }
    }
            },
            ["Soporifik"] = new Pokemon
            {
                Numero = 96,
                Nom = "Soporifik",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Psy },
                PV = 14,
                PVMax = 14,
                Attaque = 7,
                Defense = 6,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/096.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/096.png",
                Description = "Un Pokémon de type Psy.",
                Exp = 0,
                ExpDonnee = 66,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 26,
                Evolution = "Hypnomade",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Hypnose", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Endort l'adversaire." },
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Bâillement", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 0, Description = "Endort l'adversaire plus tard." } }
    }
            },
            ["Hypnomade"] = new Pokemon
            {
                Numero = 97,
                Nom = "Hypnomade",
                Niveau = 26,
                Types = new List<TypePokemon> { TypePokemon.Psy },
                PV = 28,
                PVMax = 28,
                Attaque = 13,
                Defense = 12,
                AttaqueSpe = 18,
                DefenseSpe = 16,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/097.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/097.png",
                Description = "Évolution de Soporifik.",
                Exp = 0,
                ExpDonnee = 169,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Psyko", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Psy puissante." },
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Blabla Dodo", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 0, Description = "Attaque pendant le sommeil." } }
    }
            },
            ["Krabby"] = new Pokemon
            {
                Numero = 98,
                Nom = "Krabby",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 13,
                PVMax = 13,
                Attaque = 10,
                Defense = 10,
                AttaqueSpe = 7,
                DefenseSpe = 7,
                Vitesse = 8,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/098.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/098.png",
                Description = "Un Pokémon de type Eau.",
                Exp = 0,
                ExpDonnee = 65,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 28,
                Evolution = "Krabboss",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pince-Masse", Type = TypePokemon.Eau, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque Eau puissante." },
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque physique rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Bulles d'O", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque Eau qui peut ralentir." } }
    }
            },
            ["Krabboss"] = new Pokemon
            {
                Numero = 99,
                Nom = "Krabboss",
                Niveau = 28,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 26,
                PVMax = 26,
                Attaque = 18,
                Defense = 16,
                AttaqueSpe = 10,
                DefenseSpe = 12,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/099.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/099.png",
                Description = "Évolution de Krabby.",
                Exp = 0,
                ExpDonnee = 166,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pince-Masse", Type = TypePokemon.Eau, PP = 15, PPMax = 15, Puissance = 18, Description = "Attaque Eau puissante." },
        new Attaque { Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 10, Description = "Attaque physique rapide." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." } }
    }
            },
            ["Voltorbe"] = new Pokemon
            {
                Numero = 100,
                Nom = "Voltorbe",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Electrik },
                PV = 13,
                PVMax = 13,
                Attaque = 8,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 15,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/100.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/100.png",
                Description = "Un Pokémon de type Electrik.",
                Exp = 0,
                ExpDonnee = 66,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 30,
                Evolution = "Électrode",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Éclair", Type = TypePokemon.Electrik, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque de type Electrik." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Boule Elek", Type = TypePokemon.Electrik, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Electrik spéciale." } }
    }
            },
            ["Électrode"] = new Pokemon
            {
                Numero = 101,
                Nom = "Électrode",
                Niveau = 30,
                Types = new List<TypePokemon> { TypePokemon.Electrik },
                PV = 24,
                PVMax = 24,
                Attaque = 12,
                Defense = 12,
                AttaqueSpe = 16,
                DefenseSpe = 14,
                Vitesse = 20,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/101.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/101.png",
                Description = "Évolution de Voltorbe.",
                Exp = 0,
                ExpDonnee = 168,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Boule Elek", Type = TypePokemon.Electrik, PP = 10, PPMax = 10, Puissance = 20, Description = "Attaque Electrik spéciale." },
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 10, Description = "Une attaque physique basique." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Fatal-Foudre", Type = TypePokemon.Electrik, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque Electrik très puissante." } }
    }
            },
            ["Noeunoeuf"] = new Pokemon
            {
                Numero = 102,
                Nom = "Noeunoeuf",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Psy },
                PV = 14,
                PVMax = 14,
                Attaque = 7,
                Defense = 9,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/102.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/102.png",
                Description = "Un Pokémon de type Plante/Psy.",
                Exp = 0,
                ExpDonnee = 65,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Noadkoko",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Vampigraine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 10, Description = "Vole des PV à l’adversaire." },
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Canon Graine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 20, Description = "Décharge de graines puissantes." } }
    }
            },
            ["Noadkoko"] = new Pokemon
            {
                Numero = 103,
                Nom = "Noadkoko",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Plante, TypePokemon.Psy },
                PV = 28,
                PVMax = 28,
                Attaque = 15,
                Defense = 13,
                AttaqueSpe = 18,
                DefenseSpe = 15,
                Vitesse = 11,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/103.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/103.png",
                Description = "Évolution de Noeunoeuf.",
                Exp = 0,
                ExpDonnee = 186,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Psyko", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Psy puissante." },
        new Attaque { Nom = "Canon Graine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 20, Description = "Décharge de graines puissantes." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Tempête Verte", Type = TypePokemon.Plante, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque Plante ultime." } }
    }
            },
            ["Osselait"] = new Pokemon
            {
                Numero = 104,
                Nom = "Osselait",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Sol },
                PV = 14,
                PVMax = 14,
                Attaque = 8,
                Defense = 10,
                AttaqueSpe = 6,
                DefenseSpe = 10,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/104.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/104.png",
                Description = "Un Pokémon de type Sol.",
                Exp = 0,
                ExpDonnee = 64,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 28,
                Evolution = "Ossatueur",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Osmerang", Type = TypePokemon.Sol, PP = 20, PPMax = 20, Puissance = 12, Description = "Attaque Sol en deux coups." },
        new Attaque { Nom = "Massd'Os", Type = TypePokemon.Sol, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque Sol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Torgnoles", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 10, Description = "Attaque Normal à répétition." } }
    }
            },
            ["Ossatueur"] = new Pokemon
            {
                Numero = 105,
                Nom = "Ossatueur",
                Niveau = 28,
                Types = new List<TypePokemon> { TypePokemon.Sol },
                PV = 28,
                PVMax = 28,
                Attaque = 15,
                Defense = 16,
                AttaqueSpe = 10,
                DefenseSpe = 16,
                Vitesse = 10,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/105.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/105.png",
                Description = "Évolution de Osselait.",
                Exp = 0,
                ExpDonnee = 149,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Osmerang", Type = TypePokemon.Sol, PP = 20, PPMax = 20, Puissance = 18, Description = "Attaque Sol en deux coups." },
        new Attaque { Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol très puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Massd'Os", Type = TypePokemon.Sol, PP = 20, PPMax = 20, Puissance = 20, Description = "Attaque Sol." } }
    }
            },
            ["Kicklee"] = new Pokemon
            {
                Numero = 106,
                Nom = "Kicklee",
                Niveau = 30,
                Types = new List<TypePokemon> { TypePokemon.Combat },
                PV = 24,
                PVMax = 24,
                Attaque = 18,
                Defense = 12,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 16,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/106.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/106.png",
                Description = "Pokémon spécialisé dans les coups de pied.",
                Exp = 0,
                ExpDonnee = 159,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Ultimawashi", Type = TypePokemon.Combat, PP = 5, PPMax = 5, Puissance = 30, Description = "Coup de pied puissant." },
        new Attaque { Nom = "Pied Voltige", Type = TypePokemon.Combat, PP = 10, PPMax = 10, Puissance = 20, Description = "Coup de pied sauté." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Ultimapoing", Type = TypePokemon.Combat, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de Combat." } }
    }
            },
            ["Tygnon"] = new Pokemon
            {
                Numero = 107,
                Nom = "Tygnon",
                Niveau = 30,
                Types = new List<TypePokemon> { TypePokemon.Combat },
                PV = 24,
                PVMax = 24,
                Attaque = 17,
                Defense = 13,
                AttaqueSpe = 12,
                DefenseSpe = 11,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/107.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/107.png",
                Description = "Pokémon spécialisé dans les coups de poing.",
                Exp = 0,
                ExpDonnee = 159,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Poing Comète", Type = TypePokemon.Combat, PP = 15, PPMax = 15, Puissance = 20, Description = "Envoie une série de coups de poing." },
        new Attaque { Nom = "Ultimapoing", Type = TypePokemon.Combat, PP = 5, PPMax = 5, Puissance = 30, Description = "Attaque ultime de Combat." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Poing de Feu", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 18, Description = "Attaque Combat qui brûle." } }
    }
            },
            ["Excelangue"] = new Pokemon
            {
                Numero = 108,
                Nom = "Excelangue",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 28,
                PVMax = 28,
                Attaque = 11,
                Defense = 11,
                AttaqueSpe = 10,
                DefenseSpe = 12,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/108.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/108.png",
                Description = "Un Pokémon de type Normal.",
                Exp = 0,
                ExpDonnee = 127,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Léchouille", Type = TypePokemon.Spectre, PP = 30, PPMax = 30, Puissance = 15, Description = "Peut paralyser l'adversaire." },
        new Attaque { Nom = "Roulade", Type = TypePokemon.Roche, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque de type Roche." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Coud'Boue", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 10, Description = "Attaque Sol." } }
    }
            },
            ["Smogo"] = new Pokemon
            {
                Numero = 109,
                Nom = "Smogo",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 13,
                PVMax = 13,
                Attaque = 9,
                Defense = 10,
                AttaqueSpe = 9,
                DefenseSpe = 8,
                Vitesse = 6,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/109.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/109.png",
                Description = "Un Pokémon de type Poison.",
                Exp = 0,
                ExpDonnee = 68,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 35,
                Evolution = "Smogogo",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Gaz Toxik", Type = TypePokemon.Poison, PP = 40, PPMax = 40, Puissance = 0, Description = "Empoisonne l'adversaire." },
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Bain de Smog", Type = TypePokemon.Poison, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Poison." } }
    }
            },
            ["Smogogo"] = new Pokemon
            {
                Numero = 110,
                Nom = "Smogogo",
                Niveau = 35,
                Types = new List<TypePokemon> { TypePokemon.Poison },
                PV = 26,
                PVMax = 26,
                Attaque = 16,
                Defense = 18,
                AttaqueSpe = 15,
                DefenseSpe = 15,
                Vitesse = 12,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/110.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/110.png",
                Description = "Évolution de Smogo.",
                Exp = 0,
                ExpDonnee = 172,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Bain de Smog", Type = TypePokemon.Poison, PP = 20, PPMax = 20, Puissance = 20, Description = "Attaque Poison." },
        new Attaque { Nom = "Gaz Toxik", Type = TypePokemon.Poison, PP = 40, PPMax = 40, Puissance = 0, Description = "Empoisonne l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Bomb'Beurk", Type = TypePokemon.Poison, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Poison puissante." } }
    }
            },
            ["Rhinocorne"] = new Pokemon
            {
                Numero = 111,
                Nom = "Rhinocorne",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Sol, TypePokemon.Roche },
                PV = 18,
                PVMax = 18,
                Attaque = 12,
                Defense = 12,
                AttaqueSpe = 6,
                DefenseSpe = 8,
                Vitesse = 6,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/111.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/111.png",
                Description = "Un Pokémon de type Sol/Roche.",
                Exp = 0,
                ExpDonnee = 69,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 42,
                Evolution = "Rhinoféros",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Mitra-Poing", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Sol puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Éboulement", Type = TypePokemon.Roche, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Roche puissante." } }
    }
            },
            ["Rhinoféros"] = new Pokemon
            {
                Numero = 112,
                Nom = "Rhinoféros",
                Niveau = 42,
                Types = new List<TypePokemon> { TypePokemon.Sol, TypePokemon.Roche },
                PV = 36,
                PVMax = 36,
                Attaque = 20,
                Defense = 17,
                AttaqueSpe = 10,
                DefenseSpe = 12,
                Vitesse = 10,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/112.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/112.png",
                Description = "Évolution de Rhinocorne. Sa corne est redoutable et il charge tout sur son passage.",
                Exp = 0,
                ExpDonnee = 204,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Mégacorne", Type = TypePokemon.Insecte, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque physique puissante." },
        new Attaque { Nom = "Séisme", Type = TypePokemon.Sol, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Sol très puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." } }
    }
            },
            ["Leveinard"] = new Pokemon
            {
                Numero = 113,
                Nom = "Leveinard",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 50,
                PVMax = 50,
                Attaque = 5,
                Defense = 5,
                AttaqueSpe = 15,
                DefenseSpe = 20,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/113.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/113.png",
                Description = "Un Pokémon de type Normal, réputé pour ses œufs porte-bonheur.",
                Exp = 0,
                ExpDonnee = 395,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Écras'Face", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Attaque physique basique." },
        new Attaque { Nom = "Vœu", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 0, Description = "Rend des PV au tour suivant." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Lumi-Éclat", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque qui peut soigner le lanceur." } }
    }
            },
            ["Saquedeneu"] = new Pokemon
            {
                Numero = 114,
                Nom = "Saquedeneu",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Plante },
                PV = 18,
                PVMax = 18,
                Attaque = 9,
                Defense = 11,
                AttaqueSpe = 13,
                DefenseSpe = 11,
                Vitesse = 9,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/114.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/114.png",
                Description = "Un Pokémon de type Plante dissimulé sous des lianes.",
                Exp = 0,
                ExpDonnee = 87,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Fouet Lianes", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 8, Description = "Attaque de type Plante." },
        new Attaque { Nom = "Ligotage", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 6, Description = "Empêche l'adversaire de fuir." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Vampigraine", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 10, Description = "Vole des PV à l'adversaire." } }
    }
            },
            ["Kangourex"] = new Pokemon
            {
                Numero = 115,
                Nom = "Kangourex",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 30,
                PVMax = 30,
                Attaque = 15,
                Defense = 12,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 13,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/115.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/115.png",
                Description = "Un Pokémon Normal protecteur de son petit.",
                Exp = 0,
                ExpDonnee = 172,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Marto-Poing", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque physique puissante." },
        new Attaque { Nom = "Écras'Face", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Attaque physique basique." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 35, Move = new Attaque{ Nom = "Uppercut", Type = TypePokemon.Combat, PP = 15, PPMax = 15, Puissance = 18, Description = "Coup de poing ascendant." } }
    }
            },
            ["Hypotrempe"] = new Pokemon
            {
                Numero = 116,
                Nom = "Hypotrempe",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 11,
                PVMax = 11,
                Attaque = 7,
                Defense = 8,
                AttaqueSpe = 9,
                DefenseSpe = 8,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/116.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/116.png",
                Description = "Un Pokémon de type Eau.",
                Exp = 0,
                ExpDonnee = 59,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 32,
                Evolution = "Hypocéan",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." },
        new Attaque { Nom = "Bulle d'O", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque Eau qui peut ralentir." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." } }
    }
            },
            ["Hypocéan"] = new Pokemon
            {
                Numero = 117,
                Nom = "Hypocéan",
                Niveau = 32,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 22,
                PVMax = 22,
                Attaque = 12,
                Defense = 13,
                AttaqueSpe = 14,
                DefenseSpe = 13,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/117.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/117.png",
                Description = "Évolution d'Hypotrempe.",
                Exp = 0,
                ExpDonnee = 154,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." },
        new Attaque { Nom = "Bulle d'O", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 12, Description = "Attaque Eau qui peut ralentir." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." } }
    }
            },
            ["Poissirène"] = new Pokemon
            {
                Numero = 118,
                Nom = "Poissirène",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 13,
                PVMax = 13,
                Attaque = 9,
                Defense = 8,
                AttaqueSpe = 8,
                DefenseSpe = 8,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/118.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/118.png",
                Description = "Un Pokémon de type Eau.",
                Exp = 0,
                ExpDonnee = 64,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 33,
                Evolution = "Poissoroy",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Ecume", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 12, Description = "Attaque de type Eau." },
        new Attaque { Nom = "Picpic", Type = TypePokemon.Vol, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque de type Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Hydroqueue", Type = TypePokemon.Eau, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Eau puissante." } }
    }
            },
            ["Poissoroy"] = new Pokemon
            {
                Numero = 119,
                Nom = "Poissoroy",
                Niveau = 33,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 25,
                PVMax = 25,
                Attaque = 15,
                Defense = 13,
                AttaqueSpe = 13,
                DefenseSpe = 13,
                Vitesse = 13,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/119.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/119.png",
                Description = "Évolution de Poissirène.",
                Exp = 0,
                ExpDonnee = 158,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Hydroqueue", Type = TypePokemon.Eau, PP = 10, PPMax = 10, Puissance = 20, Description = "Attaque Eau puissante." },
        new Attaque { Nom = "Picpic", Type = TypePokemon.Vol, PP = 35, PPMax = 35, Puissance = 10, Description = "Attaque de type Vol." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Mégacorne", Type = TypePokemon.Insecte, PP = 10, PPMax = 10, Puissance = 25, Description = "Puissante attaque Insecte." } }
    }
            },
            ["Stari"] = new Pokemon
            {
                Numero = 120,
                Nom = "Stari",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 12,
                PVMax = 12,
                Attaque = 8,
                Defense = 9,
                AttaqueSpe = 11,
                DefenseSpe = 10,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/120.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/120.png",
                Description = "Un Pokémon de type Eau.",
                Exp = 0,
                ExpDonnee = 68,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Staross",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." },
        new Attaque { Nom = "Rafale Psy", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 12, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." } }
    }
            },
            ["Staross"] = new Pokemon
            {
                Numero = 121,
                Nom = "Staross",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Psy },
                PV = 22,
                PVMax = 22,
                Attaque = 13,
                Defense = 15,
                AttaqueSpe = 18,
                DefenseSpe = 15,
                Vitesse = 17,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/121.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/121.png",
                Description = "Évolution de Stari.",
                Exp = 0,
                ExpDonnee = 182,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." },
        new Attaque { Nom = "Rafale Psy", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." } }
    }
            },
            ["M.Mime"] = new Pokemon
            {
                Numero = 122,
                Nom = "M.Mime",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Psy, TypePokemon.Fée },
                PV = 15,
                PVMax = 15,
                Attaque = 8,
                Defense = 10,
                AttaqueSpe = 18,
                DefenseSpe = 15,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/122.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/122.png",
                Description = "Un Pokémon de type Psy/Fée.",
                Exp = 0,
                ExpDonnee = 161,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Psy." },
        new Attaque { Nom = "Mur Lumière", Type = TypePokemon.Psy, PP = 30, PPMax = 30, Puissance = 0, Description = "Augmente la défense spéciale de l'équipe." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Psyko", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Psy puissante." } }
    }
            },
            ["Insécateur"] = new Pokemon
            {
                Numero = 123,
                Nom = "Insécateur",
                Niveau = 25,
                Types = new List<TypePokemon> { TypePokemon.Insecte, TypePokemon.Vol },
                PV = 22,
                PVMax = 22,
                Attaque = 17,
                Defense = 13,
                AttaqueSpe = 9,
                DefenseSpe = 9,
                Vitesse = 18,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/123.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/123.png",
                Description = "Un Pokémon insecte très rapide qui tranche ses ennemis avec ses lames.",
                Exp = 0,
                ExpDonnee = 187,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Tranche", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque coupante rapide." },
        new Attaque { Nom = "Piqûre", Type = TypePokemon.Insecte, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Insecte de base." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 36, Move = new Attaque { Nom = "Danse-Lames", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 0, Description = "Augmente considérablement l'attaque." } }
    }
            },
            ["Lippoutou"] = new Pokemon
            {
                Numero = 124,
                Nom = "Lippoutou",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Glace, TypePokemon.Psy },
                PV = 20,
                PVMax = 20,
                Attaque = 8,
                Defense = 10,
                AttaqueSpe = 18,
                DefenseSpe = 14,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/124.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/124.png",
                Description = "Un Pokémon de type Glace/Psy.",
                Exp = 0,
                ExpDonnee = 159,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Choc Mental", Type = TypePokemon.Psy, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque Psy." },
        new Attaque { Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Plénitude", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 0, Description = "Augmente la puissance des attaques spéciales." } }
    }
            },
            ["Élektek"] = new Pokemon
            {
                Numero = 125,
                Nom = "Élektek",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Electrik },
                PV = 22,
                PVMax = 22,
                Attaque = 14,
                Defense = 11,
                AttaqueSpe = 16,
                DefenseSpe = 12,
                Vitesse = 16,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/125.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/125.png",
                Description = "Un Pokémon de type Electrik.",
                Exp = 0,
                ExpDonnee = 172,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Éclair", Type = TypePokemon.Electrik, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque de type Electrik." },
        new Attaque { Nom = "Poing-Éclair", Type = TypePokemon.Electrik, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque physique Electrik." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Fatal-Foudre", Type = TypePokemon.Electrik, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque Electrik très puissante." } }
    }
            },
            ["Magmar"] = new Pokemon
            {
                Numero = 126,
                Nom = "Magmar",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 22,
                PVMax = 22,
                Attaque = 15,
                Defense = 11,
                AttaqueSpe = 17,
                DefenseSpe = 12,
                Vitesse = 14,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/126.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/126.png",
                Description = "Un Pokémon de type Feu.",
                Exp = 0,
                ExpDonnee = 173,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Flammèche", Type = TypePokemon.Feu, PP = 25, PPMax = 25, Puissance = 10, Description = "Petite attaque de feu." },
        new Attaque { Nom = "Poing de Feu", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque physique de feu." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Déflagration", Type = TypePokemon.Feu, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de feu." } }
    }
            },
            ["Scarabrute"] = new Pokemon
            {
                Numero = 127,
                Nom = "Scarabrute",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Insecte },
                PV = 25,
                PVMax = 25,
                Attaque = 18,
                Defense = 15,
                AttaqueSpe = 8,
                DefenseSpe = 12,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/127.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/127.png",
                Description = "Un Pokémon de type Insecte.",
                Exp = 0,
                ExpDonnee = 175,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Guillotine", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 50, Description = "Peut mettre K.O. d'un coup." },
        new Attaque { Nom = "Mégacorne", Type = TypePokemon.Insecte, PP = 10, PPMax = 10, Puissance = 25, Description = "Puissante attaque Insecte." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 35, Move = new Attaque{ Nom = "Coup d'Boule", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque puissante." } }
    }
            },
            ["Tauros"] = new Pokemon
            {
                Numero = 128,
                Nom = "Tauros",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 28,
                PVMax = 28,
                Attaque = 16,
                Defense = 14,
                AttaqueSpe = 10,
                DefenseSpe = 12,
                Vitesse = 15,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/128.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/128.png",
                Description = "Un Pokémon de type Normal.",
                Exp = 0,
                ExpDonnee = 172,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Damoclès", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque physique très puissante." },
        new Attaque { Nom = "Coup d'Boule", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Mégacorne", Type = TypePokemon.Insecte, PP = 10, PPMax = 10, Puissance = 25, Description = "Puissante attaque Insecte." } }
    }
            },
            ["Magicarpe"] = new Pokemon
            {
                Numero = 129,
                Nom = "Magicarpe",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 10,
                PVMax = 10,
                Attaque = 3,
                Defense = 7,
                AttaqueSpe = 5,
                DefenseSpe = 5,
                Vitesse = 8,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/129.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/129.png",
                Description = "Un Pokémon de type Eau très faible.",
                Exp = 0,
                ExpDonnee = 20,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 20,
                Evolution = "Léviator",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Trempette", Type = TypePokemon.Normal, PP = 40, PPMax = 40, Puissance = 0, Description = "Ne fait rien du tout." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." } }
    }
            },
            ["Léviator"] = new Pokemon
            {
                Numero = 130,
                Nom = "Léviator",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Vol },
                PV = 32,
                PVMax = 32,
                Attaque = 22,
                Defense = 16,
                AttaqueSpe = 13,
                DefenseSpe = 12,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/130.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/130.png",
                Description = "Évolution de Magicarpe, légendaire pour sa puissance.",
                Exp = 0,
                ExpDonnee = 214,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Hydroqueue", Type = TypePokemon.Eau, PP = 10, PPMax = 10, Puissance = 20, Description = "Attaque Eau puissante." },
        new Attaque { Nom = "Draco-Rage", Type = TypePokemon.Dragon, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Dragon." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." } }
    }
            },
            ["Lokhlass"] = new Pokemon
            {
                Numero = 131,
                Nom = "Lokhlass",
                Niveau = 30,
                Types = new List<TypePokemon> { TypePokemon.Eau, TypePokemon.Glace },
                PV = 38,
                PVMax = 38,
                Attaque = 14,
                Defense = 15,
                AttaqueSpe = 18,
                DefenseSpe = 18,
                Vitesse = 12,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/131.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/131.png",
                Description = "Un Pokémon très intelligent qui transporte les personnes sur l’eau.",
                Exp = 0,
                ExpDonnee = 187,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." },
        new Attaque { Nom = "Surf", Type = TypePokemon.Eau, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque Eau puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." } }
    }
            },
            ["Métamorph"] = new Pokemon
            {
                Numero = 132,
                Nom = "Métamorph",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 20,
                PVMax = 20,
                Attaque = 10,
                Defense = 10,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/132.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/132.png",
                Description = "Peut prendre l’apparence de tout autre Pokémon.",
                Exp = 0,
                ExpDonnee = 101,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Morphing", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 0, Description = "Copie les attaques de l’adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
                {
                }
            },
            ["Évoli"] = new Pokemon
            {
                Numero = 133,
                Nom = "Évoli",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 13,
                PVMax = 13,
                Attaque = 9,
                Defense = 8,
                AttaqueSpe = 8,
                DefenseSpe = 8,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/133.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/133.png",
                Description = "Un Pokémon dont l'évolution dépend de la pierre utilisée.",
                Exp = 0,
                ExpDonnee = 65,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "Aquali / Voltali / Pyroli",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Charge", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 5, Description = "Une attaque physique basique." },
        new Attaque { Nom = "Mimi-Queue", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 0, Description = "Baisse la défense de l'adversaire." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque rapide." } }
    }
            },
            ["Aquali"] = new Pokemon
            {
                Numero = 134,
                Nom = "Aquali",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Eau },
                PV = 25,
                PVMax = 25,
                Attaque = 13,
                Defense = 12,
                AttaqueSpe = 18,
                DefenseSpe = 16,
                Vitesse = 14,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/134.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/134.png",
                Description = "Évolution d'Évoli avec une Pierre Eau.",
                Exp = 0,
                ExpDonnee = 196,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." },
        new Attaque { Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." } }
    }
            },
            ["Voltali"] = new Pokemon
            {
                Numero = 135,
                Nom = "Voltali",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Electrik },
                PV = 22,
                PVMax = 22,
                Attaque = 12,
                Defense = 11,
                AttaqueSpe = 17,
                DefenseSpe = 14,
                Vitesse = 20,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/135.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/135.png",
                Description = "Évolution d'Évoli avec une Pierre Foudre.",
                Exp = 0,
                ExpDonnee = 197,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Éclair", Type = TypePokemon.Electrik, PP = 30, PPMax = 30, Puissance = 10, Description = "Attaque de type Electrik." },
        new Attaque { Nom = "Fatal-Foudre", Type = TypePokemon.Electrik, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque Electrik très puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 15, Description = "Attaque rapide." } }
    }
            },
            ["Pyroli"] = new Pokemon
            {
                Numero = 136,
                Nom = "Pyroli",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Feu },
                PV = 23,
                PVMax = 23,
                Attaque = 16,
                Defense = 12,
                AttaqueSpe = 18,
                DefenseSpe = 15,
                Vitesse = 14,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/136.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/136.png",
                Description = "Évolution d'Évoli avec une Pierre Feu.",
                Exp = 0,
                ExpDonnee = 198,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Flammèche", Type = TypePokemon.Feu, PP = 25, PPMax = 25, Puissance = 10, Description = "Petite attaque de feu." },
        new Attaque { Nom = "Déflagration", Type = TypePokemon.Feu, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de feu." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Vive-Attaque", Type = TypePokemon.Normal, PP = 30, PPMax = 30, Puissance = 15, Description = "Attaque rapide." } }
    }
            },
            ["Porygon"] = new Pokemon
            {
                Numero = 137,
                Nom = "Porygon",
                Niveau = 20,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 20,
                PVMax = 20,
                Attaque = 11,
                Defense = 13,
                AttaqueSpe = 13,
                DefenseSpe = 14,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/137.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/137.png",
                Description = "Un Pokémon virtuel créé par ordinateur.",
                Exp = 0,
                ExpDonnee = 130,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." },
        new Attaque { Nom = "Rafale Psy", Type = TypePokemon.Psy, PP = 20, PPMax = 20, Puissance = 12, Description = "Attaque Psy." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 30, Move = new Attaque{ Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." } }
    }
            },
            ["Amonita"] = new Pokemon
            {
                Numero = 138,
                Nom = "Amonita",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Eau },
                PV = 14,
                PVMax = 14,
                Attaque = 8,
                Defense = 11,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 7,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/138.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/138.png",
                Description = "Pokémon fossile de type Roche/Eau.",
                Exp = 0,
                ExpDonnee = 71,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 40,
                Evolution = "Amonistar",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Jet de Pierre", Type = TypePokemon.Roche, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Roche." },
        new Attaque { Nom = "Pistolet à O", Type = TypePokemon.Eau, PP = 25, PPMax = 25, Puissance = 10, Description = "Attaque de type Eau." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Bulles d'O", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque Eau qui peut ralentir." } }
    }
            },
            ["Amonistar"] = new Pokemon
            {
                Numero = 139,
                Nom = "Amonistar",
                Niveau = 40,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Eau },
                PV = 28,
                PVMax = 28,
                Attaque = 15,
                Defense = 18,
                AttaqueSpe = 15,
                DefenseSpe = 15,
                Vitesse = 11,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/139.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/139.png",
                Description = "Évolution d'Amonita.",
                Exp = 0,
                ExpDonnee = 173,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Jet de Pierre", Type = TypePokemon.Roche, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de type Roche." },
        new Attaque { Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." } }
    }
            },
            ["Kabuto"] = new Pokemon
            {
                Numero = 140,
                Nom = "Kabuto",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Eau },
                PV = 13,
                PVMax = 13,
                Attaque = 9,
                Defense = 10,
                AttaqueSpe = 8,
                DefenseSpe = 8,
                Vitesse = 8,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/140.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/140.png",
                Description = "Pokémon fossile de type Roche/Eau.",
                Exp = 0,
                ExpDonnee = 71,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 40,
                Evolution = "Kabutops",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Jet de Pierre", Type = TypePokemon.Roche, PP = 15, PPMax = 15, Puissance = 10, Description = "Attaque de type Roche." },
        new Attaque { Nom = "Bulles d'O", Type = TypePokemon.Eau, PP = 20, PPMax = 20, Puissance = 10, Description = "Attaque Eau qui peut ralentir." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 20, Move = new Attaque{ Nom = "Griffe", Type = TypePokemon.Normal, PP = 35, PPMax = 35, Puissance = 6, Description = "Attaque physique rapide." } }
    }
            },
            ["Kabutops"] = new Pokemon
            {
                Numero = 141,
                Nom = "Kabutops",
                Niveau = 40,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Eau },
                PV = 26,
                PVMax = 26,
                Attaque = 18,
                Defense = 15,
                AttaqueSpe = 13,
                DefenseSpe = 14,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/141.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/141.png",
                Description = "Évolution de Kabuto.",
                Exp = 0,
                ExpDonnee = 175,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Tranche", Type = TypePokemon.Normal, PP = 20, PPMax = 20, Puissance = 15, Description = "Attaque physique puissante." },
        new Attaque { Nom = "Jet de Pierre", Type = TypePokemon.Roche, PP = 15, PPMax = 15, Puissance = 15, Description = "Attaque de type Roche." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Hydrocanon", Type = TypePokemon.Eau, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque ultime de type Eau." } }
    }
            },
            ["Ptéra"] = new Pokemon
            {
                Numero = 142,
                Nom = "Ptéra",
                Niveau = 40,
                Types = new List<TypePokemon> { TypePokemon.Roche, TypePokemon.Vol },
                PV = 30,
                PVMax = 30,
                Attaque = 18,
                Defense = 13,
                AttaqueSpe = 13,
                DefenseSpe = 12,
                Vitesse = 20,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/142.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/142.png",
                Description = "Pokémon fossile de type Roche/Vol.",
                Exp = 0,
                ExpDonnee = 202,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Aéroblast", Type = TypePokemon.Vol, PP = 5, PPMax = 5, Puissance = 30, Description = "Attaque Vol puissante." },
        new Attaque { Nom = "Morsure", Type = TypePokemon.Ténèbres, PP = 25, PPMax = 25, Puissance = 15, Description = "Attaque de type Ténèbres." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." } }
    }
            },
            ["Ronflex"] = new Pokemon
            {
                Numero = 143,
                Nom = "Ronflex",
                Niveau = 40,
                Types = new List<TypePokemon> { TypePokemon.Normal },
                PV = 48,
                PVMax = 48,
                Attaque = 20,
                Defense = 18,
                AttaqueSpe = 14,
                DefenseSpe = 18,
                Vitesse = 8,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/143.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/143.png",
                Description = "Un Pokémon très paresseux mais redoutable quand il s'éveille.",
                Exp = 0,
                ExpDonnee = 189,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Repos", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 0, Description = "Le lanceur récupère tous ses PV et s'endort." },
        new Attaque { Nom = "Coup d'Boule", Type = TypePokemon.Normal, PP = 15, PPMax = 15, Puissance = 20, Description = "Attaque puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 50, Move = new Attaque{ Nom = "Lance-Soleil", Type = TypePokemon.Plante, PP = 10, PPMax = 10, Puissance = 30, Description = "Attaque Plante puissante." } }
    }
            },
            
            ["Artikodin"] = new Pokemon
            {
                Numero = 144,
                Nom = "Artikodin",
                Niveau = 50,
                Types = new List<TypePokemon> { TypePokemon.Glace, TypePokemon.Vol },
                PV = 38,
                PVMax = 38,
                Attaque = 17,
                Defense = 18,
                AttaqueSpe = 20,
                DefenseSpe = 20,
                Vitesse = 15,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/144.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/144.png",
                Description = "Oiseau légendaire de glace.",
                Exp = 0,
                ExpDonnee = 261,
                Espece = EspecePokemon.Legendaire,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Laser Glace", Type = TypePokemon.Glace, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Glace puissante." },
        new Attaque { Nom = "Piqué", Type = TypePokemon.Vol, PP = 15, PPMax = 15, Puissance = 30, Description = "Attaque Vol puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 70, Move = new Attaque{ Nom = "Blizzard", Type = TypePokemon.Glace, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de glace." } }
    }
            },
            ["Électhor"] = new Pokemon
            {
                Numero = 145,
                Nom = "Électhor",
                Niveau = 50,
                Types = new List<TypePokemon> { TypePokemon.Electrik, TypePokemon.Vol },
                PV = 38,
                PVMax = 38,
                Attaque = 18,
                Defense = 16,
                AttaqueSpe = 20,
                DefenseSpe = 18,
                Vitesse = 20,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/145.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/145.png",
                Description = "Oiseau légendaire de foudre.",
                Exp = 0,
                ExpDonnee = 261,
                Espece = EspecePokemon.Legendaire,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Fatal-Foudre", Type = TypePokemon.Electrik, PP = 5, PPMax = 5, Puissance = 35, Description = "Attaque Electrik très puissante." },
        new Attaque { Nom = "Piqué", Type = TypePokemon.Vol, PP = 15, PPMax = 15, Puissance = 30, Description = "Attaque Vol puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 70, Move = new Attaque{ Nom = "Tonnerre", Type = TypePokemon.Electrik, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Electrik puissante." } }
    }
            },
            ["Sulfura"] = new Pokemon
            {
                Numero = 146,
                Nom = "Sulfura",
                Niveau = 50,
                Types = new List<TypePokemon> { TypePokemon.Feu, TypePokemon.Vol },
                PV = 38,
                PVMax = 38,
                Attaque = 20,
                Defense = 17,
                AttaqueSpe = 20,
                DefenseSpe = 18,
                Vitesse = 17,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/146.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/146.png",
                Description = "Oiseau légendaire de feu.",
                Exp = 0,
                ExpDonnee = 261,
                Espece = EspecePokemon.Legendaire,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Lance-Flammes", Type = TypePokemon.Feu, PP = 15, PPMax = 15, Puissance = 25, Description = "Attaque de feu très puissante." },
        new Attaque { Nom = "Piqué", Type = TypePokemon.Vol, PP = 15, PPMax = 15, Puissance = 30, Description = "Attaque Vol puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 70, Move = new Attaque{ Nom = "Déflagration", Type = TypePokemon.Feu, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque ultime de feu." } }
    }
            },
            ["Minidraco"] = new Pokemon
            {
                Numero = 147,
                Nom = "Minidraco",
                Niveau = 5,
                Types = new List<TypePokemon> { TypePokemon.Dragon },
                PV = 15,
                PVMax = 15,
                Attaque = 8,
                Defense = 8,
                AttaqueSpe = 10,
                DefenseSpe = 10,
                Vitesse = 10,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/147.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/147.png",
                Description = "Un Pokémon Dragon rare.",
                Exp = 0,
                ExpDonnee = 67,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 30,
                Evolution = "Draco",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Draco-Rage", Type = TypePokemon.Dragon, PP = 10, PPMax = 10, Puissance = 15, Description = "Attaque Dragon." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 15, Move = new Attaque{ Nom = "Ouragan", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 12, Description = "Attaque Vol puissante." } }
    }
            },
            ["Draco"] = new Pokemon
            {
                Numero = 148,
                Nom = "Draco",
                Niveau = 30,
                Types = new List<TypePokemon> { TypePokemon.Dragon },
                PV = 26,
                PVMax = 26,
                Attaque = 13,
                Defense = 13,
                AttaqueSpe = 15,
                DefenseSpe = 15,
                Vitesse = 15,
                Stade = StadeEvolution.Stade2,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/148.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/148.png",
                Description = "Évolution de Minidraco.",
                Exp = 0,
                ExpDonnee = 144,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = 55,
                Evolution = "Dracolosse",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Draco-Rage", Type = TypePokemon.Dragon, PP = 10, PPMax = 10, Puissance = 20, Description = "Attaque Dragon." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 40, Move = new Attaque{ Nom = "Ouragan", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 20, Description = "Attaque Vol puissante." } }
    }
            },
            ["Dracolosse"] = new Pokemon
            {
                Numero = 149,
                Nom = "Dracolosse",
                Niveau = 55,
                Types = new List<TypePokemon> { TypePokemon.Dragon, TypePokemon.Vol },
                PV = 38,
                PVMax = 38,
                Attaque = 22,
                Defense = 18,
                AttaqueSpe = 20,
                DefenseSpe = 18,
                Vitesse = 18,
                Stade = StadeEvolution.Stade3,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/149.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/149.png",
                Description = "Évolution finale de Minidraco.",
                Exp = 0,
                ExpDonnee = 270,
                Espece = EspecePokemon.Classique,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Draco-Rage", Type = TypePokemon.Dragon, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Dragon." },
        new Attaque { Nom = "Ouragan", Type = TypePokemon.Vol, PP = 20, PPMax = 20, Puissance = 22, Description = "Attaque Vol puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 70, Move = new Attaque{ Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." } }
    }
            },
            ["Mewtwo"] = new Pokemon
            {
                Numero = 150,
                Nom = "Mewtwo",
                Niveau = 70,
                Types = new List<TypePokemon> { TypePokemon.Psy },
                PV = 40,
                PVMax = 40,
                Attaque = 20,
                Defense = 18,
                AttaqueSpe = 30,
                DefenseSpe = 22,
                Vitesse = 24,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/150.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/150.png",
                Description = "Pokémon Psy légendaire issu de manipulations génétiques.",
                Exp = 0,
                ExpDonnee = 306,
                Espece = EspecePokemon.Legendaire,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Psyko", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Psy puissante." },
        new Attaque { Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 80, Move = new Attaque{ Nom = "Exploforce", Type = TypePokemon.Combat, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque Combat très puissante." } }
    }
            },
            ["Mew"] = new Pokemon
            {
                Numero = 151,
                Nom = "Mew",
                Niveau = 50,
                Types = new List<TypePokemon> { TypePokemon.Psy },
                PV = 35,
                PVMax = 35,
                Attaque = 16,
                Defense = 16,
                AttaqueSpe = 16,
                DefenseSpe = 16,
                Vitesse = 16,
                Stade = StadeEvolution.Stade1,
                ImageFace = "pack://application:,,,/view/image/Pokemon_asset/Front/151.png",
                ImageDos = "pack://application:,,,/view/image/Pokemon_asset/Back/151.png",
                Description = "Pokémon fabuleux, base de l’ADN de Mewtwo.",
                Exp = 0,
                ExpDonnee = 270,
                Espece = EspecePokemon.Legendaire,
                NiveauEvolution = null,
                Evolution = "",
                Attaques = new List<Attaque>
    {
        new Attaque { Nom = "Psyko", Type = TypePokemon.Psy, PP = 10, PPMax = 10, Puissance = 25, Description = "Attaque Psy puissante." },
        new Attaque { Nom = "Métamorphose", Type = TypePokemon.Normal, PP = 10, PPMax = 10, Puissance = 0, Description = "Change de forme." }
    },
                LevelUpMoves = new List<Pokemon.LevelUpMove>
    {
        new Pokemon.LevelUpMove { Level = 70, Move = new Attaque{ Nom = "Ultralaser", Type = TypePokemon.Normal, PP = 5, PPMax = 5, Puissance = 40, Description = "Attaque très puissante." } }
    }
            },
        };

        public static Pokemon GetData(string nom)
        {
            return Data.ContainsKey(nom) ? Data[nom] : null;
        }
    }
}
