using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinesRUs.Observer
{
    /// <summary>
    /// An IObserver object can subscribe to an IObservable object to receive
    /// updates whenever the IObservable object's supported properties are
    /// changed.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the IObserver object to reflect a change in the IObservable
        /// object's properties.
        /// </summary>
        /// <param name="observable">
        /// The IObservable object whose properties were changed and called this
        /// method.
        /// </param>
        void Update(IObservable observable);
    }
}
