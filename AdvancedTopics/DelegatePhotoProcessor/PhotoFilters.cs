using System;

namespace DelegatePhotoProcessor
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Adjusting brightness...");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Adjusting contrast...");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing...");
        }
    }
}