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
            IncreaseQuality();
            
            if (GetSellIn() < 11)
            {
                if (GetQuality() < 50)
                {
                    IncreaseQuality();
                }
            }

            if (GetSellIn() < 6)
            {
                if (GetQuality() < 50)
                {
                    IncreaseQuality();
                }
            }
        }
    }

    private void IncreaseQuality()
    {
        SetQuality(GetQuality() + 1);
    }

    protected override void UpdateSellIn()
    {
        base.UpdateSellIn();

        if (GetSellIn() < 0)
        {
            SetQuality(0);
        }
    }
}