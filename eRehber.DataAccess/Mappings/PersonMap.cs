using eRehber.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.DataAccess.Mappings
{
	public class PersonMap : IEntityTypeConfiguration<Person>
	{
		public void Configure(EntityTypeBuilder<Person> builder)
		{
			builder.HasKey(p => p.UUID);
			builder.Property(p => p.UUID).ValueGeneratedOnAdd();
			builder.Property(p => p.FirstName).IsRequired();
			builder.Property(p => p.FirstName).HasMaxLength(50);
			builder.Property(p => p.LastName).IsRequired();
			builder.Property(p => p.LastName).HasMaxLength(50);
			builder.Property(p => p.Company).IsRequired();
			builder.Property(p => p.PhoneNumber).IsRequired();
			builder.Property(p => p.EMail).IsRequired();
			builder.Property(p => p.Location).IsRequired();
			builder.Property(p => p.InformationContent).IsRequired();


			builder.ToTable("Persons");
		}
	}
}
