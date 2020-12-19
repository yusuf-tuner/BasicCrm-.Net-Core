using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Customer
	{
		[Key]
		public int customerID { get; set; }
		public string customerName { get; set; }
		public string customerSurname { get; set; }
		public byte customerAge { get; set; }
		public string customerGender { get; set; }
		public string customerAdress { get; set; }
	}
}
