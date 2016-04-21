using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinesRUs.Machines
{
    /// <summary>
    /// IAtomicMachine is a marker interface used to identify IMachine objects that
    /// can be used in a CompositeMachine. 
    /// </summary>
    public abstract class AtomicMachine : AbstractMachine { }
}
