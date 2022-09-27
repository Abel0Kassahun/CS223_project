namespace ProjectBlue
{
    partial class SignupForm
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
            this.llblGoToLoginForm = new System.Windows.Forms.LinkLabel();
            this.txtFullName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEmailAddress = new MaterialSkin.Controls.MaterialTextBox2();
            this.mtxtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cbCustomer = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignUp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // llblGoToLoginForm
            // 
            this.llblGoToLoginForm.ActiveLinkColor = System.Drawing.Color.BlueViolet;
            this.llblGoToLoginForm.AutoSize = true;
            this.llblGoToLoginForm.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGoToLoginForm.Location = new System.Drawing.Point(377, 556);
            this.llblGoToLoginForm.Name = "llblGoToLoginForm";
            this.llblGoToLoginForm.Size = new System.Drawing.Size(49, 18);
            this.llblGoToLoginForm.TabIndex = 14;
            this.llblGoToLoginForm.TabStop = true;
            this.llblGoToLoginForm.Text = "Log In";
            this.llblGoToLoginForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGoToLoginForm_LinkClicked);
            // 
            // txtFullName
            // 
            this.txtFullName.AnimateReadOnly = false;
            this.txtFullName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFullName.Depth = 0;
            this.txtFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.HideSelection = true;
            this.txtFullName.Hint = "Full Name";
            this.txtFullName.LeadingIcon = null;
            this.txtFullName.Location = new System.Drawing.Point(58, 207);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PrefixSuffixText = null;
            this.txtFullName.ReadOnly = false;
            this.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(225, 48);
            this.txtFullName.TabIndex = 15;
            this.txtFullName.TabStop = false;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFullName.TrailingIcon = null;
            this.txtFullName.UseSystemPasswordChar = false;
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.HideSelection = true;
            this.txtUsername.Hint = "Username";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(58, 289);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PrefixSuffixText = null;
            this.txtUsername.ReadOnly = false;
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(225, 48);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.TabStop = false;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.AnimateReadOnly = false;
            this.txtEmailAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmailAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmailAddress.Depth = 0;
            this.txtEmailAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailAddress.HideSelection = true;
            this.txtEmailAddress.Hint = "Email Address";
            this.txtEmailAddress.LeadingIcon = null;
            this.txtEmailAddress.Location = new System.Drawing.Point(330, 207);
            this.txtEmailAddress.MaxLength = 32767;
            this.txtEmailAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.PasswordChar = '\0';
            this.txtEmailAddress.PrefixSuffixText = null;
            this.txtEmailAddress.ReadOnly = false;
            this.txtEmailAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmailAddress.SelectedText = "";
            this.txtEmailAddress.SelectionLength = 0;
            this.txtEmailAddress.SelectionStart = 0;
            this.txtEmailAddress.ShortcutsEnabled = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(225, 48);
            this.txtEmailAddress.TabIndex = 17;
            this.txtEmailAddress.TabStop = false;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmailAddress.TrailingIcon = null;
            this.txtEmailAddress.UseSystemPasswordChar = false;
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.AllowPromptAsInput = true;
            this.mtxtPassword.AnimateReadOnly = false;
            this.mtxtPassword.AsciiOnly = false;
            this.mtxtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtPassword.BeepOnError = false;
            this.mtxtPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtPassword.Depth = 0;
            this.mtxtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtPassword.HidePromptOnLeave = false;
            this.mtxtPassword.HideSelection = true;
            this.mtxtPassword.Hint = "Password";
            this.mtxtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtPassword.LeadingIcon = null;
            this.mtxtPassword.Location = new System.Drawing.Point(330, 289);
            this.mtxtPassword.Mask = "";
            this.mtxtPassword.MaxLength = 32767;
            this.mtxtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '●';
            this.mtxtPassword.PrefixSuffixText = null;
            this.mtxtPassword.PromptChar = '_';
            this.mtxtPassword.ReadOnly = false;
            this.mtxtPassword.RejectInputOnFirstFailure = false;
            this.mtxtPassword.ResetOnPrompt = true;
            this.mtxtPassword.ResetOnSpace = true;
            this.mtxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.Size = new System.Drawing.Size(225, 48);
            this.mtxtPassword.SkipLiterals = true;
            this.mtxtPassword.TabIndex = 18;
            this.mtxtPassword.TabStop = false;
            this.mtxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtPassword.TrailingIcon = null;
            this.mtxtPassword.UseSystemPasswordChar = false;
            this.mtxtPassword.ValidatingType = null;
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoResize = false;
            this.cbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCustomer.Depth = 0;
            this.cbCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCustomer.DropDownHeight = 174;
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.DropDownWidth = 121;
            this.cbCustomer.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Hint = "Account Type";
            this.cbCustomer.IntegralHeight = false;
            this.cbCustomer.ItemHeight = 43;
            this.cbCustomer.Items.AddRange(new object[] {
            "Customer",
            "Manager"});
            this.cbCustomer.Location = new System.Drawing.Point(58, 380);
            this.cbCustomer.MaxDropDownItems = 4;
            this.cbCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(145, 49);
            this.cbCustomer.StartIndex = 0;
            this.cbCustomer.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 56);
            this.label1.TabIndex = 21;
            this.label1.Text = "Create New Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Already have an account?";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(236, 500);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignUp.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignUp.OverrideDefault.Border.Rounding = 20;
            this.btnSignUp.OverrideDefault.Border.Width = 1;
            this.btnSignUp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSignUp.Size = new System.Drawing.Size(155, 43);
            this.btnSignUp.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignUp.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignUp.StateCommon.Border.Rounding = 20;
            this.btnSignUp.StateCommon.Border.Width = 1;
            this.btnSignUp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignUp.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSignUp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignUp.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignUp.StatePressed.Border.Rounding = 20;
            this.btnSignUp.StatePressed.Border.Width = 1;
            this.btnSignUp.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSignUp.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignUp.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignUp.StateTracking.Border.Rounding = 20;
            this.btnSignUp.StateTracking.Border.Width = 1;
            this.btnSignUp.TabIndex = 25;
            this.btnSignUp.Values.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ProjectBlue.Properties.Resources.food_collage;
            this.pictureBox1.Location = new System.Drawing.Point(628, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Image = global::ProjectBlue.Properties.Resources.round_close_black_24dp;
            this.pbClose.Location = new System.Drawing.Point(1028, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 44;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.llblGoToLoginForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 8;
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llblGoToLoginForm;
        private MaterialSkin.Controls.MaterialTextBox2 txtFullName;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsername;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmailAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtPassword;
        private MaterialSkin.Controls.MaterialComboBox cbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbClose;
    }
}