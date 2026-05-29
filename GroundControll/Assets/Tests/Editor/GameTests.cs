using NUnit.Framework;
using UnityEngine;

public class GameTests
{
    [SetUp]
    public void ResetEconomy()
    {
        Inventory.ScoreIron = 0;
        Inventory.ScoreGold = 0;
        Inventory.ScoreCobalt = 0;
        Inventory.ScoreCredits = 0;
    }

    [Test]
    public void ShopScript_IronAmount_MultipliesPriceByQuantity()
    {
        Selling.IronSell = 20;
        Inventory.ScoreIron = 5;

        Assert.AreEqual(100, ShopScript.IronAmount());
    }

    [Test]
    public void Selling_SellIron_AddsCreditsAndClearsOre()
    {
        Inventory.ScoreCredits = 0;
        Inventory.ScoreIron = 3;
        Selling.IronSell = 20;

        GameObject go = new();
        Selling selling = go.AddComponent<Selling>();

        selling.SellIron();

        Assert.AreEqual(60, Inventory.ScoreCredits, "3 iron at 20 each should be 60 credits");
        Assert.AreEqual(0, Inventory.ScoreIron, "Iron should be empty after selling");

        Object.DestroyImmediate(go);
    }

    [Test]
    public void BuyHealth_Sell_WithoutEnoughCredits_DoesNotDeduct()
    {
        BuyHealth.cost = 200;
        Inventory.ScoreCredits = 50;

        GameObject go = new();
        BuyHealth buy = go.AddComponent<BuyHealth>();

        buy.Sell();

        Assert.AreEqual(50, Inventory.ScoreCredits, "Credits should not change when you can't afford the purchase");

        Object.DestroyImmediate(go);
    }
}