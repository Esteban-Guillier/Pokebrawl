using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Attaque
    {
        public string Nom { get; set; }
        public int Puissance { get; set; }
        public int UtilisationsMax { get; set; }
        public int UtilisationsRestantes { get; set; }
        public double TauxPrecision { get; set; } // de 0 à 1
        public double TauxCritique { get; set; } // de 0 à 1
        public TypeElement Type { get; set; }
    }
}
