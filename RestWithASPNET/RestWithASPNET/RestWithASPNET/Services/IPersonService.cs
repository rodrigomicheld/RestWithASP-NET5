﻿using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindbyId(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);  

    }
}
