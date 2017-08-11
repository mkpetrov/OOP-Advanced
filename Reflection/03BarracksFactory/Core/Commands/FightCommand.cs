using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using _03BarracksFactory.Contracts;



namespace BarrackWars___A_New_Factory.Core.Commands

{

    public class FightCommand : Command

    {

        public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory)

            : base(data, repository, unitFactory)

        {

        }



        public override string Execute()

        {

            Environment.Exit(0);

            return string.Empty;

        }

    }

}