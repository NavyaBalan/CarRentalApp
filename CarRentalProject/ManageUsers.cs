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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities2 _db;
        private User _user;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities2();
            _user = new User();
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        public void PopulateGrid()
        {

            var users = _db.Users
                .Select(q => new
                {
                    q.Id,
                    q.UserName,
                    q.UserRoles.FirstOrDefault().Role.name,
                    q.isActive
                })
                .ToList();
            dgvManageUsers.DataSource = users;
            dgvManageUsers.Columns["username"].HeaderText = "Username";
            dgvManageUsers.Columns["name"].HeaderText = "Role Name";
            dgvManageUsers.Columns["isActive"].HeaderText = "Active";


            dgvManageUsers.Columns["Id"].Visible = false;
        }
        private void btnREesetPassword_Click(object sender, EventArgs e)
        {


            try
            {
                var id = (int)dgvManageUsers.SelectedRows[0].Cells["Id"].Value;
                _user.Id = id;

                RestPassword resetPassword = new RestPassword(_user);
                resetPassword.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        


        }


        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)dgvManageUsers.SelectedRows[0].Cells["id"].Value;

                //query database for record
                var user = _db.Users.FirstOrDefault(q => q.Id == id);
                //if (user.isActive == true)
                //    user.isActive = false;
                //else
                //    user.isActive = true;
                user.isActive = user.isActive == true ? false : true;
                _db.SaveChanges();

                MessageBox.Show($"{user.UserName}'s active status has changed!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
