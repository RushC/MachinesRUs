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
    /// A MachineButtonList can be used to display a list of AddMachineButton controls.
    /// </summary>
    public partial class MachineButtonList : UserControl
    {
        /// <summary>
        /// Called when an AddMachineButton is clicked. The clicked AddMachineButton will
        /// be the sender.
        /// </summary>
        public event EventHandler AddMachine;

        /// <summary>
        /// Constructs a new MachineButtonList that displays no AddMachineButton controls
        /// by default.
        /// </summary>
        public MachineButtonList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds an AddMachineButton control to the list that has the specified name.
        /// </summary>
        /// <param name="name">
        /// the name to assign to the added AddMachineButton control.
        /// </param>
        public void AddButton(String name)
        {
            // Create a new AddMachineButton.
            var button = new AddMachineButton();

            // Assign the name to the button.
            button.MachineType = name;

            // Add the button to the list.
            MachineButtonPanel.Controls.Add(button);

            // Add an event listener to the button's added event.
            button.AddMachine += button_AddMachine;
        }

        /// <summary>
        /// Loads buttons for all of the AtomicMachine implementations in the
        /// program.
        /// </summary>
        public void LoadAtomicMachines()
        {
            // Find names for every AtomicMachine implementation loaded in the program.
            // Check each assembly.
            var atomicMachineTypes = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                     // Check each type in each assembly.
                                     from type in assembly.GetTypes()
                                     // Look for types that can be assigned to an AtomicMachine instance.
                                     where typeof(AtomicMachine).IsAssignableFrom(type) && !type.IsAbstract
                                     // Select the name of the type as expected by the MachineFactory.
                                     select type.Name.Substring(0, type.Name.Length - "Machine".Length);

            // Add buttons for each machine type found.
            foreach (var machineType in atomicMachineTypes)
                AddButton(machineType);
        }

        /// <summary>
        /// Event handler for handling AddMachineButton button presses.
        /// </summary>
        void button_AddMachine(object sender, EventArgs e)
        {
            // Pass the event along.
            if (AddMachine != null)
                AddMachine(sender, e);
        }
    }
}
