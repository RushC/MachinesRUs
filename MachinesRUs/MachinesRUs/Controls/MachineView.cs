using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachinesRUs.Machines;
using MachinesRUs.Observer;

namespace MachinesRUs.Controls
{
    /// <summary>
    /// A MachineView is a control that can be used to visualize an IMachine object.
    /// 
    /// In order to ensure that the MachineView's information is always up to date,
    /// the MachineView is an IObserver implementation that observes the IMachine
    /// it is visualizing.
    /// </summary>
    public partial class MachineView : UserControl, IObserver
    {
        /// <summary>
        /// Called when the user clicks the delete icon.
        /// </summary>
        public event EventHandler Deleted;

        /// <summary>
        /// Gets ot sets the IMachine currently being visualized by this Control.
        /// </summary>
        private IMachine machine;
        public IMachine Machine
        {
            get { return machine; }
            set
            {
                // If there was already a machine, make sure to unsubscribe from it.
                if (machine != null)
                    machine.Unsubscribe(this);

                // Set the new machine.
                machine = value;

                // Ensure the new machine is not null.
                if (machine == null)
                    return;

                // Subscribe to the new machine.
                machine.Subscribe(this);

                // Update the view to the machine's status.
                Update(machine);

                // Display the name of the machine type.
                TypeLabel.Text = machine.GetType().Name;
            }
        }

        /// <summary>
        /// Gets or sets the display name of the Machine view.
        /// </summary>
        public string MachineName
        {
            get { return TypeLabel.Text; }
            set { TypeLabel.Text = value; }
        }

        /// <summary>
        /// Constructs a new MachineView that doesn't visualize any IMachine
        /// object by default.
        /// </summary>
        public MachineView()
        {
            InitializeComponent();
        }

        // Needed for IObservable implementation.
        public void Update(IObservable observable)
        {
            // Check if the current thread is a different thread than the one that
            // created the MachineView.
            if (InvokeRequired)
            {
                // Invoke this method in the correct thread.
                Invoke(new Action(() => Update(observable)));

                return;
            }

            // Ensure the observable object is an IMachine object.
            if (!typeof(IMachine).IsAssignableFrom(observable.GetType()))
                return;

            // Cast the observable to a machine.
            var updatedMachine = (IMachine)observable;

            // Set the fields based on the updated machine's values.
            TemperatureText.Text = updatedMachine.GetTemperature().ToString();
            PressureText.Text = updatedMachine.GetPressure().ToString();
        }

        /// <summary>
        /// Called when the user clicks the Delete Image.
        /// </summary>
        private void DeleteImage_Click(object sender, EventArgs e)
        {
            // Call the Deleted event handlers.
            if (Deleted != null)
                Deleted(this, e);
        }
    }
}
