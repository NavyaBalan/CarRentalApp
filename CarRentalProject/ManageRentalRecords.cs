using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities2 manageVechicleEnity;
        public ManageRentalRecords()
        {
            InitializeComponent();
            manageVechicleEnity = new CarRentalEntities2();
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void PopulateGrid()
        {
            // Select a custom model collection of cars from database
            var records = manageVechicleEnity.CarRentalRecords
                .Select(q => new
                {
                    CustomerName = q.CustomerName,
                    DateIn = q.DateRented,
                    DateOut = q.DateReturned,
                    Id = q.Id,
                    q.Cost,
                    car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
                })
                .ToList();
            dgvVehicleRecords.DataSource = records;
            //dgvVehicleRecords.Columns[4].HeaderText = "License Plate Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            dgvVehicleRecords.Columns["Id"].Visible = false;
        }

   

        private void btnAddRentalRecords_Click(object sender, EventArgs e)
        {
            var addRentalRecords = new AddEditRentalRecords();
            addRentalRecords.MdiParent = this.MdiParent;
            addRentalRecords.Show();
        }

        private void btnEditRentalRecords_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehicleRecords.SelectedRows.Count > 0)
                {
                    //get Id of selected Row
                    var id = (int)dgvVehicleRecords.SelectedRows[0].Cells["Id"].Value;

                    //query database from record
                    var records = manageVechicleEnity.CarRentalRecords.FirstOrDefault(s => s.Id == id);

                    ////Launch AddEditRentalRecords with data
                    var addEditRentalRecords = new AddEditRentalRecords(records);
                    addEditRentalRecords.MdiParent = this.MdiParent;
                    addEditRentalRecords.Show();
                    //MessageBox.Show("Row Edited ", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Select A Row  ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteRentalRecords_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehicleRecords.SelectedRows.Count > 0)
                {

                    //get Id of selected Row
                    var id = (int)dgvVehicleRecords.SelectedRows[0].Cells["Id"].Value;

                    //query database from record
                    var record = manageVechicleEnity.CarRentalRecords.FirstOrDefault(s => s.Id == id);

                    DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Record?",
                   "Delete", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        //delete vehicle from table
                        manageVechicleEnity.CarRentalRecords.Remove(record);
                        manageVechicleEnity.SaveChanges();

                        PopulateGrid();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Select A Row  ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridForRefresh();
        }
        //New Function to PopulateGrid.Can be called anytime we need a grid refresh
        public void PopulateGridForRefresh()
        {
            // Select a custom model collection of cars from database
            var cars = manageVechicleEnity.CarRentalRecords
                .Select(q => new
                {
                    CustomerName = q.CustomerName,
                    DateRented = q.DateRented,
                    DateReturned = q.DateReturned,
                    Cost = q.Cost,
                    
                    q.Id
                })
                .ToList();
            dgvVehicleRecords.DataSource = cars;
            dgvVehicleRecords.Columns[4].HeaderText = "License Plate Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            dgvVehicleRecords.Columns["Id"].Visible = false;
        }

       
    }
}
