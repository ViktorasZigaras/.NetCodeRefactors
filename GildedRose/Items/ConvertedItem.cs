namespace GildedRose
{
    public abstract class ConvertedItem : Item
    {
        protected const int MaxQuality = 50;
        protected const int MinQuality = 0;
        public abstract void UpdateQuality();

        protected void ApplyMinQuality()
        {
            if (Quality < MinQuality) Quality = MinQuality;
        }

        protected void ApplyMaxQuality()
        {
            if (Quality > MaxQuality) Quality = MaxQuality;
        }
    }
}
