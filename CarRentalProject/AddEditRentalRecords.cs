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
    public partial class AddEditRentalRecords : Form
    {
        //private readonly CarRentalEntities2 carRentalEntities2;
        private readonly CarRentalEntities2 manageVechicleEnity;
        private bool isEditMode;
        public AddEditRentalRecords()
        {
            InitializeComponent();
          
            IblTitle.Text = " Add New Rental Record ";
            this.Text = " Add New Rental Record ";
            isEditMode = false;
           manageVechicleEnity = new CarRentalEntities2();

        }
        public AddEditRentalRecords(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            isEditMode = true;
            IblTitle.Text = "Edit Rental Record";
            manageVechicleEnity = new CarRentalEntities2();
         
            if (recordToEdit == null)
            {
                MessageBox.Show(" Please ensure that  select a valid record to edit", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                isEditMode = true;
                manageVechicleEnity = new CarRentalEntities2();
                PopulateFields(recordToEdit);
            }
        }
        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            //IblId.Text = Car.Id.ToString();
            tbCustomerName.Text = recordToEdit.CustomerName;
            tbCost.Text = recordToEdit.Cost.ToString();

            dtRented.Value = (DateTime)recordToEdit.DateRented;
            dtReturned.Value = (DateTime)recordToEdit.DateReturned;
            IblRecordId.Text = recordToEdit.Id.ToString();
        }


        private void AddRentalRecords_Load(object sender, EventArgs e)
        {
            // select * from TypeOfCars
            //  var cars = carRentalEntities2.TypesOfCars.ToList();
            try
            {
                var cars = manageVechicleEnity.TypesOfCars.Select // TypesOfCars is entity name of TypesOfCars table
                  (s => new { Id = s.Id, Name = s.Make + " " + s.Model }).ToList();

           
                cbTypeOfCar.DisplayMember = "Name";
                cbTypeOfCar.ValueMember = "Id";
                cbTypeOfCar.DataSource = cars;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string CustomerName = tbCustomerName.Text;
                string Cost = tbCost.Text;
                var DateRented = dtRented.Value;
                var DateRetrurned = dtReturned.Value;

                string TypeofCars = cbTypeOfCar.Text;
                bool IsValid = true;

                if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(TypeofCars))
                {
                    MessageBox.Show("Please enter the Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                if (IsValid)
                {
                    var rentalRecords = new CarRentalRecord();
                    if (isEditMode)
                    {
                        var id = int.Parse(IblRecordId.Text);
                        rentalRecords = manageVechicleEnity.CarRentalRecords.FirstOrDefault(q => q.Id == id);
                        rentalRecords.CustomerName = CustomerName;
                        rentalRecords.Cost = decimal.Parse(Cost);
                        rentalRecords.DateRented = DateRented;
                        rentalRecords.DateReturned = DateRetrurned;
                        rentalRecords.TypesOfCarsId = (int)cbTypeOfCar.SelectedValue;
                    }
                    else
                    {
                        
                        rentalRecords.CustomerName = CustomerName;
                        rentalRecords.Cost = decimal.Parse(Cost);
                        rentalRecords.DateRented = DateRented;
                        rentalRecords.DateReturned = DateRetrurned;
                        rentalRecords.TypesOfCarsId = (int)cbTypeOfCar.SelectedValue;

                        manageVechicleEnity.CarRentalRecords.Add(rentalRecords); //(its auto generated entity)CarRentalRecords is CarRentalRecord Table Enitity
                        manageVechicleEnity.SaveChanges();

                        MessageBox.Show($"Customer Name : {CustomerName} \n\r" + $" Cost : {Cost}  \n\r "
                            + $"Date That Rented : {DateRented} \n\r "
                            + $"Date That Returned : {DateRetrurned} \n\r " + $"Car Type : {TypeofCars} \n\r ");
                    }
                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
