using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IImageFileService
    {
        List<ImageFile> GetAll();
        void Add(ImageFile imageFile);
        void Delete(ImageFile imageFile);
        void Update(ImageFile imageFile);
        ImageFile GetById(int id);
        
    }
}
