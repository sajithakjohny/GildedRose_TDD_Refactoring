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
            items.Add(new Item(ItemConstant.Dexterity, 10, 20));
            items.Add(new Item(ItemConstant.Aged, 2, 0));
            items.Add(new Item(ItemConstant.Elixi, 5, 7));
            items.Add(new Item(ItemConstant.Sulfuras, 0, 80));
            items.Add(new Item(ItemConstant.Sulfuras, 15, 20));
            items.Add(new Item(ItemConstant.Conjured, 3, 6));

            GildedRose.updateQuality(items);
            Assert.True(true);

        }
        //"Aged Brie" Test Cases
        
        [Theory]
        [ClassData(typeof(AgedBrieTestData))]
        public void testAgedBrie(Item agedBrieTestDataItem, int expectedScore,int actualScore)
        {
            IList<Item> items = new List<Item>();
            items.Add(agedBrieTestDataItem);
            GildedRose.updateQuality(items);
            Assert.Equal(expectedScore, items[0].Quality);
            Assert.Equal(actualScore, items[0].SellIn);
        }

        /*
        [Fact]
        public void testAgedBrieSellIn2Quality60_ShouldbeQuality50SellIn1()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Aged Brie", 2, 60));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(1, items[0].SellIn);
        }
        [Fact]
        public void testAgedBrieSellIn0Quality60_ShouldbeQuality50SellIn0()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Aged Brie", 0, 60));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(0, items[0].SellIn);
        }
        [Fact]
        public void testAgedBrieSellIn0Quality50_ShouldbeQuality50SellIn0()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Aged Brie", 0, 50));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(0, items[0].SellIn);
        }
        [Fact]
        public void testAgedBrieSellIn4Quality45_ShouldbeQuality46SellIn3()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Aged Brie", 4, 45));
            GildedRose.updateQuality(items);
            Assert.Equal(46, items[0].Quality);
            Assert.Equal(3, items[0].SellIn);
        }
        [Fact]
        public void testAgedBrieSellInMinus4Quality50_ShouldbeQuality50SellInMinus4()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Aged Brie", -4, 60));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(-4, items[0].SellIn);
        }
        [Fact]
        public void testAgedBrieSellIn7QualityMinus40_ShouldbeQuality0SellIn6()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Aged Brie", 7, -4));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(6, items[0].SellIn);
        }
        [Fact]
        public void testAgedBrieSellInMinus4QualityMinus4_ShouldbeQuality0SellInMinus4()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Aged Brie", -4, -4));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(-4, items[0].SellIn);
        }

        */
        //Backstag Test Cases

        [Theory]
        [ClassData(typeof(BackstageTestData))]
        public void testBackstage(Item backstageTestDataItem, int expectedScore, int actualScore)
        {
            IList<Item> items = new List<Item>();
            items.Add(backstageTestDataItem);
            GildedRose.updateQuality(items);
            Assert.Equal(expectedScore, items[0].Quality);
            Assert.Equal(actualScore, items[0].SellIn);
        }

        /*
        [Fact]
        public void testBackstageWithSellIn8Qualityis20_ShouldBeQuality22SellIn7()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 8, 20));
            GildedRose.updateQuality(items);
            Assert.Equal(22, items[0].Quality);
            Assert.Equal(7, items[0].SellIn);
        }
        [Fact]
        public void testBackstageWithSellIn5Qualityis20_ShouldBeQuality23SellIn4()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 5, 20));
            GildedRose.updateQuality(items);
            Assert.Equal(23, items[0].Quality);
            Assert.Equal(4, items[0].SellIn);
        }
        
        [Fact]
        public void testBackstageSellIn8Quality20_ShouldBeQuality22SelIn7()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 8, 20));
            GildedRose.updateQuality(items);
            Assert.Equal(22, items[0].Quality);
            Assert.Equal(7, items[0].SellIn);
        }
        [Fact]
        public void testBackstageSellIn0Quality50_ShouldBeQuality50SelIn0()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 0, 50));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(0, items[0].SellIn);
        }
        [Fact]
        public void testBackstageSellInMinus4Quality40_ShouldBeQuality0SelInMinus4()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", -4, 40));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(-4, items[0].SellIn);
        }
        [Fact]
        public void testBackstageSellInMinus4Qualityminus4_ShouldBeQuality0SelInMinus4()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", -4, -4));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(-4, items[0].SellIn);
        }
        [Fact]
        public void testBackstageSellIn7QualityMinus8_ShouldBeQuality0SelIn6()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 7, -8));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(6, items[0].SellIn);
        }

        */

        //Sulfuras
        [Fact]
        public void testSulfuraseWithSellIn50Quality40_ShouldBeQuality40SelIn50()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 50, 40));
            GildedRose.updateQuality(items);
            Assert.Equal(40, items[0].Quality);
            Assert.Equal(50, items[0].SellIn);

        }
        [Fact]
        public void testSulfurasWithSellIn34Quality40_ShouldBeQuality40SelIn34()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 34, 40));
            GildedRose.updateQuality(items);
            Assert.Equal(40, items[0].Quality);
            Assert.Equal(34, items[0].SellIn);
        }       
        [Fact]
        public void testSulfurasWithSellIn40Quality6_ShouldBeQuality34SelIn6()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 6, 40));
            GildedRose.updateQuality(items);
            Assert.Equal(40, items[0].Quality);
            Assert.Equal(6, items[0].SellIn);
        }
        [Fact]
        public void testSulfurasWithSellIn0Quality50_ShouldBeQuality50SelIn0()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 50));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(0, items[0].SellIn);
        }
        [Fact]
        public void testSulfurasWithSellIn0Quality60_ShouldBeQuality50SelIn0()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 60));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(0, items[0].SellIn);
        }
        [Fact]
        public void testSulfurasSellInMinus4Quality50_ShouldBeQuality34SelIn6()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", -4, 50));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(-4, items[0].SellIn);
        }
        [Fact]
        public void testSulfurasSellInMinus4QualityMinus4_ShouldBeQuality34SelIn6()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", -4, -4));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(-4, items[0].SellIn);
        }
        [Fact]
        public void testSulfurasSellInMinus4Quality60_ShouldBeQuality34SelIn6()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Sulfuras, Hand of Ragnaros", -4, 60));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(-4, items[0].SellIn);
        }

        //Default
        [Fact]
        public void testElixirSellIn5Quality7_ShouldBeQuality6SelIn4()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Elixir of the Mongoose", 5, 7));
            GildedRose.updateQuality(items);
            Assert.Equal(6, items[0].Quality);
            Assert.Equal(4, items[0].SellIn);
        }
        [Fact]
        public void testElixirSellIn0Quality7_ShouldBeQuality6SelIn4()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Elixir of the Mongoose", 0, 7));
            GildedRose.updateQuality(items);
            Assert.Equal(6, items[0].Quality);
            Assert.Equal(-1, items[0].SellIn);
        }
        [Fact]
        public void testElixirSellIn7Quality0_ShouldBeQuality0SelIn6()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Elixir of the Mongoose", 7, 0));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(6, items[0].SellIn);
        }
        [Fact]
        public void testElixirSellInMinus7Quality0_ShouldBeQuality10SelInMinus8()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Elixir of the Mongoose", -7, 12));
            GildedRose.updateQuality(items);
            Assert.Equal(10, items[0].Quality);
            Assert.Equal(-8, items[0].SellIn);
        }
        [Fact]
        public void testElixirSellInMinus7QualityMinus4_ShouldBeQuality0SelInMinus8()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Elixir of the Mongoose", -7, -4));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(-8, items[0].SellIn);
        }
        [Fact]
        public void testElixirSellIn8QualityMinus4_ShouldBeQuality0SelIn7()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Elixir of the Mongoose",8, -4));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(7, items[0].SellIn);
        }

        //Conjured
    }
}
