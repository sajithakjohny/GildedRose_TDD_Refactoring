using System;
using System.Collections.Generic;

namespace Katas
{
    public class GildedRose
    {
        private static IList<Item> items = null;
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            items = new List<Item>();
            items.Add(new Item("+5 Dexterity Vest", 10, 20));
            items.Add(new Item("Aged Brie", 2, 0));
            items.Add(new Item("Elixir of the Mongoose", 5, 7));
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
            items.Add(new Item("Conjured Mana Cake", 3, 6));
            updateQuality(items);
        }
        public static void updateQuality(IList<Item> items)
        {
            foreach (Item item in items)
            {
                switch (item.Name)
                {
                    case "Aged Brie":
                        checkAgedBrieCase(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        checkBackstageCase(item);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    case "Conjured Mana Cake":
                        checkConjuredCase(item);
                        break;
                    default:
                        checkDefaultCase(item);
                        break;
                }
                setDefaultQuality(item);
            }
        }
        private static void setDefaultQuality(Item item)
        {
            item.Quality = item.Quality < 0 ? item.Quality = 0 : item.Quality > 50 ? item.Quality = 50 : item.Quality;
        }
        private static void checkAgedBrieCase(Item item)
        {
            item.SellIn =  item.SellIn > 0 ? item.SellIn - 1 : item.SellIn;
            item.Quality = item.Quality < 50 ? item.Quality + 1 : item.Quality;
        }
        private static void checkBackstageCase(Item item)
        {
            if (item.Quality > 0)
            {
                switch(item.SellIn < 0 ? 0 :
                item.SellIn < 6 ? 1 : 
                item.SellIn < 11 ? 2 : 3)
                {
                    case 0:
                        item.Quality = 0;
                        break;
                    case 1:
                        item.Quality = item.Quality + 3;
                        break;
                    case 2:
                        item.Quality = item.Quality + 2;
                        break;
                    case 3:
                        item.Quality = item.Quality + 1;
                        break;
                }
            }

            item.SellIn = item.SellIn > 0 ? item.SellIn - 1 : item.SellIn;

        }
        private static void checkConjuredCase(Item item)
        {
            item.Quality = item.Quality - 2;
            item.SellIn = item.SellIn - 1;
            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }
        }
        private static void checkDefaultCase(Item item)
        {
            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
            item.SellIn = item.SellIn - 1;
            item.Quality = item.Quality - 1;
        }

    }
}
