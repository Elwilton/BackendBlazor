using System;
using CrudYTB.models;
using Microsoft.EntityFrameworkCore;

namespace CrudYTB.Data
{
	public class AppDBContext : DbContext
	{
		public DbSet<Company> Companies { get; set; }

		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{

		}
	}
}

