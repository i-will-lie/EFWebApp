using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFWebApp.Models;

namespace EFWebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{Username="Anne",JoinDate=DateTime.Parse("2005-09-01")},
            new User{Username="Bob",JoinDate=DateTime.Parse("2005-09-01")},
            new User{Username="Carol",JoinDate=DateTime.Parse("2000-09-01")},


            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

        }
    }
}
