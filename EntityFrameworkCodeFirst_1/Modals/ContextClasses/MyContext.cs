using EntityFrameworkCodeFirst_1.Modals.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst_1.Modals.Context
{
	public class MyContext:DbContext
	{
		//DbContext sınıfı veritabanı işlemlerinin hepsini yapabilen bir sınıftır.DbContexten miras alırız.Ve o sınıf bir veritabanı sınıfıdır.
		public MyContext():base("MyConnection")
		{

		}
		//Buradaki base'in (DbContext'in constructorının) string parametre alan overload'ı  çalışacak ve projenin (su anda tek bir proje var eğer birden
		//fazla olsaydı startup olarak setlenen projenin )config dosyasındaki connectionString isimlerini arayacak oradan ismini bulduğu adresi algılayacak
		//Entity Framwork entegrasyonlarında bir connectionString ismi algılandığı anda mevcut solutionda hangi proje çalışmak için görevlendirildiği ise
		//o projenin config 'ine bakılar.

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			/* ***************************************************Önemli***********************************************
			modelBuilder.Entity<Category>().ToTable("Kategoriler");   //Category tablosunun veritabanındaki ismini değiştirmek istersek
			modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasColumnName("Kategori İsmi");//Sütun ismi değiştirmek için
			modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnType("money");//Sütun tipi değiştirmek için
			*/

			//BİREBİR İLİŞKİ İÇİN AŞAĞIDAKİ GEREKLİ

			//one to one or zero bire bir ilişkide kullanılması gereken 
			modelBuilder.Entity<AppUser>().HasOptional(x => x.Profile).WithRequired(x=>x.AppUser);
			//HasOptional boş geçilebilir demek.WithRequired zorunlu  demek
			//Birebir ilişi ifadesinin ikinci fazının tanımlanmış demektir.Buradaki demek istenen bir AppUser ın Profili olmayabilir.Lakin
			//Bir Profilin bir AppUser olmak zorundadır.WithRequired(x=>x.AppUser) HasOptional opsiyonel .WithRequired gerekli



			//ÇOKA ÇOK İLİŞKİ İÇİN AŞAĞIDAKİLER GEREKLİ

			modelBuilder.Entity<OrderProduct>().Ignore(x=>x.ID);
			//Buradaki Ignnore komutu belirlediğim bir propertynin sql gönderilmesini engeller.
			//Ignore at demek buradaki propery i sql gönderme bırak ramde kalsın

			modelBuilder.Entity<OrderProduct>().HasKey(x=>new { 
			x.OrderID,
			x.ProductID
			});
			//HasKey metodu tablo olacak classın nasıl bir key' e sahip olacağını belirtir. 
		}
		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<AppUser> AppUsers { get; set; }

		public DbSet<AppUserProfile> Profiles { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<OrderProduct> OrderProducts { get; set; }
	}
}
