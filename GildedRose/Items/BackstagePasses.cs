namespace GildedRose
{
    public class BackstagePasses : ConvertedItem
    {
        public override void UpdateQuality()
        {
            SellIn--;
            if (SellIn >= 0) Quality += SellIn >= 10 ? 1 : SellIn >= 5 ? 2 : 3;
            else if (Quality != MinQuality) Quality = MinQuality;
            ApplyMaxQuality();
        }  
    }
}
