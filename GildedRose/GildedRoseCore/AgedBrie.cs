namespace GildedRoseCore;

public class AgedBrie : Item
{
    public AgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }

    protected override void UpdateQuality()
    {
        if (GetQuality() >= 50)
            return;
        
        SetQuality(GetQuality() + 1);
    }
}