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
    public partial class CreateForm : Form
    {
        private EmployeeManagement Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new EmployeeManagement();
            this.Load += CreateForm_Load;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtName.Text;
            var birthday = this.dtp.Value;
            var address = this.txtAddress.Text;
            var location_id = (int)this.cmbLocation.SelectedValue;
            var timework = (int)this.nudTimework.Value;
            var salary = 0;
            this.Business.CreateEmployee(code, name, birthday, address, location_id, timework, salary);
            MessageBox.Show("Create employee successfully");
            this.Close();

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void CreateForm_Load(object sender, EventArgs e)
        {
            this.cmbLocation.DataSource = this.Business.GetLocations();
            this.cmbLocation.DisplayMember = "Name";
            this.cmbLocation.ValueMember = "id";
        }   
    }
}
