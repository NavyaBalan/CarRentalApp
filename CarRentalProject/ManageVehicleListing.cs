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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities2 manageVechicleEnity;
        public ManageVehicleListing()
        {
            InitializeComponent();
            manageVechicleEnity = new CarRentalEntities2();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            // display the gridView from TypeOfCars Table
            // var cars = manageVechicleEnity.TypesOfCars.Select(s => new { CarId = s.Id, CarName = s.Name }).ToList();
            try
            {

                    var cars = manageVechicleEnity.TypesOfCars
                .Select(s => new { Make = s.Make, Model = s.Model, VIN = s.VIN,
                    License = s.LicensePlateNumber,s.Id
                })
                .ToList();
                dgvVehicleListing.DataSource = cars;
                //dgvVehicleListing.Columns[4].HeaderText = " License Plate Number ";
                dgvVehicleListing.Columns["Id"].Visible = false ;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehicleListing.SelectedRows.Count > 0)
                {
                    //get Id of selected Row
                    var id = (int)dgvVehicleListing.SelectedRows[0].Cells["Id"].Value;

                    //query database from record
                    var cars = manageVechicleEnity.TypesOfCars.FirstOrDefault(s => s.Id == id);

                    //Launch AddEditVehiclewindow with data
                    //var addEditVehicle = new AddEditVehicle(cars);
                    //addEditVehicle.MdiParent = this.MdiParent;
                    //addEditVehicle.Show();
                    if (!Utils.FormIsOpen("AddEditVehicle"))
                    {
                        var addEditVehicle = new AddEditVehicle(cars, this);
                        addEditVehicle.MdiParent = this.MdiParent;
                        addEditVehicle.Show();
                    }
                }
                else
                {

                    MessageBox.Show("Select A Row  ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            // get Id of selected row
            var id = (int)dgvVehicleListing.SelectedRows[0].Cells["Id"].Value;

            //query database for record
            var car = manageVechicleEnity.TypesOfCars.FirstOrDefault(q => q.Id == id);

            DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Record?",
                "Delete", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                //delete vehicle from table
                manageVechicleEnity.TypesOfCars.Remove(car);
                manageVechicleEnity.SaveChanges();
                MessageBox.Show("The Record Is Deleted","Success Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            //PopulateGrid();
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
       //New Function to PopulateGrid.Can be called anytime we need a grid refresh
        public void PopulateGrid()
        {
            // Select a custom model collection of cars from database
            var cars = manageVechicleEnity.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.Id
                })
                .ToList();
            dgvVehicleListing.DataSource = cars;
            dgvVehicleListing.Columns[4].HeaderText = "License Plate Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            dgvVehicleListing.Columns["Id"].Visible = false;
        }
    }
}
