using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace LogicalProgram
{
    public class Logic
    {
        public static void Pro()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Type start");
            String start = Console.ReadLine();
            Console.WriteLine("Started");
            stopwatch.Start();                      //Start timing
            Console.WriteLine("Type stop"); 
            String stop = Console.ReadLine();
            stopwatch.Stop();                        // Stop timing
            Console.WriteLine("Stoped");
            Console.WriteLine("Time Elapsed : " + stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}