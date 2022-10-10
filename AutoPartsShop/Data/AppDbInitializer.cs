using AutoPartsShop.Data.Static;
using AutoPartsShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsShop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            /*using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                //Shop
                if (!context.Shops.Any())
                {
                    context.Shops.AddRange(new List<Shop>()
                    {
                        new Shop()
                        {
                            Name = "Shop 1",
                            Logo = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fthumbs.dreamstime.com%2Fz%2Fautoparts-gear-auto-piston-spark-plug-wrench-logo-design-automotive-parts-automobile-detail-repairing-car-vector-170106468.jpg&imgrefurl=https%3A%2F%2Fwww.dreamstime.com%2Fillustration%2Fauto-parts-logo.html&tbnid=h8fj2uN2vcg7oM&vet=12ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygBegUIARDhAQ..i&docid=7g-lCUOxBv8PSM&w=1600&h=1422&q=autoparts%20shop%20logo&ved=2ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygBegUIARDhAQ",
                            Description = "Skopje"
                        },
                        new Shop()
                        {
                            Name = "Shop 2",
                            Logo = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fi.pinimg.com%2Foriginals%2F58%2Fef%2Fed%2F58efed4afb50d0d069fdd465afe12cf9.jpg&imgrefurl=https%3A%2F%2Fwww.pinterest.com%2Fpin%2F677721443896086117%2F&tbnid=5GoEs39T9uxoZM&vet=12ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygCegUIARDkAQ..i&docid=PxW3lhLpKRGyeM&w=800&h=600&q=autoparts%20shop%20logo&ved=2ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygCegUIARDkAQ",
                            Description = "Bitola"
                        },
                        new Shop()
                        {
                            Name = "Shop 3",
                            Logo = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimg.freepik.com%2Ffree-vector%2Fgradient-auto-parts-logo-design_23-2149455666.jpg%3Fw%3D2000&imgrefurl=https%3A%2F%2Fwww.freepik.com%2Ffree-photos-vectors%2Fauto-parts-logo&tbnid=HbvDmSiYx_AwSM&vet=12ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygFegUIARDsAQ..i&docid=k1y4lpAQoQgb0M&w=2000&h=2000&q=autoparts%20shop%20logo&ved=2ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygFegUIARDsAQ",
                            Description = "Ohrid"
                        },
                        new Shop()
                        {
                            Name = "Shop 4",
                            Logo = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimage.shutterstock.com%2Fimage-vector%2Fvector-logo-car-parts-auto-260nw-1939340251.jpg&imgrefurl=https%3A%2F%2Fwww.shutterstock.com%2Fsearch%2Fauto-parts-logo-design-concept&tbnid=MbYfI1y_kArjIM&vet=12ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygJegUIARD3AQ..i&docid=6OYWqdM9oy6PXM&w=260&h=280&q=autoparts%20shop%20logo&ved=2ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygJegUIARD3AQ",
                            Description = "Struga"
                        },
                        new Shop()
                        {
                            Name = "Shop 5",
                            Logo = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimg.freepik.com%2Ffree-vector%2Fgradient-auto-parts-logo-design_23-2149455668.jpg%3Fw%3D2000&imgrefurl=https%3A%2F%2Fwww.freepik.com%2Ffree-photos-vectors%2Fauto-parts-logo&tbnid=KkVhY3nGrSSexM&vet=12ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygjegUIARC6Ag..i&docid=k1y4lpAQoQgb0M&w=2000&h=2000&q=autoparts%20shop%20logo&ved=2ahUKEwiA-9qzrcb6AhWg4bsIHQ82CD4QMygjegUIARC6Ag",
                            Description = "Tetovo"
                        },
                    });
                    context.SaveChanges();
                }
                //Brands
                if (!context.Brands.Any())
                {
                    context.Brands.AddRange(new List<Brand>()
                    {
                        new Brand()
                        {
                            FullName = "BMW",
                            ProfilePictureURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Flogos-download.com%2Fwp-content%2Fuploads%2F2016%2F02%2FBMW_logo_big_transparent_png.png&imgrefurl=https%3A%2F%2Flogos-download.com%2F140-bmw-logo-download.html&tbnid=fRMkfJFQrVJkbM&vet=12ahUKEwi79raDrsb6AhWD5rsIHWL_AlgQMygBegUIARDjAQ..i&docid=Wz-Tz8Us2XHVrM&w=4060&h=4060&q=bmw%20logo&ved=2ahUKEwi79raDrsb6AhWD5rsIHWL_AlgQMygBegUIARDjAQ"

                        },
                        new Brand()
                        {
                            FullName = "Mercedes-Benz",
                            ProfilePictureURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2F9%2F90%2FMercedes-Logo.svg%2F800px-Mercedes-Logo.svg.png&imgrefurl=https%3A%2F%2Fcommons.wikimedia.org%2Fwiki%2FFile%3AMercedes-Logo.svg&tbnid=4IDaYC-WeupunM&vet=12ahUKEwjL06aSrsb6AhUfi_0HHW_vBiQQMygAegUIARDiAQ..i&docid=7KR56ULKHvbIcM&w=800&h=950&q=mercedes%20logo&ved=2ahUKEwjL06aSrsb6AhUfi_0HHW_vBiQQMygAegUIARDiAQ"
                        },
                        new Brand()
                        {
                            FullName = "Audi",
                            ProfilePictureURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.carlogos.org%2Fcar-logos%2Faudi-logo-1985.png&imgrefurl=https%3A%2F%2Fwww.carlogos.org%2Fcar-brands%2Faudi-logo.html&tbnid=xpSH7WN1Gdk61M&vet=12ahUKEwjd_qqarsb6AhUu7LsIHfDTC2oQMygDegUIARDmAQ..i&docid=662cEJcu6EUJ1M&w=1800&h=1200&q=audi%20logo&ved=2ahUKEwjd_qqarsb6AhUu7LsIHfDTC2oQMygDegUIARDmAQ"
                        },
                        new Brand()
                        {
                            FullName = "Renault",
                            ProfilePictureURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.carlogos.org%2Flogo%2FRenault-logo-2015-2048x2048.png&imgrefurl=https%3A%2F%2Fwww.carlogos.org%2Fcar-brands%2Frenault-logo.html&tbnid=hftIsaDWV6g7NM&vet=12ahUKEwjs2oSjrsb6AhWB5LsIHdY6AG8QMygCegUIARDgAQ..i&docid=q86NgDtKVS1JKM&w=2048&h=2048&q=renault%5C%20logo&ved=2ahUKEwjs2oSjrsb6AhWB5LsIHdY6AG8QMygCegUIARDgAQ"
                        },
                        new Brand()
                        {
                            FullName = "Nissan",
                            ProfilePictureURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2F8%2F8c%2FNissan_logo.png%2F1196px-Nissan_logo.png&imgrefurl=https%3A%2F%2Fcommons.wikimedia.org%2Fwiki%2FFile%3ANissan_logo.png&tbnid=xGRvrsqKv8LfgM&vet=12ahUKEwjMz6Wrrsb6AhW3i_0HHVfNBR8QMygBegUIARDgAQ..i&docid=ZA2rj8t3CyAO1M&w=1196&h=1024&q=nissan%20logo&ved=2ahUKEwjMz6Wrrsb6AhW3i_0HHVfNBR8QMygBegUIARDgAQ"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Valeo",
                            ProfilePictureURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.adhepose.fr%2Fwp-content%2Fuploads%2F2019%2F04%2Fvaleo.jpg&imgrefurl=https%3A%2F%2Fwww.adhepose.fr%2Fproduct%2Flogo-valeo%2F&tbnid=T17Y493T6dOivM&vet=12ahUKEwjSwprWrsb6AhUolv0HHXSCD-wQMygkegUIARCjAg..i&docid=_0J8rZyVwtLcqM&w=1200&h=1200&q=valeo%20logo&ved=2ahUKEwjSwprWrsb6AhUolv0HHXSCD-wQMygkegUIARCjAg",
                            Bio = "Valeo is a French global automotive supplier headquartered in France, listed on the Paris Stock Exchange."

                        },
                        new Producer()
                        {
                            FullName = "Brembo",
                            ProfilePictureURL = "https://www.google.com/search?q=Brembo&bih=722&biw=1536&rlz=1C1GCEA_enMK872MK872&hl=en-GB&tbm=isch&source=iu&ictx=1&vet=1&fir=9w6Jrz1qCEFKiM%252CVksMwala1vAkIM%252C%252Fm%252F07l6ny&usg=AI4_-kTrXVqQ87MJF94U98GXPNwfFFHjhw&sa=X&ved=2ahUKEwiq9ZH1rsb6AhXyS_EDHa5QDJEQ_B16BAhQEAI#imgrc=9w6Jrz1qCEFKiM",
                            Bio = "Brembo S.p.A. is an Italian manufacturer of automotive brake systems, especially for high-performance cars and motorcycles."
                        },
                        new Producer()
                        {
                            FullName = "Michelin",
                            ProfilePictureURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2F1000logos.net%2Fwp-content%2Fuploads%2F2017%2F08%2FMichelin-logo.png&imgrefurl=https%3A%2F%2F1000logos.net%2Fmichelin-logo%2F&tbnid=BrkV59cOku5XvM&vet=12ahUKEwiarPe7rsb6AhUAk_0HHUyjBowQMygAegUIARDdAQ..i&docid=5qEHqulZtFa9BM&w=3840&h=2160&q=michelin%20logo&ved=2ahUKEwiarPe7rsb6AhUAk_0HHUyjBowQMygAegUIARDdAQ",
                            Bio = "Michelin is a French multinational tyre manufacturing company based in Clermont-Ferrand in the Auvergne-Rhône-Alpes région of France."
                        },
                        new Producer()
                        {
                            FullName = "Bosch",
                            ProfilePictureURL = "https://www.google.com/search?q=bosch&bih=722&biw=1536&rlz=1C1GCEA_enMK872MK872&hl=en-GB&tbm=isch&source=iu&ictx=1&vet=1&fir=kjWf4-2ZOBnZVM%252Cho6OIUHnh5TP3M%252C%252Fm%252F01hnkf&usg=AI4_-kTcl-VBCLBPXUuyclUZtMayV7tKNQ&sa=X&ved=2ahUKEwiwo_6Gr8b6AhVvR_EDHeq-ABsQ_B16BAg6EAI#imgrc=kjWf4-2ZOBnZVM",
                            Bio = "Bosch is a German multinational engineering and technology company headquartered in Gerlingen."
                        },
                        new Producer()
                        {
                            FullName = "Castrol",
                            ProfilePictureURL = "https://www.google.com/search?q=castrol&bih=722&biw=1536&rlz=1C1GCEA_enMK872MK872&hl=en-GB&tbm=isch&source=iu&ictx=1&vet=1&fir=r2dMOjzqDJrSLM%252C30YeAFsyESKKVM%252C%252Fm%252F04p1hb&usg=AI4_-kTcRcZnQJfv828UJdMSncBRGKDKig&sa=X&ved=2ahUKEwjc8-iVr8b6AhWsR_EDHX3hB_gQ_B16BAhhEAI#imgrc=r2dMOjzqDJrSLM",
                             Bio = "Castrol is a British oil company that markets industrial and automotive lubricants, offering a wide range of oil, greases and similar products for most lubrication applications."
                        }
                    });
                    context.SaveChanges();
                }
                //PartName
                if (!context.PartNames.Any())
                {
                    context.PartNames.AddRange(new List<PartName>()
                    {
                        new PartName()
                        {
                            Name = "Air Filter",
                            Description = "Air Filter for Mercedes",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            ShopId = 3,
                            ProducerId = 3,
                            PartCategory = PartCategory.AirFilter
                        },
                        new PartName()
                        {
                            Name = "Brakes",
                            Description = "Brakes for Nissan",
                            Price = 120,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            ShopId = 1,
                            ProducerId = 1,
                            PartCategory = PartCategory.Brakes
                        },
                        new PartName()
                        {
                            Name = "Oil",
                            Description = "5W 40",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            ShopId = 4,
                            ProducerId = 4,
                            PartCategory = PartCategory.Oil
                        },
                        new PartName()
                        {
                            Name = "Oil Filter",
                            Description = "Oil Filter for Nissan",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            ShopId = 1,
                            ProducerId = 2,
                            PartCategory = PartCategory.OilFilter
                        },
                        new PartName()
                        {
                            Name = "Brakes",
                            Description = "Brakes for Renault",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            ShopId = 1,
                            ProducerId = 3,
                            PartCategory = PartCategory.Brakes
                        },
                        new PartName()
                        {
                            Name = "Air Filter",
                            Description = "Air Filter for BMW",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            ShopId = 1,
                            ProducerId = 5,
                            PartCategory = PartCategory.AirFilter
                        }
                    });
                    context.SaveChanges();
                }
                //Brand & PartName
                if (!context.Brands_PartNames.Any())
                {
                    context.Brands_PartNames.AddRange(new List<Brand_PartName>()
                    {
                        new Brand_PartName()
                        {
                            BrandId = 1,
                            PartNameId = 1
                        },
                        new Brand_PartName()
                        {
                            BrandId = 3,
                            PartNameId = 1
                        },

                         new Brand_PartName()
                        {
                            BrandId = 1,
                            PartNameId = 2
                        },
                         new Brand_PartName()
                        {
                            BrandId = 4,
                            PartNameId = 2
                        },

                        new Brand_PartName()
                        {
                            BrandId = 1,
                            PartNameId = 3
                        },
                        new Brand_PartName()
                        {
                            BrandId = 2,
                            PartNameId = 3
                        },
                        new Brand_PartName()
                        {
                            BrandId = 5,
                            PartNameId = 3
                        },


                        new Brand_PartName()
                        {
                            BrandId = 2,
                            PartNameId = 4
                        },
                        new Brand_PartName()
                        {
                            BrandId = 3,
                            PartNameId = 4
                        },
                        new Brand_PartName()
                        {
                            BrandId = 4, 
                            PartNameId = 4
                        },


                        new Brand_PartName()
                        {
                            BrandId = 2,
                            PartNameId = 5
                        },
                        new Brand_PartName()
                        {
                            BrandId = 3,
                            PartNameId = 5
                        },
                        new Brand_PartName()
                        {
                            BrandId = 4,
                            PartNameId = 5
                        },
                        new Brand_PartName()
                        {
                            BrandId = 5,
                            PartNameId = 5
                        },


                        new Brand_PartName()
                        {
                            BrandId = 3,
                            PartNameId = 6
                        },
                        new Brand_PartName()
                        {
                            BrandId = 4,
                            PartNameId = 6
                        },
                        new Brand_PartName()
                        {
                            BrandId = 5,
                            PartNameId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }*/
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                
                if(!await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                string adminUserEmail = "admin@epartshop.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                

                string appUserEmail = "user@epartshop.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
