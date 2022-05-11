using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirtCore.Models
{
    public class Order : BaseEntity
    {
        
        public int AppUserID { get; set; }

        // Relational Properties
        //[ForeignKey("UserID")]
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
