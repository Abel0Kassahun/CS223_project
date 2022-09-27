namespace ProjectBlue
{
    partial class OfferingCardLarge
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
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.lblRestaurantName = new MaterialSkin.Controls.MaterialLabel();
            this.lblOfferingName = new MaterialSkin.Controls.MaterialLabel();
            this.pbOfferingImage = new System.Windows.Forms.PictureBox();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOfferingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.lblTime);
            this.materialCard5.Controls.Add(this.lblRestaurantName);
            this.materialCard5.Controls.Add(this.lblOfferingName);
            this.materialCard5.Controls.Add(this.pbOfferingImage);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(3, 2);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(215, 320);
            this.materialCard5.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Depth = 0;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTime.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblTime.Location = new System.Drawing.Point(17, 287);
            this.lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 19);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Depth = 0;
            this.lblRestaurantName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRestaurantName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblRestaurantName.Location = new System.Drawing.Point(17, 258);
            this.lblRestaurantName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(124, 19);
            this.lblRestaurantName.TabIndex = 2;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // lblOfferingName
            // 
            this.lblOfferingName.AutoSize = true;
            this.lblOfferingName.Depth = 0;
            this.lblOfferingName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblOfferingName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblOfferingName.Location = new System.Drawing.Point(17, 222);
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
            this.pbOfferingImage.Size = new System.Drawing.Size(205, 205);
            this.pbOfferingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOfferingImage.TabIndex = 0;
            this.pbOfferingImage.TabStop = false;
            // 
            // OfferingCardLarge
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard5);
            this.MaximumSize = new System.Drawing.Size(220, 325);
            this.MinimumSize = new System.Drawing.Size(220, 325);
            this.Name = "OfferingCardLarge";
            this.Size = new System.Drawing.Size(220, 325);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOfferingImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private MaterialSkin.Controls.MaterialLabel lblRestaurantName;
        private MaterialSkin.Controls.MaterialLabel lblOfferingName;
        private System.Windows.Forms.PictureBox pbOfferingImage;
    }
}
