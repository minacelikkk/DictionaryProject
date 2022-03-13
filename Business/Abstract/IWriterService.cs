﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetAll();
        void Add(Writer writer);
        void Delete(Writer writer);
        void Update(Writer writer);
        Writer GetById(int id);
    }
}
