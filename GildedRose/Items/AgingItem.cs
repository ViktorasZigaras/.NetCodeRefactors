namespace GildedRose
{
    public class AgingItem : ConvertedItem
    {
        public AgingItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality()
        {
            SellIn--;
            Quality += SellIn >= 0 ? 1 : 2;
            ApplyMaxQuality();
        }  
    }
}
