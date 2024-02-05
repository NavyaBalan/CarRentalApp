
namespace CarRentalProject
{
    partial class ManageVehicleListing
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
            this.BasePanel = new System.Windows.Forms.Panel();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVehicleListing = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.BasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleListing)).BeginInit();
            this.SuspendLayout();
            // 
            // BasePanel
            // 
            this.BasePanel.Controls.Add(this.btnRefresh);
            this.BasePanel.Controls.Add(this.btnDeleteVehicle);
            this.BasePanel.Controls.Add(this.btnEditVehicle);
            this.BasePanel.Controls.Add(this.btnAddVehicle);
            this.BasePanel.Controls.Add(this.label1);
            this.BasePanel.Controls.Add(this.dgvVehicleListing);
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.Location = new System.Drawing.Point(0, 0);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(978, 605);
            this.BasePanel.TabIndex = 1;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(778, 355);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(140, 50);
            this.btnDeleteVehicle.TabIndex = 5;
            this.btnDeleteVehicle.Text = "Delete Vehicles";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.Location = new System.Drawing.Point(778, 253);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(140, 50);
            this.btnEditVehicle.TabIndex = 4;
            this.btnEditVehicle.Text = "Edit Vehicles";
            this.btnEditVehicle.UseVisualStyleBackColor = true;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(778, 145);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(140, 50);
            this.btnAddVehicle.TabIndex = 3;
            this.btnAddVehicle.Text = "Add Vehicles";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Managing Vehicle Listing";
            // 
            // dgvVehicleListing
            // 
            this.dgvVehicleListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleListing.Location = new System.Drawing.Point(21, 145);
            this.dgvVehicleListing.Name = "dgvVehicleListing";
            this.dgvVehicleListing.RowHeadersWidth = 51;
            this.dgvVehicleListing.RowTemplate.Height = 24;
            this.dgvVehicleListing.Size = new System.Drawing.Size(725, 444);
            this.dgvVehicleListing.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(778, 472);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 50);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 605);
            this.Controls.Add(this.BasePanel);
            this.Name = "ManageVehicleListing";
            this.Text = "ManageVehicleListing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            this.BasePanel.ResumeLayout(false);
            this.BasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleListing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVehicleListing;
        private System.Windows.Forms.Button btnRefresh;
    }
}