using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Joueur
    {
        public string Nom { get; set; }
        public string Avatar { get; set; }
        public Equipe Equipe { get; set; } = new Equipe();
        public int Argent { get; set; }
        public int Balls { get; set; }
        public List<Objet> Objets { get; set; } = new List<Objet>();
        public int CombatEnCours { get; set; } = 1;
        public Inventaire Inventaire { get; set; } = new();
    }
}
