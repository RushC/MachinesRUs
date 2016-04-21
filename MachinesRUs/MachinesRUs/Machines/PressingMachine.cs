using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinesRUs.Machines
{
    /// <summary>
    /// A PressingMachine is an IMachine implementation that generates
    /// pressure.
    /// </summary>
    public class PressingMachine : AtomicMachine
    {
        // Needed for AbstractMachine implementation.
        public override void Update()
        {
            // Determine the input pressure.
            var inputPressure = Previous == null ? 0 : Previous.GetPressure();

            // Add an arbitrary amount of pressure to the input pressure.
            var arbitraryAmountOfPressure = new Random().Next(10);
            Pressure = GetPressure() + arbitraryAmountOfPressure + inputPressure;
        }
    }
}
