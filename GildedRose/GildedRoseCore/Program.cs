// See https://aka.ms/new-console-template for more information

using GildedRoseCore;

List<Item> items = new List<Item>();

items.Add(new Item("+5 Dexterity Vest", 10, 20));
items.Add(new Item("Aged Brie", 2, 0));
items.Add(new Item("Elixir of the Mongoose", 5, 7));
items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
items.Add(new Item("Conjured Mana Cake", 3, 6));

GildedRose.UpdateQuality(items);

foreach (var item in items)
{
    Console.WriteLine("Item: " + item.name + ",Quality: " + item.quality + ",SellIn: " + item.sellIn);
}