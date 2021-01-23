namespace GildedRose
{
    public class ManaCake : ConvertedItem
    {
        public override void UpdateQuality()
        {
            SellIn--;
            Quality -= SellIn >= 0 ? 2 : 4;
            ApplyMinQuality();
        }  
    }
}
