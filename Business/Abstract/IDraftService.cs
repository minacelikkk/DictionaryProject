using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDraftService
    {
        List<Draft> GetAll();
        void Add(Draft draft);
        void Delete(Draft draft);
        void Update(Draft draft);
        Draft GetById(int id);
    }
}
