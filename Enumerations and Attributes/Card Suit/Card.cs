using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;







namespace CardPower

{

    public class Card : IComparable<Card>

    {





        public Card(CardSuit suit, CardRank rank)

        {

            this.Suit = suit;

            this.Rank = rank;

            this.Power = (int)this.Rank + (int)this.Suit;

        }



        public int Power { get; }

        public CardRank Rank { get; }

        public CardSuit Suit { get; }



        public override string ToString()

        {

            return $"Card name: {this.Rank} of {this.Suit}; Card power: {(int)this.Rank + (int)this.Suit}";

        }



        public int CompareTo(Card other)

        {

            if (ReferenceEquals(this, other))

            {

                return 0;

            }

            if (ReferenceEquals(null, other))

            {

                return 1;

            }

            var firstResult = (int)this.Rank + (int)this.Suit;

            var secondResult = (int)other.Rank + (int)other.Suit;

            var rankComparison = firstResult.CompareTo(secondResult);

            return rankComparison;

        }

    }

}