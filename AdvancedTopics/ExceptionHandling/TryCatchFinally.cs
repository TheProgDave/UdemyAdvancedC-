using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionHandling
{
    public class TryCatchFinally
    {
        
        public static void HandleWithTryCatchFinally()
        {
            var streamReader = new StreamReader(@"c:\file.zip");
            try
            {
                Console.WriteLine(Calculator.Divide(56, 0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry there was an unexpected error!");
                Console.WriteLine(e);
            }
            finally
            {
                streamReader.Dispose();
            }
        }
    }
}
