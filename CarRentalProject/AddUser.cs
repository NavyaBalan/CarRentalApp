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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities2 _db;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new CarRentalEntities2();
            _manageUsers = manageUsers ;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cbRole.DataSource = roles;
            cbRole.DisplayMember = "name";
            cbRole.ValueMember = "id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUserName.Text;
                var RoleId = (int)cbRole.SelectedValue;
                var password = tbPassword.Text;
                var user = new User
                {
                    UserName = username,
                    Password = password,
                    isActive = true

                };
                _db.Users.Add(user);
                _db.SaveChanges();

                //To see the userid and roleid into the UserRole table
                var userId = user.Id;
                var userRole = new UserRole { roleId = RoleId, userId = userId };

                //add these record into the table UserRoles
                _db.UserRoles.Add(userRole);
                _db.SaveChanges();

                MessageBox.Show("New User Is Added Successfully", "Success Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _manageUsers.PopulateGrid();
                //after that close the window
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

       
    }
}
