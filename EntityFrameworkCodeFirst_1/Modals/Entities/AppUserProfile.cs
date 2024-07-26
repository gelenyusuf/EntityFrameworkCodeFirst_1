using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst_1.Modals.Entities
{
	public class AppUserProfile:BaseEntity
	{
		//Bire bir ve çoka çok ilişkiler ,bire çok gibi tek fazda ifade edilemez.
		//Bunlar öncelikle class ilişkilerinde tanımlanmalı sonra veritabanı yarartılma ayarlarıdna özellikle beliritlmelidirler.
		public string FirstName  { get; set; }
		public  string LastName { get; set; }

		//Relational Properties

		public virtual AppUser AppUser { get; set; }
	}
}
