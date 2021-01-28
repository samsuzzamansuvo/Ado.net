using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ProductInformation : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        int count = 0;        
        string imglocation;
        public ProductInformation()
        {
            InitializeComponent(); 
            LoadCmbSupplier();
           // CleareAll();
        }

        private void CleareAll()
        {
            txtproductid.Text = "";
            txtstockid.Text = "";
            txtprice.Text = "";
        }

        private void ProductInformation_Load(object sender, EventArgs e)
        {
          //  LoadCmbSupplier();
            LoadProductInfoDataGridView();
        }

        private void LoadCmbSupplier()
        {
            using (var conn = new SqlConnection(conStr))
            {
                DataRow dr;
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Supplier";
                conn.Open();
                var dt = new DataTable();
                var rdr = cmd.ExecuteReader();
                dt.Load(rdr, LoadOption.Upsert);

                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "----Select Type---" };
                dt.Rows.InsertAt(dr, 0);

                combosupplier.ValueMember = "SupplierId";
                combosupplier.DisplayMember = "SupplierName";
                combosupplier.DataSource = dt;

            }
        }

        private void LoadProductInfoDataGridView()
        {
            using (var conn = new SqlConnection(conStr))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Product";
                conn.Open();
                var dt = new DataTable();
                var rdr = cmd.ExecuteReader();
                dt.Load(rdr, LoadOption.Upsert);
                if (dt != null)
                {
                    dgvProductinformation.DataSource = dt;
                }

            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Product obje = new Product();

            try
            {
                obje.ProductId = Convert.ToInt32(txtproductid.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Product ID");
            }
            obje.ProductName = txtproductname.Text;
            try
            {
                obje.Price = Convert.ToDecimal(txtprice.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Price");
            }
            try
            {
                obje.MfgDate = Convert.ToDateTime(dtpmfgdate.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid MFG Date");
            }
            try
            {
                obje.ExpDate = Convert.ToDateTime(dtpexpdate.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid EXP Date");
            }
            try
            {
                obje.SupplierId = Convert.ToInt32(combosupplier.SelectedValue);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Supplier ID");
            }
            try
            {
                obje.StockID = Convert.ToInt32(txtstockid.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Stock ID");
            }
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);




            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Product(ProductId,ProductName,Price,MfgDate,ExpDate,ProductImage,SupplierId,StockID) " +
                    "Values('" + obje.ProductId + "','" + obje.ProductName + "','" + obje.Price + "','" + obje.MfgDate + "','" + obje.ExpDate + "',@image,'" + obje.SupplierId + "','" + obje.StockID + "')";
                cmd.Parameters.Add(new SqlParameter("@image", images));
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count > 0)
                {

                    MessageBox.Show("Data Inserted sucesfully");
                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }

            }
            LoadProductInfoDataGridView();
            CleareAll();
        }
        private void linkupload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dilog = new OpenFileDialog();
            dilog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dilog.FileName.ToString();
                imgbox.ImageLocation = imglocation;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Product obje = new Product();

            try
            {
                obje.ProductId = Convert.ToInt32(txtproductid.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Product ID");
            }
            obje.ProductName = txtproductname.Text;
            try
            {
                obje.Price = Convert.ToDecimal(txtprice.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Price");
            }
            try
            {
                obje.MfgDate = Convert.ToDateTime(dtpmfgdate.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid MFG Date");
            }
            try
            {
                obje.ExpDate = Convert.ToDateTime(dtpexpdate.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid EXP Date");
            }
            try
            {
                obje.SupplierId = Convert.ToInt32(combosupplier.SelectedValue);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Supplier ID");
            }
            try
            {
                obje.StockID = Convert.ToInt32(txtstockid.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Stock ID");
            }
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);




            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Product  set ProductName='" + obje.ProductName + "',Price='" + obje.Price + "',MfgDate='" + obje.MfgDate + "',ExpDate='"+obje.ExpDate+ "',ProductImage=@image,SupplierId='"+obje.SupplierId+ "',StockID='" + obje.StockID + "' where ProductId='" + obje.ProductId + "';";
                cmd.Parameters.Add(new SqlParameter("@image", images));
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Data Update sucesfully");
                }
                else
                {
                    MessageBox.Show("Data not Updated");
                }

            }
            LoadProductInfoDataGridView();
            CleareAll();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Product obje = new Product();

            try
            {
                obje.ProductId = Convert.ToInt32(txtproductid.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Product ID");
            }
            obje.ProductName = txtproductname.Text;
            try
            {
                obje.Price = Convert.ToDecimal(txtprice.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Price");
            }
            try
            {
                obje.MfgDate = Convert.ToDateTime(dtpmfgdate.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid MFG Date");
            }
            try
            {
                obje.ExpDate = Convert.ToDateTime(dtpexpdate.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid EXP Date");
            }
            try
            {
                obje.SupplierId = Convert.ToInt32(combosupplier.SelectedValue);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Supplier ID");
            }
            try
            {
                obje.StockID = Convert.ToInt32(txtstockid.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Stock ID");
            }
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);




            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Product where ProductId='" + obje.ProductId + "'";
                cmd.Parameters.Add(new SqlParameter("@image", images));
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Data Update sucesfully");
                }
                else
                {
                    MessageBox.Show("Data not Updated");
                }

            }
            LoadProductInfoDataGridView();
            CleareAll();
        }

        private void dgvProductinformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            DataGridViewRow row = dgvProductinformation.Rows[cellId];

            int proID = Convert.ToInt32(row.Cells[0].Value.ToString());
            txtproductid.Text = proID.ToString();

            txtproductname.Text = row.Cells[1].Value.ToString();

            decimal pric = Convert.ToDecimal(row.Cells[2].Value.ToString());
            txtprice.Text = pric.ToString();

            DateTime mfgdate = Convert.ToDateTime(row.Cells[3].Value.ToString());
            dtpmfgdate.Text = mfgdate.ToString();

            DateTime expdate = Convert.ToDateTime(row.Cells[4].Value.ToString());
            dtpexpdate.Text = expdate.ToString();

            int supID = Convert.ToInt32(row.Cells[6].Value.ToString());
            combosupplier.Text = supID.ToString();

            int stokID = Convert.ToInt32(row.Cells[7].Value.ToString());
            txtstockid.Text = stokID.ToString();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wellcome wlc = new Wellcome();
            wlc.Show();
        }

        private void lblreport_Click(object sender, EventArgs e)
        {

            this.Hide();
            ReportForm rf = new ReportForm();
            rf.Show();
        }
    }
}
