using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;
using System.Security.Claims;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class ApplicationUserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            IPasswordHasher<ApplicationUser> _hasher = new PasswordHasher<ApplicationUser>();


            #region Admin
            var admin = new ApplicationUser
            {
                Id = "1",
                UserName = "admin@pawpi.com",
                NormalizedUserName = "admin@pawpi.com".ToUpper(),
                Email = "admin@pawpi.com",
                NormalizedEmail = "admin@pawpi.com".ToUpper(),
                SecurityStamp = new Guid().ToString(),
                ConcurrencyStamp = new Guid().ToString(),
                EmailConfirmed = true
            };

            admin.PasswordHash = _hasher.HashPassword(admin, "Test12345");

            var adminClaim = new IdentityUserClaim<string>[]
            {
                new IdentityUserClaim<string>
                {
                    Id = 1,
                    UserId = admin.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Admin"
                },
                new IdentityUserClaim<string>
                {
                    Id = 2,
                    UserId = admin.Id,
                    ClaimType = ClaimTypes.NameIdentifier,
                    ClaimValue = admin.Id
                },
            };

            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(adminClaim);
            #endregion

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

            var customerClaims = new List<IdentityUserClaim<string>>();

            foreach(var user in customerUsers)
            {
                user.PasswordHash = _hasher.HashPassword(user, Guid.NewGuid().ToString());
                customerClaims.Add(new IdentityUserClaim<string>
                {
                    Id = (int)user.CustomerId + 20,
                    UserId = user.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Customer"
                });
                customerClaims.Add(new IdentityUserClaim<string>
                {
                    Id = (int)user.CustomerId + 41,
                    UserId = user.Id,
                    ClaimType = ClaimTypes.NameIdentifier,
                    ClaimValue = user.Id
                });
                user.EmailConfirmed = true;
            }

            var testCustomer = new ApplicationUser
            {
                Id = "12",
                CustomerId = 999,
                UserName = "Customer@test.com",
                NormalizedUserName = "Customer@test.com".ToUpper(),
                Email = "Customer@test.com",
                NormalizedEmail = "Customer@test.com".ToUpper(),
                EmailConfirmed = true
            };

            customerClaims.Add(new IdentityUserClaim<string>
            {
                Id = (int)testCustomer.CustomerId + 20,
                UserId = testCustomer.Id,
                ClaimType = ClaimTypes.Role,
                ClaimValue = "Customer"
            });
            customerClaims.Add(new IdentityUserClaim<string>
            {
                Id = (int)testCustomer.CustomerId + 41,
                UserId = testCustomer.Id,
                ClaimType = ClaimTypes.NameIdentifier,
                ClaimValue = testCustomer.Id
            });

            testCustomer.PasswordHash = _hasher.HashPassword(testCustomer, "Test12345");
            customerUsers.Add(testCustomer);
            customerUsers.Add(admin);

            modelBuilder.Entity<ApplicationUser>().HasData(customerUsers);
            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(customerClaims);
            #endregion

            #region Veterinarians
            var veterinarianUsers = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Id = "13",
                    VeterinarianId = 1,
                    UserName = "vl@deberenakker.be",
                    NormalizedUserName = "vl@deberenakker.be".ToUpper(),
                    Email = "vl@deberenakker.be",
                    NormalizedEmail = "vl@deberenakker.be".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "14",
                    VeterinarianId = 2,
                    UserName = "wb@gmail.com",
                    NormalizedUserName = "wb@gmail.com".ToUpper(),
                    Email = "wb@gmail.com",
                    NormalizedEmail = "wb@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "15",
                    VeterinarianId = 3,
                    UserName = "kdv@gmail.com",
                    NormalizedUserName = "kdv@gmail.com".ToUpper(),
                    Email = "kdv@gmail.com",
                    NormalizedEmail = "kdv@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "16",
                    VeterinarianId = 4,
                    UserName = "SanneDZ@telenet.be",
                    NormalizedUserName = "SanneDZ@telenet.be".ToUpper(),
                    Email = "SanneDZ@telenet.be",
                    NormalizedEmail = "SanneDZ@telenet.be".ToUpper()
                },
                new ApplicationUser
                {
                    Id = "17",
                    VeterinarianId = 5,
                    UserName = "Lottevanputte@proximus.be",
                    NormalizedUserName = "Lottevanputte@proximus.be".ToUpper(),
                    Email = "Lottevanputte@proximus.be",
                    NormalizedEmail = "Lottevanputte@proximus.be".ToUpper()
                }
            };

            var vetClaims = new List<IdentityUserClaim<string>>();

            foreach (var user in veterinarianUsers)
            {
                user.PasswordHash = _hasher.HashPassword(user, Guid.NewGuid().ToString());
                vetClaims.Add(new IdentityUserClaim<string>
                {
                    Id = (int)user.VeterinarianId + 60,
                    UserId = user.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Veterinarian"
                });
                vetClaims.Add(new IdentityUserClaim<string>
                {
                    Id = (int)user.VeterinarianId + 81,
                    UserId = user.Id,
                    ClaimType = ClaimTypes.NameIdentifier,
                    ClaimValue = user.Id
                });
                user.EmailConfirmed = true;
            }

            var testVet = new ApplicationUser
            {
                Id = "18",
                VeterinarianId = 999,
                UserName = "Veterinarian@test.com",
                NormalizedUserName = "Veterinarian@test.com".ToUpper(),
                Email = "Veterinarian@test.com",
                NormalizedEmail = "Veterinarian@test.com".ToUpper(),
                EmailConfirmed = true
            };

            vetClaims.Add(new IdentityUserClaim<string>
            {
                Id = (int)testVet.VeterinarianId + 60,
                UserId = testVet.Id,
                ClaimType = ClaimTypes.Role,
                ClaimValue = "Veterinarian"
            });
            vetClaims.Add(new IdentityUserClaim<string>
            {
                Id = (int)testVet.VeterinarianId + 81,
                UserId = testVet.Id,
                ClaimType = ClaimTypes.NameIdentifier,
                ClaimValue = testVet.Id
            });

            testVet.PasswordHash = _hasher.HashPassword(testVet, "Test12345");
            veterinarianUsers.Add(testVet);

            modelBuilder.Entity<ApplicationUser>().HasData(veterinarianUsers);
            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(vetClaims);
            #endregion

            #region Practices

            #endregion
        }
    }
}
