namespace GildedRoseCore;

public class BackstagePasses : Item
{
    public BackstagePasses(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }

    protected override void UpdateQuality()
    {
        if (GetQuality() < 50)
        {
            SetQuality(GetQuality() + 1);
            if (GetSellIn() < 11)
            {
                if (GetQuality() < 50)
                {
                    SetQuality(GetQuality() + 1);
                }
            }

            if (GetSellIn() < 6)
            {
                if (GetQuality() < 50)
                {
                    SetQuality(GetQuality() + 1);
                }
            }
        }
    }
}