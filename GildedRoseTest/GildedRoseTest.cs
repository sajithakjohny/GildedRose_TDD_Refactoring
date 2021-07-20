using System;
using System.Collections.Generic;
using Xunit;

namespace Katas
{
    public class GuildedRoseTest
    {

        [Fact]
        public void testTheTruth()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("+5 Dexterity Vest", 10, 20));
            items.Add(new Item("Aged Brie", 2, 0));
            items.Add(new Item("Elixir of the Mongoose", 5, 7));
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
            items.Add(new Item("Conjured Mana Cake", 3, 6));

            GildedRose.updateQuality(items);
            Assert.True(true);

        }
        [Fact]
        public void testElixir_QualityShoulddecreasebyone()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Elixir of the Mongoose", 5, 7));
            GildedRose.updateQuality(items);
            Assert.Equal( 6, items[0].Quality);
        }
        [Fact]
        public void testSulfurasHandofRagnaros_QualityShouldNotDescrease()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
            GildedRose.updateQuality(items);
            Assert.Equal(80, items[0].Quality);
        }
       
        [Fact]
        public void testBackstageWithSellRate8Qualityis20_QualityShouldIncreasetwo()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 8, 20));
            GildedRose.updateQuality(items);
            Assert.Equal(22, items[0].Quality);
        }
        [Fact]
        public void testBackstageWithSellRate5Qualityis20_QualityShouldIncreasethree()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 5, 20));
            GildedRose.updateQuality(items);
            Assert.Equal(23, items[0].Quality);
        }

        [Fact]
        public void testBackstageWithQualityLessThan50_QualityShouldNotChange()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 34, 40));
            GildedRose.updateQuality(items);
            Assert.Equal(40, items[0].Quality);
        }
        [Fact]
        public void testBackstageWithQuality50_QualityShouldNotChange()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 50, 40));
            GildedRose.updateQuality(items);
            Assert.Equal(40, items[0].Quality);
        }
        [Fact]
        public void testBackstage_SellPriceShouldDecreaseByOne()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 8, 20));
            GildedRose.updateQuality(items);
            Assert.Equal(7, items[0].SellIn);
        }
        [Fact]
        public void testSulfuras_SellPriceShouldNotChange()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 6, 40));
            GildedRose.updateQuality(items);
            Assert.Equal(6, items[0].SellIn);
        }


    }
}
