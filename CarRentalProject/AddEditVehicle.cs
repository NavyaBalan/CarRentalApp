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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly  CarRentalEntities2 manageVechicleEnity;
      


        public AddEditVehicle()
        {
            InitializeComponent();
            isEditMode = false;

            IblTitle.Text = "Add New Vehicle";
            manageVechicleEnity = new CarRentalEntities2();
        }
        public AddEditVehicle(TypesOfCar CarToEdit)
        {
            InitializeComponent();
            isEditMode = true;
            IblTitle.Text = "Edit Vehicle";
            manageVechicleEnity = new CarRentalEntities2();
            PopulateFields(CarToEdit);
        }


        private void PopulateFields(TypesOfCar Car)
        {
            IblId.Text = Car.Id.ToString();
            txtMake.Text = Car.Make;
            txtModel.Text = Car.Model;
            txtVin.Text = Car.VIN;
            txtYear.Text = Car.Year.ToString();
            txtLicense.Text = Car.LicensePlateNumber;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(isEditMode == true)
            {
                //Edit code  here 
                var id = int.Parse(IblId.Text);
                var car = manageVechicleEnity.TypesOfCars.FirstOrDefault(s => s.Id == id);
                car.Make = txtMake.Text;
                car.Model = txtModel.Text;
                car.Year = int.Parse(txtYear.Text);
                car.VIN = txtVin.Text;
                car.LicensePlateNumber = txtLicense.Text;
                manageVechicleEnity.SaveChanges();


            }
            else
            {
                //Add code here
                var newCar = new TypesOfCar()
                {
                    LicensePlateNumber = txtLicense.Text ,
                    Make = txtMake.Text ,
                    Model = txtModel.Text ,
                    VIN = txtVin.Text ,
                    Year = int.Parse(txtYear.Text) 

                };
                manageVechicleEnity.TypesOfCars.Add(newCar);
                manageVechicleEnity.SaveChanges();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
