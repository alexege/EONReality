using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserRegEON.Data;

namespace UserRegEON.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserRegEONContext(
                serviceProvider.GetRequiredService<DbContextOptions<UserRegEONContext>>()))
            {
                //Look for any Users
                if (context.User.Any())
                {
                    return; //Database has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        Name = "Alexander Ege",
                        Email = "Alexander@Ege.com",
                        Gender = "M",
                        DateRegistered = DateTime.Parse("2019-24-10"),
                        Days = "Day1, Day2",
                        Requests = "None"
                    },

                    new User
                    {
                        Name = "Stephen Kaatz",
                        Email = "Stephen@K.com",
                        Gender = "M",
                        DateRegistered = DateTime.Parse("2019-04-10"),
                        Days = "Day1, Day2, Day3",
                        Requests = "Private Room"
                    },

                    new User
                    {
                        Name = "Jane Doe",
                        Email = "JaneDoe@gmail.com",
                        Gender = "F",
                        DateRegistered = DateTime.Parse("2019-21-10"),
                        Days = "Day1",
                        Requests = "Bringing a plus one."

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
