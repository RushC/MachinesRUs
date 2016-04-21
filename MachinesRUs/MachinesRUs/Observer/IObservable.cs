using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinesRUs.Observer
{
    /// <summary>
    /// An IObservable object can be subscribed to by an IObserver object in
    /// order to receive updates whenever the IObservable object's supported
    /// properties are changed.
    /// </summary>
    public interface IObservable
    {
        /// <summary>
        /// Notifies all of the IObserver objects that are subscribed to this object
        /// that the value of a property has been changed.
        /// </summary>
        void NotifyObservers();

        /// <summary>
        /// Subscribes an IObserver object to receive updates whenever this IObservable
        /// object's supported properties are changed. Which properties are supported
        /// depends on the IObservable implementation.
        /// </summary>
        /// <param name="observer">
        /// the IObserver object that should receive updates on this object's properties.
        /// </param>
        void Subscribe(IObserver observer);
    }
}
