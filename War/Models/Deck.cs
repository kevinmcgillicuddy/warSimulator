using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War.Models
{
    internal class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            foreach (Suite suite in Enum.GetValues(typeof(Suite)))
            {
              
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    Cards.Add(new Card { Suite = suite, Value = value });
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            Cards = Cards.OrderBy(x => random.Next()).ToList();
        }

    }
}
