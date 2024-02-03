using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random Random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++) 
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = Random.Next(1, 5);
            if (value == 1) return "pik";
            if (value == 2) return "kier";
            if (value == 3) return "trefl";
            return "karo";
        }

        private static string RandomValue()
        {
            int value = Random.Next(1, 14);
            if (value == 1) return "As";
            if (value == 11) return "Walet";
            if (value == 12) return "Dama";
            if (value == 13) return "Król";
            return value.ToString();
        }
    }
}
