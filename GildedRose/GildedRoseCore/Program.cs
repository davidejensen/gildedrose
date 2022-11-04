// See https://aka.ms/new-console-template for more information

using GildedRoseCore;

List<Item> items = new List<Item>();

items.Add(new Item("+5 Dexterity Vest", 10, 20));
items.Add(new AgedBrie("Aged Brie", 2, 0));
items.Add(new Item("Elixir of the Mongoose", 5, 7));
items.Add(new Sulfuras("Sulfuras, Hand of Ragnaros", 0, 80));
items.Add(new BackstagePasses("Backstage passes to a TAFKAL80ETC concert", 15, 20));
items.Add(new Conjured("Conjured Mana Cake", 3, 6));


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"\n Day {i+1}");
    GildedRose.UpdateQuality(items);

    foreach (var item in items)
    {
        Console.WriteLine($"Item: {item.name}, SellIn: {item.sellIn}, Quality: {item.quality}");
    }
}