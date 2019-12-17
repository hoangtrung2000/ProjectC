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
        private int developer = 100000;
        private int it = 200000;
        private int hrm = 150000;
        private EmployeeManagement Business;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.EmployeeId = id;
            this.Business = new EmployeeManagement();
            this.Load += UpdateForm_Load;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text;
            var name = txtName.Text;
            var birthday = dtp.Value;
            var address = txtAddress.Text;
            var location_id = (int)this.cmbLocation.SelectedValue;
            var timework = (int)nudTimework.Value;
            var salary = SalaryTotal();
            this.Business.UpdateEmployee(EmployeeId, code, name, birthday, address, location_id, timework, salary);
            MessageBox.Show("Update employee successfully");
            this.Close();
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var employee = this.Business.GetEmployee(this.EmployeeId);
            this.txtId.Text = employee.id.ToString();
            this.txtCode.Text = employee.Code;
            this.txtName.Text = employee.Name;
            this.dtp.Value = employee.Birthday;
            this.txtAddress.Text = employee.Address;      
            this.nudTimework.Value = employee.Timework;
            this.txtSalary.Text = employee.Salary.ToString();
            this.cmbLocation.DataSource = this.Business.GetLocations();
            this.cmbLocation.DisplayMember = "Name";
            this.cmbLocation.ValueMember = "id";
            this.cmbLocation.SelectedValue = employee.Location_id;
        }
        public int SalaryTotal()
        {
            int hoursalary = 0;
            if (cmbLocation.Text == "Developer")
            {
                hoursalary = (int)nudTimework.Value * developer;
            }
            else if (cmbLocation.Text == "IT Manager")
            {
                hoursalary = (int)nudTimework.Value * it;
            }
            else if (cmbLocation.Text == "HRM")
            {
                hoursalary = (int)nudTimework.Value * hrm;
            }
            return hoursalary;
        }
    }
}
