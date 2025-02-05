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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            productdatagridview.Visible = false;
            btn_getdata.Visible = false;
            btn_updatenow.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Product_Id = productidtextbox.Text;
            string Name = nametextbox.Text;
            string Price = pricetextbox.Text;
            string Stock = stocktextbox.Text;

            prod prod = new prod
            {
                Product_Id1 = Product_Id,
                Name1 = Name,
                Price1 = Price,
                Stock1 = Stock
            };

            ProdBLL p = new ProdBLL();
            bool isInserted = p.ProductInsertBLL(prod);

            if (isInserted)
            {
                MessageBox.Show("Product data saved successfully!");
            }
            else
            {
                MessageBox.Show("Error saving product data.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string Product_Id = productidtextbox.Text;
            btn_getdata.Visible = true;
            nametextbox.Enabled = false;
            pricetextbox.Enabled = false;
            stocktextbox.Enabled = false;
           

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Product_Id = productidtextbox.Text;
            prod prod = new prod
            {
                Product_Id1 = Product_Id,

            };

            ProdBLL p = new ProdBLL();
            bool isDeleted = p.ProductDeleteBLL(Product_Id);

            if (isDeleted)
            {
                MessageBox.Show("Product data deleted successfully!");
            }
            else
            {
                MessageBox.Show("Error deleting product data.");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Product_Id = productidtextbox.Text;

            ProdBLL p = new ProdBLL();

            DataTable dt = p.ProductSearchBLL(Product_Id);
            if (dt != null && dt.Rows.Count > 0)
            {
                nametextbox.Text = dt.Rows[0]["Name"].ToString();
                pricetextbox.Text = dt.Rows[0]["Price"].ToString();
                stocktextbox.Text = dt.Rows[0]["Stock"].ToString();

            }
            else
            {
                MessageBox.Show("Error searching data or no data found!");
            }
           

        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string Product_Id = productidtextbox.Text;
            string Name = nametextbox.Text;
            string Price = pricetextbox.Text;
            string Stock = stocktextbox.Text;
            ProdBLL p = new ProdBLL();
            DataTable dt = p.ProductViewAllBLL(Product_Id, Name, Price, Stock);
            if (dt != null && dt.Rows.Count > 0)
            {
                productdatagridview.Visible = true;
                productdatagridview.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Error searching data or no data found!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            productidtextbox.Clear();
            nametextbox.Clear();
            pricetextbox.Clear();
            stocktextbox.Clear();

        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            string Product_Id = productidtextbox.Text;

            custBLL custBLL = new custBLL();

            DataTable dt = custBLL.CustSearchBLL(Product_Id);
            nametextbox.Text = dt.Rows[0]["Name"].ToString();
            pricetextbox.Text = dt.Rows[0]["Price"].ToString();
            stocktextbox.Text = dt.Rows[0]["Stock"].ToString();
            btn_updatenow.Visible = true;
            nametextbox.Enabled = true;
            pricetextbox.Enabled = true;
            stocktextbox.Enabled = true;

        }

        private void btn_updatenow_Click(object sender, EventArgs e)
        {
            string Product_Id = productidtextbox.Text;
            string Name = nametextbox.Text;
            string Price = pricetextbox.Text;
            string Stock = stocktextbox.Text;

            prod prod = new prod
            {
                Product_Id1 = Product_Id,
                Name1 = Name,
                Price1 = Price,
                Stock1 = Stock
            };

            ProdBLL p = new ProdBLL();
            bool isUpdated = p.ProductUpdateBLL(Product_Id, Name, Price, Stock);
            if (isUpdated)
            {
                MessageBox.Show("Product data updated successfully!");
            }
            else
            {
                MessageBox.Show("Error updating product data.");
            }
        }
    }

    }

