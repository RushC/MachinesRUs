using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachinesRUs.Observer;

namespace MachinesRUs.Machines
{
    /// <summary>
    /// An IMachine generates heat and pressure and contains sensors to
    /// retrieve the resulting temperature and pressure.
    /// </summary>
    public interface IMachine : IObservable
    {
        /// <summary>
        /// Gets the pressure of the machine in units of Paschals.
        /// </summary>
        /// <returns>the pressure of the machine.</returns>
        double GetPressure();

        /// <summary>
        /// Gets the temperature of the machine in degrees Fahrenheit.
        /// </summary>
        /// <returns>the temperature of the machine.</returns>
        double GetTemperature();

        /// <summary>
        /// Starts running the machine in a new thread. This will begin the machine's
        /// cycle that will periodically call the update method.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops the thread started by the Start method. If no thread has been started yet,
        /// this method will do nothing.
        /// </summary>
        void Stop();

        /// <summary>
        /// Updates the machines temperature and pressure values.
        /// </summary>
        void Update();
    }
}
