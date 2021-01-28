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
    public partial class PrintReport : Form
    {
        List<Product> _list;
        public PrintReport(List<Product> products)
        {
            InitializeComponent();
            _list = products;
        }

        private void PrintReport_Load(object sender, EventArgs e)
        {
            Productinfo rpt = new Productinfo();
            rpt.SetDataSource(_list);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
