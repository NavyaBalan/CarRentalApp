using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CarRentalProject
{
   public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(s => s.Name == name);
            return isOpen;
        }
        public static string HashPassword(string password)
        {

            SHA256 sha = SHA256.Create();
            //convert the input string to a byte  array and compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //StringBuilder to collete the byte
            StringBuilder sBuilder = new StringBuilder();

       
            //loop through each byte of the hashed data and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static string DefaultHashedPassword()
        {

            SHA256 sha = SHA256.Create();
            //convert the input string to a byte  array and compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("password@123"));

            //StringBuilder to collete the byte
            StringBuilder sBuilder = new StringBuilder();

            //loop through each byte of the hashed data and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}