namespace GildedRose
{
    public class DexterityVest : ConvertedItem
    {
        public override void UpdateQuality()
        {
            SellIn--;
            Quality -= SellIn >= 0 ? 1 : 2;
            ApplyMinQuality();
        }  
    }
}
