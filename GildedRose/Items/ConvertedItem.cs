using GildedRose.Interfaces;

namespace GildedRose
{
    public abstract class ConvertedItem : Item, IConvertedItem
    {
        public ConvertedItem (string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        protected const int MaxQuality = 50;
        protected const int MinQuality = 0;
        public abstract void UpdateQuality();

        /*protected void ApplyMinQuality()
        {
            if (Quality < MinQuality) Quality = MinQuality;
        }*/

        protected void ApplyMaxQuality()
        {
            if (Quality > MaxQuality) Quality = MaxQuality;
        }

        public void ApplyMinQuality()
        {
            if (Quality < MinQuality) Quality = MinQuality;
        }
    }
}
