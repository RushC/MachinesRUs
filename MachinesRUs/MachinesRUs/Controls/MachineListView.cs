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

namespace MachinesRUs.Controls
{
    /// <summary>
    /// A MachineListPanel is a control used to display a list of IMachine
    /// objects. Each IMachine object is represented by a MachineView
    /// control.
    /// </summary>
    public partial class MachineListView : UserControl
    {
        // The list of machines displayed by the control.
        private List<IMachine> machines;

        /// <summary>
        /// Constructs a new MachineListView instance that displays no IMachine
        /// objects initially.
        /// </summary>
        public MachineListView()
        {
            InitializeComponent();
            machines = new List<IMachine>();
        }

        /// <summary>
        /// Adds an IMachine object to the MachineListView and places it at the
        /// end of the list.
        /// </summary>
        /// <param name="machine">
        /// the IMachine object to add to the MachineListView.
        /// </param>
        public void AddMachine(IMachine machine)
        {
            AddMachine(machine, machine.GetType().Name);
        }

        /// <summary>
        /// Adds an IMachine object to the MachineListView and places it at the
        /// end of the list.
        /// </summary>
        /// <param name="machine">
        /// the IMachine object to add to the MachineListView.
        /// </param>
        /// <param name="machineName">
        /// the name to display for the machine in the list.
        /// </param>
        public void AddMachine(IMachine machine, string machineName)
        {
            // Set the current last machine as the new machine's input.
            if (machines.Count > 0)
                machine.SetPrevious(machines[machines.Count - 1]);

            // Add the machine to the list.
            machines.Add(machine);

            // Add a view for the machine.
            var machineView = new MachineView();
            machineView.Machine = machine;
            machineView.MachineName = machineName;
            machineView.Deleted += MachineDeleted;
            MachinePanel.Controls.Add(machineView);
        }

        /// <summary>
        /// Starts all of the machines in the list.
        /// </summary>
        public void StartMachines()
        {
            foreach (var machine in machines)
                machine.Start();
        }

        /// <summary>
        /// Stops all of the machines in the list.
        /// </summary>
        public void StopMachines()
        {
            foreach (var machine in machines)
                machine.Stop();
        }

        /// <summary>
        /// Called whenever MachineView's delete button is clicked.
        /// </summary>
        public void MachineDeleted(object sender, EventArgs e)
        {
            // Ensure a MachineView was the sender.
            if (sender.GetType() != typeof(MachineView))
                return;

            // Cast the sender to a machine view.
            var machineView = (MachineView)sender;

            // Retrieve the machine for the machine view.
            var machine = machineView.Machine;

            // Determine the machine's index in the list.
            var machineIndex = machines.IndexOf(machine);

            // Retrieve the machine's input machine.
            var previous = machineIndex == 0 ? null : machines[machineIndex - 1];

            // Set the previous machine as the next machine's input machine.
            if (machineIndex < machines.Count - 1)
                machines[machineIndex + 1].SetPrevious(previous);

            // Stop the machine.
            machine.Stop();

            // Remove the machine and its view.
            machines.RemoveAt(machineIndex);
            MachinePanel.Controls.Remove(machineView);
        }
    }
}
