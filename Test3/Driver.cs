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
                string[] array = {"Constant 0", "Constant 1", "Identity", "Negation"};
                for (int i = 0; i < 4; i++) {
                    var blackBox = array[i];
                    var res = Add.Run(sim, blackBox).Result;
                    Console.WriteLine($"{blackBox}: {res}");
                }
            }
            Console.WriteLine("Press any key to continue...");  
            Console.ReadKey();  
        }  
    }
}