using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Wellcome : Form
    {
        public Wellcome()
        {
            InitializeComponent();
        }

        private void Wellcome_Load(object sender, EventArgs e)
        {
            lblinvenManage.Parent = pictureBox1;
            lblinvenManage.BackColor = Color.Transparent;

            lblNext.Parent = pictureBox1;
            lblNext.BackColor = Color.Transparent;
          
        }

        private void lblNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login logins = new login();
            logins.Show();
        }
    }
}
