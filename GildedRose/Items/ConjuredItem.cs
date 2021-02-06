namespace GildedRose
{
    public class ConjuredItem : ConvertedItem
    {
        public ConjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality) {}

        public override void UpdateQuality()
        {
            SellIn--;
            Quality -= SellIn >= 0 ? 2 : 4;
            ApplyMinQuality();
        }  
    }
}
