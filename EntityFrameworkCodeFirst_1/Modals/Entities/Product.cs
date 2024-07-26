using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst_1.Modals.Entities
{
	public class Product:BaseEntity
	{
		/*Bire çok ilişkilerde classların birbirlerini tanıyarak (çoğul ve tekillik durumlarına dikkat edilip)  ilişkinin ifade edilmesi mümkündür.
		//Lakin ilişkiyi tekil olarak alan tarafta ek olarak Foreign key tanımlaması yapılması en sağlıklıdır.
		//Yapmazsak yin eilişki kurarız fakat Entity Framework Foreign key kendisi tanımlatır.Bu sadece Sql tarafında tanımlaması olur.Yani Ram'de 
		//kullanıdğımız programlama dilinde asla  tanımlanmadığı için  o Foreig keye ulaşamayız.
		Dolayısıyla direkt ilişkinin nesnesi tarafından haberleşmek zorunda kalırız.*/
		
		/*Bu nedenle en sağlıklısı foreign key elle ve uygun standartlarla tanımalmak gerekir.Uygun standartla
		ilişki propertysinin isminin sonuna ID takısının getirilerek yeni bir isim yaratılmasıdır.
		Bu yöntem yapıldığında otomatik olarka bire çok ilişki kurulur.
		Bir neden den dolayı eğer kendi verdiğimiz ismin Foreign key olmasını istiyorsak bu da mümkündür ancak tavsiye edilmez
		 */

		//1 category 1 den fazla product var 1 productın 1 categorysi var.
		//1 category n Product
		//1 product 1 Category
		//1 e çok ilişki
		public string  ProductName { get; set; }
		public decimal UnitPrice { get; set; }
		public int  CategoryID { get; set; }
		//foreign key

		//Relational Properties
		public virtual Category Category { get; set; }
		public virtual  List<OrderProduct> OrderProducts { get; set; }
	}
}
