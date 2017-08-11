﻿using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private List<CoffeeType> coffeesSold=new List<CoffeeType>();
    private int coins;

    public IEnumerable<CoffeeType> CoffeesSold => this.coffeesSold;

    public void BuyCoffee(string price, string type)
    {
        CoffeeType coffeeType = (CoffeeType) Enum.Parse(typeof(CoffeeType), type);
        CoffeePrice coffePrice = (CoffeePrice) Enum.Parse(typeof(CoffeePrice), price);

        if (this.coins>=(int)coffePrice)
        {
            this.coffeesSold.Add(coffeeType);
            this.coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        Coin rem = (Coin)Enum.Parse(typeof(Coin), coin);

        this.coins += (int)rem;
    }

    
}