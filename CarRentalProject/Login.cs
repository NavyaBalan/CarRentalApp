using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class Login : Form
    {

        private readonly CarRentalEntities2 manageVechicleEnity;
        public Login()
        {
            InitializeComponent();
            manageVechicleEnity = new CarRentalEntities2();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SHA256 sha = SHA256.Create();
            var username = tbUserName.Text.Trim();
            var password = tbPassword.Text;

            //convert the input string to a byte  array and compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //StringBuilder to collete the byte
            StringBuilder sBuilder = new StringBuilder();
            
            //loop through each byte of the hashed data and format each one as a hexadecimal string
            for(int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            var hash_password = Utils.HashPassword(password);
          
            var user = manageVechicleEnity.Users.FirstOrDefault(q => q.UserName == username && q.Password == password && q.isActive == true);


            if (user == null)
            {
                MessageBox.Show("Please Provide a valid crededentials", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
             
                var mainwindow = new MainWindow(this , user);
                mainwindow.Show();
                Hide();
            }
        }
    }
}
