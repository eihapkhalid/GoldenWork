using Bl;
using Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GoldenWorkSys
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<FireSystemContractsDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            //identity AspNetCore Step 3 : Add Identity
            builder.Services.AddIdentity<ApplicationUser,IdentityRole>(Options=>
			{
				Options.Password.RequiredLength = 8;
				Options.Password.RequireNonAlphanumeric= true;
				Options.Password.RequireUppercase= true;
				Options.User.RequireUniqueEmail = true;
			}).AddEntityFrameworkStores<FireSystemContractsDbContext>();

            builder.Services.AddScoped<IBusinessLayer<TbContract>, ClsContract>();
            builder.Services.AddScoped<IBusinessLayer<VwContractMaintnceService>, ClsVwContractMaintnceService>();
            builder.Services.AddScoped<IBusinessLayer<TbMaintenanceServicesItem>, ClsTbMaintenanceServicesItem>(); 


            var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

            //identity AspNetCore Step 5 : add Authorization and do migrations in database
            app.UseAuthentication();
            app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				app.MapControllerRoute(
				name: "admin",
				pattern: "{area:exists}/{controller=Contract}/{action=List}");

				app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Contract}/{action=List}/{id?}");
			});

			

			app.Run();
		}
	}
}