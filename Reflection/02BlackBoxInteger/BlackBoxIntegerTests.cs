using System.Linq;
using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    class BlackBoxIntegerTests
    {
        private const BindingFlags NonPulbicFlags = BindingFlags.Instance | BindingFlags.NonPublic;
        static void Main(string[] args)
        {
            var blackBoxType=typeof(BlackBoxInt);
            var myBlackBox = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);

            var input = Console.ReadLine();

            while (input!="END")
            {
                var tokens = input.Split('_');

                var method = tokens[0];
                var value = int.Parse(tokens[1]);

                blackBoxType.GetMethod(method, NonPulbicFlags).Invoke(myBlackBox, new object[] {value});

                var innerValue = blackBoxType.GetFields(NonPulbicFlags).First().GetValue(myBlackBox);

                Console.WriteLine(innerValue);

                input = Console.ReadLine();
            }
        }
    }
}
