namespace GildedRoseCore;

public class Conjured : Item
{
    public Conjured(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }

    protected override void UpdateQuality()
    {
        var finalQuality = GetQuality() - 2;
        SetQuality(finalQuality <= 0 ? 0 : finalQuality);
    }
}