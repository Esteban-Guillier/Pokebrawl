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
        public int? NiveauEvolution { get; set; } // Niveau d'évolution
        public List<LevelUpMove> LevelUpMoves { get; set; } = new(); // Nouvelles attaques par niveau

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
                    Evoluer();
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
                        // Proposer UI pour remplacer attaque (à implémenter, popup)
                    }
                }
            }
        }

        private int ExpPourNiveauSuivant() => 100 + (Niveau - 1) * 50;
        private bool PeutEvoluer() => this.Nom == "Salamèche" && Niveau >= 16; // Par exemple
        private void Evoluer()
        {
            var data = PokemonDatabase.GetData(Evolution);
            if (data != null)
            {
                Nom = data.Nom;
                ImageFace = data.ImageFace;
                ImageDos = data.ImageDos;
                PVMax += 20; // bonus d'évolution
                // Ajoute/maj attaques etc.
            }
        }
        private Attaque ChercheNouvelleAttaque() { /* Retourne une nouvelle attaque à ce niveau si dispo */ return null; }
    

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
