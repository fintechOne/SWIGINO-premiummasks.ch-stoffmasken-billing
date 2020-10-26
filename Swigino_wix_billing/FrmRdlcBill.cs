using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swigino_wix_billing
{
    public partial class FrmRdlcBill : Form
    {
        public FrmRdlcBill()
        {
            InitializeComponent();
        }

        private void FrmRdlcBill_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
