using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Services.Description;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Project_63135350.Models.Model_63135350;
using Project_63135350.Models.Models_63135350;

namespace Project_63135350.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Category_63135350> Categories { get; set; }
        public DbSet<News_63135350> News { get; set; }
        public DbSet<ProductCategory_63135350> ProductCategories { get; set; }
        public DbSet<Product_63135350> Products { get; set; }
        public DbSet<ProductImage_63135350> ProductImages { get; set; }
        public DbSet<Contact_63135350> Contacts { get; set; }
        public DbSet<Order_63135350> Orders { get; set; }
        public DbSet<OrderDetail_63135350> OrderDetails { get; set; }

        public DbSet<CustomerInfo> CustomerInfo { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
