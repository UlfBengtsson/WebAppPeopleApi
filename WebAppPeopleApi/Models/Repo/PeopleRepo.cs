﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeopleApi.Data;
using WebAppPeopleApi.Models.Entity;

namespace WebAppPeopleApi.Models.Repo
{
    public class PeopleRepo : IPeopleRepo
    {
        private readonly AppDbContext _appDb;

        public PeopleRepo(AppDbContext appDb)
        {
            _appDb = appDb;
        }

        public Person Create(Person person)
        {
            person.Id = Guid.NewGuid();
            person.Created = DateTime.Now;
            person.Modified = DateTime.Now;

            _appDb.People.Add(person);

            _appDb.SaveChanges();

            return person;
        }

        public void Delete(Person person)
        {
            _appDb.People.Remove(person);
            _appDb.SaveChanges();
        }

        public Person FindByEmail(string email)
        {
            return _appDb.People.SingleOrDefault( p => p.Email.Equals(email));
        }

        public Person FindById(Guid id)
        {
            return _appDb.People.SingleOrDefault( p => p.Id == id);
        }

        public List<Person> GetAll()
        {
            return _appDb.People.ToList();
        }

        public void Update(Person person)
        {
            //person.Modified = DateTime.Now;
            _appDb.Entry(person).State = EntityState.Modified;
            _appDb.SaveChanges();
        }
    }
}
