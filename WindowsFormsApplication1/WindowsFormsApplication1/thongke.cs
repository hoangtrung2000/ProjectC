using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class thongke : Form
    {
        private EmployeeManagement Business;
        public thongke()
        {
            InitializeComponent();
            this.Business = new EmployeeManagement();
            this.Load += thongke_Load;
        }

        void thongke_Load(object sender, EventArgs e)
        {
            this.ShowData();
        }
        public void ShowData()
        {
            this.grdLocationViews.DataSource = this.Business.GetLocations();
        }
    }
}
