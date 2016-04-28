namespace MachinesRUs.Controls
{
    partial class AddMachineButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MachineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(162, 39);
            this.AddButton.TabIndex = 0;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MachinesRUs.Properties.Resources.machine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MachineLabel
            // 
            this.MachineLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MachineLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineLabel.Location = new System.Drawing.Point(44, 4);
            this.MachineLabel.Name = "MachineLabel";
            this.MachineLabel.Size = new System.Drawing.Size(115, 30);
            this.MachineLabel.TabIndex = 2;
            this.MachineLabel.Text = "Machine";
            this.MachineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MachineLabel.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddMachineButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MachineLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddButton);
            this.Name = "AddMachineButton";
            this.Size = new System.Drawing.Size(162, 41);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MachineLabel;
    }
}
