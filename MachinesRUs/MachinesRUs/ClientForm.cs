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
using MachinesRUs.Controls;
using MachinesRUs.Dialogs;

namespace MachinesRUs
{
    public partial class ClientForm : Form
    {
        // The list of machines in the form.
        private List<IMachine> machines = new List<IMachine>();

        // A dictionary containing lists of Machine types for constructing a Composite
        // machine.
        private Dictionary<string, string[]> compositeMachines;

        /// <summary>
        /// Sets the state of the machines stored in the machines list.
        /// </summary>
        private bool Started
        {
            set
            {
                // Determine if the machines should be stopped or started.
                if (value)
                    MachineList.StartMachines();
                else
                    MachineList.StopMachines();

                // Enable/Disable the appropriate controls.
                startToolStripMenuItem.Enabled = !value;
                StartButton.Enabled = !value;
                stopToolStripMenuItem.Enabled = value;
                StopButton.Enabled = value;
            }
        }

        public ClientForm()
        {
            InitializeComponent();

            compositeMachines = new Dictionary<string, string[]>();

            // Load all of the AtomicMachine implementations in the AtomicMachine
            // list.
            AtomicMachineList.LoadAtomicMachines();
                
        }

        /// <summary>
        /// Called when an AddMachineButton from the AtomicMachineList is clicked.
        /// </summary>
        private void AddMachineButton_Click(object sender, EventArgs e)
        {
            // Ensure an AddMachineButton called was the sender.
            if (!(sender is AddMachineButton))
                return;

            // Ensure the machines are stopped.
            Started = false;

            // Cast the sender to its correct type.
            var addMachineButton = (AddMachineButton)sender;

            // Retrieve the type of machine from the button.
            var machineType = addMachineButton.MachineType;

            // Create a new machine of the specified type.
            var machineFactory = MachineFactory.GetInstance();
            var machine = machineFactory.CreateMachine(machineType);

            // Add the machine to the MachineList.
            MachineList.AddMachine(machine);
        }

        /// <summary>
        /// Called when the form is being closed.
        /// </summary>
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop all of the machines.
            MachineList.StopMachines();
        }

        /// <summary>
        /// Called when the NewCompositeButton is clicked.
        /// </summary>
        private void NewCompositeButton_Click(object sender, EventArgs e)
        {
            // Display a CompositemachineDialog.
            var dialog = new CompositeMachineDialog();
            dialog.ShowDialog();

            // Ensure the user chose to save the result.
            if (dialog.DialogResult == DialogResult.Cancel)
                return;

            // Ensure the name the user chose is not already taken.
            String[] machineTypes;
            if (compositeMachines.TryGetValue(dialog.MachineName, out machineTypes))
            {
                MessageBox.Show(
                    "The name " + dialog.MachineName + " is already in use.", 
                    "Name Taken", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
                return;
            }

            // Add the composite machine definition to the dictionary.
            compositeMachines.Add(dialog.MachineName, dialog.MachineTypes);

            // Add an AddMachineButton for the new machine type.
            CompositeMachineList.AddButton(dialog.MachineName);
        }

        /// <summary>
        /// Called when an AddMachineButton in the composite list is clicked.
        /// </summary>
        private void CompositeMachineList_AddMachine(object sender, EventArgs e)
        {
            // Ensure an AddMachineButton sent the event.
            if (!(sender is AddMachineButton))
                return;

            // Ensure the machines are stopped.
            Started = false;

            // Retrieve the button reference.
            var button = (AddMachineButton)sender;

            // Retrieve the name of the machine type.
            var name = button.MachineType;

            // Retrive the list of machine types in the composite machine with the specified name.
            string[] types = compositeMachines[name];

            // Construct an array of AtomicMachines using the composite machine's types.
            var atomicMachines = new AtomicMachine[types.Length];
            for (var i = 0; i < atomicMachines.Length; i++)
                atomicMachines[i] = (AtomicMachine)MachineFactory.GetInstance().CreateMachine(types[i]);

            // Create a new composite machine with the constructed array of machines.
            var compositeMachine = new CompositeMachine(atomicMachines);

            // Add the composite machine to the machine list.
            MachineList.AddMachine(compositeMachine, name);
        }

        /// <summary>
        /// Called when a start option is clicked.
        /// </summary>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Start the machines.
            Started = true;            
        }

        /// <summary>
        /// Called when the stop option is clicked.
        /// </summary>
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stop the machines.
            Started = false;
        }
    }
}
