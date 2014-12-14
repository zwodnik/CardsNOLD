using System;
using System.Collections.Generic;
using System.Text;

namespace CardsNOLD
{
    class Board
    {
        private List<Card> _allCards;
        private List<Card> _cardsOnTable;

        public Board()
        {
            _players = new List<Player>();
            _players.Add(new Player() { Name="Kamil", Cards = new List<Card>() });
            _players.Add(new Player() { Name = "Tomek", Cards = new List<Card>() });

            _cardsOnTable = new List<Card>();
            _allCards = new List<Card>();
            _allCards = DataModel.CardsList();

            bool selectPlayer = true;
            while(_allCards.Count > 0) 
            {
                if (selectPlayer == true)
                {
                    _players[0].Cards.Add(_randomCard());
                }
                else
                {
                    _players[1].Cards.Add(_randomCard());
                }
                selectPlayer = !selectPlayer;
            }
        }

        private Card _randomCard()
        {
            Random rand = new Random();
            var cardIndex = rand.Next(0, _allCards.Count);
            var card = _allCards[cardIndex];
            _allCards.RemoveAt(cardIndex);
            return card;
        }

        private List<Player> _players;
        public List<Player> Players
        {
            get
            {
                return _players;
            }
        }

    }
}
