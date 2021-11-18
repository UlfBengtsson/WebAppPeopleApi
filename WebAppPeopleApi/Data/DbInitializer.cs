using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeopleApi.Models.Entity;

namespace WebAppPeopleApi.Data
{
    internal class DbInitializer
    {
        internal static void Initialize(AppDbContext context)
        {
            /*
               Will create the database if it does not already exist.  
            */
            context.Database.EnsureCreated();
            //context.Database.Migrate();//applies any pending migrations for the context to the database.

            if (context.People.Any())//Check if there are any people in the database, if there are end the Initialize here. 
            {
                return;
            }

            //Seeding in some people if there where not anyone in the database.
            Person person1 = new Person
            {
                FirstName = "Mehrdad",
                LastName = "Javan",
                Email = "Mehrdad.Javan@Lexicon.se",
                Title = "Teacher",
                Created = DateTime.Now,
                Modified = DateTime.Now
            };
            Person person2 = new Person
            {
                FirstName = "Ulf",
                LastName = "Bengtsson",
                Email = "Ulf.Bengtsson@Lexicon.se",
                Title = "Teacher",
                Created = DateTime.Now,
                Modified = DateTime.Now
            };
            Person person3 = new Person
            {
                FirstName = "Fredrik",
                LastName = "Odin",
                Email = "Fredrik.Odin@Adapta.se",
                Title = "Consultant",
                Created = DateTime.Now,
                Modified = DateTime.Now
            };

            context.People.Add(person1);
            context.People.Add(person2);
            context.People.Add(person3);

            context.SaveChanges();
        }
    }
}
