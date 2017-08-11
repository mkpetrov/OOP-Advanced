using System;

using System.Collections.Generic;

using System.Linq;

using System.Reflection;

using System.Text;

using System.Threading.Tasks;



namespace CardPower

{

    public class Program

    {

        public static void Main(string[] args)

        {





        }



        public static void CardsCompare()

        {

            var rankInput = Console.ReadLine();

            var suitInput = Console.ReadLine();

            CardRank rank = (CardRank)Enum.Parse(typeof(CardRank), rankInput);

            CardSuit suit = (CardSuit)Enum.Parse(typeof(CardSuit), suitInput);

            Card cardOne = new Card(suit, rank);

            var rankInput2 = Console.ReadLine();

            var suitInput2 = Console.ReadLine();

            CardRank rank2 = (CardRank)Enum.Parse(typeof(CardRank), rankInput2);

            CardSuit suit2 = (CardSuit)Enum.Parse(typeof(CardSuit), suitInput2);

            Card cardTwo = new Card(suit2, rank2);

            List<Card> cards = new List<Card>();

            cards.Add(cardOne);

            cards.Add(cardTwo);

            Card resultCard = cards.OrderByDescending(c => c).First();

            Console.WriteLine(resultCard.ToString());

        }

        public static void CustomEnumAttribute()

        {

            var enumType = Console.ReadLine();



            Type type = null;

            if (enumType == "Rank")

            {

                type = typeof(CardRank);

            }

            else

            {

                type = typeof(CardSuit);

            }

            var attributes = type.GetCustomAttributes(true);



            foreach (var attribute in attributes)

            {

                Console.WriteLine(attribute.ToString());

            }

        }

        public static void CardGame()

        {

            Dictionary<string, List<Card>> players = new Dictionary<string, List<Card>>();

            List<Card> usedCards = new List<Card>();



            var player1 = Console.ReadLine();

            players.Add(player1, new List<Card>());

            var player2 = Console.ReadLine();

            players.Add(player2, new List<Card>());



            while (players[player1].Count != 5)

            {

                var tokens = Console.ReadLine().Split();

                try

                {

                    CardRank rankC = (CardRank)Enum.Parse(typeof(CardRank), tokens[0]);

                    CardSuit suitC = (CardSuit)Enum.Parse(typeof(CardSuit), tokens[2]);

                    Card card = new Card(suitC, rankC);

                    if (usedCards.Where(c => c.Rank == rankC).Where(c => c.Suit == suitC).Count() == 0)

                    {

                        players[player1].Add(card);

                        usedCards.Add(card);

                    }

                    else

                    {

                        Console.WriteLine("Card is not in the deck.");

                    }



                }

                catch (Exception)

                {

                    Console.WriteLine("No such card exists.");

                }

            }

            while (players[player2].Count != 5)

            {

                var tokens = Console.ReadLine().Split();

                try

                {

                    CardRank rankC = (CardRank)Enum.Parse(typeof(CardRank), tokens[0]);

                    CardSuit suitC = (CardSuit)Enum.Parse(typeof(CardSuit), tokens[2]);

                    Card card = new Card(suitC, rankC);

                    if (usedCards.Where(c => c.Rank == rankC).Where(c => c.Suit == suitC).Count() == 0)

                    {

                        players[player2].Add(card);

                        usedCards.Add(card);

                    }

                    else

                    {

                        Console.WriteLine("Card is not in the deck.");

                    }

                }

                catch (Exception)

                {

                    Console.WriteLine("No such card exists.");

                }

            }



            Card playerOneBiggestCard = players[player1].OrderByDescending(p => p.Power).First();

            Card playerTwoBiggestCard = players[player2].OrderByDescending(p => p.Power).First();

            if (playerOneBiggestCard.Power > playerTwoBiggestCard.Power)

            {

                Console.WriteLine($"{player1} wins with {playerOneBiggestCard.Rank} of {playerOneBiggestCard.Suit}.");

            }

            else

            {

                Console.WriteLine($"{player2} wins with {playerTwoBiggestCard.Rank} of {playerTwoBiggestCard.Suit}.");

            }

        }





    }

}