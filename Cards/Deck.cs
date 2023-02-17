using System;
namespace Cards
{
	public class Deck
	{
        Card[] deckCards = new Card[51];
        int nextCard = 0;

        public Deck()
		{
			for (int i = 0; i < 52; i++)
			{
				Card card = new Card(i);
				deckCards = new Card[card]; 


			}
            nextCard = 0;
        }
		
		public Deck(Card[] existingDeck)
		{
            
            for (int i = 0; i < 52; i++)
			{
				deckCards = new Card[i];
				existingDeck = deckCards;
				
			}
            nextCard = 0;
        }

		

		
		public void Shuffle()
		{
            
            for (int x = 0; x <= 51; x++)
			{
				Random random = new Random(x);
				int num = random.Next();

				deckCards.ToString();
				
            }
			
			
		}

		public Card DealACard()
		{ 
            Card singleCard = deckCards[nextCard]; 
			nextCard++;
			return singleCard;
		}

		public void DealAHand(int handSize)
		{
			
			for (int i = 0; i <= handSize; i++)
			{
				string hand1 = deckCards[nextCard].ToString();
				nextCard++;
            }

            
        }
		
	}
}

