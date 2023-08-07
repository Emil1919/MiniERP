using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Services.Data;
using MiniERP.Services.Data.Interfaces;

namespace Mini_ERP
{
	public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<MiniERP_DbContext>(options =>
                options.UseSqlServer(connectionString));
            

            builder.Services.AddDefaultIdentity<IdentityUser>(options => 
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = true;
                    options.Password.RequireLowercase = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                
                })

                .AddEntityFrameworkStores<MiniERP_DbContext>();
            builder.Services.AddScoped<IProductService,ProductService>();
            builder.Services.AddScoped<IInvoiceService,InvoiceService>();
            builder.Services.AddScoped<IOrderService ,OrderService>();
            builder.Services.AddControllersWithViews();


            var app = builder.Build();

           
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapDefaultControllerRoute();
            app.MapRazorPages();
            
            app.Run();
        }
    }
}