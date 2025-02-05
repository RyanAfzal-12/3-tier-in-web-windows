namespace FormApp
{
    partial class Supplier
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
            this.supplieridtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.cellnotxt = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_viewall = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.supplierdatagridview = new System.Windows.Forms.DataGridView();
            this.btn_getdata = new System.Windows.Forms.Button();
            this.btn_updatenow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cell_No";
            // 
            // supplieridtxt
            // 
            this.supplieridtxt.Location = new System.Drawing.Point(322, 107);
            this.supplieridtxt.Name = "supplieridtxt";
            this.supplieridtxt.Size = new System.Drawing.Size(269, 26);
            this.supplieridtxt.TabIndex = 5;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(322, 166);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(269, 26);
            this.nametxt.TabIndex = 6;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(322, 215);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(269, 26);
            this.addresstxt.TabIndex = 7;
            // 
            // cellnotxt
            // 
            this.cellnotxt.Location = new System.Drawing.Point(322, 262);
            this.cellnotxt.Name = "cellnotxt";
            this.cellnotxt.Size = new System.Drawing.Size(269, 26);
            this.cellnotxt.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.Location = new System.Drawing.Point(43, 351);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 43);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Teal;
            this.btn_search.Location = new System.Drawing.Point(174, 351);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 43);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Teal;
            this.btn_update.Location = new System.Drawing.Point(296, 351);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 43);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_delete.Location = new System.Drawing.Point(422, 351);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 43);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_viewall
            // 
            this.btn_viewall.BackColor = System.Drawing.Color.Teal;
            this.btn_viewall.Location = new System.Drawing.Point(567, 351);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(75, 43);
            this.btn_viewall.TabIndex = 13;
            this.btn_viewall.Text = "ViewAll";
            this.btn_viewall.UseVisualStyleBackColor = false;
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Teal;
            this.btn_clear.Location = new System.Drawing.Point(698, 351);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 43);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // supplierdatagridview
            // 
            this.supplierdatagridview.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.supplierdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierdatagridview.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierdatagridview.Location = new System.Drawing.Point(2, 1);
            this.supplierdatagridview.Name = "supplierdatagridview";
            this.supplierdatagridview.RowHeadersWidth = 62;
            this.supplierdatagridview.RowTemplate.Height = 28;
            this.supplierdatagridview.Size = new System.Drawing.Size(797, 191);
            this.supplierdatagridview.TabIndex = 15;
            // 
            // btn_getdata
            // 
            this.btn_getdata.BackColor = System.Drawing.Color.Teal;
            this.btn_getdata.Location = new System.Drawing.Point(628, 265);
            this.btn_getdata.Name = "btn_getdata";
            this.btn_getdata.Size = new System.Drawing.Size(128, 43);
            this.btn_getdata.TabIndex = 16;
            this.btn_getdata.Text = "Get Data";
            this.btn_getdata.UseVisualStyleBackColor = false;
            this.btn_getdata.Click += new System.EventHandler(this.btn_getdata_Click);
            // 
            // btn_updatenow
            // 
            this.btn_updatenow.BackColor = System.Drawing.Color.Teal;
            this.btn_updatenow.Location = new System.Drawing.Point(628, 207);
            this.btn_updatenow.Name = "btn_updatenow";
            this.btn_updatenow.Size = new System.Drawing.Size(128, 43);
            this.btn_updatenow.TabIndex = 17;
            this.btn_updatenow.Text = "Update";
            this.btn_updatenow.UseVisualStyleBackColor = false;
            this.btn_updatenow.Click += new System.EventHandler(this.btn_updatenow_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_updatenow);
            this.Controls.Add(this.btn_getdata);
            this.Controls.Add(this.supplierdatagridview);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cellnotxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.supplieridtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Supplier";
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.supplierdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox supplieridtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox cellnotxt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_viewall;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView supplierdatagridview;
        private System.Windows.Forms.Button btn_getdata;
        private System.Windows.Forms.Button btn_updatenow;
    }
}