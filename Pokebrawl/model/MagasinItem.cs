using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class MagasinItem
    {
        public string Nom { get; set; }
        public string Image { get; set; }
        public int Prix { get; set; }
        public ItemType Type { get; set; }
    }

    public enum ItemType
    {
        Potion,
        Ball
    }
}
