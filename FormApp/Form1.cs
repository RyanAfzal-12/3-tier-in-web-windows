using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppProps;
using Business_Layer;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employeDataGridView.Visible = false;
            btn_getdata.Visible = false;
            btn_updatenow.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            string empId = empid_textbox.Text;
            string name = name_textbox.Text;
            string cellNo = cell_textbox.Text;
            string address = address_textbox.Text;

            Employee newEmployee = new Employee
            {
                Emp_Id = empId,
                Name = name,
                Cell_No = cellNo,
                Address = address
            };

            EmpBLL empBLL = new EmpBLL();
            bool isInserted = empBLL.EmpInsertBLL(newEmployee);

            if (isInserted)
            {
                MessageBox.Show("Employee data saved successfully!");
            }
            else
            {
                MessageBox.Show("Error saving employee data.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text;
            Employee newEmployee = new Employee
            {
                Emp_Id = empId,

            };

            EmpBLL empBLL = new EmpBLL();
            bool isDeleted = empBLL.EmpDeleteBLL(empId);

            if (isDeleted)
            {
                MessageBox.Show("Employee data deleted successfully!");
            }
            else
            {
                MessageBox.Show("Error deleting employee data.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string emp_Id = empid_textbox.Text;
            btn_getdata.Visible = true;
            name_textbox.Enabled = false;
            cell_textbox.Enabled = false;
            address_textbox.Enabled = false;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text; 

            EmpBLL empBLL = new EmpBLL(); 

            DataTable dt = empBLL.EmpSearchBLL(empId);
            if (dt != null && dt.Rows.Count > 0)
            {
                name_textbox.Text = dt.Rows[0]["Name"].ToString();
                cell_textbox.Text = dt.Rows[0]["Cell_No"].ToString();
                address_textbox.Text = dt.Rows[0]["Address"].ToString();

            }
            else
            {
                MessageBox.Show("Error searching data or no data found!");
            }
        


        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text;
            string name = name_textbox.Text;
            string cellNo = cell_textbox.Text;
            string address = address_textbox.Text;
            EmpBLL empBLL = new EmpBLL();

            DataTable dt = empBLL.EmpViewAllBLL(empId, name, cellNo, address);

            if (dt != null && dt.Rows.Count > 0)
            {
                employeDataGridView.Visible = true;
                employeDataGridView.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Error searching data or no data found!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            empid_textbox.Clear();
            name_textbox.Clear();
            cell_textbox.Clear();
            address_textbox.Clear();
        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            string emp_Id = empid_textbox.Text;

            custBLL custBLL = new custBLL();

            DataTable dt = custBLL.CustSearchBLL(emp_Id);
            name_textbox.Text = dt.Rows[0]["Name"].ToString();
            cell_textbox.Text = dt.Rows[0]["Cell_No"].ToString();
            address_textbox.Text = dt.Rows[0]["Address"].ToString();
            btn_updatenow.Visible = true;
            name_textbox.Enabled = true;
            cell_textbox.Enabled = true;
            address_textbox.Enabled = true;
        }

        private void btn_updatenow_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text;
            string name = name_textbox.Text;
            string cellNo = cell_textbox.Text;
            string address = address_textbox.Text;
            Employee newEmployee = new Employee
            {
                Emp_Id = empId,
                Name = name,
                Cell_No = cellNo,
                Address = address
            };

            EmpBLL empBLL = new EmpBLL();
            bool isUpdated = empBLL.EmpUpdateBLL(empId, name, cellNo, address);
            if (isUpdated)
            {
                MessageBox.Show("Employee data updated successfully!");
            }
            else
            {
                MessageBox.Show("Error updating employee data.");
            }
        }
    }
}



