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
    
    public partial class Message
    {
        public int message_id { get; set; }
        public int message_sender_id { get; set; }
        public int message_reciever_id { get; set; }
        public string message_value { get; set; }
        public System.DateTime message_date { get; set; }
    }
}