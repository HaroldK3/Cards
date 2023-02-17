/**
*--------------------------------------------------------------------
* File name: 1260-001-HaroldKaylee-Lab2
* Project name: Cards
*--------------------------------------------------------------------
* Author’s name and email: Kaylee Harold | haroldk@etsu.edu
* Course-Section: 001
* Creation Date: 2/6/2023
* -------------------------------------------------------------------
*/
using System;
namespace Cards
{
	public class Card
	{
		private SuitofCard _suit;
		private FaceofCard _face;
		public Deck[] deckCards = new Deck[51];


		//constructors
		public Card()
		{
			SetFace(FaceofCard.Ace);
			SetSuit(SuitofCard.Diamonds);
		}

		public Card(Card existingCard)
		{
			SetFace(existingCard.GetFace());
			SetSuit(existingCard.GetSuit());
		}

		public Card(int n)
		{
            SetFace((FaceofCard)Enum.GetValues(typeof(FaceofCard)).GetValue(n % 13));
            SetSuit((SuitofCard)Enum.GetValues(typeof(SuitofCard)).GetValue(n % 4));
        }

        //methods

        public override string ToString()
        {
			string output = ("The " + _face + " of " + _suit);

			return output;
        }

		public void ShowDeck()
		{
			for (int i = 0; i < 53; i++)
			{
				Card deck = new Card(i);
				Console.WriteLine(deck.ToString());
			}
		}

        //getters and setters

        public FaceofCard GetFace()
		{
			return _face;
		}

		public SuitofCard GetSuit()
		{
			return _suit;
		}

		public void SetFace(FaceofCard face)
		{
			_face = face;
		}
		public void SetSuit(SuitofCard suit)
		{
			_suit = suit;
		}

	}
}

