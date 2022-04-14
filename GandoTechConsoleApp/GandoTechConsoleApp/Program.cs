using System;
using System.Threading;

namespace GandoTechConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = MyProcess.DoProcess(1000, 1);
            if (result)
                Console.WriteLine("App has been finished successfully.");
            else
                Console.WriteLine("App has NOT been finished successfully.");
        }
    }
}
