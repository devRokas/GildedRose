using GildedRose.Processors;

namespace GildedRose
{
    public static class ItemExtensions
    {
        public static BaseItemProcessor MapToItemProcessor(this Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new AgedBrieProcessor(),
                "Sulfuras, Hand of Ragnaros" => new LegendaryItemProcessor(),
                "Backstage passes to a TAFKAL80ETC concert" => new BackStagePassItemProcessor(),
                "Conjured Mana Cake" => new ConjuredItemProcessor(),
                _ => new NormalItemProcessor()
            };
        }
    }
}