namespace ProjectBlue
{
    partial class OfferingDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfferingDetailsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCuisine = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCourseOfMeal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOfferingType = new MaterialSkin.Controls.MaterialTextBox();
            this.lblcousine = new System.Windows.Forms.Label();
            this.lblcourse_of_meal = new System.Windows.Forms.Label();
            this.lblofferingType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtETA = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEWT = new MaterialSkin.Controls.MaterialTextBox();
            this.txtServiceOptions = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOffering_name = new MaterialSkin.Controls.MaterialTextBox();
            this.lblETA = new MaterialSkin.Controls.MaterialLabel();
            this.lblEWT = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblservice_options = new MaterialSkin.Controls.MaterialLabel();
            this.lblrestaurant_name = new MaterialSkin.Controls.MaterialLabel();
            this.lblprice = new MaterialSkin.Controls.MaterialLabel();
            this.lbloffering_name = new MaterialSkin.Controls.MaterialLabel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblCancel = new MaterialSkin.Controls.MaterialLabel();
            this.lblSave = new MaterialSkin.Controls.MaterialLabel();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.txtlabelFav = new MaterialSkin.Controls.MaterialLabel();
            this.txtlabelOrder = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Offering Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCuisine);
            this.panel2.Controls.Add(this.txtCourseOfMeal);
            this.panel2.Controls.Add(this.txtOfferingType);
            this.panel2.Controls.Add(this.lblcousine);
            this.panel2.Controls.Add(this.lblcourse_of_meal);
            this.panel2.Controls.Add(this.lblofferingType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(357, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 246);
            this.panel2.TabIndex = 11;
            // 
            // txtCuisine
            // 
            this.txtCuisine.AnimateReadOnly = false;
            this.txtCuisine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuisine.Depth = 0;
            this.txtCuisine.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuisine.Hint = "Ethiopian, American....";
            this.txtCuisine.LeadingIcon = null;
            this.txtCuisine.Location = new System.Drawing.Point(236, 170);
            this.txtCuisine.MaxLength = 50;
            this.txtCuisine.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuisine.Multiline = false;
            this.txtCuisine.Name = "txtCuisine";
            this.txtCuisine.Size = new System.Drawing.Size(227, 50);
            this.txtCuisine.TabIndex = 59;
            this.txtCuisine.Text = "";
            this.txtCuisine.TrailingIcon = null;
            // 
            // txtCourseOfMeal
            // 
            this.txtCourseOfMeal.AnimateReadOnly = false;
            this.txtCourseOfMeal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseOfMeal.Depth = 0;
            this.txtCourseOfMeal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourseOfMeal.Hint = "Main, Appetizer or Dinner";
            this.txtCourseOfMeal.LeadingIcon = null;
            this.txtCourseOfMeal.Location = new System.Drawing.Point(236, 101);
            this.txtCourseOfMeal.MaxLength = 50;
            this.txtCourseOfMeal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCourseOfMeal.Multiline = false;
            this.txtCourseOfMeal.Name = "txtCourseOfMeal";
            this.txtCourseOfMeal.Size = new System.Drawing.Size(227, 50);
            this.txtCourseOfMeal.TabIndex = 58;
            this.txtCourseOfMeal.Text = "";
            this.txtCourseOfMeal.TrailingIcon = null;
            // 
            // txtOfferingType
            // 
            this.txtOfferingType.AnimateReadOnly = false;
            this.txtOfferingType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOfferingType.Depth = 0;
            this.txtOfferingType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOfferingType.Hint = "Break Fast, Lunch or Dinner";
            this.txtOfferingType.LeadingIcon = null;
            this.txtOfferingType.Location = new System.Drawing.Point(236, 30);
            this.txtOfferingType.MaxLength = 50;
            this.txtOfferingType.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOfferingType.Multiline = false;
            this.txtOfferingType.Name = "txtOfferingType";
            this.txtOfferingType.Size = new System.Drawing.Size(227, 50);
            this.txtOfferingType.TabIndex = 57;
            this.txtOfferingType.Text = "";
            this.txtOfferingType.TrailingIcon = null;
            // 
            // lblcousine
            // 
            this.lblcousine.AutoSize = true;
            this.lblcousine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblcousine.Location = new System.Drawing.Point(259, 182);
            this.lblcousine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcousine.Name = "lblcousine";
            this.lblcousine.Size = new System.Drawing.Size(105, 26);
            this.lblcousine.TabIndex = 5;
            this.lblcousine.Text = "American";
            // 
            // lblcourse_of_meal
            // 
            this.lblcourse_of_meal.AutoSize = true;
            this.lblcourse_of_meal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblcourse_of_meal.Location = new System.Drawing.Point(259, 112);
            this.lblcourse_of_meal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcourse_of_meal.Name = "lblcourse_of_meal";
            this.lblcourse_of_meal.Size = new System.Drawing.Size(76, 26);
            this.lblcourse_of_meal.TabIndex = 4;
            this.lblcourse_of_meal.Text = "Entrée";
            // 
            // lblofferingType
            // 
            this.lblofferingType.AutoSize = true;
            this.lblofferingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblofferingType.Location = new System.Drawing.Point(259, 42);
            this.lblofferingType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblofferingType.Name = "lblofferingType";
            this.lblofferingType.Size = new System.Drawing.Size(71, 26);
            this.lblofferingType.TabIndex = 3;
            this.lblofferingType.Text = "Lunch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(139, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cuisine:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(49, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course of Meal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(45, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Meal of the Day:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtETA);
            this.panel1.Controls.Add(this.txtEWT);
            this.panel1.Controls.Add(this.txtServiceOptions);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtOffering_name);
            this.panel1.Controls.Add(this.lblETA);
            this.panel1.Controls.Add(this.lblEWT);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialDivider2);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.lblservice_options);
            this.panel1.Controls.Add(this.lblrestaurant_name);
            this.panel1.Controls.Add(this.lblprice);
            this.panel1.Controls.Add(this.lbloffering_name);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(96, 377);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 246);
            this.panel1.TabIndex = 14;
            // 
            // txtETA
            // 
            this.txtETA.AnimateReadOnly = false;
            this.txtETA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtETA.Depth = 0;
            this.txtETA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtETA.LeadingIcon = null;
            this.txtETA.Location = new System.Drawing.Point(460, 165);
            this.txtETA.MaxLength = 50;
            this.txtETA.MouseState = MaterialSkin.MouseState.OUT;
            this.txtETA.Multiline = false;
            this.txtETA.Name = "txtETA";
            this.txtETA.Size = new System.Drawing.Size(227, 50);
            this.txtETA.TabIndex = 64;
            this.txtETA.Text = "";
            this.txtETA.TrailingIcon = null;
            // 
            // txtEWT
            // 
            this.txtEWT.AnimateReadOnly = false;
            this.txtEWT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEWT.Depth = 0;
            this.txtEWT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEWT.LeadingIcon = null;
            this.txtEWT.Location = new System.Drawing.Point(460, 95);
            this.txtEWT.MaxLength = 50;
            this.txtEWT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEWT.Multiline = false;
            this.txtEWT.Name = "txtEWT";
            this.txtEWT.Size = new System.Drawing.Size(227, 50);
            this.txtEWT.TabIndex = 63;
            this.txtEWT.Text = "";
            this.txtEWT.TrailingIcon = null;
            // 
            // txtServiceOptions
            // 
            this.txtServiceOptions.AnimateReadOnly = false;
            this.txtServiceOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceOptions.Depth = 0;
            this.txtServiceOptions.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServiceOptions.Hint = "Service Options";
            this.txtServiceOptions.LeadingIcon = null;
            this.txtServiceOptions.Location = new System.Drawing.Point(405, 30);
            this.txtServiceOptions.MaxLength = 50;
            this.txtServiceOptions.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServiceOptions.Multiline = false;
            this.txtServiceOptions.Name = "txtServiceOptions";
            this.txtServiceOptions.Size = new System.Drawing.Size(227, 50);
            this.txtServiceOptions.TabIndex = 62;
            this.txtServiceOptions.Text = "";
            this.txtServiceOptions.TrailingIcon = null;
            // 
            // txtPrice
            // 
            this.txtPrice.AnimateReadOnly = false;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.Hint = "Price";
            this.txtPrice.LeadingIcon = null;
            this.txtPrice.Location = new System.Drawing.Point(31, 105);
            this.txtPrice.MaxLength = 50;
            this.txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 50);
            this.txtPrice.TabIndex = 60;
            this.txtPrice.Text = "";
            this.txtPrice.TrailingIcon = null;
            // 
            // txtOffering_name
            // 
            this.txtOffering_name.AnimateReadOnly = false;
            this.txtOffering_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOffering_name.Depth = 0;
            this.txtOffering_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOffering_name.Hint = "Offering Name";
            this.txtOffering_name.LeadingIcon = null;
            this.txtOffering_name.Location = new System.Drawing.Point(31, 30);
            this.txtOffering_name.MaxLength = 50;
            this.txtOffering_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOffering_name.Multiline = false;
            this.txtOffering_name.Name = "txtOffering_name";
            this.txtOffering_name.Size = new System.Drawing.Size(227, 50);
            this.txtOffering_name.TabIndex = 59;
            this.txtOffering_name.Text = "";
            this.txtOffering_name.TrailingIcon = null;
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Depth = 0;
            this.lblETA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblETA.Location = new System.Drawing.Point(473, 171);
            this.lblETA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblETA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(50, 19);
            this.lblETA.TabIndex = 9;
            this.lblETA.Text = "24 min";
            // 
            // lblEWT
            // 
            this.lblEWT.AutoSize = true;
            this.lblEWT.Depth = 0;
            this.lblEWT.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEWT.Location = new System.Drawing.Point(473, 108);
            this.lblEWT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEWT.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEWT.Name = "lblEWT";
            this.lblEWT.Size = new System.Drawing.Size(50, 19);
            this.lblEWT.TabIndex = 8;
            this.lblEWT.Text = "30 min";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(415, 171);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(34, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "ETA:";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.Gray;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(343, 30);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(3, 185);
            this.materialDivider2.TabIndex = 6;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(415, 108);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(38, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "EWT:";
            // 
            // lblservice_options
            // 
            this.lblservice_options.AutoSize = true;
            this.lblservice_options.Depth = 0;
            this.lblservice_options.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblservice_options.Location = new System.Drawing.Point(415, 49);
            this.lblservice_options.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblservice_options.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblservice_options.Name = "lblservice_options";
            this.lblservice_options.Size = new System.Drawing.Size(193, 19);
            this.lblservice_options.TabIndex = 3;
            this.lblservice_options.Text = "Dine-in, Takeaway, Delivery";
            // 
            // lblrestaurant_name
            // 
            this.lblrestaurant_name.AutoSize = true;
            this.lblrestaurant_name.Depth = 0;
            this.lblrestaurant_name.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblrestaurant_name.Location = new System.Drawing.Point(42, 171);
            this.lblrestaurant_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrestaurant_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblrestaurant_name.Name = "lblrestaurant_name";
            this.lblrestaurant_name.Size = new System.Drawing.Size(167, 19);
            this.lblrestaurant_name.TabIndex = 2;
            this.lblrestaurant_name.Text = "Atmosphere Restaurant";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Depth = 0;
            this.lblprice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblprice.Location = new System.Drawing.Point(41, 110);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(61, 19);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "210 ETB";
            // 
            // lbloffering_name
            // 
            this.lbloffering_name.AutoSize = true;
            this.lbloffering_name.Depth = 0;
            this.lbloffering_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbloffering_name.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbloffering_name.Location = new System.Drawing.Point(41, 48);
            this.lbloffering_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloffering_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbloffering_name.Name = "lbloffering_name";
            this.lbloffering_name.Size = new System.Drawing.Size(122, 19);
            this.lbloffering_name.TabIndex = 0;
            this.lbloffering_name.Text = "Special Hummus";
            // 
            // pbClose
            // 
            this.pbClose.Image = global::ProjectBlue.Properties.Resources.round_close_black_24dp;
            this.pbClose.Location = new System.Drawing.Point(888, 13);
            this.pbClose.Margin = new System.Windows.Forms.Padding(4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(32, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 44;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Depth = 0;
            this.lblCancel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCancel.Location = new System.Drawing.Point(661, 639);
            this.lblCancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(49, 19);
            this.lblCancel.TabIndex = 54;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Depth = 0;
            this.lblSave.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSave.Location = new System.Drawing.Point(764, 639);
            this.lblSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(36, 19);
            this.lblSave.TabIndex = 53;
            this.lblSave.Text = "Save";
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.Image = global::ProjectBlue.Properties.Resources.round_edit_black_24dp;
            this.pbEdit.Location = new System.Drawing.Point(827, 60);
            this.pbEdit.Margin = new System.Windows.Forms.Padding(4);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(32, 30);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 52;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // txtlabelFav
            // 
            this.txtlabelFav.AutoSize = true;
            this.txtlabelFav.Depth = 0;
            this.txtlabelFav.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtlabelFav.Location = new System.Drawing.Point(93, 639);
            this.txtlabelFav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtlabelFav.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtlabelFav.Name = "txtlabelFav";
            this.txtlabelFav.Size = new System.Drawing.Size(115, 19);
            this.txtlabelFav.TabIndex = 55;
            this.txtlabelFav.Text = "Set as Favourite";
            this.txtlabelFav.Click += new System.EventHandler(this.txtlabelFav_Click);
            // 
            // txtlabelOrder
            // 
            this.txtlabelOrder.AutoSize = true;
            this.txtlabelOrder.Depth = 0;
            this.txtlabelOrder.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtlabelOrder.Location = new System.Drawing.Point(267, 639);
            this.txtlabelOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtlabelOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtlabelOrder.Name = "txtlabelOrder";
            this.txtlabelOrder.Size = new System.Drawing.Size(39, 19);
            this.txtlabelOrder.TabIndex = 56;
            this.txtlabelOrder.Text = "Order";
            this.txtlabelOrder.Click += new System.EventHandler(this.txtlabelOrder_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OfferingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 682);
            this.Controls.Add(this.txtlabelOrder);
            this.Controls.Add(this.txtlabelFav);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OfferingDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 8;
            this.Text = "OfferingDetailsForm";
            this.Load += new System.EventHandler(this.OfferingDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblservice_options;
        private MaterialSkin.Controls.MaterialLabel lblrestaurant_name;
        private MaterialSkin.Controls.MaterialLabel lblprice;
        private MaterialSkin.Controls.MaterialLabel lbloffering_name;
        private System.Windows.Forms.PictureBox pbClose;
        private MaterialSkin.Controls.MaterialLabel lblETA;
        private MaterialSkin.Controls.MaterialLabel lblEWT;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.Label lblcousine;
        private System.Windows.Forms.Label lblcourse_of_meal;
        private System.Windows.Forms.Label lblofferingType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel lblCancel;
        private MaterialSkin.Controls.MaterialLabel lblSave;
        private System.Windows.Forms.PictureBox pbEdit;
        private MaterialSkin.Controls.MaterialLabel txtlabelFav;
        private MaterialSkin.Controls.MaterialLabel txtlabelOrder;
        private MaterialSkin.Controls.MaterialTextBox txtCuisine;
        private MaterialSkin.Controls.MaterialTextBox txtCourseOfMeal;
        private MaterialSkin.Controls.MaterialTextBox txtOfferingType;
        private MaterialSkin.Controls.MaterialTextBox txtETA;
        private MaterialSkin.Controls.MaterialTextBox txtEWT;
        private MaterialSkin.Controls.MaterialTextBox txtServiceOptions;
        private MaterialSkin.Controls.MaterialTextBox txtPrice;
        private MaterialSkin.Controls.MaterialTextBox txtOffering_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}