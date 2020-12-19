using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=TUNERYUSUF-PC; database=BasicCrm; integrated security=true;");
		}

		public DbSet<Customer> Customers { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
