using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeopleApi.Models.Entity;

namespace WebAppPeopleApi.Models.Repo
{
    public interface IPeopleRepo
    {
        //C
        Person Create(Person person);

        //R
        Person FindById(Guid id);
        Person FindByEmail(string email);
        List<Person> GetAll();

        //U
        void Update(Person person);

        //D
        void Delete(Person person);


    }
}
