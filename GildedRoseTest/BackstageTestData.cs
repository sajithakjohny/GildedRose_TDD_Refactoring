using System.Collections;
using System.Collections.Generic;

namespace Katas
{
    public class BackstageTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { new Item(ItemConstant.Backstage, 8, 20), 22, 7 },
            new object[] {new Item(ItemConstant.Backstage, 5, 20),23,4 },
            new object[] {new Item(ItemConstant.Backstage, 50, 40),41,49 },
            new object[] { new Item(ItemConstant.Backstage, 8, 20), 22,7 },
            new object[] { new Item(ItemConstant.Backstage, 0, 50), 50,0 },
            new object[] { new Item(ItemConstant.Backstage, - 4,40),0,-4 },
            new object[] { new Item(ItemConstant.Backstage, - 4, -4),0,-4 },
            new object[] { new Item(ItemConstant.Backstage, 7, -8),0,6 },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
