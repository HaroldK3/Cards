using System;
namespace Cards
{
	public class Deck
	{
        Card[] deckCards = new Card[52];
        int nextCard = 0;

        public Deck()
		{
			for (int i = 0; i < 52; i++)
			{
				Card card = new Card(i);
				deckCards[i] = card;
				
			}
        }
		
		public Deck(Deck existingDeck)
		{
            
            for (int i = 0; i < 52; i++)
			{
                Card card = new Card(i);
                deckCards[i] = card;

				existingDeck = deckCards;

            }
        }

		

		
		public void Shuffle()
		{
            
            for (int x = 0; x <= 51; x++)
			{
				Random random = new Random(x);
				int num = random.Next();

				deckCards.ToString();
				nextCard = 0;
            }
			
			
		}

		public Card DealACard()
		{ 
            Card singleCard = deckCards[nextCard]; 
			nextCard++;
			return singleCard;
		}

		public Card DealAHand(int handSize)
		{
			
        }
		
	}
}

