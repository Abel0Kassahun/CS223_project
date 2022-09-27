namespace ProjectBlue
{
    partial class OfferingCardSmall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfferingCardSmall));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblOfferingPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblOfferingName = new MaterialSkin.Controls.MaterialLabel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbOfferingImage = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOfferingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblOfferingPrice);
            this.materialCard1.Controls.Add(this.lblOfferingName);
            this.materialCard1.Controls.Add(this.pbIcon);
            this.materialCard1.Controls.Add(this.pbOfferingImage);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 2);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(505, 86);
            this.materialCard1.TabIndex = 0;
            // 
            // lblOfferingPrice
            // 
            this.lblOfferingPrice.AutoSize = true;
            this.lblOfferingPrice.Depth = 0;
            this.lblOfferingPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOfferingPrice.Location = new System.Drawing.Point(100, 52);
            this.lblOfferingPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOfferingPrice.Name = "lblOfferingPrice";
            this.lblOfferingPrice.Size = new System.Drawing.Size(107, 19);
            this.lblOfferingPrice.TabIndex = 3;
            this.lblOfferingPrice.Text = "materialLabel2";
            // 
            // lblOfferingName
            // 
            this.lblOfferingName.AutoSize = true;
            this.lblOfferingName.Depth = 0;
            this.lblOfferingName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblOfferingName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblOfferingName.Location = new System.Drawing.Point(100, 14);
            this.lblOfferingName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOfferingName.Name = "lblOfferingName";
            this.lblOfferingName.Size = new System.Drawing.Size(135, 24);
            this.lblOfferingName.TabIndex = 2;
            this.lblOfferingName.Text = "materialLabel1";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(457, 25);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(36, 36);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // pbOfferingImage
            // 
            this.pbOfferingImage.BackColor = System.Drawing.Color.Silver;
            this.pbOfferingImage.Location = new System.Drawing.Point(3, 3);
            this.pbOfferingImage.Name = "pbOfferingImage";
            this.pbOfferingImage.Size = new System.Drawing.Size(80, 80);
            this.pbOfferingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOfferingImage.TabIndex = 0;
            this.pbOfferingImage.TabStop = false;
            // 
            // OfferingCardSmall
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.MaximumSize = new System.Drawing.Size(510, 90);
            this.MinimumSize = new System.Drawing.Size(510, 90);
            this.Name = "OfferingCardSmall";
            this.Size = new System.Drawing.Size(510, 90);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOfferingImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pbOfferingImage;
        private System.Windows.Forms.PictureBox pbIcon;
        private MaterialSkin.Controls.MaterialLabel lblOfferingPrice;
        private MaterialSkin.Controls.MaterialLabel lblOfferingName;
    }
}
