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
namespace Cards;
public class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("This is the original deck of cards.");
        Deck deck1 = new Deck();

        for (int i = 0; i < 52; i++)
        {
            Console.WriteLine(deck1.DealACard());
        }
        


        Console.WriteLine("This is the original deck shuffled.");

        
        

    }
}