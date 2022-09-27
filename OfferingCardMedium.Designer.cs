namespace ProjectBlue
{
    partial class OfferingCardMedium
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
            this.lblRestaurantName = new MaterialSkin.Controls.MaterialLabel();
            this.lblOfferingPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblOfferingName = new MaterialSkin.Controls.MaterialLabel();
            this.pbOfferingImage = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOfferingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblRestaurantName);
            this.materialCard1.Controls.Add(this.lblOfferingPrice);
            this.materialCard1.Controls.Add(this.lblOfferingName);
            this.materialCard1.Controls.Add(this.pbOfferingImage);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 2);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MaximumSize = new System.Drawing.Size(375, 150);
            this.materialCard1.MinimumSize = new System.Drawing.Size(375, 150);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(375, 150);
            this.materialCard1.TabIndex = 0;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Depth = 0;
            this.lblRestaurantName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRestaurantName.Location = new System.Drawing.Point(170, 97);
            this.lblRestaurantName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(124, 19);
            this.lblRestaurantName.TabIndex = 3;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // lblOfferingPrice
            // 
            this.lblOfferingPrice.AutoSize = true;
            this.lblOfferingPrice.Depth = 0;
            this.lblOfferingPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOfferingPrice.Location = new System.Drawing.Point(170, 58);
            this.lblOfferingPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOfferingPrice.Name = "lblOfferingPrice";
            this.lblOfferingPrice.Size = new System.Drawing.Size(98, 19);
            this.lblOfferingPrice.TabIndex = 2;
            this.lblOfferingPrice.Text = "Offering Price";
            // 
            // lblOfferingName
            // 
            this.lblOfferingName.AutoSize = true;
            this.lblOfferingName.Depth = 0;
            this.lblOfferingName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblOfferingName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblOfferingName.Location = new System.Drawing.Point(170, 14);
            this.lblOfferingName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOfferingName.Name = "lblOfferingName";
            this.lblOfferingName.Size = new System.Drawing.Size(132, 24);
            this.lblOfferingName.TabIndex = 1;
            this.lblOfferingName.Text = "Offering Name";
            // 
            // pbOfferingImage
            // 
            this.pbOfferingImage.BackColor = System.Drawing.Color.Silver;
            this.pbOfferingImage.Location = new System.Drawing.Point(5, 5);
            this.pbOfferingImage.Name = "pbOfferingImage";
            this.pbOfferingImage.Size = new System.Drawing.Size(140, 140);
            this.pbOfferingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOfferingImage.TabIndex = 0;
            this.pbOfferingImage.TabStop = false;
            // 
            // OfferingCardMedium
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.MaximumSize = new System.Drawing.Size(380, 155);
            this.MinimumSize = new System.Drawing.Size(380, 155);
            this.Name = "OfferingCardMedium";
            this.Size = new System.Drawing.Size(380, 155);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOfferingImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pbOfferingImage;
        private MaterialSkin.Controls.MaterialLabel lblRestaurantName;
        private MaterialSkin.Controls.MaterialLabel lblOfferingPrice;
        private MaterialSkin.Controls.MaterialLabel lblOfferingName;
    }
}
