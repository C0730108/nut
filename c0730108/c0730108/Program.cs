using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c0730108
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Download();
            Console.ReadLine();

        }
        static void Download()
        {
            //task 1
            Thread.Sleep(7000);
            Console.WriteLine("Download complete");
        } 
        
    }
}
