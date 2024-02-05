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
    public partial class MainWindow : Form
               
    {
        private Login _login;
        private string _roleName;
        private User _user;
       

        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login ,User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;

            //   _roleName =  user.UserRoles.FirstOrDefault().Role.name;
            if (_user.UserRoles != null && _user.UserRoles.Any())
            {
                _roleName = _user.UserRoles.First().Role.name;
            }
            else
            {
                // Handle the case where there are no user roles.
                // You might want to set a default role or handle it in a way that makes sense for your application.
                _roleName = "DefaultRole";
            }
        }

        private void addRentedRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditRentalRecords"))
            {
                var addRentalRecords = new AddEditRentalRecords();
                addRentalRecords.MdiParent = this;
                addRentalRecords.Show();
            }
        }

        private void manageVechicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("ManageVehicleListing"))
            { 
                var manageVechicleListing = new ManageVehicleListing();
                manageVechicleListing.MdiParent = this;
                manageVechicleListing.Show();
            }
           
        }

        private void viewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageRentalRecords"))
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();

            }

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            if(_user.Password == Utils.DefaultHashedPassword())
            {
                var resetPassword = new RestPassword(_user);
                resetPassword.ShowDialog();

            }

            var username = _user.UserName;
            tsiLogintxt.Text = $"Logged As : {username} ";
            if(username == "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
          
        }

    }

    
}
