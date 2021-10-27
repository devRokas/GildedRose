namespace GildedRose.Items
{
    public class NormalItem : BaseItem
    {
        public NormalItem(Item item) : base(item)
        {
        }
        
        public override void UpdateItemQuality()
        {
            if (--Item.SellIn < 0)
            {
                Item.Quality -= 2;
            }
            else
            {
                Item.Quality--;
            }
            
            LimitQuality();
        }
    }
}