using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJck
{
    public enum CardSuit
    {
        Heart,
        Diamond,
        Spade,
        Club
    }

    public enum CardFace
    {
        ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardFace Face { get; set; }
        public int Value { get; set; }
    }


    public class Deck
    {
        private List<Card> deckOfCards;

        public Deck()
        {
            this.Start();
        }

        /// <summary>
        /// Preparing cards list
        /// </summary>
        public void Start()
        {
            deckOfCards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                   // deckOfCards.Add(new Card() { Suit = (CardSuit)i, Face = (CardFace)j });
                    var context = new BlackJackOnlineEntities();
                    var carddetails = new CardInfo();
                    carddetails.PokerOrder = j + 1;
                    carddetails.Name = Convert.ToString((CardSuit)i) + Convert.ToString( (CardFace)j);
                    carddetails.Image = "~/PNG-cards-1.3/" + Convert.ToString((CardSuit)i) + Convert.ToString((CardFace)j);

                    context.CardInfoes.Add(carddetails);
                    context.SaveChanges();
                }
            }
        }


        /// <summary>
        /// Shuffling the cards
        /// </summary>
        public void CardShuffle()
        {
            Random randCard = new Random();
            int cardCount = deckOfCards.Count;
            while(cardCount > 1)
            {
                cardCount--;
                int nxtCard = randCard.Next(cardCount + 1);
                Card card = deckOfCards[nxtCard];
                deckOfCards[nxtCard] = deckOfCards[cardCount];
                deckOfCards[cardCount] = card;

            }
        }

        /// <summary>
        /// Drawing the card when its user turn
        /// </summary>
        /// <returns></returns>
        public Card DrawACard()
        {
            int count = deckOfCards.Count;
            if(count <=0)
            {
                this.Start();
                this.CardShuffle();

            }

            Card PutDownACard = deckOfCards[count - 1];
            deckOfCards.RemoveAt(deckOfCards.Count - 1);
            return PutDownACard;
        }

        /// <summary>
        /// This method is used just for printing of cards
        /// </summary>
        public void PrintingDeckOfCards()
        {
            int i = 1;
            foreach (Card card in deckOfCards)
            {
                Console.WriteLine("Card {0}: {1} of {2}. Value: {3}", i, card.Face, card.Suit, card.Value);
                i++;
            }
        }

        public int GetLeftOverCards()
        {
            return deckOfCards.Count;
        }


    }


}
