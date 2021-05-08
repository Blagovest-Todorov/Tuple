using System;
using System.Collections.Generic;
using System.Text;

namespace TupleClass
{
    class Tuple<TFirst, TSec>  // Tuple<string, int>
    {
        public TFirst FirstItem { get; set; }
        public TSec SecItem { get; set; }

        public Tuple(TFirst firstItem, TSec secondItem)
        {
            this.FirstItem = firstItem;
            this.SecItem = secondItem;
        }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecItem}";
        }
    }
}
