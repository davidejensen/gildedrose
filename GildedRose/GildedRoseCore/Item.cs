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
}