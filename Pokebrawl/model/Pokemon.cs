using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Pokemon
    {
        public int Numero { get; set; }
        public string Nom { get; set; } = string.Empty;
        public int Niveau { get; set; } = 5;
        public List<TypePokemon> Types { get; set; } = new();
        public int PV { get; set; } = 10;
        public int PVMax { get; set; } = 10;
        public int Attaque { get; set; } = 5;
        public int Defense { get; set; } = 5;
        public int AttaqueSpe { get; set; } = 5;
        public int DefenseSpe { get; set; } = 5;
        public int Vitesse { get; set; } = 5;
        public List<Attaque> Attaques { get; set; } = new();
        public StadeEvolution Stade { get; set; } = StadeEvolution.Stade1;
        public string ImageFace { get; set; } = string.Empty;
        public string ImageDos { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Exp { get; set; } = 0;
        public int ExpDonnee { get; set; } = 5;
        public EspecePokemon Espece { get; set; } = EspecePokemon.Classique;
        public int CoutEquipe { get; set; } = 2;

        public string Evolution { get; set; } = string.Empty;
        public int? NiveauEvolution { get; set; }
        public List<LevelUpMove> LevelUpMoves { get; set; } = new();

        public class LevelUpMove
        {
            public int Level { get; set; }
            public Attaque Move { get; set; }
        }

        public void GainExp(int expGagne)
        {
            this.Exp += expGagne;
            while (this.Exp >= ExpPourNiveauSuivant())
            {
                this.Exp -= ExpPourNiveauSuivant();
                this.Niveau++;
                // Vérifie l'évolution
                if (PeutEvoluer() && this.Niveau >= NiveauEvolution)
                {
                    Evoluer(this);
                }
                // Vérifie capacité à apprendre
                var nouvelle = ChercheNouvelleAttaque();
                if (nouvelle != null)
                {
                    if (this.Attaques.Count < 4)
                    {
                        this.Attaques.Add(nouvelle);
                    }
                    else
                    {
                        // Appelle l'événement pour demander le remplacement
                        PokemonEvents.OnDemandeRemplacementCapacite?.Invoke(this, nouvelle);
                        // Ne rien ajouter, attend la page pour effectuer le remplacement
                    }
                }
            }
        }

        public int ExpPourNiveauSuivant()
        {
            return Niveau * 20;
        }
        private bool PeutEvoluer()
        {
            // Vérifie si le Pokémon a une évolution définie
            if (string.IsNullOrEmpty(this.Evolution))
                return false;

            // Vérifie si le niveau est suffisant
            return (this.Niveau >= this.NiveauEvolution && this.Evolution !=null);
        }
        public void Evoluer(Pokemon pokemon)
        {
            // Vérifie si le niveau est suffisant pour évoluer
            if (pokemon.Niveau >= pokemon.NiveauEvolution && !string.IsNullOrEmpty(pokemon.Evolution))
            {
                Console.WriteLine($"{pokemon.Nom} évolue en {pokemon.Evolution} !");

                // Récupère le Pokémon dans la base correspondant à l'évolution
                if (PokemonDatabase.Data.TryGetValue(pokemon.Evolution, out Pokemon evolutionData))
                {
                    // Copie les infos de l'évolution
                    pokemon.Nom = evolutionData.Nom;
                    pokemon.Numero = evolutionData.Numero;
                    pokemon.Types = new List<TypePokemon>(evolutionData.Types);
                    pokemon.PVMax = evolutionData.PVMax;
                    pokemon.PV = pokemon.PVMax;
                    pokemon.Attaque = evolutionData.Attaque;
                    pokemon.Defense = evolutionData.Defense;
                    pokemon.AttaqueSpe = evolutionData.AttaqueSpe;
                    pokemon.DefenseSpe = evolutionData.DefenseSpe;
                    pokemon.Vitesse = evolutionData.Vitesse;
                    pokemon.Stade = evolutionData.Stade;
                    pokemon.ImageFace = evolutionData.ImageFace;
                    pokemon.ImageDos = evolutionData.ImageDos;
                    pokemon.Description = evolutionData.Description;
                    pokemon.NiveauEvolution = evolutionData.NiveauEvolution;
                    pokemon.Evolution = evolutionData.Evolution;

                }
                else
                {
                    Console.WriteLine($"Erreur : données d'évolution pour {pokemon.Evolution} introuvables.");
                }
            }
            else
            {
                Console.WriteLine($"{pokemon.Nom} ne peut pas encore évoluer.");
            }
        }
        private Attaque ChercheNouvelleAttaque()
        {
            foreach (var lvlMove in LevelUpMoves)
            {
                // Conditions :
                // - ce niveau n'a pas encore été dépassé
                // - attaque pas déjà connue (par Nom)
                if (lvlMove.Level == this.Niveau
                    && !this.Attaques.Any(a => a.Nom == lvlMove.Move.Nom))
                {
                    // On retourne une COPIE de l'attaque à apprendre
                    return new Attaque
                    {
                        Nom = lvlMove.Move.Nom,
                        Type = lvlMove.Move.Type,
                        Puissance = lvlMove.Move.Puissance,
                        PP = lvlMove.Move.PPMax,
                        PPMax = lvlMove.Move.PPMax,
                        Description = lvlMove.Move.Description
                    };
                }
            }
            // Sinon, rien à apprendre à ce niveau
            return null;
        }

        public void MonterNiveauAuto(int niveauCible)
        {
            
            while (Niveau < niveauCible)
            {
                Niveau++;
                PVMax += 2; PV += 2;
                Attaque += 1;
                Defense += 1;
                AttaqueSpe += 1;
                DefenseSpe += 1;
                Vitesse += 1;
                ExpDonnee += 3;
                
            }
        }
        public static Pokemon BossEtage100 => new Pokemon
        {
            Nom = "Kirby",
            Niveau = 95,
            PV = 600,
            PVMax = 600,
            Attaque = 200,
            Defense = 200,
            AttaqueSpe = 200,
            DefenseSpe = 200,
            Vitesse = 200,
            Types = new List<TypePokemon> { TypePokemon.Psy },
            ImageFace = "/view/image/Pokemon_Asset/Kirby/bossKirby.png",
            CoutEquipe = 4,
            ExpDonnee = 5000,
        };
        public Pokemon Clone()
        {
            return new Pokemon
            {
                Numero = this.Numero,
                Nom = this.Nom,
                Niveau = this.Niveau,
                Types = new List<TypePokemon>(this.Types),
                PV = this.PVMax, // Full PV au début d'une session de combat
                PVMax = this.PVMax,
                Attaque = this.Attaque,
                Defense = this.Defense,
                AttaqueSpe = this.AttaqueSpe,
                DefenseSpe = this.DefenseSpe,
                Vitesse = this.Vitesse,
                Stade = this.Stade,
                ImageFace = this.ImageFace,
                ImageDos = this.ImageDos,
                Description = this.Description,
                Exp = this.Exp,
                ExpDonnee = this.ExpDonnee,
                Espece = this.Espece,
                CoutEquipe = this.CoutEquipe,
                Evolution = this.Evolution,
                NiveauEvolution = this.NiveauEvolution,
                Attaques = this.Attaques?.Select(a => new Attaque
                {
                    Nom = a.Nom,
                    Type = a.Type,
                    Puissance = a.Puissance,
                    PP = a.PPMax,
                    PPMax = a.PPMax,
                    Description = a.Description
                }).ToList() ?? new List<Attaque>(),
                LevelUpMoves = this.LevelUpMoves?.Select(m => new LevelUpMove
                {
                    Level = m.Level,
                    Move = new Attaque
                    {
                        Nom = m.Move.Nom,
                        Type = m.Move.Type,
                        Puissance = m.Move.Puissance,
                        PP = m.Move.PPMax,
                        PPMax = m.Move.PPMax,
                        Description = m.Move.Description
                    }
                }).ToList() ?? new List<LevelUpMove>()
            };
        }
    }
}
