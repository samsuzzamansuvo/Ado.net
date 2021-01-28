namespace InventoryManagement
{
    partial class Wellcome
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
            this.lblinvenManage = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinvenManage
            // 
            this.lblinvenManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblinvenManage.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvenManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblinvenManage.Location = new System.Drawing.Point(185, 44);
            this.lblinvenManage.Name = "lblinvenManage";
            this.lblinvenManage.Size = new System.Drawing.Size(745, 86);
            this.lblinvenManage.TabIndex = 1;
            this.lblinvenManage.Text = "Inventory Management";
            // 
            // lblNext
            // 
            this.lblNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNext.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.LinkColor = System.Drawing.Color.OldLace;
            this.lblNext.Location = new System.Drawing.Point(512, 359);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(45, 20);
            this.lblNext.TabIndex = 2;
            this.lblNext.TabStop = true;
            this.lblNext.Text = "Next";
            this.lblNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNext_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::InventoryManagement.Properties.Resources.windows;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1085, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Wellcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 530);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblinvenManage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Wellcome";
            this.Text = "Wellcome";
            this.Load += new System.EventHandler(this.Wellcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblinvenManage;
        private System.Windows.Forms.LinkLabel lblNext;
    }
}