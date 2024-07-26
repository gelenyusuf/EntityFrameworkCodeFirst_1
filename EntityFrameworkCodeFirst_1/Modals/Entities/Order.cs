using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst_1.Modals.Entities
{
	public class Order:BaseEntity
	{
		//1 AppUser n Orders  BİRE BİR İLİŞKİ
		//1 Order 1 AppUser

		//1 Order n Product    ÇOKA ÇOK İLİŞKİ
		//1 Product n Order
		public string ShippingAddress { get; set; }
		public int AppUserID { get; set; }
		//Relational Properties

		public virtual AppUser AppUser { get; set; }
		public virtual List<OrderProduct> OrderProducts { get; set; }
	}
}
