using System;
using Microsoft.EntityFrameworkCore;

namespace WebApp.DataModels
{
	public class MyDBContext : DbContext
	{
		public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
		public DbSet<Person> Persons { get; set; }

		public static void FirstMain(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();

			builder.Services.AddDbContext<MyDBContext>(options =>
			{
				options.UseSqlite(@"Data source=\Users\tihonsavenkov\Projects\Temp");
			});
		}
	}
}