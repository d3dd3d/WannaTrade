using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WannaTrade.Models
{
    public class HelperClass
    {
        public class SaleAdd
        {
            public int category_id;
            public int tier_id;
            public int ench_lvl;
            public int request_number;
            public int request_price;
            public string request_seller;
        }
        public class SaleDel
        {
            public int req_id;
        }
        public class StatsHelp
        {
            public int timeCase;
            public int request_item_id;
            public int category_id;
            public int tier_id;
            public int ench_lvl;
        }
    }
}