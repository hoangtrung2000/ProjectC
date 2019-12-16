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
    public partial class IndexForm : Form
    {
        private EmployeeManagement Business;
        public IndexForm()
        {
            InitializeComponent();
            this.Business = new EmployeeManagement();
            this.Load += IndexForm_Load;
            this.btnCreate.Click += btnCreate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdViewAll.DoubleClick += grdViewAll_DoubleClick;
            this.btnSearch.Click += btnSearch_Click;
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            var db = new IMDatabaseEntities();
            var infor = this.Business.GetEmployees();
            var searching = new EmployeeView[infor.Length];
            for (int i = 0; i < infor.Length; i++)
                searching[i] = new EmployeeView(infor[i]);
            grdViewAll.DataSource = searching.Where(x => x.Code.Contains(txtSearch.Text)).ToList();
        }

        void grdViewAll_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdViewAll.SelectedRows.Count == 1)
            {
                var row = this.grdViewAll.SelectedRows[0];
                var employeeView = (EmployeeView)row.DataBoundItem;

                new UpdateForm(employeeView.id).ShowDialog();
                this.ShowAllEmployees();
            }
        }
        //tang cai nao
        // nudTimework 
        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdViewAll.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var DeleteEmployee = (EmployeeView)this.grdViewAll.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteEmployee(DeleteEmployee.id);
                    MessageBox.Show("Delete employee successfully");
                    this.ShowAllEmployees();
                }
            }
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateForm().ShowDialog();
            this.ShowAllEmployees();
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            this.ShowAllEmployees();
        }
        public void ShowAllEmployees()
        {
            var employees = this.Business.GetEmployees();
            var employeeViews = new EmployeeView[employees.Length];
            for (int i = 0; i < employees.Length; i++)
                employeeViews[i] = new EmployeeView(employees[i]);
            this.grdViewAll.DataSource = employeeViews;          
        }
    }
}
