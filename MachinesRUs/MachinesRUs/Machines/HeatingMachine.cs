using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinesRUs.Machines
{
    /// <summary>
    /// A HeatingMachine is an IMachine implementation that generates
    /// heat.
    /// </summary>
    public class HeatingMachine : AtomicMachine
    {
        // Needed for AbstractMachine implementation.
        public override void Update()
        {
            // Determine the input temperature and pressure.
            var inputTemperature = Previous == null ? 0 : Previous.GetTemperature();
            var inputPressure = Previous == null ? 0 : Previous.GetPressure();

            // Add an arbitrary amount of heat to the temperature.
            var arbitraryAmountOfHeat = new Random().Next(10);
            Temperature = arbitraryAmountOfHeat + inputTemperature;
            Pressure = inputPressure;

        }
    }
}
