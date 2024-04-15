using System.ComponentModel.DataAnnotations;

namespace UnionTest1.Models
{
    public partial class Categories
    {
        public Categories()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
