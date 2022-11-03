using System.Collections.Generic;
using GildedRoseCore;
using NUnit.Framework;

namespace GildedRoseTests;

public class AgedBrieUpdateQualityTest
{
    [Test]
    public void IncreasesQualityTheOlderItGets()
    {
        Item agedBrie = new Item("Aged Brie", 1, 1);

        GildedRose.UpdateQuality(new List<Item>{agedBrie});
        
        Assert.AreEqual(2, agedBrie.GetQuality());
    }
    
    [Test]
    public void NeverIncreasesOver50()
    {
        Item agedBrie = new Item("Aged Brie", 1, 50);

        GildedRose.UpdateQuality(new List<Item>{agedBrie});
        
        Assert.AreEqual(50, agedBrie.GetQuality());
    }
}