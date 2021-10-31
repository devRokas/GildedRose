namespace GildedRose.Processors
{
    public class AgedBrieProcessor : BaseItemProcessor
    {
        public override void UpdateQuality(Item item)
        {
            if (--item.SellIn < 0)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }

            LimitQuality(item);
        }
    }
}