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
            this.addMachineButton2 = new MachinesRUs.Controls.AddMachineButton();
            this.addMachineButton1 = new MachinesRUs.Controls.AddMachineButton();
            this.MachineList = new MachinesRUs.Controls.MachineListView();
            this.SuspendLayout();
            // 
            // addMachineButton2
            // 
            this.addMachineButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addMachineButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.addMachineButton2.Location = new System.Drawing.Point(372, 61);
            this.addMachineButton2.MachineType = "Pressing";
            this.addMachineButton2.Name = "addMachineButton2";
            this.addMachineButton2.Size = new System.Drawing.Size(162, 41);
            this.addMachineButton2.TabIndex = 4;
            this.addMachineButton2.AddMachine += new System.EventHandler(this.AddMachineButton_Click);
            // 
            // addMachineButton1
            // 
            this.addMachineButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addMachineButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.addMachineButton1.Location = new System.Drawing.Point(372, 13);
            this.addMachineButton1.MachineType = "Heating";
            this.addMachineButton1.Name = "addMachineButton1";
            this.addMachineButton1.Size = new System.Drawing.Size(162, 41);
            this.addMachineButton1.TabIndex = 3;
            this.addMachineButton1.AddMachine += new System.EventHandler(this.AddMachineButton_Click);
            // 
            // MachineList
            // 
            this.MachineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MachineList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MachineList.Location = new System.Drawing.Point(13, 13);
            this.MachineList.Name = "MachineList";
            this.MachineList.Size = new System.Drawing.Size(353, 338);
            this.MachineList.TabIndex = 2;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 363);
            this.Controls.Add(this.addMachineButton2);
            this.Controls.Add(this.addMachineButton1);
            this.Controls.Add(this.MachineList);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MachineListView MachineList;
        private Controls.AddMachineButton addMachineButton1;
        private Controls.AddMachineButton addMachineButton2;


    }
}

