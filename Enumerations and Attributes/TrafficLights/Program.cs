using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace TrafficLights

{

    public class Program

    {

        public static void Main(string[] args)

        {

            string[] initialLights = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);



            List<TrafficLight> trafficLights = new List<TrafficLight>();



            foreach (var light in initialLights)

            {

                trafficLights.Add(new TrafficLight(light));

            }



            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)

            {

                trafficLights.ForEach(l => l.Cycle());



                Console.WriteLine(string.Join(" ", trafficLights));

            }

        }

    }

}