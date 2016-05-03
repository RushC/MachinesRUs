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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.AtomicMachineLabel = new System.Windows.Forms.Label();
            this.CompositeMachineLabel = new System.Windows.Forms.Label();
            this.NewCompositeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newCompositeMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartButton = new System.Windows.Forms.ToolStripButton();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.CompositeMachineList = new MachinesRUs.Controls.MachineButtonList();
            this.AtomicMachineList = new MachinesRUs.Controls.MachineButtonList();
            this.MachineList = new MachinesRUs.Controls.MachineListView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AtomicMachineLabel
            // 
            this.AtomicMachineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AtomicMachineLabel.AutoSize = true;
            this.AtomicMachineLabel.Location = new System.Drawing.Point(392, 52);
            this.AtomicMachineLabel.Name = "AtomicMachineLabel";
            this.AtomicMachineLabel.Size = new System.Drawing.Size(88, 13);
            this.AtomicMachineLabel.TabIndex = 4;
            this.AtomicMachineLabel.Text = "Atomic Machines";
            // 
            // CompositeMachineLabel
            // 
            this.CompositeMachineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompositeMachineLabel.AutoSize = true;
            this.CompositeMachineLabel.Location = new System.Drawing.Point(392, 192);
            this.CompositeMachineLabel.Name = "CompositeMachineLabel";
            this.CompositeMachineLabel.Size = new System.Drawing.Size(105, 13);
            this.CompositeMachineLabel.TabIndex = 5;
            this.CompositeMachineLabel.Text = "Composite Machines";
            // 
            // NewCompositeButton
            // 
            this.NewCompositeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewCompositeButton.Location = new System.Drawing.Point(392, 367);
            this.NewCompositeButton.Name = "NewCompositeButton";
            this.NewCompositeButton.Size = new System.Drawing.Size(207, 23);
            this.NewCompositeButton.TabIndex = 7;
            this.NewCompositeButton.Text = "New Composite Machine";
            this.NewCompositeButton.UseVisualStyleBackColor = true;
            this.NewCompositeButton.Click += new System.EventHandler(this.NewCompositeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machinesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newCompositeMachineToolStripMenuItem});
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.machinesToolStripMenuItem.Text = "Machines";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Enabled = false;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 6);
            // 
            // newCompositeMachineToolStripMenuItem
            // 
            this.newCompositeMachineToolStripMenuItem.Name = "newCompositeMachineToolStripMenuItem";
            this.newCompositeMachineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newCompositeMachineToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.newCompositeMachineToolStripMenuItem.Text = "New Composite Machine";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartButton,
            this.StopButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StartButton
            // 
            this.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartButton.Enabled = false;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(23, 22);
            this.StartButton.Text = "toolStripButton1";
            this.StartButton.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // StopButton
            // 
            this.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopButton.Enabled = false;
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(23, 22);
            this.StopButton.Text = "toolStripButton2";
            this.StopButton.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // CompositeMachineList
            // 
            this.CompositeMachineList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompositeMachineList.AutoScroll = true;
            this.CompositeMachineList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompositeMachineList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompositeMachineList.Location = new System.Drawing.Point(392, 208);
            this.CompositeMachineList.Name = "CompositeMachineList";
            this.CompositeMachineList.Size = new System.Drawing.Size(207, 153);
            this.CompositeMachineList.TabIndex = 6;
            this.CompositeMachineList.AddMachine += new System.EventHandler(this.CompositeMachineList_AddMachine);
            // 
            // AtomicMachineList
            // 
            this.AtomicMachineList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AtomicMachineList.AutoScroll = true;
            this.AtomicMachineList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AtomicMachineList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AtomicMachineList.Location = new System.Drawing.Point(392, 70);
            this.AtomicMachineList.Name = "AtomicMachineList";
            this.AtomicMachineList.Size = new System.Drawing.Size(207, 110);
            this.AtomicMachineList.TabIndex = 3;
            this.AtomicMachineList.AddMachine += new System.EventHandler(this.AddMachineButton_Click);
            // 
            // MachineList
            // 
            this.MachineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MachineList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MachineList.Location = new System.Drawing.Point(11, 60);
            this.MachineList.Name = "MachineList";
            this.MachineList.Size = new System.Drawing.Size(375, 330);
            this.MachineList.TabIndex = 2;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 403);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NewCompositeButton);
            this.Controls.Add(this.CompositeMachineList);
            this.Controls.Add(this.CompositeMachineLabel);
            this.Controls.Add(this.AtomicMachineLabel);
            this.Controls.Add(this.AtomicMachineList);
            this.Controls.Add(this.MachineList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(641, 401);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MachineListView MachineList;
        private Controls.MachineButtonList AtomicMachineList;
        private System.Windows.Forms.Label AtomicMachineLabel;
        private System.Windows.Forms.Label CompositeMachineLabel;
        private Controls.MachineButtonList CompositeMachineList;
        private System.Windows.Forms.Button NewCompositeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem machinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newCompositeMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StartButton;
        private System.Windows.Forms.ToolStripButton StopButton;


    }
}

