namespace GildedRose
{
    public class ArtifactItem : ConvertedItem
    {
        public ArtifactItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality()
        {
            // Sulfuras the artifact is static in quality over time
        }  
    }
}
