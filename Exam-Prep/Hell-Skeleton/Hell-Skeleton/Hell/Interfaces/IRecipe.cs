using System.Collections.Generic;

public interface IRecipe:IItem
{
    string RecipeName { get; }

    IList<string> RequiredItems { get;  }
}