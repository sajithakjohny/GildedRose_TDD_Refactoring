using System.Collections;
using System.Collections.Generic;

namespace Katas
{
    public class AgedBrieTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { new Item(ItemConstant.Aged, 2, 60), 50, 1 },
            new object[] {new Item(ItemConstant.Aged, 0, 60),50,0 },
            new object[] {new Item(ItemConstant.Aged, 0, 50),50,0 },
            new object[] { new Item(ItemConstant.Aged, 4, 45), 46,3 },
            new object[] { new Item(ItemConstant.Aged, -4, 50), 50,-4 },
            new object[] { new Item(ItemConstant.Aged, 7, -40),0,6 },
            new object[] { new Item(ItemConstant.Aged, -4, -4),0,-4 },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
