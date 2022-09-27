namespace ProjectBlue
{
    partial class RestaurantCardImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.pbRestaurantImage = new System.Windows.Forms.PictureBox();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblRestaurantName = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurantImage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblPhoneNumber);
            this.materialCard1.Controls.Add(this.pbRestaurantImage);
            this.materialCard1.Controls.Add(this.lblAddress);
            this.materialCard1.Controls.Add(this.lblRestaurantName);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(2, 2);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(412, 170);
            this.materialCard1.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Depth = 0;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhoneNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblPhoneNumber.Location = new System.Drawing.Point(193, 116);
            this.lblPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(74, 19);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone No.";
            // 
            // pbRestaurantImage
            // 
            this.pbRestaurantImage.BackColor = System.Drawing.Color.Silver;
            this.pbRestaurantImage.Location = new System.Drawing.Point(5, 5);
            this.pbRestaurantImage.Name = "pbRestaurantImage";
            this.pbRestaurantImage.Size = new System.Drawing.Size(160, 160);
            this.pbRestaurantImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestaurantImage.TabIndex = 0;
            this.pbRestaurantImage.TabStop = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddress.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblAddress.Location = new System.Drawing.Point(193, 72);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 19);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Depth = 0;
            this.lblRestaurantName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRestaurantName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblRestaurantName.Location = new System.Drawing.Point(193, 23);
            this.lblRestaurantName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(157, 24);
            this.lblRestaurantName.TabIndex = 7;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // RestaurantCardImage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.materialCard1);
            this.MaximumSize = new System.Drawing.Size(417, 175);
            this.MinimumSize = new System.Drawing.Size(417, 175);
            this.Name = "RestaurantCardImage";
            this.Size = new System.Drawing.Size(417, 175);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurantImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblPhoneNumber;
        private System.Windows.Forms.PictureBox pbRestaurantImage;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblRestaurantName;
    }
}
