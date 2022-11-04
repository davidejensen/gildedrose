namespace GildedRoseCore;

public class Item
{
    public string name;
    public int sellIn;
    public int quality;

    public Item(string name, int sellIn, int quality)
    {
        SetName(name);
        SetSellIn(sellIn);
        SetQuality(quality);
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetSellIn()
    {
        return sellIn;
    }

    public void SetSellIn(int sellIn)
    {
        this.sellIn = sellIn;
    }

    public int GetQuality()
    {
        return quality;
    }

    public void SetQuality(int quality)
    {
        this.quality = quality;
    }

    public void Update()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    protected virtual void UpdateQuality()
    {
        if ((!GetName().Equals("Aged Brie")) && !GetName().Equals("Backstage passes to a TAFKAL80ETC concert"))
        {
            if (GetQuality() > 0)
            {
                SetQuality(GetQuality() - 1);
            }
        }
        else
        {
            if (GetQuality() < 50)
            {
                SetQuality(GetQuality() + 1);

                if (GetName().Equals("Backstage passes to a TAFKAL80ETC concert"))
                {
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
    }

    protected virtual  void UpdateSellIn()
    {
        SetSellIn(GetSellIn() - 1);

        if (GetSellIn() < 0)
        {
            if (!GetName().Equals("Aged Brie"))
            {
                if (!GetName().Equals("Backstage passes to a TAFKAL80ETC concert"))
                {
                    if (GetQuality() > 0)
                    {
                        if (!GetName().Equals("Sulfuras, Hand of Ragnaros"))
                        {
                            SetQuality(GetQuality() - 1);
                        }
                    }
                }
                else
                {
                    SetQuality(GetQuality() - GetQuality());
                }
            }
            else
            {
                if (GetQuality() < 50)
                {
                    SetQuality(GetQuality() + 1);
                }
            }
        }
    }
}