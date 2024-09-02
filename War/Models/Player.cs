using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace War.Models
{
    class Player(string _name)
    {
        public List<Card> Cards { get; set; }
        public List<Card> DiscardCards { get; set; }
        String Name { get; set; } = _name;
        public void Shuffle()
        {
            Random random = new Random();
            Cards = Cards.OrderBy(x => random.Next()).ToList();
        }

    }
}
