namespace ProjectBlue
{
    partial class CustomerMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbHome = new System.Windows.Forms.TabPage();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.flpChineseCuisine = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.flpAmericanCuisine = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.flpDesserts = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.flpEntrees = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.flpAppetizers = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.flpEthiopianCuisine = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.flpMealOfTheDay = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.flpSearchResults = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbFavorites = new System.Windows.Forms.TabPage();
            this.flpFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbOrders = new System.Windows.Forms.TabPage();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.flpCurrentOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.tbAccount = new System.Windows.Forms.TabPage();
            this.btnLogOut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.lblEmailAddress = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.lblFullName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ilTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tbHome.SuspendLayout();
            this.tbSearch.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbFavorites.SuspendLayout();
            this.tbOrders.SuspendLayout();
            this.tbAccount.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbHome);
            this.materialTabControl1.Controls.Add(this.tbSearch);
            this.materialTabControl1.Controls.Add(this.tbFavorites);
            this.materialTabControl1.Controls.Add(this.tbOrders);
            this.materialTabControl1.Controls.Add(this.tbAccount);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.ilTabIcons;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 98);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1436, 719);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tbHome
            // 
            this.tbHome.AutoScroll = true;
            this.tbHome.BackColor = System.Drawing.Color.White;
            this.tbHome.Controls.Add(this.materialLabel21);
            this.tbHome.Controls.Add(this.flpChineseCuisine);
            this.tbHome.Controls.Add(this.materialLabel19);
            this.tbHome.Controls.Add(this.flpAmericanCuisine);
            this.tbHome.Controls.Add(this.materialLabel20);
            this.tbHome.Controls.Add(this.flpDesserts);
            this.tbHome.Controls.Add(this.materialLabel17);
            this.tbHome.Controls.Add(this.flpEntrees);
            this.tbHome.Controls.Add(this.materialLabel18);
            this.tbHome.Controls.Add(this.flpAppetizers);
            this.tbHome.Controls.Add(this.materialLabel6);
            this.tbHome.Controls.Add(this.flpEthiopianCuisine);
            this.tbHome.Controls.Add(this.materialLabel5);
            this.tbHome.Controls.Add(this.flpMealOfTheDay);
            this.tbHome.ImageKey = "home_FILL0_wght400_GRAD0_opsz48.png";
            this.tbHome.Location = new System.Drawing.Point(4, 39);
            this.tbHome.Margin = new System.Windows.Forms.Padding(4);
            this.tbHome.Name = "tbHome";
            this.tbHome.Padding = new System.Windows.Forms.Padding(4);
            this.tbHome.Size = new System.Drawing.Size(1428, 676);
            this.tbHome.TabIndex = 0;
            this.tbHome.Text = "Home";
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel21.Location = new System.Drawing.Point(55, 1910);
            this.materialLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(73, 24);
            this.materialLabel21.TabIndex = 14;
            this.materialLabel21.Text = "Chinese";
            // 
            // flpChineseCuisine
            // 
            this.flpChineseCuisine.AutoScroll = true;
            this.flpChineseCuisine.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChineseCuisine.Location = new System.Drawing.Point(41, 1963);
            this.flpChineseCuisine.Margin = new System.Windows.Forms.Padding(4);
            this.flpChineseCuisine.Name = "flpChineseCuisine";
            this.flpChineseCuisine.Size = new System.Drawing.Size(1211, 219);
            this.flpChineseCuisine.TabIndex = 13;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel19.Location = new System.Drawing.Point(60, 1599);
            this.materialLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(86, 24);
            this.materialLabel19.TabIndex = 12;
            this.materialLabel19.Text = "American";
            // 
            // flpAmericanCuisine
            // 
            this.flpAmericanCuisine.AutoScroll = true;
            this.flpAmericanCuisine.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAmericanCuisine.Location = new System.Drawing.Point(47, 1652);
            this.flpAmericanCuisine.Margin = new System.Windows.Forms.Padding(4);
            this.flpAmericanCuisine.Name = "flpAmericanCuisine";
            this.flpAmericanCuisine.Size = new System.Drawing.Size(1211, 219);
            this.flpAmericanCuisine.TabIndex = 11;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel20.Location = new System.Drawing.Point(60, 1297);
            this.materialLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(80, 24);
            this.materialLabel20.TabIndex = 10;
            this.materialLabel20.Text = "Desserts";
            // 
            // flpDesserts
            // 
            this.flpDesserts.AutoScroll = true;
            this.flpDesserts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDesserts.Location = new System.Drawing.Point(47, 1350);
            this.flpDesserts.Margin = new System.Windows.Forms.Padding(4);
            this.flpDesserts.Name = "flpDesserts";
            this.flpDesserts.Size = new System.Drawing.Size(1211, 219);
            this.flpDesserts.TabIndex = 9;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel17.Location = new System.Drawing.Point(65, 977);
            this.materialLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(69, 24);
            this.materialLabel17.TabIndex = 8;
            this.materialLabel17.Text = "Entrées";
            // 
            // flpEntrees
            // 
            this.flpEntrees.AutoScroll = true;
            this.flpEntrees.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEntrees.Location = new System.Drawing.Point(52, 1030);
            this.flpEntrees.Margin = new System.Windows.Forms.Padding(4);
            this.flpEntrees.Name = "flpEntrees";
            this.flpEntrees.Size = new System.Drawing.Size(1211, 219);
            this.flpEntrees.TabIndex = 7;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel18.Location = new System.Drawing.Point(65, 676);
            this.materialLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(97, 24);
            this.materialLabel18.TabIndex = 6;
            this.materialLabel18.Text = "Appetizers";
            // 
            // flpAppetizers
            // 
            this.flpAppetizers.AutoScroll = true;
            this.flpAppetizers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAppetizers.Location = new System.Drawing.Point(52, 729);
            this.flpAppetizers.Margin = new System.Windows.Forms.Padding(4);
            this.flpAppetizers.Name = "flpAppetizers";
            this.flpAppetizers.Size = new System.Drawing.Size(1211, 219);
            this.flpAppetizers.TabIndex = 5;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(67, 357);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(84, 24);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Ethiopian";
            // 
            // flpEthiopianCuisine
            // 
            this.flpEthiopianCuisine.AutoScroll = true;
            this.flpEthiopianCuisine.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEthiopianCuisine.Location = new System.Drawing.Point(53, 410);
            this.flpEthiopianCuisine.Margin = new System.Windows.Forms.Padding(4);
            this.flpEthiopianCuisine.Name = "flpEthiopianCuisine";
            this.flpEthiopianCuisine.Size = new System.Drawing.Size(1211, 219);
            this.flpEthiopianCuisine.TabIndex = 3;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(67, 55);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(142, 24);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Good Afternoon";
            // 
            // flpMealOfTheDay
            // 
            this.flpMealOfTheDay.AutoScroll = true;
            this.flpMealOfTheDay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMealOfTheDay.Location = new System.Drawing.Point(53, 108);
            this.flpMealOfTheDay.Margin = new System.Windows.Forms.Padding(4);
            this.flpMealOfTheDay.Name = "flpMealOfTheDay";
            this.flpMealOfTheDay.Size = new System.Drawing.Size(1211, 219);
            this.flpMealOfTheDay.TabIndex = 1;
            // 
            // tbSearch
            // 
            this.tbSearch.AutoScroll = true;
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.Controls.Add(this.materialLabel9);
            this.tbSearch.Controls.Add(this.materialCard1);
            this.tbSearch.Controls.Add(this.flpSearchResults);
            this.tbSearch.Controls.Add(this.materialLabel1);
            this.tbSearch.Controls.Add(this.materialTextBox21);
            this.tbSearch.Controls.Add(this.panel1);
            this.tbSearch.ImageKey = "search_FILL0_wght400_GRAD0_opsz48.png";
            this.tbSearch.Location = new System.Drawing.Point(4, 39);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.tbSearch.Size = new System.Drawing.Size(1428, 676);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.Text = "Search";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel9.Location = new System.Drawing.Point(782, 46);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(107, 19);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "materialLabel9";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.groupBox1);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.materialSlider1);
            this.materialCard1.Controls.Add(this.materialTextBox22);
            this.materialCard1.Controls.Add(this.materialDivider6);
            this.materialCard1.Controls.Add(this.materialDivider5);
            this.materialCard1.Controls.Add(this.materialDivider4);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(53, 187);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.Size = new System.Drawing.Size(368, 441);
            this.materialCard1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialRadioButton3);
            this.groupBox1.Controls.Add(this.materialRadioButton2);
            this.groupBox1.Controls.Add(this.materialRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(33, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 183);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Location = new System.Drawing.Point(24, 116);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(81, 37);
            this.materialRadioButton3.TabIndex = 8;
            this.materialRadioButton3.TabStop = true;
            this.materialRadioButton3.Text = "Dinner";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Location = new System.Drawing.Point(24, 65);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(79, 37);
            this.materialRadioButton2.TabIndex = 1;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Lunch";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(24, 18);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(110, 37);
            this.materialRadioButton1.TabIndex = 0;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Break Fast";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(225, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "ETB";
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(8, 127);
            this.materialSlider1.Margin = new System.Windows.Forms.Padding(4);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.Size = new System.Drawing.Size(333, 40);
            this.materialSlider1.TabIndex = 28;
            this.materialSlider1.Text = "";
            // 
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.Hint = "Price";
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.Location = new System.Drawing.Point(33, 48);
            this.materialTextBox22.Margin = new System.Windows.Forms.Padding(4);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = false;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(184, 48);
            this.materialTextBox22.TabIndex = 27;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(33, 665);
            this.materialDivider6.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(300, 2);
            this.materialDivider6.TabIndex = 25;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(33, 434);
            this.materialDivider5.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(300, 2);
            this.materialDivider5.TabIndex = 24;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(33, 196);
            this.materialDivider4.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(300, 2);
            this.materialDivider4.TabIndex = 23;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(36, 230);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 24);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Meals of the Day";
            // 
            // flpSearchResults
            // 
            this.flpSearchResults.AutoScroll = true;
            this.flpSearchResults.Location = new System.Drawing.Point(496, 183);
            this.flpSearchResults.Margin = new System.Windows.Forms.Padding(4);
            this.flpSearchResults.Name = "flpSearchResults";
            this.flpSearchResults.Size = new System.Drawing.Size(733, 1034);
            this.flpSearchResults.TabIndex = 15;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(47, 25);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 29);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Search";
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "Search";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(500, 69);
            this.materialTextBox21.Margin = new System.Windows.Forms.Padding(4);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(680, 48);
            this.materialTextBox21.TabIndex = 16;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            this.materialTextBox21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.materialTextBox21_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 1213);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 50);
            this.panel1.TabIndex = 19;
            // 
            // tbFavorites
            // 
            this.tbFavorites.BackColor = System.Drawing.Color.White;
            this.tbFavorites.Controls.Add(this.flpFavorites);
            this.tbFavorites.Controls.Add(this.materialLabel3);
            this.tbFavorites.ImageKey = "star_FILL0_wght400_GRAD0_opsz48.png";
            this.tbFavorites.Location = new System.Drawing.Point(4, 39);
            this.tbFavorites.Margin = new System.Windows.Forms.Padding(4);
            this.tbFavorites.Name = "tbFavorites";
            this.tbFavorites.Padding = new System.Windows.Forms.Padding(4);
            this.tbFavorites.Size = new System.Drawing.Size(1428, 676);
            this.tbFavorites.TabIndex = 2;
            this.tbFavorites.Text = "Favorites";
            // 
            // flpFavorites
            // 
            this.flpFavorites.Location = new System.Drawing.Point(53, 92);
            this.flpFavorites.Margin = new System.Windows.Forms.Padding(4);
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.Size = new System.Drawing.Size(1320, 535);
            this.flpFavorites.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(47, 25);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(100, 29);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Favorites";
            // 
            // tbOrders
            // 
            this.tbOrders.BackColor = System.Drawing.Color.White;
            this.tbOrders.Controls.Add(this.materialLabel24);
            this.tbOrders.Controls.Add(this.flpCurrentOrders);
            this.tbOrders.ImageKey = "list_alt_FILL0_wght400_GRAD0_opsz48.png";
            this.tbOrders.Location = new System.Drawing.Point(4, 39);
            this.tbOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrders.Name = "tbOrders";
            this.tbOrders.Size = new System.Drawing.Size(1428, 676);
            this.tbOrders.TabIndex = 3;
            this.tbOrders.Text = "Orders";
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel24.Location = new System.Drawing.Point(47, 25);
            this.materialLabel24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(158, 29);
            this.materialLabel24.TabIndex = 6;
            this.materialLabel24.Text = "Current Orders";
            // 
            // flpCurrentOrders
            // 
            this.flpCurrentOrders.Location = new System.Drawing.Point(53, 92);
            this.flpCurrentOrders.Margin = new System.Windows.Forms.Padding(4);
            this.flpCurrentOrders.Name = "flpCurrentOrders";
            this.flpCurrentOrders.Size = new System.Drawing.Size(1260, 433);
            this.flpCurrentOrders.TabIndex = 13;
            // 
            // tbAccount
            // 
            this.tbAccount.BackColor = System.Drawing.Color.White;
            this.tbAccount.Controls.Add(this.btnLogOut);
            this.tbAccount.Controls.Add(this.materialLabel4);
            this.tbAccount.Controls.Add(this.materialCard4);
            this.tbAccount.ImageKey = "account_circle_FILL0_wght400_GRAD0_opsz48.png";
            this.tbAccount.Location = new System.Drawing.Point(4, 39);
            this.tbAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(1428, 676);
            this.tbAccount.TabIndex = 4;
            this.tbAccount.Text = "Account";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(622, 512);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogOut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogOut.OverrideDefault.Border.Rounding = 20;
            this.btnLogOut.OverrideDefault.Border.Width = 1;
            this.btnLogOut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLogOut.Size = new System.Drawing.Size(207, 53);
            this.btnLogOut.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogOut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogOut.StateCommon.Border.Rounding = 20;
            this.btnLogOut.StateCommon.Border.Width = 1;
            this.btnLogOut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogOut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogOut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogOut.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogOut.StatePressed.Border.Rounding = 20;
            this.btnLogOut.StatePressed.Border.Width = 1;
            this.btnLogOut.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnLogOut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogOut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogOut.StateTracking.Border.Rounding = 20;
            this.btnLogOut.StateTracking.Border.Width = 1;
            this.btnLogOut.TabIndex = 25;
            this.btnLogOut.Values.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(47, 25);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(139, 29);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Account Info";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.lblEmailAddress);
            this.materialCard4.Controls.Add(this.materialLabel14);
            this.materialCard4.Controls.Add(this.materialDivider3);
            this.materialCard4.Controls.Add(this.lblUsername);
            this.materialCard4.Controls.Add(this.lblFullName);
            this.materialCard4.Controls.Add(this.materialLabel8);
            this.materialCard4.Controls.Add(this.materialLabel7);
            this.materialCard4.Controls.Add(this.materialDivider2);
            this.materialCard4.Controls.Add(this.materialDivider1);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(382, 135);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard4.Size = new System.Drawing.Size(673, 312);
            this.materialCard4.TabIndex = 0;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Depth = 0;
            this.lblEmailAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmailAddress.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblEmailAddress.Location = new System.Drawing.Point(391, 253);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(138, 19);
            this.lblEmailAddress.TabIndex = 10;
            this.lblEmailAddress.Text = "dwight@gmail.com";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel14.Location = new System.Drawing.Point(53, 248);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(128, 24);
            this.materialLabel14.TabIndex = 9;
            this.materialLabel14.Text = "Email Address";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(56, 310);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(560, 2);
            this.materialDivider3.TabIndex = 8;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblUsername.Location = new System.Drawing.Point(391, 139);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "schrute42";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Depth = 0;
            this.lblFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFullName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblFullName.Location = new System.Drawing.Point(391, 39);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(109, 19);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Dwight Schrute";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(53, 134);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(92, 24);
            this.materialLabel8.TabIndex = 3;
            this.materialLabel8.Text = "Username";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(53, 34);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(54, 24);
            this.materialLabel7.TabIndex = 2;
            this.materialLabel7.Text = "Name";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(56, 203);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(560, 2);
            this.materialDivider2.TabIndex = 1;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(56, 96);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(560, 2);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ilTabIcons
            // 
            this.ilTabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTabIcons.ImageStream")));
            this.ilTabIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTabIcons.Images.SetKeyName(0, "account_circle_FILL0_wght400_GRAD0_opsz48.png");
            this.ilTabIcons.Images.SetKeyName(1, "home_FILL0_wght400_GRAD0_opsz48.png");
            this.ilTabIcons.Images.SetKeyName(2, "list_alt_FILL0_wght400_GRAD0_opsz48.png");
            this.ilTabIcons.Images.SetKeyName(3, "round_more_vert_black_24dp.png");
            this.ilTabIcons.Images.SetKeyName(4, "search_FILL0_wght400_GRAD0_opsz48.png");
            this.ilTabIcons.Images.SetKeyName(5, "star_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 821);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CustomerMainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 98, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enbila";
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tbHome.ResumeLayout(false);
            this.tbHome.PerformLayout();
            this.tbSearch.ResumeLayout(false);
            this.tbSearch.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbFavorites.ResumeLayout(false);
            this.tbFavorites.PerformLayout();
            this.tbOrders.ResumeLayout(false);
            this.tbOrders.PerformLayout();
            this.tbAccount.ResumeLayout(false);
            this.tbAccount.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbHome;
        private System.Windows.Forms.TabPage tbFavorites;
        private System.Windows.Forms.TabPage tbOrders;
        private System.Windows.Forms.ImageList ilTabIcons;
        private System.Windows.Forms.TabPage tbAccount;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel lblFullName;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblEmailAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.FlowLayoutPanel flpEthiopianCuisine;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.FlowLayoutPanel flpMealOfTheDay;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flpSearchResults;
        private System.Windows.Forms.FlowLayoutPanel flpCurrentOrders;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogOut;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpFavorites;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private System.Windows.Forms.FlowLayoutPanel flpChineseCuisine;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private System.Windows.Forms.FlowLayoutPanel flpAmericanCuisine;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private System.Windows.Forms.FlowLayoutPanel flpDesserts;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.FlowLayoutPanel flpEntrees;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private System.Windows.Forms.FlowLayoutPanel flpAppetizers;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

