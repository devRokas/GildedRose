namespace GildedRose.Processors
{
    public class ConjuredItemProcessor : BaseItemProcessor
    {
        public override void UpdateQuality(Item item)
        {
            item.SellIn--;
            
            if (item.SellIn < 0)
            {
                item.Quality -= 4;
            }
            else
            {
                item.Quality -= 2;
            }
            
            LimitQuality(item);
        }
    }
}