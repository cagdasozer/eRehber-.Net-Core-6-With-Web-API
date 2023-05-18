using eRehber.DataAccess.Mappings;
using eRehber.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.DataAccess.Concrete.Context
{
	public class eRehberContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-RG9CD6I\SQLEXPRESS;Database=eRehber;Trusted_Connection=true");
		}

        public DbSet<Person> Persons { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PersonMap());
			
		}
	}
}
