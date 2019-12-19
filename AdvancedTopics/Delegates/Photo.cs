using System;

namespace Delegates
{
    public class Photo : IPicture
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("The photo has been saved");
        }
    }
}