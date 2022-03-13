using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imageFileDal;

        public ImageFileManager(IImageFileDal imageFileDal)
        {
            _imageFileDal = imageFileDal;
        }

        public void Add(ImageFile imageFile)
        {
            _imageFileDal.Add(imageFile);
        }

        public void Delete(ImageFile imageFile)
        {
            _imageFileDal.Delete(imageFile);
        }

        public List<ImageFile> GetAll()
        {
            return _imageFileDal.GetAll();
        }

        public ImageFile GetById(int id)
        {
            return _imageFileDal.Get(i => i.ImageId == id);
        }

        public void Update(ImageFile imageFile)
        {
            _imageFileDal.Update(imageFile);
        }
    }
}
