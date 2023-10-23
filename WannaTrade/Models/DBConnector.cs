using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace WannaTrade.Models
{
    public class MsSqlConnector : DbContext
    {
        public MsSqlConnector()
            : base("name=WannaTradeEntities1")
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 180;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public IEnumerable<int> User_Check(User sendData1)
        {
            var userName = sendData1.user_name != null ?
                new ObjectParameter("user_login", sendData1.user_name) :
                new ObjectParameter("user_login", typeof(string));
            var userPass = sendData1.user_pass != null ?
                new ObjectParameter("pass", sendData1.user_pass) :
                new ObjectParameter("pass", typeof(string));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<int>("User_check", userName, userPass);
        }
        public IEnumerable<int> User_Reg(User sendData1)
        {
            var userName = sendData1.user_name != null ?
                new ObjectParameter("user_name", sendData1.user_name) :
                new ObjectParameter("user_name", typeof(string));
            var userPass = sendData1.user_pass != null ?
                new ObjectParameter("user_pass", sendData1.user_pass) :
                new ObjectParameter("user_pass", typeof(string));
            var userEmail = sendData1.user_email != null ?
                new ObjectParameter("user_email", sendData1.user_email) :
                new ObjectParameter("user_email", typeof(string));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<int>("User_reg", userName, userPass, userEmail);
        }
        public IEnumerable<Items_load_Result> Items_load(Items_load_Result sendData1)
        {
            var userName = sendData1.seller_name != null ?
                new ObjectParameter("user_login", sendData1.seller_name) :
                new ObjectParameter("user_login", typeof(string));
            var itemName = sendData1.item_name != null ?
               new ObjectParameter("item_name", sendData1.item_name) :
               new ObjectParameter("item_name", typeof(string));
            var price = sendData1.request_price != 0 ?
                new ObjectParameter("item_price", sendData1.request_price) :
                new ObjectParameter("item_price", typeof(string));
            var tier = sendData1.tier_id != null ?
               new ObjectParameter("item_tier", sendData1.tier_id) :
               new ObjectParameter("item_tier", typeof(string));
            var category = sendData1.category_id != null ?
                new ObjectParameter("item_category", sendData1.category_id) :
                new ObjectParameter("item_category", typeof(string));
            var group = sendData1.group_id != null ?
                new ObjectParameter("item_group", sendData1.group_id) :
                new ObjectParameter("item_group", typeof(string));
            var ench = sendData1.item_ench_lvl != null ?
                new ObjectParameter("item_ench_lvl", sendData1.item_ench_lvl) :
                new ObjectParameter("item_ench_lvl", typeof(string));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Items_load_Result>("Items_load", userName, itemName,tier,price, group,category, ench);
        }
        public IEnumerable<Items_load_Sales_Result> Items_load_Sales(Items_load_Result sendData1)
        {
            var userName = sendData1.seller_name != null ?
                new ObjectParameter("user_login", sendData1.seller_name) :
                new ObjectParameter("user_login", typeof(string));
            var itemName = sendData1.item_name != null ?
               new ObjectParameter("item_name", sendData1.item_name) :
               new ObjectParameter("item_name", typeof(string));
            var price = sendData1.request_price != 0 ?
                new ObjectParameter("item_price", sendData1.request_price) :
                new ObjectParameter("item_price", typeof(string));
            var tier = sendData1.tier_id != null ?
               new ObjectParameter("item_tier", sendData1.tier_id) :
               new ObjectParameter("item_tier", typeof(string));
            var category = sendData1.category_id != null ?
                new ObjectParameter("item_category", sendData1.category_id) :
                new ObjectParameter("item_category", typeof(string));
            var group = sendData1.group_id != null ?
                new ObjectParameter("item_group", sendData1.group_id) :
                new ObjectParameter("item_group", typeof(string));
            var ench = sendData1.item_ench_lvl != null ?
               new ObjectParameter("item_ench_lvl", sendData1.item_ench_lvl) :
               new ObjectParameter("item_ench_lvl", typeof(string));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Items_load_Sales_Result>("Items_load_Sales", userName, itemName, tier, price, group, category, ench);
        }
        public IEnumerable<Items_load_Buys_Result> Items_load_Buys(Items_load_Result sendData1)
        {
            var userName = sendData1.seller_name != null ?
                new ObjectParameter("user_login", sendData1.seller_name) :
                new ObjectParameter("user_login", typeof(string));
            var itemName = sendData1.item_name != null ?
               new ObjectParameter("item_name", sendData1.item_name) :
               new ObjectParameter("item_name", typeof(string));
            var price = sendData1.request_price != 0 ?
                new ObjectParameter("item_price", sendData1.request_price) :
                new ObjectParameter("item_price", typeof(string));
            var tier = sendData1.tier_id != null ?
               new ObjectParameter("item_tier", sendData1.tier_id) :
               new ObjectParameter("item_tier", typeof(string));
            var category = sendData1.category_id != null ?
                new ObjectParameter("item_category", sendData1.category_id) :
                new ObjectParameter("item_category", typeof(string));
            var group = sendData1.group_id != null ?
                new ObjectParameter("item_group", sendData1.group_id) :
                new ObjectParameter("item_group", typeof(string));
            var ench = sendData1.item_ench_lvl != null ?
               new ObjectParameter("item_ench_lvl", sendData1.item_ench_lvl) :
               new ObjectParameter("item_ench_lvl", typeof(string));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Items_load_Buys_Result>("Items_load_Buys", userName, itemName, tier, price, group, category, ench);
        }
        public IEnumerable<Items_load_Sales_Gen_Result> Items_load_Sales_Gen(Items_load_Result sendData1)
        {
            var userName = sendData1.seller_name != null ?
                new ObjectParameter("user_login", sendData1.seller_name) :
                new ObjectParameter("user_login", typeof(string));
            var itemName = sendData1.item_name != null ?
               new ObjectParameter("item_name", sendData1.item_name) :
               new ObjectParameter("item_name", typeof(string));
            var price = sendData1.request_price != 0 ?
                new ObjectParameter("item_price", sendData1.request_price) :
                new ObjectParameter("item_price", typeof(string));
            var tier = sendData1.tier_id != null ?
               new ObjectParameter("item_tier", sendData1.tier_id) :
               new ObjectParameter("item_tier", typeof(string));
            var category = sendData1.category_id != null ?
                new ObjectParameter("item_category", sendData1.category_id) :
                new ObjectParameter("item_category", typeof(string));
            var group = sendData1.group_id != null ?
                new ObjectParameter("item_group", sendData1.group_id) :
                new ObjectParameter("item_group", typeof(string));
            var ench = sendData1.item_ench_lvl != null ?
               new ObjectParameter("item_ench_lvl", sendData1.item_ench_lvl) :
               new ObjectParameter("item_ench_lvl", typeof(string));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Items_load_Sales_Gen_Result>("Items_load_Sales_Gen", userName, itemName, tier, price, group, category, ench);
        }
        public IEnumerable<Tier_Load_Result> Tier_Load()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Tier_Load_Result>("Tier_Load");
        }
        public IEnumerable<Group_load_Result> Group_Load()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Group_load_Result>("Group_load");
        }
        public IEnumerable<Category_load_Result> Category_Load(int group_id)
        {
            var group = new ObjectParameter("group_id", group_id);
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Category_load_Result>("Category_load", group);
        }
        public IEnumerable<int> Sale_Ins(Items_load_Result sendData1, string user)
        {
            var itemId = sendData1.item_id != 0 ?
                new ObjectParameter("request_item_id", sendData1.item_id) :
                new ObjectParameter("request_item_id", typeof(int));
            var number = sendData1.request_number != 0 ?
                new ObjectParameter("request_number", sendData1.request_number) :
                new ObjectParameter("request_number", typeof(int));
            var price = sendData1.request_price != 0 ?
                new ObjectParameter("request_price", sendData1.request_price) :
                new ObjectParameter("request_price", typeof(int));
            var sellerId = sendData1.request_seller_id != 0 ?
                new ObjectParameter("request_seller_id", sendData1.request_seller_id) :
                new ObjectParameter("request_seller_id", typeof(int));
            var buyerName = user != null ?
                new ObjectParameter("request_buyer", user) :
                new ObjectParameter("request_buyer", typeof(string));
            var requestId = sendData1.request_id != 0 ?
                new ObjectParameter("request_id", sendData1.request_id) :
                new ObjectParameter("request_id", typeof(int));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<int>("Sale_Ins", itemId, number, price, sellerId, buyerName, requestId);
            
        }
        public IEnumerable<int> Sale_Add(HelperClass.SaleAdd sendData1)
        {
            var itemId = sendData1.category_id != 0 ?
                new ObjectParameter("category_id", sendData1.category_id) :
                new ObjectParameter("category_id", typeof(int));
            var number = sendData1.request_number != 0 ?
                new ObjectParameter("request_number", sendData1.request_number) :
                new ObjectParameter("request_number", typeof(int));
            var price = sendData1.request_price != 0 ?
                new ObjectParameter("request_price", sendData1.request_price) :
                new ObjectParameter("request_price", typeof(int));
            var sellerId = sendData1.request_seller != null ?
                new ObjectParameter("request_seller", sendData1.request_seller) :
                new ObjectParameter("request_seller", typeof(string));
            var requestId = sendData1.tier_id != 0 ?
                new ObjectParameter("tier_id", sendData1.tier_id) :
                new ObjectParameter("tier_id", typeof(int));
            var ench = new ObjectParameter("ench_lvl", sendData1.ench_lvl);
                
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<int>("Sale_Add", itemId, number, price, sellerId, requestId, ench);

        }
        public IEnumerable<int> Sale_Delete(HelperClass.SaleDel sendData1)
        {
            var itemId = sendData1.req_id != 0 ?
                new ObjectParameter("request_id", sendData1.req_id) :
                new ObjectParameter("request_id", typeof(int));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<int>("Sale_Delete", itemId);

        }
        public int Confirm_Buy(int id, int val)
        {
            var itemId =
                new ObjectParameter("request_id", id);
            var number =
                new ObjectParameter("cass", val);
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Buy_Confirm", itemId, number);

        }
        public IEnumerable<Stats_Get_Result> Stats_Get(HelperClass.StatsHelp sendData1)
        {
            var timeCase = new ObjectParameter("timecase", sendData1.timeCase);
            var request_item_id = sendData1.request_item_id != -1 ?
               new ObjectParameter("request_item_id", sendData1.request_item_id) :
               new ObjectParameter("request_item_id", typeof(int));
            var category_id = sendData1.category_id != 0 ?
               new ObjectParameter("category_id", sendData1.category_id) :
               new ObjectParameter("category_id", typeof(int));
            var tier_id = sendData1.tier_id != 0 ?
               new ObjectParameter("tier_id", sendData1.tier_id) :
               new ObjectParameter("tier_id", typeof(int));
            var ench_lvl = sendData1.ench_lvl != -1 ?
               new ObjectParameter("ench_lvl", sendData1.ench_lvl) :
               new ObjectParameter("ench_lvl", typeof(int));
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Stats_Get_Result>("Stats_Get", timeCase, request_item_id, category_id, tier_id, ench_lvl);
        }
    }
}