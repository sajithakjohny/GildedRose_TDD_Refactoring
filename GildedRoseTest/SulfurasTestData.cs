using System.Collections.Generic;
using System.Collections;

namespace Katas
{
   public class SulfurasTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { new Item(ItemConstant.Sulfuras, 50, 40), 40, 50 },
            new object[] { new Item(ItemConstant.Sulfuras, 34, 40), 40, 34 },
            new object[] { new Item(ItemConstant.Sulfuras, 6, 40), 40, 6 },
            new object[] { new Item(ItemConstant.Sulfuras, 0, 50), 50, 0 },
            new object[] { new Item(ItemConstant.Sulfuras, 0, 60), 50, 0 },
            new object[] { new Item(ItemConstant.Sulfuras, -4, 50), 50, -4 },
            new object[] { new Item(ItemConstant.Sulfuras, -4, -4), 0, -4 },
            new object[] { new Item(ItemConstant.Sulfuras, -4, 60), 50, -4 },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
