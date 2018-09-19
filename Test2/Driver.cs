using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Test2
{
    class Driver
    {
        static void Main(string[] args)  
        {  
            using (var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: false))  
            {  
                int zero = 0;
                int one = 0;
                for (int i = 0; i < 100; i++) {
                if (Add.Run(sim).Result == Result.Zero)
                    zero ++;
                else
                    one ++;
                }
                Console.WriteLine(string.Format("Zero: {0}", zero));
                Console.WriteLine(string.Format("One: {0}", one));
            }
            Console.WriteLine("Press any key to continue...");  
            Console.ReadKey();  
        }  
    }
}