using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MachinesRUs.Observer;

namespace MachinesRUs.Machines
{
    /// <summary>
    /// AbstractMachine is a basic implementation of the IMachine interface.
    /// 
    /// AbstractMachine implements every method in the IMachine interface
    /// except for the Update method which all concrete subclasses should
    /// use to define the bahavior of the machine.
    /// 
    /// AbstractMachine also provides functionality for connecting to the
    /// output of another IMachine which can be accessed via the Previous
    /// property.
    /// </summary>
    public abstract class AbstractMachine : IMachine
    {
        // The list of IObserver objects that are subscribed to this machine.
        // Needed for IObservable implementation.
        private List<IObserver> observers = new List<IObserver>();

        // Whether or not the machine is running. Used for Start and Stop implementations.
        private bool running = false;

        /// <summary>
        /// Gets or sets the previous IMachine.
        /// 
        /// The previous IMachine's pressure and temperature may be used when
        /// determining the temperature and pressure.
        /// </summary>
        public IMachine Previous { get; set; }

        /// <summary>
        /// Gets or sets the pressure to be returned by the GetPressure method.
        /// </summary>
        private double pressure;
        protected double Pressure { 
            get { return pressure; } 
            set
            {
                pressure = value;

                // Update the IObserver objects.
                NotifyObservers();
            }
        }

        /// <summary>
        /// Gets or sets the temperature to be returned by the GetTemperature method.
        /// </summary>
        private double temperature;
        protected double Temperature
        {
            private get { return temperature; }
            set
            {
                temperature = value;

                // Update the IObserver objects.
                NotifyObservers();
            }
        }

        // Needed for implementation of IMachine.
        public double GetPressure()
        {
            return Pressure;
        }

        // Needed for implementation of IMachine.
        public double GetTemperature()
        {
            return Temperature;
        }

        // Needed for implementation of IObservable.
        public void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Update(this);
        }

        // Needed for implementation of IMachine.
        public void Start()
        {
            // Ensure only one thread can run this method at a time.
            lock (this)
            {
                // Set the machine as running.
                running = true;

                // Create a new thread to start running the machine.
                var thread = new Thread(() =>
                {
                    // Loop until the machine is no longer running.
                    while (running)
                    {
                        // Wait for some arbitrary number of seconds.
                        var arbitraryNumberOfSeconds = new Random().Next(10);
                        Thread.Sleep(arbitraryNumberOfSeconds * 1000);

                        // Update the machine.
                        Update();
                    }
                });

                // Start the thread.
                thread.Start();
            }
        }

        // Needed for implementation of IMachine.
        public void Stop()
        {
            // Ensure only one thread can run this method at a time.
            lock (this)
                // Set the machine as not running.
                running = false;
        }

        /// <summary>
        /// Subscribes the IObservable object to receive updates whenever the pressure
        /// or temperature change.
        /// </summary>
        /// <param name="observer">
        /// the IObservable object to be subscribed.
        /// </param>
        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Unsubscribes the IObservable object from receiving updated about the machine.
        /// </summary>
        /// <param name="observer">
        /// the IObservable object to be unsubscribed.
        /// </param>
        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        // Needed for implementation of IMachine.
        public abstract void Update();
    }
}
