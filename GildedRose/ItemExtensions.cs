using GildedRose.Items;

namespace GildedRose
{
    public static class ItemExtensions
    {
        public static BaseItem MapToSpecificItem(this Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new AgedBrieItem(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackStagePassItem(item),
                "Sulfuras, Hand of Ragnaros" => new LegendaryItem(item),
                "Conjured Mana Cake" => new ConjuredManaCakeItem(item),
                _ => new NormalItem(item)
            };
        }
    }
}