using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class DraftManager : IDraftService
    {
        IDraftDal _draftDal;

        public DraftManager(IDraftDal draftDal)
        {
            _draftDal = draftDal;
        }

        public void Add(Draft draft)
        {
            _draftDal.Add(draft);
        }

        public void Delete(Draft draft)
        {
            _draftDal.Delete(draft);
        }

        public List<Draft> GetAll()
        {
            return _draftDal.GetAll();
        }

        public Draft GetById(int id)
        {
            return _draftDal.Get(d => d.DraftId == id);
        }

        public void Update(Draft draft)
        {
            _draftDal.Update(draft);
        }
    }
}
