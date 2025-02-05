namespace FormApp
{
    partial class Form1
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
            this.empid_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.cell_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.employeDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_viewall = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_getdata = new System.Windows.Forms.Button();
            this.btn_updatenow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(365, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(193, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(193, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(193, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cell_No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(193, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // empid_textbox
            // 
            this.empid_textbox.Location = new System.Drawing.Point(335, 111);
            this.empid_textbox.Name = "empid_textbox";
            this.empid_textbox.Size = new System.Drawing.Size(241, 26);
            this.empid_textbox.TabIndex = 5;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(335, 168);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(241, 26);
            this.name_textbox.TabIndex = 6;
            // 
            // cell_textbox
            // 
            this.cell_textbox.Location = new System.Drawing.Point(335, 228);
            this.cell_textbox.Name = "cell_textbox";
            this.cell_textbox.Size = new System.Drawing.Size(241, 26);
            this.cell_textbox.TabIndex = 7;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(335, 279);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(241, 26);
            this.address_textbox.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_save.Location = new System.Drawing.Point(29, 361);
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
            this.btn_search.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_search.Location = new System.Drawing.Point(169, 361);
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
            this.btn_update.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_update.Location = new System.Drawing.Point(316, 361);
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
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_delete.Location = new System.Drawing.Point(450, 361);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 43);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // employeDataGridView
            // 
            this.employeDataGridView.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.employeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeDataGridView.Location = new System.Drawing.Point(2, 1);
            this.employeDataGridView.Name = "employeDataGridView";
            this.employeDataGridView.RowHeadersWidth = 62;
            this.employeDataGridView.RowTemplate.Height = 28;
            this.employeDataGridView.Size = new System.Drawing.Size(797, 175);
            this.employeDataGridView.TabIndex = 13;
            // 
            // btn_viewall
            // 
            this.btn_viewall.BackColor = System.Drawing.Color.Teal;
            this.btn_viewall.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_viewall.Location = new System.Drawing.Point(571, 361);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(75, 43);
            this.btn_viewall.TabIndex = 14;
            this.btn_viewall.Text = "ViewAll";
            this.btn_viewall.UseVisualStyleBackColor = false;
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Teal;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_clear.Location = new System.Drawing.Point(696, 361);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 43);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_getdata
            // 
            this.btn_getdata.BackColor = System.Drawing.Color.Teal;
            this.btn_getdata.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_getdata.Location = new System.Drawing.Point(639, 271);
            this.btn_getdata.Name = "btn_getdata";
            this.btn_getdata.Size = new System.Drawing.Size(110, 43);
            this.btn_getdata.TabIndex = 16;
            this.btn_getdata.Text = "Get Data";
            this.btn_getdata.UseVisualStyleBackColor = false;
            this.btn_getdata.Click += new System.EventHandler(this.btn_getdata_Click);
            // 
            // btn_updatenow
            // 
            this.btn_updatenow.BackColor = System.Drawing.Color.Teal;
            this.btn_updatenow.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_updatenow.Location = new System.Drawing.Point(639, 205);
            this.btn_updatenow.Name = "btn_updatenow";
            this.btn_updatenow.Size = new System.Drawing.Size(110, 43);
            this.btn_updatenow.TabIndex = 17;
            this.btn_updatenow.Text = "Update";
            this.btn_updatenow.UseVisualStyleBackColor = false;
            this.btn_updatenow.Click += new System.EventHandler(this.btn_updatenow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_updatenow);
            this.Controls.Add(this.btn_getdata);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.employeDataGridView);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.cell_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.empid_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empid_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox cell_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView employeDataGridView;
        private System.Windows.Forms.Button btn_viewall;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_getdata;
        private System.Windows.Forms.Button btn_updatenow;
    }
}

