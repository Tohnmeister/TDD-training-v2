using System;

namespace _02_photosearcher
{
    public class PhotoDeleter
    {
        private IPhotoRepository photoRepository;

        public PhotoDeleter(IPhotoRepository photoRepository)
        {
            this.photoRepository = photoRepository;
        }

        public void DeletePhotos(FuzzyDate fuzzyDate)
        {
            // Use test-driven development to implement this method
            throw new NotImplementedException();
        }

        public void DeletePhotos(FuzzyDate fuzzyDate, Color color, ContentType? contentType)
        {
            // Use test-driven development to implement this method
            throw new NotImplementedException();
        }

    }
}
