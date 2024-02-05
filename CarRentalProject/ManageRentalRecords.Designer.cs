
namespace CarRentalProject
{
    partial class ManageRentalRecords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteRentalRecords = new System.Windows.Forms.Button();
            this.btnEditRentalRecords = new System.Windows.Forms.Button();
            this.btnAddRentalRecords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVehicleRecords = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDeleteRentalRecords);
            this.panel1.Controls.Add(this.btnEditRentalRecords);
            this.panel1.Controls.Add(this.btnAddRentalRecords);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvVehicleRecords);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 621);
            this.panel1.TabIndex = 0;
 
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(793, 536);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 50);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteRentalRecords
            // 
            this.btnDeleteRentalRecords.Location = new System.Drawing.Point(793, 396);
            this.btnDeleteRentalRecords.Name = "btnDeleteRentalRecords";
            this.btnDeleteRentalRecords.Size = new System.Drawing.Size(140, 50);
            this.btnDeleteRentalRecords.TabIndex = 11;
            this.btnDeleteRentalRecords.Text = "Delete Rental Records";
            this.btnDeleteRentalRecords.UseVisualStyleBackColor = true;
            this.btnDeleteRentalRecords.Click += new System.EventHandler(this.btnDeleteRentalRecords_Click);
            // 
            // btnEditRentalRecords
            // 
            this.btnEditRentalRecords.Location = new System.Drawing.Point(793, 272);
            this.btnEditRentalRecords.Name = "btnEditRentalRecords";
            this.btnEditRentalRecords.Size = new System.Drawing.Size(140, 50);
            this.btnEditRentalRecords.TabIndex = 10;
            this.btnEditRentalRecords.Text = "Edit Rental Records";
            this.btnEditRentalRecords.UseVisualStyleBackColor = true;
            this.btnEditRentalRecords.Click += new System.EventHandler(this.btnEditRentalRecords_Click);
            // 
            // btnAddRentalRecords
            // 
            this.btnAddRentalRecords.Location = new System.Drawing.Point(793, 152);
            this.btnAddRentalRecords.Name = "btnAddRentalRecords";
            this.btnAddRentalRecords.Size = new System.Drawing.Size(140, 50);
            this.btnAddRentalRecords.TabIndex = 9;
            this.btnAddRentalRecords.Text = "Add Rental Records";
            this.btnAddRentalRecords.UseVisualStyleBackColor = true;
            this.btnAddRentalRecords.Click += new System.EventHandler(this.btnAddRentalRecords_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 79);
            this.label1.TabIndex = 8;
            this.label1.Text = "Managing Rental Records";
            // 
            // dgvVehicleRecords
            // 
            this.dgvVehicleRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleRecords.Location = new System.Drawing.Point(36, 152);
            this.dgvVehicleRecords.Name = "dgvVehicleRecords";
            this.dgvVehicleRecords.RowHeadersWidth = 51;
            this.dgvVehicleRecords.RowTemplate.Height = 24;
            this.dgvVehicleRecords.Size = new System.Drawing.Size(725, 444);
            this.dgvVehicleRecords.TabIndex = 7;
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 645);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRentalRecords";
            this.Text = "ManageRentalRecords";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteRentalRecords;
        private System.Windows.Forms.Button btnEditRentalRecords;
        private System.Windows.Forms.Button btnAddRentalRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVehicleRecords;
    }
}