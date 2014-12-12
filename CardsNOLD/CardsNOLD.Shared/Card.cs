using System;
using System.Collections.Generic;
using System.Text;

namespace CardsNOLD
{
    public class Card
    {

        public int Number
        {
            set;
            get;
        }

        public string Color
        {
            set;
            get;
        }

        public Uri Image
        {
            set;
            get;
        }

        public string NumberColor
        {
            get
            {
                return Number + Color;
            }
        }

    }
}
