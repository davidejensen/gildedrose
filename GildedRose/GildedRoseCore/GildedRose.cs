namespace GildedRoseCore;

public class GildedRose
{
    public static void UpdateQuality(List<Item> items) {
        for (int i = 0; i < items.Count; i++) {
            var item = items[i];
            item.Update();
        }
    }
}