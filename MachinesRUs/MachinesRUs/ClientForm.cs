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

namespace MachinesRUs
{
    public partial class ClientForm : Form
    {
        // The list of machines in the form.
        private List<IMachine> machines = new List<IMachine>();

        public ClientForm()
        {
            InitializeComponent();

            // Create a new pressing machine.
            var machines = new AtomicMachine[] {
                new PressingMachine(),
                new HeatingMachine(),
                new PressingMachine(),
                new HeatingMachine(),
                new PressingMachine(),
                new HeatingMachine()
            };

            var composite = new CompositeMachine(machines);

            // Start the machines.
            composite.Start();
        }

        private void machineView1_Deleted(object sender, EventArgs e)
        {
            Controls.Remove((Control)sender);
        }

        private void AddMachineButton_Click(object sender, EventArgs e)
        {
            // Ensure an AddMachineButton called was the sender.
            if (!(sender is AddMachineButton))
                return;

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
    }
}
