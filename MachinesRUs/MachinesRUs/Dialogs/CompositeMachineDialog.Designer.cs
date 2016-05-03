namespace MachinesRUs.Dialogs
{
    partial class CompositeMachineDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.MachineList = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.AtomicMachineList = new MachinesRUs.Controls.MachineButtonList();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose which Machines should make up the Composite Machine.";
            // 
            // MachineList
            // 
            this.MachineList.FormattingEnabled = true;
            this.MachineList.Location = new System.Drawing.Point(13, 30);
            this.MachineList.Name = "MachineList";
            this.MachineList.Size = new System.Drawing.Size(355, 303);
            this.MachineList.TabIndex = 1;
            this.MachineList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MachineList_KeyDown);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(403, 347);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(484, 347);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 347);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name: ";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(61, 347);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(307, 20);
            this.NameField.TabIndex = 6;
            this.NameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            // 
            // AtomicMachineList
            // 
            this.AtomicMachineList.AutoScroll = true;
            this.AtomicMachineList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AtomicMachineList.Location = new System.Drawing.Point(375, 30);
            this.AtomicMachineList.Name = "AtomicMachineList";
            this.AtomicMachineList.Size = new System.Drawing.Size(184, 303);
            this.AtomicMachineList.TabIndex = 2;
            this.AtomicMachineList.AddMachine += new System.EventHandler(this.AtomicMachineList_AddMachine);
            // 
            // CompositeMachineDialog
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(571, 382);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AtomicMachineList);
            this.Controls.Add(this.MachineList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompositeMachineDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CompositeMachineDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox MachineList;
        private Controls.MachineButtonList AtomicMachineList;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameField;
    }
}