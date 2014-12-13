using System;
using System.Collections.Generic;
using System.Text;

namespace CardsNOLD
{
    public static class DataModel
    {
        //W,Z,C,D
        public static List<Card> CardsList(){
            return new List<Card>
            {
                new Card() { Start=true, Number=9, Image = new Uri("ms-appx:///Assets/9c.png"), CanPut=false },
                new Card() { Start=false, Number=9, Image = new Uri("ms-appx:///Assets/9d.png"), CanPut=false },
                new Card() { Start=false, Number=9, Image = new Uri("ms-appx:///Assets/9w.png"), CanPut=false },
                new Card() { Start=false, Number=9, Image = new Uri("ms-appx:///Assets/9z.png"), CanPut=false },
                
                new Card() { Start=false, Number=10, Image = new Uri("ms-appx:///Assets/10c.png"), CanPut=false },
                new Card() { Start=false, Number=10, Image = new Uri("ms-appx:///Assets/10d.png"), CanPut=false },
                new Card() { Start=false, Number=10, Image = new Uri("ms-appx:///Assets/10w.png"), CanPut=false },
                new Card() { Start=false, Number=10, Image = new Uri("ms-appx:///Assets/10z.png"), CanPut=false },

                new Card() { Start=false, Number=11, Image = new Uri("ms-appx:///Assets/11c.png"), CanPut=false },
                new Card() { Start=false, Number=11, Image = new Uri("ms-appx:///Assets/11d.png"), CanPut=false },
                new Card() { Start=false, Number=11, Image = new Uri("ms-appx:///Assets/11w.png"), CanPut=false },
                new Card() { Start=false, Number=11, Image = new Uri("ms-appx:///Assets/11z.png"), CanPut=false },

                new Card() { Start=false, Number=12, Image = new Uri("ms-appx:///Assets/12c.png"), CanPut=false },
                new Card() { Start=false, Number=12, Image = new Uri("ms-appx:///Assets/12d.png"), CanPut=false },
                new Card() { Start=false, Number=12, Image = new Uri("ms-appx:///Assets/12w.png"), CanPut=false },
                new Card() { Start=false, Number=12, Image = new Uri("ms-appx:///Assets/12z.png"), CanPut=false },

                new Card() { Start=false, Number=13, Image = new Uri("ms-appx:///Assets/13c.png"), CanPut=false },
                new Card() { Start=false, Number=13, Image = new Uri("ms-appx:///Assets/13d.png"), CanPut=false },
                new Card() { Start=false, Number=13, Image = new Uri("ms-appx:///Assets/13w.png"), CanPut=false },
                new Card() { Start=false, Number=13, Image = new Uri("ms-appx:///Assets/13z.png"), CanPut=false },

                new Card() { Start=false, Number=14, Image = new Uri("ms-appx:///Assets/14c.png"), CanPut=false },
                new Card() { Start=false, Number=14, Image = new Uri("ms-appx:///Assets/14d.png"), CanPut=false },
                new Card() { Start=false, Number=14, Image = new Uri("ms-appx:///Assets/14w.png"), CanPut=false },
                new Card() { Start=false, Number=14, Image = new Uri("ms-appx:///Assets/14z.png"), CanPut=false },
            };
        }
    }
}
