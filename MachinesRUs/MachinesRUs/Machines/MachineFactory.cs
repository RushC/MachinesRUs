using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinesRUs.Machines
{
    /// <summary>
    /// MachineFactory is used to create new IMachine instances.
    /// 
    /// MachineFactory implements the Singleton pattern since only one
    /// MachineFactory instance is ever needed.
    /// </summary>
    public class MachineFactory
    {
        // The single MachineFactory instance.
        private static MachineFactory factory;

        // The constructor private so that only this class can create new instances.
        private MachineFactory() { }

        /// <summary>
        /// Retrieves the single MachineFactory instance.
        /// </summary>
        /// <returns>
        /// the single MachineFactory instance.
        /// </returns>
        public static MachineFactory GetInstance()
        {
            // If the factory has not been initialized yet, initialize it.
            if (factory == null)
                factory = new MachineFactory();

            return factory;
        }

        /// <summary>
        /// Creates a new IMachine instance of the specified machine type.
        /// </summary>
        /// <param name="machineName">
        /// the type of machine to be created. This should be the name of the IMachine
        /// implementations class without the package name or Machine suffix. For
        /// example, to create a new HeatingMachine, pass the string "Heating".
        /// </param>
        /// <returns>
        /// the created IMachine instance.
        /// </returns>
        public IMachine CreateMachine(string machineName)
        {
            // Construct the full machine name.
            machineName = "MachinesRUs.Machines." + machineName + "Machine";

            // Retrieve the type of the machine.
            var machineType = Type.GetType(machineName, false);

            // Ensure a type was found and implements IMachine.
            if (machineType == null || !typeof(IMachine).IsAssignableFrom(machineType))
                return null;

            // Create and return an instance of the machine type.
            return  (IMachine)Activator.CreateInstance(machineType);
        }
    }
}
