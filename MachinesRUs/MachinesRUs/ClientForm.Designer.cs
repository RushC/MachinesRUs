namespace MachinesRUs
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddMachineButton = new System.Windows.Forms.Button();
            this.machineListView1 = new MachinesRUs.Controls.MachineListView();
            this.SuspendLayout();
            // 
            // AddMachineButton
            // 
            this.AddMachineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMachineButton.Location = new System.Drawing.Point(334, 12);
            this.AddMachineButton.Name = "AddMachineButton";
            this.AddMachineButton.Size = new System.Drawing.Size(75, 23);
            this.AddMachineButton.TabIndex = 1;
            this.AddMachineButton.Text = "Add";
            this.AddMachineButton.UseVisualStyleBackColor = true;
            this.AddMachineButton.Click += new System.EventHandler(this.AddMachineButton_Click);
            // 
            // machineListView1
            // 
            this.machineListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.machineListView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.machineListView1.Location = new System.Drawing.Point(13, 13);
            this.machineListView1.Name = "machineListView1";
            this.machineListView1.Size = new System.Drawing.Size(315, 338);
            this.machineListView1.TabIndex = 2;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 363);
            this.Controls.Add(this.machineListView1);
            this.Controls.Add(this.AddMachineButton);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMachineButton;
        private Controls.MachineListView machineListView1;


    }
}

