using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserRegEON.Models;

namespace UserRegEON.Data
{
    public class UserRegEONContext : DbContext
    {
        public UserRegEONContext (DbContextOptions<UserRegEONContext> options)
            : base(options)
        {
        }

        public DbSet<UserRegEON.Models.User> User { get; set; }
    }
}
