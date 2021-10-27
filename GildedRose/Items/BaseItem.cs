namespace GildedRose.Items
{
    public abstract class BaseItem
    {
        protected readonly Item Item;

        protected BaseItem(Item item)
        {
            Item = item;
        }
        
        public abstract void UpdateItemQuality();

        protected void LimitQuality()
        {
            Item.Quality = Item.Quality < 0 ? 0 : Item.Quality;
            Item.Quality = (Item.Quality > 50) ? 50 : Item.Quality;
        }
    }
}