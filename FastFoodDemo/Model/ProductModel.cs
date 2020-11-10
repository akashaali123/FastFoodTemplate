using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Formula { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> SoldPricePerUnit { get; set; }
        public Nullable<decimal> RetailPricePerUnit { get; set; }
        public Nullable<int> TotalQuantityPerPacket { get; set; }
        public Nullable<decimal> TotalSoldPrice { get; set; }
        public Nullable<decimal> TotalPurchasePrice { get; set; }
        public Nullable<int> TotalTabletStock { get; set; }
        public Nullable<bool> IsActive { get; set; }

    }
}
