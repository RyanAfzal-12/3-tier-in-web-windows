using AppProps;
using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            customerdatagridview.Visible = false;
            btn_getdata.Visible = false;
            btn_updatenow.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Customer_Id = customeridtxt.Text;
            string Name = nametxt.Text;
            string Cell_No = cellnotxt.Text;
            string Address = addresstxt.Text;

            cust customer = new cust
            {
                Customer_Id1 = Customer_Id,
                Customer_Name1 = Name,
                Cell_No1 = Cell_No,
                Address1 = Address
            };

            custBLL custBLL = new custBLL();
            bool isInserted = custBLL.CustInsertBLL(customer);

            if (isInserted)
            {
                MessageBox.Show("Customer data saved successfully!");
            }
            else
            {
                MessageBox.Show("Error saving customer data.");
            }
        }
    

        private void btn_update_Click(object sender, EventArgs e)

        {
            string Customer_Id = customeridtxt.Text;                           
            btn_getdata.Visible = true;
            nametxt.Enabled = false; 
            cellnotxt.Enabled = false;
            addresstxt.Enabled = false;

        }


            
        

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Customer_Id = customeridtxt.Text;
            cust customer = new cust
            {
                Customer_Id1 = Customer_Id,

            };

            custBLL custBLL = new custBLL();
            bool isDeleted = custBLL.CustDeleteBLL(Customer_Id);

            if (isDeleted)
            {
                MessageBox.Show("Customer data deleted successfully!");
            }
            else
            {
                MessageBox.Show("Error deleting customer data.");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Customer_Id = customeridtxt.Text;

            custBLL custBLL = new custBLL();

            DataTable dt = custBLL.CustSearchBLL(Customer_Id);
            if (dt != null && dt.Rows.Count > 0)
            {
                nametxt.Text = dt.Rows[0]["Name"].ToString();
                cellnotxt.Text = dt.Rows[0]["Cell_No"].ToString();
                addresstxt.Text = dt.Rows[0]["Address"].ToString();

            }
            else
            {
                MessageBox.Show("Error searching data or no data found!");
            }
            
                        
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string Customer_Id = customeridtxt.Text;
            string Name = nametxt.Text;
            string Cell_No = cellnotxt.Text;
            string Address = addresstxt.Text;
            custBLL custBLL = new custBLL();

            DataTable dt = custBLL.CustViewAllBLL(Customer_Id, Name, Cell_No, Address);

            if (dt != null && dt.Rows.Count > 0)
            {
                customerdatagridview.Visible = true;
                customerdatagridview.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Error searching data or no data found!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            customeridtxt.Clear();
            nametxt.Clear();
            cellnotxt.Clear();
            addresstxt.Clear();


        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            string Customer_Id = customeridtxt.Text;

            custBLL custBLL = new custBLL();

            DataTable dt = custBLL.CustSearchBLL(Customer_Id);
            nametxt.Text = dt.Rows[0]["Name"].ToString();
            cellnotxt.Text = dt.Rows[0]["Cell_No"].ToString();
            addresstxt.Text = dt.Rows[0]["Address"].ToString();
            btn_updatenow.Visible = true;
            nametxt.Enabled = true;
            cellnotxt.Enabled = true;
            addresstxt.Enabled = true;

        }

        private void btn_updatenow_Click(object sender, EventArgs e)
        {
            string Customer_Id = customeridtxt.Text;
            string Name = nametxt.Text;
            string Cell_No = cellnotxt.Text;
            string Address = addresstxt.Text;
            cust customer = new cust
            {
                Customer_Id1 = Customer_Id,
                Customer_Name1 = Name,
                Cell_No1 = Cell_No,
                Address1 = Address
            };

            custBLL custBLL = new custBLL();
            bool isUpdated = custBLL.CustUpdateBLL(Customer_Id, Name, Cell_No, Address);
            if (isUpdated)
            {
                MessageBox.Show("Customer data updated successfully!");
            }
            else
            {
                MessageBox.Show("Error updating customer data.");
            }

        }
    }
}
