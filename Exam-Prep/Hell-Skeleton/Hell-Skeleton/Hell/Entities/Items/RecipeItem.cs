﻿using System;
using System.Collections.Generic;


public class RecipeItem:AbstractItem,IRecipe
{
    public RecipeItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus,IList<string> requiredItems) 
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
    {
        this.RequiredItems = requiredItems;
    }

    public string RecipeName { get; }

    public IList<string> RequiredItems { get; private set; }
}
