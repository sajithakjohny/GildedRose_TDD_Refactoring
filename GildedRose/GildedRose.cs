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
            items.Add(new Item(ItemConstant.Dexterity, 10, 20));
            items.Add(new Item(ItemConstant.Aged, 2, 0));
            items.Add(new Item(ItemConstant.Elixi, 5, 7));
            items.Add(new Item(ItemConstant.Sulfuras, 0, 80));
            items.Add(new Item(ItemConstant.Sulfuras, 15, 20));
            items.Add(new Item(ItemConstant.Conjured, 3, 6));
            updateQuality(items);
        }
        public static void updateQuality(IList<Item> items)
        {
            foreach (Item item in items)
            {
                switch (item.Name)
                {
                    case ItemConstant.Aged:
                        checkAgedBrieCase(item);
                        break;
                    case ItemConstant.Backstage:
                        checkBackstageCase(item);
                        break;
                    case ItemConstant.Sulfuras:
                        break;
                    case ItemConstant.Conjured:
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
