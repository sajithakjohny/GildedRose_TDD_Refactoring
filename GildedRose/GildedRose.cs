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
			for (int i = 0; i < items.Count; i++)
			{
			//	switch(i >0)
			//{
			//		case (!"Aged Brie".Equals(items[i].Name) and 
			//		!"Backstage passes to a TAFKAL80ETC concert".Equals(items[i].Name):
			//		break;
			//}
				if ((!"Aged Brie".Equals(items[i].Name)) && !"Backstage passes to a TAFKAL80ETC concert".Equals(items[i].Name))
				{
					if (items[i].Quality > 0)
					{
						if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].Name))
						{
							items[i].Quality = items[i].Quality - 1;
						}
					}
				}
				else
				{
					if (items[i].Quality < 50)
					{
						items[i].Quality = items[i].Quality + 1;

						if ("Backstage passes to a TAFKAL80ETC concert".Equals(items[i].Name))
						{
							if (items[i].SellIn < 11)
							{
								if (items[i].Quality < 50)
								{
									items[i].Quality = (items[i].Quality + 1);
									if (items[i].SellIn < 6)
									{
										items[i].Quality = (items[i].Quality + 1);
									}
								}
							}
						}
					}
				}

				if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].Name))
				{
					items[i].SellIn = (items[i].SellIn - 1);
				}

				if (items[i].SellIn < 0)
				{
					if (!"Aged Brie".Equals(items[i].Name))
					{
						if (!"Backstage passes to a TAFKAL80ETC concert".Equals(items[i].Name))
						{
							if (items[i].Quality > 0)
							{
								if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].Name))
								{
									items[i].Quality = (items[i].Quality - 1);
								}
							}
						}
						else
						{
							items[i].Quality = (items[i].Quality - items[i].Quality);
						}
					}
					else
					{
						if (items[i].Quality < 50)
						{
							items[i].Quality = (items[i].Quality + 1);
						}
					}
				}
			}
		}
    }
}
