namespace GildedRose
{
    public class TicketItem : ConvertedItem
    {
        public TicketItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality()
        {
            SellIn--;
            if (SellIn >= 0) Quality += SellIn >= 10 ? 1 : SellIn >= 5 ? 2 : 3;
            else if (Quality != MinQuality) Quality = MinQuality;
            ApplyMaxQuality();
        }  
    }
}
