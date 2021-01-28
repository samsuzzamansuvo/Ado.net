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
    public partial class ReportForm : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public ReportForm()
        {
            InitializeComponent();
        }
      
        private void btnVewReport_Click_1(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From Product";
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                var rdr = cmd.ExecuteReader();
                dt.Load(rdr, LoadOption.Upsert);

                List<Product> products = new List<Product>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Product obj = new Product();
                    obj.ProductId = Convert.ToInt32(dt.Rows[i]["ProductId"].ToString());
                    obj.ProductName = dt.Rows[i]["ProductName"].ToString();
                    obj.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                    obj.MfgDate = Convert.ToDateTime(dt.Rows[i]["MfgDate"].ToString());
                    obj.ExpDate = Convert.ToDateTime(dt.Rows[i]["ExpDate"].ToString());
                    obj.SupplierId = Convert.ToInt32(dt.Rows[i]["SupplierId"].ToString());
                    obj.StockID = Convert.ToInt32(dt.Rows[i]["StockID"].ToString());
                    products.Add(obj);
                }

                using (PrintReport prForm = new PrintReport(products))
                {
                    prForm.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInformation pf = new ProductInformation();
            pf.Show();
        }
    }
}
