using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public enum StadeEvolution { Stade1, Stade2, Stade3 }

    public enum Espece { Classique, Legendaire }

    public class Pokemon
    {
        public int Numero { get; set; }
        public string Nom { get; set; }
        public int Niveau { get; set; }
        public List<TypeElement> Types { get; set; }
        public int PV { get; set; }
        public int Attaque { get; set; }
        public int Defense { get; set; }
        public int AttaqueSpe { get; set; }
        public int DefenseSpe { get; set; }
        public int Vitesse { get; set; }
        public List<Attaque> Attaques { get; set; }
        public StadeEvolution Evolution { get; set; }
        public string ImageFace { get; set; }
        public string ImageDos { get; set; }
        public string Description { get; set; }
        public int CoutEquipe { get; set; }
        public int ExpActuelle { get; set; }
        public int ExpNiveauSuivant { get; set; }
        public int ExpDonnee { get; set; }
        public Espece Espece { get; set; }
        Sprite = new BitmapImage(new Uri(p.ImageFace, UriKind.RelativeOrAbsolute))

    }
}
