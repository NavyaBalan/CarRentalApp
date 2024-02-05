
namespace CarRentalProject
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVechicleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentedRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentedRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editbRentedRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsiLogintxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVechicleListingToolStripMenuItem,
            this.manageRentedRecordsToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1495, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVechicleListingToolStripMenuItem
            // 
            this.manageVechicleListingToolStripMenuItem.Name = "manageVechicleListingToolStripMenuItem";
            this.manageVechicleListingToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.manageVechicleListingToolStripMenuItem.Text = "Manage Vechicle Listing";
            this.manageVechicleListingToolStripMenuItem.Click += new System.EventHandler(this.manageVechicleListingToolStripMenuItem_Click);
            // 
            // manageRentedRecordsToolStripMenuItem
            // 
            this.manageRentedRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentedRecordsToolStripMenuItem,
            this.viewRecordsToolStripMenuItem,
            this.editbRentedRecordsToolStripMenuItem});
            this.manageRentedRecordsToolStripMenuItem.Name = "manageRentedRecordsToolStripMenuItem";
            this.manageRentedRecordsToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.manageRentedRecordsToolStripMenuItem.Text = "Manage Rented Records";
            // 
            // addRentedRecordsToolStripMenuItem
            // 
            this.addRentedRecordsToolStripMenuItem.Name = "addRentedRecordsToolStripMenuItem";
            this.addRentedRecordsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addRentedRecordsToolStripMenuItem.Text = "Add Rented Records";
            this.addRentedRecordsToolStripMenuItem.Click += new System.EventHandler(this.addRentedRecordsToolStripMenuItem_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            this.viewRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewRecordsToolStripMenuItem_Click);
            // 
            // editbRentedRecordsToolStripMenuItem
            // 
            this.editbRentedRecordsToolStripMenuItem.Name = "editbRentedRecordsToolStripMenuItem";
            this.editbRentedRecordsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.editbRentedRecordsToolStripMenuItem.Text = "Editb Rented Records";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLogintxt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 796);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1495, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsiLogintxt
            // 
            this.tsiLogintxt.Name = "tsiLogintxt";
            this.tsiLogintxt.Size = new System.Drawing.Size(0, 18);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 820);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVechicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentedRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentedRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editbRentedRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsiLogintxt;
    }
}