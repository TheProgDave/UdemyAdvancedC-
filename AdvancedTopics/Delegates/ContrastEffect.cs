using System;

namespace Delegates
{
    public class ContrastEffect : IEffect
    {
        public void Apply(IPicture pic)
        {
            Console.WriteLine("Applies contrast");
        }
    }
}