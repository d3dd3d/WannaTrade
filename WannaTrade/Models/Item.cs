//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WannaTrade.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int item_id { get; set; }
        public string item_name { get; set; }
        public int item_tier_id { get; set; }
        public int item_category_id { get; set; }
        public Nullable<int> item_ench_lvl { get; set; }
    }
}