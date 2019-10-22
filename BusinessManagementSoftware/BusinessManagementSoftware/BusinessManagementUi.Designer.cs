namespace BusinessManagementSoftware
{
    partial class BusinessManagementUi
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
            this.productLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockPictureBox = new System.Windows.Forms.PictureBox();
            this.supplierPictureBox = new System.Windows.Forms.PictureBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(124, 186);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(64, 18);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Product";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.Location = new System.Drawing.Point(224, 186);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(68, 18);
            this.supplierLabel.TabIndex = 1;
            this.supplierLabel.Text = "Supplier";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(315, 186);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(105, 18);
            this.stockLabel.TabIndex = 1;
            this.stockLabel.Text = "Stock Module";
            // 
            // stockPictureBox
            // 
            this.stockPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stockPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockPictureBox.Image = global::BusinessManagementSoftware.Properties.Resources.out_of_stock_icon_22;
            this.stockPictureBox.Location = new System.Drawing.Point(337, 122);
            this.stockPictureBox.Name = "stockPictureBox";
            this.stockPictureBox.Size = new System.Drawing.Size(60, 61);
            this.stockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stockPictureBox.TabIndex = 0;
            this.stockPictureBox.TabStop = false;
            this.stockPictureBox.Click += new System.EventHandler(this.stockPictureBox_Click);
            // 
            // supplierPictureBox
            // 
            this.supplierPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplierPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplierPictureBox.Image = global::BusinessManagementSoftware.Properties.Resources.supplier_icon_png_22;
            this.supplierPictureBox.Location = new System.Drawing.Point(228, 122);
            this.supplierPictureBox.Name = "supplierPictureBox";
            this.supplierPictureBox.Size = new System.Drawing.Size(60, 61);
            this.supplierPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.supplierPictureBox.TabIndex = 0;
            this.supplierPictureBox.TabStop = false;
            // 
            // productPictureBox
            // 
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productPictureBox.Image = global::BusinessManagementSoftware.Properties.Resources.add_to_basket_512;
            this.productPictureBox.Location = new System.Drawing.Point(126, 122);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(60, 61);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            this.productPictureBox.Click += new System.EventHandler(this.productPictureBox_Click);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginPictureBox.Image = global::BusinessManagementSoftware.Properties.Resources.user_login_icon_29;
            this.loginPictureBox.Location = new System.Drawing.Point(244, 12);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(60, 61);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPictureBox.TabIndex = 0;
            this.loginPictureBox.TabStop = false;
            this.loginPictureBox.Tag = "";
            this.loginPictureBox.Click += new System.EventHandler(this.loginPictureBox_Click);
            // 
            // BusinessManagementUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 379);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockPictureBox);
            this.Controls.Add(this.supplierPictureBox);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.loginPictureBox);
            this.Name = "BusinessManagementUi";
            this.Text = "Business Management Software";
            ((System.ComponentModel.ISupportInitialize)(this.stockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.PictureBox supplierPictureBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.PictureBox stockPictureBox;
        private System.Windows.Forms.Label stockLabel;
    }
}

