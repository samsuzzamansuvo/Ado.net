using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class login : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //panelLogin.Parent = pictureBoxLogin;
            //pictureBoxLogin.BackColor = Color.Transparent;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var con=new SqlConnection(conStr))
            {
                string specificRowQuery = "SELECT * FROM Users WHERE UserName='" + txt_UserName.Text.Trim() + "' and Passwords='" + txt_Password.Text.Trim() + "'";
                SqlDataAdapter da = new SqlDataAdapter(specificRowQuery, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count==1)
                {
                    ProductInformation product = new ProductInformation();
                    product.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct UserName and Password");
                }
            }
        }
       
    }
}
