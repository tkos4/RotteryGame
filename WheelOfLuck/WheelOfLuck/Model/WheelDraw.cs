using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WheelOfLuck.Model
{
    public class WheelDraw
    {


        public int OrderLineId { get; set; }

        public int BranchId { get; set; }

        public DateTime WheelDrawDateTime { get; set; }

        public bool Wins { get; set; }

        public string ProductCode { get; set; }

        public int OrderLineQuantityIndex { get; set; }


        




    }
}
