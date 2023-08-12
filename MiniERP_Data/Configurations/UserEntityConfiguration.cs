
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MiniERP.Data.Configurations
{
    
    public class UserEntityConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();

        public IdentityUser admin = new IdentityUser
        {
            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "admin@gmail.com",
            NormalizedEmail= "admin@gmail.com"
            
        };
        public IdentityUser user = new IdentityUser
        {
            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
            UserName = "user",
            NormalizedUserName = "USER",
            Email = "user@gmail.com",
            NormalizedEmail = "user@gmail.com"
        };
        
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            admin.PasswordHash = hasher.HashPassword(admin, "Admin123");
            user.PasswordHash = hasher.HashPassword(user, "User123");
            builder.HasData(admin,user);


        }
    }


    
}
    

