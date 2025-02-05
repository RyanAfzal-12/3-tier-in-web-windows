namespace FormApp
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productidtextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.stocktextbox = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_viewall = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.productdatagridview = new System.Windows.Forms.DataGridView();
            this.btn_updatenow = new System.Windows.Forms.Button();
            this.btn_getdata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            // 
            // productidtextbox
            // 
            this.productidtextbox.Location = new System.Drawing.Point(306, 112);
            this.productidtextbox.Name = "productidtextbox";
            this.productidtextbox.Size = new System.Drawing.Size(198, 26);
            this.productidtextbox.TabIndex = 5;
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(306, 165);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(198, 26);
            this.nametextbox.TabIndex = 6;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(306, 210);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(198, 26);
            this.pricetextbox.TabIndex = 7;
            // 
            // stocktextbox
            // 
            this.stocktextbox.Location = new System.Drawing.Point(306, 254);
            this.stocktextbox.Name = "stocktextbox";
            this.stocktextbox.Size = new System.Drawing.Size(198, 26);
            this.stocktextbox.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_save.Location = new System.Drawing.Point(35, 354);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 40);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_search.Location = new System.Drawing.Point(157, 354);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 40);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_update.Location = new System.Drawing.Point(280, 354);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 40);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.Location = new System.Drawing.Point(418, 354);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 40);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_viewall
            // 
            this.btn_viewall.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_viewall.Location = new System.Drawing.Point(547, 354);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(75, 40);
            this.btn_viewall.TabIndex = 13;
            this.btn_viewall.Text = "ViewAll";
            this.btn_viewall.UseVisualStyleBackColor = false;
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_clear.Location = new System.Drawing.Point(679, 354);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 40);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // productdatagridview
            // 
            this.productdatagridview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.productdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdatagridview.Location = new System.Drawing.Point(-18, 3);
            this.productdatagridview.Name = "productdatagridview";
            this.productdatagridview.RowHeadersWidth = 62;
            this.productdatagridview.RowTemplate.Height = 28;
            this.productdatagridview.Size = new System.Drawing.Size(825, 182);
            this.productdatagridview.TabIndex = 15;
            // 
            // btn_updatenow
            // 
            this.btn_updatenow.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_updatenow.Location = new System.Drawing.Point(594, 200);
            this.btn_updatenow.Name = "btn_updatenow";
            this.btn_updatenow.Size = new System.Drawing.Size(105, 40);
            this.btn_updatenow.TabIndex = 16;
            this.btn_updatenow.Text = "Update";
            this.btn_updatenow.UseVisualStyleBackColor = false;
            this.btn_updatenow.Click += new System.EventHandler(this.btn_updatenow_Click);
            // 
            // btn_getdata
            // 
            this.btn_getdata.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_getdata.Location = new System.Drawing.Point(594, 254);
            this.btn_getdata.Name = "btn_getdata";
            this.btn_getdata.Size = new System.Drawing.Size(105, 40);
            this.btn_getdata.TabIndex = 17;
            this.btn_getdata.Text = "Get Data";
            this.btn_getdata.UseVisualStyleBackColor = false;
            this.btn_getdata.Click += new System.EventHandler(this.btn_getdata_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_getdata);
            this.Controls.Add(this.btn_updatenow);
            this.Controls.Add(this.productdatagridview);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.stocktextbox);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.productidtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.productdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productidtextbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.TextBox stocktextbox;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_viewall;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView productdatagridview;
        private System.Windows.Forms.Button btn_updatenow;
        private System.Windows.Forms.Button btn_getdata;
    }
}