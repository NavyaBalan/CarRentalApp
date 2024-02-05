using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class RestPassword : Form
    {
        private readonly CarRentalEntities2 _db;
        private User _user;
        public RestPassword(User user)
        { 
            InitializeComponent();
            _db = new CarRentalEntities2();
            _user = user;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbPassword.Text;
                var confirmPassword = tbCPassword.Text;

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
                var user = _db.Users.FirstOrDefault(q => q.Id ==  _user.Id);

                if (user != null)
                {

                    user.Password = password;

                    _db.SaveChanges();
                    MessageBox.Show("Password has been reset successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("User not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DbEntityValidationException ex)
            {
                // Display or log the validation errors
                foreach (var entityValidationError in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationError.ValidationErrors)
                    {
                        Console.WriteLine($"Validation Error: Property - {validationError.PropertyName}, Error - {validationError.ErrorMessage}");
                    }
                }
            }

            }



        }
}
