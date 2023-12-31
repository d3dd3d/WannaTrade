﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WannaTradeEntities1 : DbContext
    {
        public WannaTradeEntities1()
            : base("name=WannaTradeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Tier> Tier { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Message> Message { get; set; }
    
        public virtual ObjectResult<Nullable<int>> User_check(string user_login, string pass)
        {
            var user_loginParameter = user_login != null ?
                new ObjectParameter("user_login", user_login) :
                new ObjectParameter("user_login", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("User_check", user_loginParameter, passParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> User_reg(string user_name, string user_pass, string user_email)
        {
            var user_nameParameter = user_name != null ?
                new ObjectParameter("user_name", user_name) :
                new ObjectParameter("user_name", typeof(string));
    
            var user_passParameter = user_pass != null ?
                new ObjectParameter("user_pass", user_pass) :
                new ObjectParameter("user_pass", typeof(string));
    
            var user_emailParameter = user_email != null ?
                new ObjectParameter("user_email", user_email) :
                new ObjectParameter("user_email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("User_reg", user_nameParameter, user_passParameter, user_emailParameter);
        }
    
        public virtual ObjectResult<Items_load_Result> Items_load(string user_login, string item_name, Nullable<int> item_tier, Nullable<int> item_price, Nullable<int> item_group, Nullable<int> item_category, Nullable<int> item_ench_lvl)
        {
            var user_loginParameter = user_login != null ?
                new ObjectParameter("user_login", user_login) :
                new ObjectParameter("user_login", typeof(string));
    
            var item_nameParameter = item_name != null ?
                new ObjectParameter("item_name", item_name) :
                new ObjectParameter("item_name", typeof(string));
    
            var item_tierParameter = item_tier.HasValue ?
                new ObjectParameter("item_tier", item_tier) :
                new ObjectParameter("item_tier", typeof(int));
    
            var item_priceParameter = item_price.HasValue ?
                new ObjectParameter("item_price", item_price) :
                new ObjectParameter("item_price", typeof(int));
    
            var item_groupParameter = item_group.HasValue ?
                new ObjectParameter("item_group", item_group) :
                new ObjectParameter("item_group", typeof(int));
    
            var item_categoryParameter = item_category.HasValue ?
                new ObjectParameter("item_category", item_category) :
                new ObjectParameter("item_category", typeof(int));
    
            var item_ench_lvlParameter = item_ench_lvl.HasValue ?
                new ObjectParameter("item_ench_lvl", item_ench_lvl) :
                new ObjectParameter("item_ench_lvl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Items_load_Result>("Items_load", user_loginParameter, item_nameParameter, item_tierParameter, item_priceParameter, item_groupParameter, item_categoryParameter, item_ench_lvlParameter);
        }
    
        public virtual ObjectResult<Category_load_Result> Category_load(Nullable<int> group_id)
        {
            var group_idParameter = group_id.HasValue ?
                new ObjectParameter("group_id", group_id) :
                new ObjectParameter("group_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Category_load_Result>("Category_load", group_idParameter);
        }
    
        public virtual ObjectResult<Group_load_Result> Group_load()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Group_load_Result>("Group_load");
        }
    
        public virtual ObjectResult<Tier_Load_Result> Tier_Load()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Tier_Load_Result>("Tier_Load");
        }
    
        public virtual ObjectResult<Nullable<int>> Sale_Ins(Nullable<int> request_item_id, Nullable<int> request_number, Nullable<int> request_price, Nullable<int> request_seller_id, string request_buyer, Nullable<int> request_id)
        {
            var request_item_idParameter = request_item_id.HasValue ?
                new ObjectParameter("request_item_id", request_item_id) :
                new ObjectParameter("request_item_id", typeof(int));
    
            var request_numberParameter = request_number.HasValue ?
                new ObjectParameter("request_number", request_number) :
                new ObjectParameter("request_number", typeof(int));
    
            var request_priceParameter = request_price.HasValue ?
                new ObjectParameter("request_price", request_price) :
                new ObjectParameter("request_price", typeof(int));
    
            var request_seller_idParameter = request_seller_id.HasValue ?
                new ObjectParameter("request_seller_id", request_seller_id) :
                new ObjectParameter("request_seller_id", typeof(int));
    
            var request_buyerParameter = request_buyer != null ?
                new ObjectParameter("request_buyer", request_buyer) :
                new ObjectParameter("request_buyer", typeof(string));
    
            var request_idParameter = request_id.HasValue ?
                new ObjectParameter("request_id", request_id) :
                new ObjectParameter("request_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sale_Ins", request_item_idParameter, request_numberParameter, request_priceParameter, request_seller_idParameter, request_buyerParameter, request_idParameter);
        }
    
        public virtual ObjectResult<Items_load_Buys_Result> Items_load_Buys(string user_login, string item_name, Nullable<int> item_tier, Nullable<int> item_price, Nullable<int> item_group, Nullable<int> item_category, Nullable<int> item_ench_lvl)
        {
            var user_loginParameter = user_login != null ?
                new ObjectParameter("user_login", user_login) :
                new ObjectParameter("user_login", typeof(string));
    
            var item_nameParameter = item_name != null ?
                new ObjectParameter("item_name", item_name) :
                new ObjectParameter("item_name", typeof(string));
    
            var item_tierParameter = item_tier.HasValue ?
                new ObjectParameter("item_tier", item_tier) :
                new ObjectParameter("item_tier", typeof(int));
    
            var item_priceParameter = item_price.HasValue ?
                new ObjectParameter("item_price", item_price) :
                new ObjectParameter("item_price", typeof(int));
    
            var item_groupParameter = item_group.HasValue ?
                new ObjectParameter("item_group", item_group) :
                new ObjectParameter("item_group", typeof(int));
    
            var item_categoryParameter = item_category.HasValue ?
                new ObjectParameter("item_category", item_category) :
                new ObjectParameter("item_category", typeof(int));
    
            var item_ench_lvlParameter = item_ench_lvl.HasValue ?
                new ObjectParameter("item_ench_lvl", item_ench_lvl) :
                new ObjectParameter("item_ench_lvl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Items_load_Buys_Result>("Items_load_Buys", user_loginParameter, item_nameParameter, item_tierParameter, item_priceParameter, item_groupParameter, item_categoryParameter, item_ench_lvlParameter);
        }
    
        public virtual ObjectResult<Items_load_Sales_Result> Items_load_Sales(string user_login, string item_name, Nullable<int> item_tier, Nullable<int> item_price, Nullable<int> item_group, Nullable<int> item_category, Nullable<int> item_ench_lvl)
        {
            var user_loginParameter = user_login != null ?
                new ObjectParameter("user_login", user_login) :
                new ObjectParameter("user_login", typeof(string));
    
            var item_nameParameter = item_name != null ?
                new ObjectParameter("item_name", item_name) :
                new ObjectParameter("item_name", typeof(string));
    
            var item_tierParameter = item_tier.HasValue ?
                new ObjectParameter("item_tier", item_tier) :
                new ObjectParameter("item_tier", typeof(int));
    
            var item_priceParameter = item_price.HasValue ?
                new ObjectParameter("item_price", item_price) :
                new ObjectParameter("item_price", typeof(int));
    
            var item_groupParameter = item_group.HasValue ?
                new ObjectParameter("item_group", item_group) :
                new ObjectParameter("item_group", typeof(int));
    
            var item_categoryParameter = item_category.HasValue ?
                new ObjectParameter("item_category", item_category) :
                new ObjectParameter("item_category", typeof(int));
    
            var item_ench_lvlParameter = item_ench_lvl.HasValue ?
                new ObjectParameter("item_ench_lvl", item_ench_lvl) :
                new ObjectParameter("item_ench_lvl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Items_load_Sales_Result>("Items_load_Sales", user_loginParameter, item_nameParameter, item_tierParameter, item_priceParameter, item_groupParameter, item_categoryParameter, item_ench_lvlParameter);
        }
    
        public virtual ObjectResult<Items_load_Sales_Gen_Result> Items_load_Sales_Gen(string user_login, string item_name, Nullable<int> item_tier, Nullable<int> item_price, Nullable<int> item_group, Nullable<int> item_category, Nullable<int> item_ench_lvl)
        {
            var user_loginParameter = user_login != null ?
                new ObjectParameter("user_login", user_login) :
                new ObjectParameter("user_login", typeof(string));
    
            var item_nameParameter = item_name != null ?
                new ObjectParameter("item_name", item_name) :
                new ObjectParameter("item_name", typeof(string));
    
            var item_tierParameter = item_tier.HasValue ?
                new ObjectParameter("item_tier", item_tier) :
                new ObjectParameter("item_tier", typeof(int));
    
            var item_priceParameter = item_price.HasValue ?
                new ObjectParameter("item_price", item_price) :
                new ObjectParameter("item_price", typeof(int));
    
            var item_groupParameter = item_group.HasValue ?
                new ObjectParameter("item_group", item_group) :
                new ObjectParameter("item_group", typeof(int));
    
            var item_categoryParameter = item_category.HasValue ?
                new ObjectParameter("item_category", item_category) :
                new ObjectParameter("item_category", typeof(int));
    
            var item_ench_lvlParameter = item_ench_lvl.HasValue ?
                new ObjectParameter("item_ench_lvl", item_ench_lvl) :
                new ObjectParameter("item_ench_lvl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Items_load_Sales_Gen_Result>("Items_load_Sales_Gen", user_loginParameter, item_nameParameter, item_tierParameter, item_priceParameter, item_groupParameter, item_categoryParameter, item_ench_lvlParameter);
        }
    
        public virtual int Buy_Confirm(Nullable<int> request_id, Nullable<int> cass)
        {
            var request_idParameter = request_id.HasValue ?
                new ObjectParameter("request_id", request_id) :
                new ObjectParameter("request_id", typeof(int));
    
            var cassParameter = cass.HasValue ?
                new ObjectParameter("cass", cass) :
                new ObjectParameter("cass", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Buy_Confirm", request_idParameter, cassParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Sale_Add(Nullable<int> category_id, Nullable<int> tier_id, Nullable<int> request_number, Nullable<int> request_price, Nullable<int> ench_lvl, string request_seller)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            var tier_idParameter = tier_id.HasValue ?
                new ObjectParameter("tier_id", tier_id) :
                new ObjectParameter("tier_id", typeof(int));
    
            var request_numberParameter = request_number.HasValue ?
                new ObjectParameter("request_number", request_number) :
                new ObjectParameter("request_number", typeof(int));
    
            var request_priceParameter = request_price.HasValue ?
                new ObjectParameter("request_price", request_price) :
                new ObjectParameter("request_price", typeof(int));
    
            var ench_lvlParameter = ench_lvl.HasValue ?
                new ObjectParameter("ench_lvl", ench_lvl) :
                new ObjectParameter("ench_lvl", typeof(int));
    
            var request_sellerParameter = request_seller != null ?
                new ObjectParameter("request_seller", request_seller) :
                new ObjectParameter("request_seller", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sale_Add", category_idParameter, tier_idParameter, request_numberParameter, request_priceParameter, ench_lvlParameter, request_sellerParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Sale_Delete(Nullable<int> request_id)
        {
            var request_idParameter = request_id.HasValue ?
                new ObjectParameter("request_id", request_id) :
                new ObjectParameter("request_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sale_Delete", request_idParameter);
        }
    
        public virtual ObjectResult<Stats_Get_Result> Stats_Get(Nullable<int> timecase, Nullable<int> request_item_id, Nullable<int> category_id, Nullable<int> tier_id, Nullable<int> ench_lvl)
        {
            var timecaseParameter = timecase.HasValue ?
                new ObjectParameter("timecase", timecase) :
                new ObjectParameter("timecase", typeof(int));
    
            var request_item_idParameter = request_item_id.HasValue ?
                new ObjectParameter("request_item_id", request_item_id) :
                new ObjectParameter("request_item_id", typeof(int));
    
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            var tier_idParameter = tier_id.HasValue ?
                new ObjectParameter("tier_id", tier_id) :
                new ObjectParameter("tier_id", typeof(int));
    
            var ench_lvlParameter = ench_lvl.HasValue ?
                new ObjectParameter("ench_lvl", ench_lvl) :
                new ObjectParameter("ench_lvl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Stats_Get_Result>("Stats_Get", timecaseParameter, request_item_idParameter, category_idParameter, tier_idParameter, ench_lvlParameter);
        }
    }
}
