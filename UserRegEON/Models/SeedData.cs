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
                if (context.Users.Any())
                {
                    return; //Database has been seeded
                }

                context.Users.AddRange(
                    new User
                    {
                        Name = "Alexander Ege",
                        Email = "Alexander@Ege.com",
                        Gender = "M",
                        DateRegistered = DateTime.ParseExact("24/10/2019", "dd/MM/yyyy", null),
                        Days = "Day1, Day2",
                        Requests = "None"
                    },

                    new User
                    {
                        Name = "Stephen Kaatz",
                        Email = "Stephen@K.com",
                        Gender = "M",
                        DateRegistered = DateTime.ParseExact("04/08/2019", "dd/MM/yyyy", null),
                        Days = "Day1, Day2, Day3",
                        Requests = "Private Room"
                    },

                    new User
                    {
                        Name = "Jane Doe",
                        Email = "JaneDoe@gmail.com",
                        Gender = "F",
                        DateRegistered = DateTime.ParseExact("12/11/2019", "dd/MM/yyyy", null),
                        Days = "Day1",
                        Requests = "Bringing a plus one."

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
