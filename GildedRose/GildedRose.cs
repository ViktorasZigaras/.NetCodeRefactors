using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        readonly IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                // SF is static
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    // AB increases in value - once
                    if (item.Name == "Aged Brie") IncreaseQuality(item, 1);
                    else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        // BSTT increases value 5 days before - thrice
                        if (item.SellIn < 6) IncreaseQuality(item, 3);
                        // BSTT increases value 10 days before - twice
                        else if (item.SellIn < 11) IncreaseQuality(item, 2);
                        // BSTT increases normally - once
                        else if (item.SellIn > 10) IncreaseQuality(item, 1);
                    }
                    // non tickets and non brie: regular quality drop
                    else DecreaseQuality(item);
                    // regular sell date reduction
                    item.SellIn -= 1;
                    // if sale date is over
                    if (item.SellIn < 0)
                    {
                        // AB increases in value - once
                        if (item.Name == "Aged Brie") IncreaseQuality(item, 1);
                        // BSTT loses value after event
                        else if (item.Quality > 0 && item.Name == "Backstage passes to a TAFKAL80ETC concert") item.Quality = 0;
                        // other goods - advanced quality decay
                        else DecreaseQuality(item);
                    }
                }
            }
        }

        private void IncreaseQuality(Item item, int times)
        {
            // quality is max 50
            if (item.Quality < 50)
            {
                item.Quality++;
                if (--times > 0) IncreaseQuality(item, times);
            }
        }

        private void DecreaseQuality(Item item)
        {
            // CMC decays twice as fast
            if (item.Name == "Conjured Mana Cake") DecreaseQualityTimes(item, 2);
            else DecreaseQualityTimes(item, 1);
        }

        private void DecreaseQualityTimes(Item item, int times)
        {
            // quality is always positive
            if (item.Quality > 0)
            {
                item.Quality--;
                if (--times > 0) DecreaseQualityTimes(item, times);
            }
        }
    }
}

// !!! does brie increase value twice??
// UpdateQuality method - static?
