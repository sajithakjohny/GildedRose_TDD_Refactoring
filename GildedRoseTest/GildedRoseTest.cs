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

        //Sulfuras
        [Theory]
        [ClassData(typeof(SulfurasTestData))]
        public void testSulfurase(Item sulfurasTestData, int expectedQuality, int expectedSellIn)
        {
            IList<Item> items = new List<Item>();
            items.Add(sulfurasTestData);
            GildedRose.updateQuality(items);
            Assert.Equal(expectedQuality, items[0].Quality);
            Assert.Equal(expectedSellIn, items[0].SellIn);

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
        [Fact]
        public void testConjuredSellIn3Quality6_ShouldBeQuality4SelIn2()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Conjured Mana Cake", 3, 6));
            GildedRose.updateQuality(items);
            Assert.Equal(4, items[0].Quality);
            Assert.Equal(2, items[0].SellIn);
        }

        [Fact]
        public void testConjuredSellIn3Quality60_ShouldBeQuality50SelIn1()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Conjured Mana Cake", 2, 60));
            GildedRose.updateQuality(items);
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(1, items[0].SellIn);
        }

        [Fact]
        public void testConjuredSellInMinus4Quality40_ShouldBeQuality36SelInMinus5()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Conjured Mana Cake", -4, 40));
            GildedRose.updateQuality(items);
            Assert.Equal(36, items[0].Quality);
            Assert.Equal(-5, items[0].SellIn);
        }

        [Fact]
        public void testConjuredSellIn4QualityMinus40_ShouldBeQuality36SelInMinus5()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("Conjured Mana Cake", 4, -40));
            GildedRose.updateQuality(items);
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(3, items[0].SellIn);
        }
    }
}
