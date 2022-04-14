using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GandoTechConsoleApp
{
    public static class MyProcess
    {
        public static bool DoProcess(int sleepInterval, int stopInterval)
        {
            if (sleepInterval <= 0 || stopInterval <= 0) return false;

            Console.WriteLine($"GandoTech app started at {DateTime.Now.ToUniversalTime()}");
            Console.WriteLine($"=========================================================");
            var stopTime = DateTime.Now.ToUniversalTime().AddMinutes(stopInterval);
            while (DateTime.Now.ToUniversalTime() < stopTime)
            {
                Console.WriteLine($"GandoTech app is going to sleep at {DateTime.Now.ToUniversalTime()}");
                Thread.Sleep(sleepInterval);
                Console.WriteLine($"GandoTech app is running at {DateTime.Now.ToUniversalTime()}");
            }
            Console.WriteLine($"=========================================================");
            Console.WriteLine($"GandoTech app stopped at {DateTime.Now.ToUniversalTime()}");

            return true;
        }
    }
}
