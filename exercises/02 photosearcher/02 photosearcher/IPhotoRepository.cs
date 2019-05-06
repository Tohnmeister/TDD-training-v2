using System.Collections.Generic;

namespace _02_photosearcher
{
    public interface IPhotoRepository
    {
        IList<IPhoto> GetPhotos();
        void DeletePhotos(IList<int> ids);
    }
}