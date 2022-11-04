namespace GildedRoseCore;

public class GildedRose
{
    public static void UpdateQuality(List<Item> items) {
        for (int i = 0; i < items.Count; i++) {
            var item = items[i];
            if ((!item.GetName().Equals("Aged Brie")) && !item.GetName().Equals("Backstage passes to a TAFKAL80ETC concert")) {
                if (item.GetQuality() > 0) {
                    if (!item.GetName().Equals("Sulfuras, Hand of Ragnaros")) {
                        item.SetQuality(item.GetQuality() - 1);
                    }
                }
            } else {
                if (item.GetQuality() < 50) {
                    item.SetQuality(item.GetQuality() + 1);

                    if (item.GetName().Equals("Backstage passes to a TAFKAL80ETC concert")) {
                        if (item.GetSellIn() < 11) {
                            if (item.GetQuality() < 50) {
                                item.SetQuality(item.GetQuality() + 1);
                            }
                        }

                        if (item.GetSellIn() < 6) {
                            if (item.GetQuality() < 50) {
                                item.SetQuality(item.GetQuality() + 1);
                            }
                        }
                    }
                }
            }

            if (!item.GetName().Equals("Sulfuras, Hand of Ragnaros")) {
                item.SetSellIn(item.GetSellIn() - 1);
            }

            if (item.GetSellIn() < 0) {
                if (!item.GetName().Equals("Aged Brie")) {
                    if (!item.GetName().Equals("Backstage passes to a TAFKAL80ETC concert")) {
                        if (item.GetQuality() > 0) {
                            if (!item.GetName().Equals("Sulfuras, Hand of Ragnaros")) {
                                item.SetQuality(item.GetQuality() - 1);
                            }
                        }
                    } else {
                        item.SetQuality(item.GetQuality() - item.GetQuality());
                    }
                } else {
                    if (item.GetQuality() < 50) {
                        item.SetQuality(item.GetQuality() + 1);
                    }
                }
            }
        }
    }
}