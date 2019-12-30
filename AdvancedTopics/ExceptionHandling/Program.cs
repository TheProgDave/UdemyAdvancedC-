using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatchFinally.HandleWithTryCatchFinally();
            TryCatchUsing.HandleWithTryCatchUsing();
        }
    }
}
