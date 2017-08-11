using _03BarracksFactory.Contracts;

using _03BarracksFactory.Core;

using _03BarracksFactory.Core.Factories;

using _03BarracksFactory.Data;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using BarrackWars___A_New_Factory.Core;



namespace BarrackWars___A_New_Factory

{

    public class Program

    {

        public static void Main(string[] args)

        {

            IRepository repository = new UnitRepository();

            IUnitFactory unitFactory = new UnitFactory();

            ICommandInterpreter commandInterpreter

                = new CommandInterpreter(repository, unitFactory);

            IRunnable engine = new Engine(commandInterpreter);

            engine.Run();

        }

    }

}