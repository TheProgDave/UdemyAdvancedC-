using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionHandling
{
    public class TryCatchUsing
    {
        public static void  HandleWithTryCatchUsing()
        {
            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    //TODO Output contents of the stream reader
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry there was an unexpected error!");
                Console.WriteLine(e);
                // It is common practice to re-throw custom errors in large project-code such that the origin of the fault is easily identifiable. 
            }

        }
    }
}
