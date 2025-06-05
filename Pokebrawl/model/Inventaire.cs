using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Inventaire
    {
        public Dictionary<string, int> ObjetsPossedes { get; set; } = new();

        public void Ajouter(string nomObjet, int quantite = 1)
        {
            if (ObjetsPossedes.ContainsKey(nomObjet))
                ObjetsPossedes[nomObjet] += quantite;
            else
                ObjetsPossedes[nomObjet] = quantite;
        }
        public bool Possede(string nomObjet) => ObjetsPossedes.ContainsKey(nomObjet) && ObjetsPossedes[nomObjet] > 0;
        public bool Retirer(string nomObjet, int quantite = 1)
        {
            if (!Possede(nomObjet)) return false;
            ObjetsPossedes[nomObjet] -= quantite;
            if (ObjetsPossedes[nomObjet] <= 0)
                ObjetsPossedes.Remove(nomObjet);
            return true;
        }
    }
}
