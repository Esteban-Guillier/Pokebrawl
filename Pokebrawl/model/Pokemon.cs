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
        public int ExpPourNiveauSuivant { get; set; } = 10;
        public int ExpDonnee { get; set; } = 5;
        public EspecePokemon Espece { get; set; } = EspecePokemon.Classique;
        public int CoutEquipe { get; set; } = 2;
    }
}
