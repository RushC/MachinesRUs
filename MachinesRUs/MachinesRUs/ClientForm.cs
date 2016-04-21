using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachinesRUs.Machines;
using MachinesRUs.Observer;

namespace MachinesRUs
{
    public partial class ClientForm : Form, IObserver
    {
        // The list of machines in the form.
        private List<IMachine> machines = new List<IMachine>();

        public ClientForm()
        {
            InitializeComponent();
        }

        // Needed for IObserver implementation.
        public void Update(IObservable observable)
        {
            // Ensure that the observable object is an IMachine.
            if (!typeof(IMachine).IsAssignableFrom(observable.GetType()))
                return;

            // Cast the observable to an IMachine.
            var machine = (IMachine)observable;

            /**
             * TODO: Make this do a thing.
             */
        }
    }
}
