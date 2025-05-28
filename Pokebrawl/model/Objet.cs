using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Objet
    {
        public class Objet
        {
            public string Nom { get; set; }
            public string Description { get; set; }
            public int Prix { get; set; }
            public int Quantite { get; set; }
            public string Effet { get; set; } // "Soin", "Ball", etc.
            public int Valeur { get; set; } // ex: PV soignés ou taux de capture

            public void Utiliser(Pokemon cible)
            {
                if (Effet == "Soin")
                {
                    cible.PV = System.Math.Min(cible.PVMax, cible.PV + Valeur);
                }
                // Autres effets...
            }
        }

        public static class Boutique
        {
            public static List<Objet> Catalogue = new()
        {
            new Objet { Nom = "Potion", Description = "Soigne 20 PV", Prix = 100, Effet = "Soin", Valeur = 20 },
            new Objet { Nom = "Super Potion", Description = "Soigne 50 PV", Prix = 300, Effet = "Soin", Valeur = 50 },
            new Objet { Nom = "Poké Ball", Description = "Permet de capturer des Pokémon", Prix = 200, Effet = "Ball", Valeur = 1 }
            // Ajoute d'autres objets...
        };
        }
    }

}
