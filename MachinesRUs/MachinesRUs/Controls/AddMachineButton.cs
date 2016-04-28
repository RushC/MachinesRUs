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
    public partial class AddMachineButton : UserControl
    {
        /// <summary>
        /// Called when the Add Machine button is clicked by the user.
        /// </summary>
        public event EventHandler AddMachine;

        /// <summary>
        /// Gets or sets the type of Machine class that can be retrieved by this
        /// control. The name should be the class name of the Machine type without
        /// the "Machine" suffix and without the package name.
        /// </summary>
        public String MachineType
        {
            get { return MachineLabel.Text; }
            set { MachineLabel.Text = value; }
        }

        /// <summary>
        /// Constructs a new AddMachineButton control with no default MachineType.
        /// </summary>
        public AddMachineButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the AddButton is clicked.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Call the AddMachine handlers.
            if (AddMachine != null)
                AddMachine(this, e);
        }
    }
}
