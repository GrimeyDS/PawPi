using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class ApplicationUserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            IPasswordHasher<ApplicationUser> _hasher = new PasswordHasher<ApplicationUser>();

            var admin = new ApplicationUser
            {
                Id = "1",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@pawpi.COM",
                NormalizedEmail = "ADMIN@PAWPI.COM",
                SecurityStamp = new Guid().ToString(),
                ConcurrencyStamp = new Guid().ToString(),
            };

            var roles = new IdentityRole<string>[]
            {
                new IdentityRole<string>
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                },
                new IdentityRole<string>
                {
                    Id = "2",
                    Name = "Veterinarian",
                    NormalizedName = "VETERINARIAN",
                },
                new IdentityRole<string>
                {
                    Id = "3",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                }
            };

            #region Customers
            var customerUsers = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Id = "2",
                    CustomerId = 1,
                    UserName = "svends@gmail.com",
                    NormalizedUserName = "svends@gmail.com".ToUpper(),
                    Email = "svends@gmail.com",
                    NormalizedEmail = "svends@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "3",
                    CustomerId = 2,
                    UserName = "vb@gmail.com",
                    NormalizedUserName = "vb@gmail.com".ToUpper(),
                    Email = "vb@gmail.com",
                    NormalizedEmail = "vb@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "4",
                    CustomerId = 3,
                    UserName = "kdv@outlook.com",
                    NormalizedUserName = "kdv@outlook.com".ToUpper(),
                    Email = "kdv@outlook.com",
                    NormalizedEmail = "kdv@outlook.com".ToUpper()

                },
                new ApplicationUser
                {
                    Id = "5",
                    CustomerId = 4,
                    UserName = "makkermaat@telenet.be",
                    NormalizedUserName = "makkermaat@telenet.be".ToUpper(),
                    Email = "makkermaat@telenet.be",
                    NormalizedEmail = "makkermaat@telenet.be".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "6",
                    CustomerId = 5,
                    UserName = "sarahdv@proximus.be",
                    NormalizedUserName = "sarahdv@proximus.be".ToUpper(),
                    Email = "sarahdv@proximus.be",
                    NormalizedEmail = "sarahdv@proximus.be".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "7",
                    CustomerId = 6,
                    UserName = "jdv@yahoo.com",
                    NormalizedUserName = "jdv@yahoo.com".ToUpper(),
                    Email = "jdv@yahoo.com",
                    NormalizedEmail = "jdv@yahoo.com".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "8",
                    CustomerId = 7,
                    UserName = "mieketjeeeeh@gmail.com",
                    NormalizedUserName = "mieketjeeeeh@gmail.com".ToUpper(),
                    Email = "mieketjeeeeh@gmail.com",
                    NormalizedEmail = "mieketjeeeeh@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "9",
                    CustomerId = 8,
                    UserName = "jeffkeeuh@gmail.com",
                    NormalizedUserName = "jeffkeeuh@gmail.com".ToUpper(),
                    Email = "jeffkeeuh@gmail.com",
                    NormalizedEmail = "jeffkeeuh@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "10",
                    CustomerId = 9,
                    UserName = "hansdissen@telenet.be",
                    NormalizedUserName = "hansdissen@telenet.be".ToUpper(),
                    Email = "hansdissen@telenet.be",
                    NormalizedEmail = "hansdissen@telenet.be".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "11",
                    CustomerId = 10,
                    UserName = "chaydz@gmail.com",
                    NormalizedUserName = "chaydz@gmail.com".ToUpper(),
                    Email = "chaydz@gmail.com",
                    NormalizedEmail = "chaydz@gmail.com".ToUpper()
                }
            };

            var customerRoles = new List<IdentityUserRole<string>>();

            foreach(var user in customerUsers)
            {
                user.PasswordHash = _hasher.HashPassword(user, Guid.NewGuid().ToString());
                customerRoles.Add(new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = user.Id
                });
            }

            var testCustomer = new ApplicationUser
            {
                Id = "12",
                CustomerId = 999,
                UserName = "Customer@test.com",
                NormalizedUserName = "Customer@test.com".ToUpper(),
                Email = "Customer@test.com",
                NormalizedEmail = "Customer@test.com".ToUpper()
            };

            testCustomer.PasswordHash = _hasher.HashPassword(testCustomer, "Test123");
            customerUsers.Add(testCustomer);


            #endregion

            modelBuilder.Entity<ApplicationUser>().HasData(customerUsers);
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(customerRoles);
        }
    }
}
