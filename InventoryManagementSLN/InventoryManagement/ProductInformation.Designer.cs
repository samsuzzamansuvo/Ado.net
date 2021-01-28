namespace InventoryManagement
{
    partial class ProductInformation
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
            this.dgvProductinformation = new System.Windows.Forms.DataGridView();
            this.pnlTotalInfo = new System.Windows.Forms.Panel();
            this.lblreport = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgbox = new System.Windows.Forms.PictureBox();
            this.linkupload = new System.Windows.Forms.LinkLabel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dtpmfgdate = new System.Windows.Forms.DateTimePicker();
            this.dtpexpdate = new System.Windows.Forms.DateTimePicker();
            this.txtstockid = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lblproductname = new System.Windows.Forms.Label();
            this.lblProdutid = new System.Windows.Forms.Label();
            this.lblsupplier = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblstockid = new System.Windows.Forms.Label();
            this.lblexpdate = new System.Windows.Forms.Label();
            this.lblmfgdate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combosupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductinformation)).BeginInit();
            this.pnlTotalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductinformation
            // 
            this.dgvProductinformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductinformation.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvProductinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductinformation.Location = new System.Drawing.Point(12, 245);
            this.dgvProductinformation.Name = "dgvProductinformation";
            this.dgvProductinformation.Size = new System.Drawing.Size(981, 311);
            this.dgvProductinformation.TabIndex = 2;
            this.dgvProductinformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductinformation_CellClick);
            // 
            // pnlTotalInfo
            // 
            this.pnlTotalInfo.BackColor = System.Drawing.Color.LightGreen;
            this.pnlTotalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalInfo.Controls.Add(this.combosupplier);
            this.pnlTotalInfo.Controls.Add(this.lblreport);
            this.pnlTotalInfo.Controls.Add(this.btnback);
            this.pnlTotalInfo.Controls.Add(this.pictureBox2);
            this.pnlTotalInfo.Controls.Add(this.imgbox);
            this.pnlTotalInfo.Controls.Add(this.linkupload);
            this.pnlTotalInfo.Controls.Add(this.btndelete);
            this.pnlTotalInfo.Controls.Add(this.btnupdate);
            this.pnlTotalInfo.Controls.Add(this.btninsert);
            this.pnlTotalInfo.Controls.Add(this.dtpmfgdate);
            this.pnlTotalInfo.Controls.Add(this.dtpexpdate);
            this.pnlTotalInfo.Controls.Add(this.txtstockid);
            this.pnlTotalInfo.Controls.Add(this.txtprice);
            this.pnlTotalInfo.Controls.Add(this.txtproductname);
            this.pnlTotalInfo.Controls.Add(this.txtproductid);
            this.pnlTotalInfo.Controls.Add(this.lblproductname);
            this.pnlTotalInfo.Controls.Add(this.lblProdutid);
            this.pnlTotalInfo.Controls.Add(this.lblsupplier);
            this.pnlTotalInfo.Controls.Add(this.lblprice);
            this.pnlTotalInfo.Controls.Add(this.lblstockid);
            this.pnlTotalInfo.Controls.Add(this.lblexpdate);
            this.pnlTotalInfo.Controls.Add(this.lblmfgdate);
            this.pnlTotalInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlTotalInfo.Name = "pnlTotalInfo";
            this.pnlTotalInfo.Size = new System.Drawing.Size(981, 227);
            this.pnlTotalInfo.TabIndex = 3;
            // 
            // lblreport
            // 
            this.lblreport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreport.Location = new System.Drawing.Point(720, 157);
            this.lblreport.Name = "lblreport";
            this.lblreport.Size = new System.Drawing.Size(75, 28);
            this.lblreport.TabIndex = 11;
            this.lblreport.Text = "Report";
            this.lblreport.UseVisualStyleBackColor = true;
            this.lblreport.Click += new System.EventHandler(this.lblreport_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(892, 14);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 29);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryManagement.Properties.Resources.inventory;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // imgbox
            // 
            this.imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbox.Location = new System.Drawing.Point(502, 12);
            this.imgbox.Name = "imgbox";
            this.imgbox.Size = new System.Drawing.Size(184, 182);
            this.imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbox.TabIndex = 7;
            this.imgbox.TabStop = false;
            // 
            // linkupload
            // 
            this.linkupload.AutoSize = true;
            this.linkupload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkupload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkupload.Location = new System.Drawing.Point(622, 197);
            this.linkupload.Name = "linkupload";
            this.linkupload.Size = new System.Drawing.Size(64, 21);
            this.linkupload.TabIndex = 6;
            this.linkupload.TabStop = true;
            this.linkupload.Text = "Upload ";
            this.linkupload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkupload_LinkClicked);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(720, 114);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 28);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delate";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(720, 72);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 30);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(720, 30);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 32);
            this.btninsert.TabIndex = 4;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dtpmfgdate
            // 
            this.dtpmfgdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmfgdate.Location = new System.Drawing.Point(309, 102);
            this.dtpmfgdate.Name = "dtpmfgdate";
            this.dtpmfgdate.Size = new System.Drawing.Size(161, 20);
            this.dtpmfgdate.TabIndex = 2;
            // 
            // dtpexpdate
            // 
            this.dtpexpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpexpdate.Location = new System.Drawing.Point(309, 133);
            this.dtpexpdate.Name = "dtpexpdate";
            this.dtpexpdate.Size = new System.Drawing.Size(161, 20);
            this.dtpexpdate.TabIndex = 2;
            // 
            // txtstockid
            // 
            this.txtstockid.Location = new System.Drawing.Point(309, 197);
            this.txtstockid.Name = "txtstockid";
            this.txtstockid.Size = new System.Drawing.Size(161, 20);
            this.txtstockid.TabIndex = 1;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(309, 70);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(161, 20);
            this.txtprice.TabIndex = 1;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(309, 38);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(161, 20);
            this.txtproductname.TabIndex = 1;
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(309, 12);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(161, 20);
            this.txtproductid.TabIndex = 1;
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(196, 40);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(90, 15);
            this.lblproductname.TabIndex = 0;
            this.lblproductname.Text = "Product Name:";
            // 
            // lblProdutid
            // 
            this.lblProdutid.AutoSize = true;
            this.lblProdutid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutid.Location = new System.Drawing.Point(214, 14);
            this.lblProdutid.Name = "lblProdutid";
            this.lblProdutid.Size = new System.Drawing.Size(67, 15);
            this.lblProdutid.TabIndex = 0;
            this.lblProdutid.Text = "Product Id:";
            // 
            // lblsupplier
            // 
            this.lblsupplier.AutoSize = true;
            this.lblsupplier.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplier.Location = new System.Drawing.Point(217, 170);
            this.lblsupplier.Name = "lblsupplier";
            this.lblsupplier.Size = new System.Drawing.Size(56, 15);
            this.lblsupplier.TabIndex = 0;
            this.lblsupplier.Text = "Supplier:";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(243, 72);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(38, 15);
            this.lblprice.TabIndex = 0;
            this.lblprice.Text = "Price:";
            // 
            // lblstockid
            // 
            this.lblstockid.AutoSize = true;
            this.lblstockid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockid.Location = new System.Drawing.Point(214, 202);
            this.lblstockid.Name = "lblstockid";
            this.lblstockid.Size = new System.Drawing.Size(53, 15);
            this.lblstockid.TabIndex = 0;
            this.lblstockid.Text = "Stock Id:";
            // 
            // lblexpdate
            // 
            this.lblexpdate.AutoSize = true;
            this.lblexpdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpdate.Location = new System.Drawing.Point(221, 133);
            this.lblexpdate.Name = "lblexpdate";
            this.lblexpdate.Size = new System.Drawing.Size(60, 15);
            this.lblexpdate.TabIndex = 0;
            this.lblexpdate.Text = "EXP Date:";
            // 
            // lblmfgdate
            // 
            this.lblmfgdate.AutoSize = true;
            this.lblmfgdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmfgdate.Location = new System.Drawing.Point(214, 102);
            this.lblmfgdate.Name = "lblmfgdate";
            this.lblmfgdate.Size = new System.Drawing.Size(65, 15);
            this.lblmfgdate.TabIndex = 0;
            this.lblmfgdate.Text = "MFG Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::InventoryManagement.Properties.Resources.product;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1005, 568);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // combosupplier
            // 
            this.combosupplier.FormattingEnabled = true;
            this.combosupplier.Location = new System.Drawing.Point(309, 163);
            this.combosupplier.Name = "combosupplier";
            this.combosupplier.Size = new System.Drawing.Size(161, 21);
            this.combosupplier.TabIndex = 12;
            // 
            // ProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1005, 568);
            this.Controls.Add(this.pnlTotalInfo);
            this.Controls.Add(this.dgvProductinformation);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductInformation";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductinformation)).EndInit();
            this.pnlTotalInfo.ResumeLayout(false);
            this.pnlTotalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProductinformation;
        private System.Windows.Forms.Panel pnlTotalInfo;
        private System.Windows.Forms.Label lblProdutid;
        private System.Windows.Forms.Label lblsupplier;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblstockid;
        private System.Windows.Forms.Label lblexpdate;
        private System.Windows.Forms.Label lblmfgdate;
        private System.Windows.Forms.DateTimePicker dtpmfgdate;
        private System.Windows.Forms.DateTimePicker dtpexpdate;
        private System.Windows.Forms.TextBox txtstockid;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.LinkLabel linkupload;
        private System.Windows.Forms.PictureBox imgbox;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button lblreport;
        private System.Windows.Forms.ComboBox combosupplier;
    }
}