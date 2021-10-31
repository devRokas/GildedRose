namespace GildedRose.Processors
{
    public abstract class BaseItemProcessor
    {
        private const int MinimumQuality = 0;
        private const int MaximumQuality = 50;
        
        public abstract void UpdateQuality(Item item);

        protected static void LimitQuality(Item item)
        {
            item.Quality = item.Quality < MinimumQuality ? MinimumQuality : item.Quality;
            item.Quality = item.Quality > MaximumQuality ? MaximumQuality : item.Quality;
        }
    }
}