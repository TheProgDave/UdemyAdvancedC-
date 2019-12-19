using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pic = new Photo();
            var processor = new PhotoProcessor(
                new PhotoFilters(
                    new List<IEffect>() { new BrightnessEffect(), new ContrastEffect(), new ResizeEffect() }), 
                    pic);
            processor.Process();
            
        }
    }
}
