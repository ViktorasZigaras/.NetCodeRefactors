namespace GildedRose
{
    public class ElixirOfMongoose : ConvertedItem
    {
        public override void UpdateQuality()
        {
            SellIn--;
            Quality -= SellIn >= 0 ? 1 : 2;
            ApplyMinQuality();
        }  
    }
}
