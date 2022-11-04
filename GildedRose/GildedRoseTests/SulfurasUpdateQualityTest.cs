using System.Collections.Generic;
using GildedRoseCore;
using NUnit.Framework;

namespace GildedRoseTests;

public class SulfurasUpdateQualityTest
{
    [Test]
    public void NeverHasToBeSold()
    {
        Item sulfuras = new Sulfuras("Sulfuras, Hand of Ragnaros", 0, 80);
        
        GildedRose.UpdateQuality(new List<Item> {sulfuras});
        
        Assert.AreEqual(0, sulfuras.GetSellIn());
    }
    
    [Test]
    public void NeverDecreasesQuality() {
        Item sulfuras = new Sulfuras("Sulfuras, Hand of Ragnaros", 0, 80);
        
        GildedRose.UpdateQuality(new List<Item> {sulfuras});
        
        Assert.AreEqual(80, sulfuras.GetQuality());
    }
}