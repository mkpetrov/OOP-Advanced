using System;

using System.Collections.Generic;

using System.Globalization;

using System.Linq;

using System.Reflection;

using System.Text;

using System.Threading.Tasks;

using _03BarracksFactory.Contracts;



namespace BarrackWars___A_New_Factory.Core

{

    public class CommandInterpreter : ICommandInterpreter

    {

        private const string CommandSuffix = "Command";



        private IRepository repository;

        private IUnitFactory unitFactory;



        public CommandInterpreter

            (IRepository repository, IUnitFactory unitFactory)

        {

            this.repository = repository;

            this.unitFactory = unitFactory;

        }



        public IExecutable InterpretCommand(string[] data, string commandName)

        {

            string commandCompName = CultureInfo.CurrentCulture

                                         .TextInfo.ToTitleCase(commandName) + CommandSuffix;







            Type commandType = Assembly.GetExecutingAssembly()

                .GetTypes().FirstOrDefault(t => t.Name == commandCompName);



            object[] commandParams =

            {

                data,

                this.repository,

                this.unitFactory

            };



            if (commandType == null)

            {

                throw new InvalidOperationException("No such units in repository.");

            }



            return (IExecutable)Activator.CreateInstance(commandType, commandParams);





        }

    }

}