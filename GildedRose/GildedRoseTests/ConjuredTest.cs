using System.Collections.Generic;
using GildedRoseCore;
using NUnit.Framework;

namespace GildedRoseTests;

public class ConjuredTest
{
    [Test]
    public void DecresesQualityTwiceAsFast()
    {
        Item conjured = new Conjured("Aged Brie", 1, 3);

        GildedRose.UpdateQuality(new List<Item>{conjured});
        
        Assert.AreEqual(1, conjured.GetQuality());
    }
    
    [Test]
    public void DecresesQualityNoLessThanZero()
    {
        Item conjured = new Conjured("Aged Brie", 1, 1);

        GildedRose.UpdateQuality(new List<Item>{conjured});
        
        Assert.AreEqual(0, conjured.GetQuality());
    }
}