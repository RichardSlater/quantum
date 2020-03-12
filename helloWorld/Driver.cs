﻿using System;
using System.Threading.Tasks;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace helloWorld
{
    class Driver
    {
        static async Task Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                await HelloQ.Run(qsim);
            }
        }
    }
}