using System;

namespace Delegates
{
    public class BrightnessEffect : IEffect
    {
        public void Apply(IPicture pic)
        {
            Console.WriteLine("Applies brightness");
        }
    }
}