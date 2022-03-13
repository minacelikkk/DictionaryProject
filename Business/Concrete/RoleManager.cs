using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Add(Role role)
        {
            _roleDal.Add(role);
        }

        public void Delete(Role role)
        {
            _roleDal.Delete(role);
        }

        public List<Role> GetAll()
        {
            return _roleDal.GetAll();
        }

        public Role GetById(int id)
        {
            return _roleDal.Get(r => r.RoleId == id);
        }

        public void Update(Role role)
        {
            _roleDal.Update(role);
        }
    }
}
