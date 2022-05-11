using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirtCore.Models
{
    public class OrderDetail : BaseEntity
    {
        public short Quantity { get; set; }

        [Column("Toplam Fiyatı", TypeName = "numeric(18,1)")]
        public decimal? TotalPrice { get; set; }

        //[Key,Column(Order=1)]
        public int OrderID { get; set; }

        //[Key,Column(Order=2)]
        public int ProductID { get; set; }

        // Relational Properties

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
