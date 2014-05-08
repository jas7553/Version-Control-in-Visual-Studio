using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionControlInVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing");
            foo();
            Console.ReadKey();
        }

        static void foo()
        {
            Console.WriteLine("test");
            Console.WriteLine("In foo()");
        }
    }
}
