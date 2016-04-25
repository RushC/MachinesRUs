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
            var machine = new HeatingMachine();
            machineListView1.AddMachine(machine);
        }
    }
}
