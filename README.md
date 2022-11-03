# Gilded Rose

We have an inventory system developed by a somewhat quirky and lacking in common sense guy named Leeory, now he's chasing new adventures!

Your task is to add new functionality to the system so that we can start selling a new category of items.

You can do all the refactoring needed, but there is one thing you cannot do:
change the interface of GildedRose class, it's ugly, we know, but we have many systems that use it, and we're not going to change them now!

Lets start with a small introduction to our system:

- All items have a `SellIn` date, which specifies the number of days we have to sell the item.
- All items have a `Quality`, which specifies the value of the item.
- At the end of the day the system reduces both values of each item.

Simple, right? Now the interesting part begins:

- Items degrade quality by one unit for each upgrade.
- When the expiration sell date has passed, the quality degrades at twice the speed.
- The quality of an item is never negative.
- The item "aged brie" increases its quality instead of decreasing it as the days go by.
- The quality of an item is never higher than 50.
- The item "Sulfuras", our most legendary item!, must never be sold or diminish its quality.
- The "backstage passes" increase its quality as the expiration sale date approaches. The quality is increased by two when there are 10 days or less left for the concert, by 3 when there are 5 days or less left. However the quality drops to 0 after the concert.

We have signed a new agreement to sell "conjured" items, however we need a change in the system:

- "Conjured" items decrease in quality twice as fast as the rest.

Have fun!