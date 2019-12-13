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
    public partial class UpdateForm : Form
    {
        private int EmployeeId;
        private EmployeeManagement Business;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.Business = new EmployeeManagement();
            this.Load += UpdateForm_Load;
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var employee = this.Business.GetEmployee(this.EmployeeId);
            this.cmbLocation.DataSource = this.Business.GetEmployees();
            this.cmbLocation.DisplayMember = "Name";
            this.cmbLocation.ValueMember = "id";
            this.cmbLocation.SelectedValue = employee.Location_id;
        }
    }
}
