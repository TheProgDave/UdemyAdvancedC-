using System;

namespace DelegatePhotoProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            //filterHandler += filters.Resize;
            processor.Process("irrelevant", filterHandler);
        }
    }
}
