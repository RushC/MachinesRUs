using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinesRUs.Machines
{
    /// <summary>
    /// A CompositeMachine is an IMachine implementation that can 
    /// combine multiple IAtomicMachine implementations to generate
    /// a single method for each of Pressure and Temperature.
    /// </summary>
    public class CompositeMachine : AbstractMachine
    {
        // The machines that this composite machine consists of.
        protected AtomicMachine[] machines;

        /// <summary>
        /// Constructs a new CompositeMachine instance with the specified
        /// internal machines.
        /// </summary>
        /// <param name="machines">
        /// an array of IAtomicMachine objects.
        /// </param>
        public CompositeMachine(AtomicMachine[] machines)
        {
            this.machines = machines;

            // Iterate through each of the machines.
            for (var i = 1; i < machines.Length; i++)
                // Attach each previous machine to the current machine's input.
                machines[i].Previous = machines[i - 1];

        }

        // Required for AbstractMachine implementation.
        public void Update()
        {
            // Set the previous machine for the first machine.
            machines[0].Previous = Previous;

            // Iterate through all of the internal machines.
            foreach (var machine in machines)
                // Update the machine.
                machine.Update();

            // Retrieve the last machine.
            var lastMachine = machines[machines.Length - 1];

            // Set the pressure and temperature to those of the last machine.
            Pressure = lastMachine.GetPressure();
            Temperature = lastMachine.GetTemperature();
        }
    }
}
