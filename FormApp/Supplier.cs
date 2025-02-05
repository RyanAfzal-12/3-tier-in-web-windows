using AppProps;
using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            supplierdatagridview.Visible = false;
            btn_getdata.Visible = false;
            btn_updatenow.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Supplier_Id = supplieridtxt.Text;
            string Name = nametxt.Text;
            string Cell_No = cellnotxt.Text;
            string Address = addresstxt.Text;

            supp supplier = new supp
            {
                Supplier_Id1 = Supplier_Id,
                Name1 = Name,
                Cell_No1 = Cell_No,
                Address1 = Address
            };

            supBLL supBLL = new supBLL();
            bool isInserted = supBLL.SuppInsertBLL(supplier);

            if (isInserted)
            {
                MessageBox.Show("Supplier data saved successfully!");
            }
            else
            {
                MessageBox.Show("Error saving supplier data.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string Supplier_Id = supplieridtxt.Text;
            btn_getdata.Visible = true;
            nametxt.Enabled = false;
            cellnotxt.Enabled = false;
            addresstxt.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Supplier_Id = supplieridtxt.Text;

            supBLL supBLL = new supBLL();
            bool isDeleted = supBLL.SuppDeleteBLL(Supplier_Id);

            if (isDeleted)
            {
                MessageBox.Show("Supplier data deleted successfully!");
            }
            else
            {
                MessageBox.Show("Error deleting supplier data.");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Supplier_Id = supplieridtxt.Text;

            supBLL supBLL = new supBLL();
            DataTable dt = supBLL.SuppSearchBLL(Supplier_Id);
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
            string Supplier_Id = supplieridtxt.Text;
            string Name = nametxt.Text;
            string Cell_No = cellnotxt.Text;
            string Address = addresstxt.Text;

            supBLL supBLL = new supBLL();
            DataTable dt = supBLL.SuppViewAllBLL(Supplier_Id, Name, Cell_No, Address);

            if (dt != null && dt.Rows.Count > 0)
            {
                supplierdatagridview.Visible = true;
                supplierdatagridview.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error retrieving data!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            supplieridtxt.Clear();
            nametxt.Clear();
            cellnotxt.Clear();
            addresstxt.Clear();
        }

        private void btn_updatenow_Click(object sender, EventArgs e)
        {
            string Supplier_Id = supplieridtxt.Text;
            string Name = nametxt.Text;
            string Cell_No = cellnotxt.Text;
            string Address = addresstxt.Text;

            supBLL supBLL = new supBLL();
            bool isUpdated = supBLL.SuppUpdateBLL(Supplier_Id, Name, Cell_No, Address);

            if (isUpdated)
            {
                MessageBox.Show("Supplier data updated successfully!");
            }
            else
            {
                MessageBox.Show("Error updating supplier data.");
            }

        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            string Supplier_Id = supplieridtxt.Text;

            custBLL custBLL = new custBLL();

            DataTable dt = custBLL.CustSearchBLL(Supplier_Id);
            nametxt.Text = dt.Rows[0]["Name"].ToString();
            cellnotxt.Text = dt.Rows[0]["Cell_No"].ToString();
            addresstxt.Text = dt.Rows[0]["Address"].ToString();
            btn_updatenow.Visible = true;
            nametxt.Enabled = true;
            cellnotxt.Enabled = true;
            addresstxt.Enabled = true;
        }
    }
}
