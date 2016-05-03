using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachinesRUs.Controls;

namespace MachinesRUs.Dialogs
{
    /// <summary>
    /// A CompositeMachineDialog can be used to prompt a user for a list
    /// of Machine types to use for constructing a composite machine.
    /// </summary>
    public partial class CompositeMachineDialog : Form
    {
        private List<string> machineTypes;
        /// <summary>
        /// Gets the machine types selected by the user in the dialog.
        /// </summary>
        public string[] MachineTypes
        {
            get { return machineTypes.ToArray(); }
        }

        /// <summary>
        /// Gets the name the user chose for the Machine.
        /// </summary>
        public string MachineName
        {
            get { return NameField.Text; }
        }

        /// <summary>
        /// Constructs a new CompositeMachineDialog with no machine types
        /// currently selected.
        /// </summary>
        public CompositeMachineDialog()
        {
            InitializeComponent();
            machineTypes = new List<string>();
            AtomicMachineList.LoadAtomicMachines();
        }

        /// <summary>
        /// Enables or disables the Save button depending on whether enough
        /// information is supplied for a valid output.
        /// </summary>
        private void UpdateSaveButton()
        {
            // Check if there are at least two machines in the machines in the list
            // and if a valid name has been entered.
            var valid = machineTypes.Count >= 2 && !string.IsNullOrWhiteSpace(NameField.Text);

            // Enable or disable the save button based on whether or not the input is valid.
            SaveButton.Enabled = valid;
        }

        /// <summary>
        /// Called when an AddMachineButton is clicked.
        /// </summary>
        private void AtomicMachineList_AddMachine(object sender, EventArgs e)
        {
            // Ensure a machine button sent this event.
            if (!(sender is AddMachineButton))
                return;

            // Retrieve the MachineButton instance.
            var machineButton = (AddMachineButton)sender;

            // Add the name of the machine to the list.
            machineTypes.Add(machineButton.MachineType);
            MachineList.Items.Add(machineButton.MachineType);

            // Update the save button.
            UpdateSaveButton();
        }

        /// <summary>
        /// Called when the NameField has its text changed.
        /// </summary>
        private void NameField_TextChanged(object sender, EventArgs e)
        {
            // Update the save button.
            UpdateSaveButton();
        }

        /// <summary>
        /// Called when the save button is clicked.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Set the result as OK.
            DialogResult = DialogResult.OK;

            // Close the dialog.
            Close();
        }

        /// <summary>
        /// Called when the cancel button is clicked.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the dialog.
            Close();
        }

        /// <summary>
        /// Called when a key is pressed.
        /// </summary>
        private void MachineList_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the delete key was pressed.
            if (e.KeyCode == Keys.Delete)
            {
                // Ensure an item is selected.
                var index = MachineList.SelectedIndex;
                if (index == -1)
                    return;

                // Remove the selected item.
                MachineList.Items.RemoveAt(index);
                machineTypes.RemoveAt(index);

                // Update the save button.
                UpdateSaveButton();
            }
        }
    }
}
