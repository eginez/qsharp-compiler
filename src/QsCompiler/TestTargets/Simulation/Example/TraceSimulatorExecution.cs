// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Quantum.Simulation.Simulators.QCTraceSimulators;

namespace Microsoft.Quantum.Testing.Simulation
{
    internal static class Driver
    {
        /// <summary>
        /// Executes the Q# operation Main defined in Microsoft.Quantum.Testing.Simulation on the QsTraceSimulator.
        /// </summary>
        static void Main(string[] args)
        {
            var qsim = new QCTraceSimulator();
            Simulation.Main.Run(qsim).Wait(); 
        }
    }
}