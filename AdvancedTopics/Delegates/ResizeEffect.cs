using System;

namespace Delegates
{
    public class ResizeEffect : IEffect
    {
        public void Apply(IPicture pic)
        {
            Console.WriteLine("Applies resize");
        }
    }
}