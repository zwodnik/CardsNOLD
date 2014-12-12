using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CardsNOLD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            List<Card> card = new List<Card>();
            card.Add(new Card() { Color = "D", Number = 5 });
            card.Add(new Card() { Color = "W", Number = 6 });
            card.Add(new Card() { Color = "Z", Number = 7 });
            card.Add(new Card() { Color = "C", Number = 8 });

            Player player = new Player() { Name="Zodnik", Cards = card };

            CardsListView.ItemsSource = player.Cards;
        }
    }
}
