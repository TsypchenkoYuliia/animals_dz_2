using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Helpers;

namespace DataAccess.Context.Initializer
{
    public static class DbInitializer
    {
        public static void Initialize(AnimalContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cats.Any())
            {
                return;
            }

            context.Cats.AddRange(new Cat[] {
                new Cat() { Name = "Murzik", Age = 5 },
            });

            context.Dogs.AddRange(new Dog[] {
                new Dog() { Name = "Rem", Age = 2 },
            });

            context.Users.AddRange(new User[] {
                new User() { Email = "admin@gmail.com", Password = Crypto.SHA256("admin@gmail.com"), Role="admin" },
                new User() { Email = "employee1@gmail.com", Password = Crypto.SHA256("employee1@gmail.com"), Role="employee" },
                new User() { Email = "employee2@gmail.com", Password = Crypto.SHA256("employee2@gmail.com"), Role="manager" },
                new User() { Email = "employee3gmail.com", Password = Crypto.SHA256("employee3gmail.com"), Role="employee" },
                new User() { Email = "employee4@gmail.com", Password = Crypto.SHA256("employee4@gmail.com"), Role="employee" },
                new User() { Email = "employee5@gmail.com", Password = Crypto.SHA256("employee5@gmail.com"), Role="manager" }
            });

            context.SaveChanges();
        }
    }
}
