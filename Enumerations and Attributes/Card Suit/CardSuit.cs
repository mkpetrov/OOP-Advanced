using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace CardPower

{

    [Type("Enumeration", "Suit", "Provides suit constants for a Card class.")]

    public enum CardSuit

    {

        Clubs,

        Hearts = 26,

        Diamonds = 13,

        Spades = 39

    }

}