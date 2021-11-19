using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeopleApi.Models.ViewModels;

namespace WebAppPeopleApi.Models.Services
{
    public interface IPeopleService
    {
        //C
        PersonViewModel Create(PersonCreateVM person);

        //R
        PersonViewModel FindById(int id);
        PersonViewModel FindByEmail(string email);
        IEnumerable<PersonViewModel> GetAll();
        IEnumerable<PersonViewModel> GetFromDateTime(DateTime from);

        //U
        bool Update(PersonViewModel person);

        //D
        bool Delete(int id);
    }
}
