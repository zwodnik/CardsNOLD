using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace CardsNOLD
{
    public class Card
    {

        public int Number
        {
            set;
            get;
        }

        public bool Start
        {
            set;
            get;
        }

        public Uri Image
        {
            set;
            get;
        }

        public bool CanPut
        {
            get;
            set;
        }

    }
}
