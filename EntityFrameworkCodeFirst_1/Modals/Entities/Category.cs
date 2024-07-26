using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst_1.Modals.Entities
{
	//Bire çok ilişkilerde ilişkiyi çoğul olarak alınan tarafa sadece Relational Property yazılır.
	public class Category:BaseEntity
	{
		public string  CategoryName { get; set; }
		public string Description { get; set; }

		//Relational Properties

		//Virtual keywordü entitiy frameworktei relational propertylerde Lazy loading anlamına gelir.
		//Polymorphizm ile karıştırmayalım.
		public virtual List<Product> Products { get; set; }
	}
}
