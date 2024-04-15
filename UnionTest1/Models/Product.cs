using System;
using System.Collections.Generic;

namespace UnionTest1.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int UnitsInStock { get; set; }
        public string? QuantityPerUnit { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
