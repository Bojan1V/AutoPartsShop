using AutoPartsShop.Models;
using Microsoft.AspNetCore.Builder;
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
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
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
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Shop()
                        {
                            Name = "Shop 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Shop()
                        {
                            Name = "Shop 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Shop()
                        {
                            Name = "Shop 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Shop()
                        {
                            Name = "Shop 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
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
                            FullName = "Brand 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Brand()
                        {
                            FullName = "Brand 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Brand()
                        {
                            FullName = "Brand 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Brand()
                        {
                            FullName = "Brand 4",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Brand()
                        {
                            FullName = "Brand 5",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
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
                            FullName = "Producer 1",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg",
                            Bio = "test123"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg",
                Bio = "test123"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg",
                Bio = "test123"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg",
                Bio = "test123"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg",
                Bio = "test123"
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
                            Description = "Brakes for Toyota",
                            Price = 29.50,
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
            }
        }
    }
}
