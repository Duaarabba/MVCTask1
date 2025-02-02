﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Employee> Employees {  get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=.;database=mvctask1;trusted_connection=true;TrustServerCertificate=True");
		}
	}
}
