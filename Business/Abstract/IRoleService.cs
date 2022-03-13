using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAll();
        void Add(Role role);
        void Delete(Role role);
        void Update(Role role);
        Role GetById(int id);
    }
}

