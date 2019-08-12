using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<TItem1, TItem2,TItem3>
    {
        private TItem1 item1;
        private TItem2 item2;
        private TItem3 item3;

        public Tuple(TItem1 item1,TItem2 item2,TItem3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public string GetInfo()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
