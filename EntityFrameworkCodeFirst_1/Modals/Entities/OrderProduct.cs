﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst_1.Modals.Entities
{
	public class OrderProduct:BaseEntity
	{
		public int ProductID { get; set; }
		public int OrderID { get; set; }
		public decimal Discount { get; set; }

		//Relational Properties
		public virtual Product  Product { get; set; }
		public virtual  Order Order { get; set; }
	}
}
