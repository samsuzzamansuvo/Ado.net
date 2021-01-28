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
    public partial class Registration : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Registration()
        {
            InitializeComponent();
            ClearAll();
        }

        private void ClearAll()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtUsernames.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //pannelRegistration.Parent = pictureBoxRegistrtion;
            //pannelRegistration.BackColor = Color.Transparent;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.FirstName = txtFirstname.Text;
            user.LastName = txtLastname.Text;
            user.Adress = txtAddress.Text;
            user.PhoneNo = txtPhone.Text;
            user.UserName = txtUsernames.Text;
            user.Passwords = txtPassword.Text;
            var a = 7;
            var b = 11;
            if (txtFirstname.Text == "" || txtLastname.Text == "" || txtPassword.Text == "")
                MessageBox.Show("This Field Can't be Empty");
            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Password Dosen't Match");
            else if (txtPassword.Text.Length < a)
                MessageBox.Show("Password Must be 6 Charecter long");
            else if (txtPhone.Text.Length != b)
                MessageBox.Show("Phone no must be in 11 digites");
            else
            {
                using (var con = new SqlConnection(conStr))
                {
                    int count = 0;
                    var cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert Into Users(FirstName,LastName,Adress,PhoneNo,UserName,Passwords)" +
                                      "VALUES('" + user.FirstName + "','" + user.LastName + "','" + user.Adress + "','" + user.PhoneNo + "','" + user.UserName + "','" + user.Passwords + "')";
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Congratulation****** @ Registration Complete Sucessfully");
                        this.Hide();
                        login log = new login();
                        log.Show();
                    }
                    else
                    {
                        MessageBox.Show("Something Is Wrong*****");
                    }
                    ClearAll();
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }
    }
}
