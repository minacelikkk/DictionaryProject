﻿using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContactDal:GenericRepository<Contact>,IContactDal
    {
    }
}
