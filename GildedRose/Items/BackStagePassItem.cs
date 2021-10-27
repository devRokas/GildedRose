namespace GildedRose.Items
{
    public class BackStagePassItem : BaseItem
    {
        public BackStagePassItem(Item item) : base(item)
        {
            
        }
        public override void UpdateItemQuality()
        {
            Item.SellIn--;

            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
            else if (Item.SellIn < 5)
            {
                Item.Quality += 3;
            }
            else if (Item.SellIn < 10)
            {
                Item.Quality += 2;
            }
            else
            {
                Item.Quality += 1;
            }
            
            LimitQuality();
        }
    }
}