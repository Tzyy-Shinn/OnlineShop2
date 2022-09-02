using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OnlineShop2.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }
        public int Id { get; set; }
        [Display(Name = "Order No")]
        public string OrderNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }
        //public DateTime OrderD ()
        //{
        //    OrderDate = DateTime.Now;
        //    return OrderDate;
        //}

        public virtual List<OrderDetails> OrderDetails { get; set; }

    }
}
