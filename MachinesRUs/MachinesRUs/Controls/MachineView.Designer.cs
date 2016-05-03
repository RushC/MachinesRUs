namespace MachinesRUs.Controls
{
    partial class MachineView
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

                // Unsubscribe the view from the machine.
                machine.Unsubscribe(this);

                // Stop the machine.
                machine.Stop();
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
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.TemperatureText = new System.Windows.Forms.TextBox();
            this.TemperatureUnitsLabel = new System.Windows.Forms.Label();
            this.PressureText = new System.Windows.Forms.TextBox();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.PressureUnitLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.MachineImage = new System.Windows.Forms.PictureBox();
            this.DeleteImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MachineImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.Location = new System.Drawing.Point(109, 51);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(67, 17);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "Temperature";
            this.TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TemperatureText
            // 
            this.TemperatureText.Enabled = false;
            this.TemperatureText.Location = new System.Drawing.Point(182, 48);
            this.TemperatureText.Name = "TemperatureText";
            this.TemperatureText.Size = new System.Drawing.Size(59, 20);
            this.TemperatureText.TabIndex = 2;
            // 
            // TemperatureUnitsLabel
            // 
            this.TemperatureUnitsLabel.Location = new System.Drawing.Point(248, 51);
            this.TemperatureUnitsLabel.Name = "TemperatureUnitsLabel";
            this.TemperatureUnitsLabel.Size = new System.Drawing.Size(38, 17);
            this.TemperatureUnitsLabel.TabIndex = 3;
            this.TemperatureUnitsLabel.Text = "°F";
            // 
            // PressureText
            // 
            this.PressureText.Enabled = false;
            this.PressureText.Location = new System.Drawing.Point(182, 75);
            this.PressureText.Name = "PressureText";
            this.PressureText.Size = new System.Drawing.Size(59, 20);
            this.PressureText.TabIndex = 4;
            // 
            // PressureLabel
            // 
            this.PressureLabel.Location = new System.Drawing.Point(109, 77);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(67, 14);
            this.PressureLabel.TabIndex = 5;
            this.PressureLabel.Text = "Pressure";
            this.PressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PressureUnitLabel
            // 
            this.PressureUnitLabel.Location = new System.Drawing.Point(248, 77);
            this.PressureUnitLabel.Name = "PressureUnitLabel";
            this.PressureUnitLabel.Size = new System.Drawing.Size(38, 14);
            this.PressureUnitLabel.TabIndex = 6;
            this.PressureUnitLabel.Text = "Pa";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(110, 4);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(145, 41);
            this.TypeLabel.TabIndex = 7;
            this.TypeLabel.Text = "Machine";
            // 
            // MachineImage
            // 
            this.MachineImage.Image = global::MachinesRUs.Properties.Resources.machine;
            this.MachineImage.InitialImage = null;
            this.MachineImage.Location = new System.Drawing.Point(3, 3);
            this.MachineImage.Name = "MachineImage";
            this.MachineImage.Size = new System.Drawing.Size(100, 100);
            this.MachineImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MachineImage.TabIndex = 0;
            this.MachineImage.TabStop = false;
            // 
            // DeleteImage
            // 
            this.DeleteImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteImage.Image = global::MachinesRUs.Properties.Resources.delete;
            this.DeleteImage.InitialImage = null;
            this.DeleteImage.Location = new System.Drawing.Point(261, 5);
            this.DeleteImage.Name = "DeleteImage";
            this.DeleteImage.Size = new System.Drawing.Size(25, 25);
            this.DeleteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteImage.TabIndex = 8;
            this.DeleteImage.TabStop = false;
            this.DeleteImage.Click += new System.EventHandler(this.DeleteImage_Click);
            // 
            // MachineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DeleteImage);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.PressureUnitLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.PressureText);
            this.Controls.Add(this.TemperatureUnitsLabel);
            this.Controls.Add(this.TemperatureText);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.MachineImage);
            this.Name = "MachineView";
            this.Size = new System.Drawing.Size(291, 106);
            ((System.ComponentModel.ISupportInitialize)(this.MachineImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MachineImage;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.TextBox TemperatureText;
        private System.Windows.Forms.Label TemperatureUnitsLabel;
        private System.Windows.Forms.TextBox PressureText;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label PressureUnitLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.PictureBox DeleteImage;
    }
}
