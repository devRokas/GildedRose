namespace GildedRose.Items
{
    public class AgedBrieItem : BaseItem
    {
        public AgedBrieItem(Item item) : base(item)
        {
        }
        
        public override void UpdateItemQuality()
        {
            if (--Item.SellIn < 0)
            {
                Item.Quality += 2;
            }
            else {
                Item.Quality++;
            }
            
            LimitQuality();
        }
    }
}