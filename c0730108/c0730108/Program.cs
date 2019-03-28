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
            Network.Download();
        }
       // {
            //task 1
          //  Task.Run(() =>
          // {
             //  Thread.Sleep(7000);
            //   Console.WriteLine("Download complete");
          // }
          //  );
      //  } 
        
    }
    class Network
    {
        static public Task Download()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }
    }
}
