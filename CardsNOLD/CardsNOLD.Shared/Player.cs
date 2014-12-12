using System;
using System.Collections.Generic;
using System.Text;

namespace CardsNOLD
{
    public class Player
    {

        public Player()
        {
            _cards = new List<Card>();
        }

        public string Name
        {
            set;
            get;
        }

        private List<Card> _cards;

        public List<Card> Cards
        {
            set;
            get;
        }

    }
}
