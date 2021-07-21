using System;
using System.Collections.Generic;

namespace Katas
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public Item(string name, int sellIn, int quality)
        {
            Quality = quality;
            SellIn = sellIn;
            Name = name;
        }
        //private int quality = 0;
        //public int Quality
        //{

        //    get { return quality; }
        //    set
        //    {
        //        if (quality < 0)
        //        {
        //            quality = 0;
        //        }
        //        else if (quality > 50)
        //        {
        //            quality = 50;
        //        }

        //    }
        //}

    }
}
