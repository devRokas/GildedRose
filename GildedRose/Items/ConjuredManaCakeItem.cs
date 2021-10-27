namespace GildedRose.Items
{
    public class ConjuredManaCakeItem : BaseItem
    {
        public ConjuredManaCakeItem(Item item) : base(item)
        {
        }

        public override void UpdateItemQuality()
        {
            if (--Item.SellIn < 0)
            {
                Item.Quality -= 4;
            }
            else
            {
                Item.Quality -= 2;
            }
            
            LimitQuality();
        }
    }
}