using System;
using System.Collections.Generic;
using System.Text;

namespace CardsNOLD
{
    public class Player
    {

        public Player() { }

        public string Name
        {
            set;
            get;
        }

        public List<Card> Cards
        {
            set;
            get;
        }

        public bool CanMove(Card top, Card current)
        {
            return (top.Number <= current.Number) ? true : false;
        }

    }

}
