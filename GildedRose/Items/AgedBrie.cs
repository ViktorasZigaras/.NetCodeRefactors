namespace GildedRose
{
    public class AgedBrie : ConvertedItem
    {
        public override void UpdateQuality()
        {
            SellIn--;
            Quality += SellIn >= 0 ? 1 : 2;
            ApplyMaxQuality();
        }  
    }
}
