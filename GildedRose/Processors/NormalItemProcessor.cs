namespace GildedRose.Processors
{
    public class NormalItemProcessor : BaseItemProcessor
    {
        public override void UpdateQuality(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality -= 2;
            }
            else
            {
                item.Quality--;
            }

            LimitQuality(item);
        }
    }
}