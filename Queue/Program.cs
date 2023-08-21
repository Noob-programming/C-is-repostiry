//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace queue
{
    internal abstract class Program
    {
        private static void Main()
        {
            try
            {
                Queue<PrintJob> fQueue = new Queue<PrintJob>();
                fQueue.Enqueue(new PrintJob("fsdgjfdhfgj", 2));
                fQueue.Enqueue(new PrintJob("fsdgjhfdgj", 32));
                fQueue.Enqueue(new PrintJob("fsdgjhfdgj", 22));
                fQueue.Enqueue(new PrintJob("fsdgjgj", 22));
                fQueue.Enqueue(new PrintJob("fshfgj", 21));
                fQueue.Enqueue(new PrintJob("fshfgj", 23));
                foreach (var printJob in fQueue)
                {
                    Console.WriteLine(printJob);
                }

                Console.WriteLine($"Count is : {fQueue.Count}\n Capitcy is :{fQueue}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }

    public class PrintJob
    {
        private readonly int _copies;
        private readonly string _file;

        public PrintJob(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }

        public override string ToString() { return $"{_file} x #{_copies} copies"; }
    }
}
