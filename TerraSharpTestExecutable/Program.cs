using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp;

namespace TerraSharpTest
{
    class TerraSharpTestExecutable
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello worlds");

            TerraStartup.InitializeKernel(); // Run this method to initialize the TerraSharp Library
        }
    }
}