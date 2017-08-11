using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace CardPower

{

    [AttributeUsage(AttributeTargets.Enum)]

    public class TypeAttribute : Attribute

    {

        public TypeAttribute(string type, string category, string description)

        {

            Type = type;

            Category = category;

            Description = description;

        }



        public string Type { get; }

        public string Category { get; }

        public string Description { get; }

        public override string ToString()

        {

            return $"Type = {this.Type}, Description = {this.Description}";

        }

    }

}