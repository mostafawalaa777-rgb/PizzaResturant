namespace Pizza_Resturant
{
    partial class PizzaOrder
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbWherToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.grCrustType = new System.Windows.Forms.GroupBox();
            this.rbCrustThick = new System.Windows.Forms.RadioButton();
            this.rbCrustThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbExtraChees = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.Toppings = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.WhereToEat = new System.Windows.Forms.Label();
            this.CrustType = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbWherToEat.SuspendLayout();
            this.grCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(167, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(12, 119);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(183, 155);
            this.gbSize.TabIndex = 20;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.UseWaitCursor = true;
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.rbLarg.ForeColor = System.Drawing.Color.Black;
            this.rbLarg.Location = new System.Drawing.Point(40, 102);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(67, 24);
            this.rbLarg.TabIndex = 14;
            this.rbLarg.TabStop = true;
            this.rbLarg.Tag = "45";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.UseWaitCursor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.rbMeduim.ForeColor = System.Drawing.Color.Black;
            this.rbMeduim.Location = new System.Drawing.Point(40, 70);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(96, 24);
            this.rbMeduim.TabIndex = 12;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "35";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.UseWaitCursor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.rbSmall.ForeColor = System.Drawing.Color.Black;
            this.rbSmall.Location = new System.Drawing.Point(40, 38);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(74, 24);
            this.rbSmall.TabIndex = 9;
            this.rbSmall.Tag = "25";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.UseWaitCursor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbWherToEat
            // 
            this.gbWherToEat.Controls.Add(this.rbTakeOut);
            this.gbWherToEat.Controls.Add(this.rbEatIn);
            this.gbWherToEat.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWherToEat.Location = new System.Drawing.Point(255, 376);
            this.gbWherToEat.Name = "gbWherToEat";
            this.gbWherToEat.Size = new System.Drawing.Size(365, 90);
            this.gbWherToEat.TabIndex = 21;
            this.gbWherToEat.TabStop = false;
            this.gbWherToEat.Text = "Wher To Eat";
            this.gbWherToEat.UseWaitCursor = true;
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.rbTakeOut.ForeColor = System.Drawing.Color.Black;
            this.rbTakeOut.Location = new System.Drawing.Point(175, 45);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(102, 24);
            this.rbTakeOut.TabIndex = 12;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.UseWaitCursor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.rbEatIn.ForeColor = System.Drawing.Color.Black;
            this.rbEatIn.Location = new System.Drawing.Point(31, 45);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(81, 24);
            this.rbEatIn.TabIndex = 9;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.UseWaitCursor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // grCrustType
            // 
            this.grCrustType.Controls.Add(this.rbCrustThick);
            this.grCrustType.Controls.Add(this.rbCrustThin);
            this.grCrustType.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grCrustType.Location = new System.Drawing.Point(12, 323);
            this.grCrustType.Name = "grCrustType";
            this.grCrustType.Size = new System.Drawing.Size(183, 143);
            this.grCrustType.TabIndex = 19;
            this.grCrustType.TabStop = false;
            this.grCrustType.Text = "Crust Type";
            this.grCrustType.UseWaitCursor = true;
            // 
            // rbCrustThick
            // 
            this.rbCrustThick.AutoSize = true;
            this.rbCrustThick.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.rbCrustThick.ForeColor = System.Drawing.Color.Black;
            this.rbCrustThick.Location = new System.Drawing.Point(16, 99);
            this.rbCrustThick.Name = "rbCrustThick";
            this.rbCrustThick.Size = new System.Drawing.Size(116, 24);
            this.rbCrustThick.TabIndex = 12;
            this.rbCrustThick.TabStop = true;
            this.rbCrustThick.Tag = "10";
            this.rbCrustThick.Text = "CrustThick";
            this.rbCrustThick.UseVisualStyleBackColor = true;
            this.rbCrustThick.UseWaitCursor = true;
            this.rbCrustThick.CheckedChanged += new System.EventHandler(this.rbCrustThick_CheckedChanged);
            // 
            // rbCrustThin
            // 
            this.rbCrustThin.AutoSize = true;
            this.rbCrustThin.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.rbCrustThin.ForeColor = System.Drawing.Color.Black;
            this.rbCrustThin.Location = new System.Drawing.Point(16, 44);
            this.rbCrustThin.Name = "rbCrustThin";
            this.rbCrustThin.Size = new System.Drawing.Size(120, 24);
            this.rbCrustThin.TabIndex = 9;
            this.rbCrustThin.TabStop = true;
            this.rbCrustThin.Tag = "0";
            this.rbCrustThin.Text = "Thin Crust ";
            this.rbCrustThin.UseVisualStyleBackColor = true;
            this.rbCrustThin.UseWaitCursor = true;
            this.rbCrustThin.CheckedChanged += new System.EventHandler(this.rbCrustThin_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chbGreenPeppers);
            this.gbToppings.Controls.Add(this.chbOlives);
            this.gbToppings.Controls.Add(this.chbOnion);
            this.gbToppings.Controls.Add(this.chbTomatoes);
            this.gbToppings.Controls.Add(this.chbMushrooms);
            this.gbToppings.Controls.Add(this.chbExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(228, 130);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(365, 144);
            this.gbToppings.TabIndex = 22;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.UseWaitCursor = true;
            // 
            // chbGreenPeppers
            // 
            this.chbGreenPeppers.AutoSize = true;
            this.chbGreenPeppers.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGreenPeppers.ForeColor = System.Drawing.Color.Black;
            this.chbGreenPeppers.Location = new System.Drawing.Point(212, 108);
            this.chbGreenPeppers.Name = "chbGreenPeppers";
            this.chbGreenPeppers.Size = new System.Drawing.Size(144, 24);
            this.chbGreenPeppers.TabIndex = 17;
            this.chbGreenPeppers.Tag = "5";
            this.chbGreenPeppers.Text = "Green Peppers";
            this.chbGreenPeppers.UseVisualStyleBackColor = true;
            this.chbGreenPeppers.UseWaitCursor = true;
            this.chbGreenPeppers.CheckedChanged += new System.EventHandler(this.chbGreenPeppers_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOlives.ForeColor = System.Drawing.Color.Black;
            this.chbOlives.Location = new System.Drawing.Point(212, 73);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(80, 24);
            this.chbOlives.TabIndex = 16;
            this.chbOlives.Tag = "5";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.UseWaitCursor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOnion.ForeColor = System.Drawing.Color.Black;
            this.chbOnion.Location = new System.Drawing.Point(212, 38);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(80, 24);
            this.chbOnion.TabIndex = 15;
            this.chbOnion.Tag = "5";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.UseWaitCursor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTomatoes.ForeColor = System.Drawing.Color.Black;
            this.chbTomatoes.Location = new System.Drawing.Point(16, 108);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(107, 24);
            this.chbTomatoes.TabIndex = 14;
            this.chbTomatoes.Tag = "5";
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.UseWaitCursor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMushrooms.ForeColor = System.Drawing.Color.Black;
            this.chbMushrooms.Location = new System.Drawing.Point(16, 73);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(123, 24);
            this.chbMushrooms.TabIndex = 13;
            this.chbMushrooms.Tag = "5";
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            this.chbMushrooms.UseWaitCursor = true;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.chbMushrooms_CheckedChanged);
            // 
            // chbExtraChees
            // 
            this.chbExtraChees.AutoSize = true;
            this.chbExtraChees.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExtraChees.ForeColor = System.Drawing.Color.Black;
            this.chbExtraChees.Location = new System.Drawing.Point(16, 38);
            this.chbExtraChees.Name = "chbExtraChees";
            this.chbExtraChees.Size = new System.Drawing.Size(126, 24);
            this.chbExtraChees.TabIndex = 12;
            this.chbExtraChees.Tag = "5";
            this.chbExtraChees.Text = "Extra Chees";
            this.chbExtraChees.UseVisualStyleBackColor = true;
            this.chbExtraChees.UseWaitCursor = true;
            this.chbExtraChees.CheckedChanged += new System.EventHandler(this.chbExtraChees_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(724, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "OrderSummary";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.BackColor = System.Drawing.Color.Transparent;
            this.Size.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.Size.ForeColor = System.Drawing.Color.Navy;
            this.Size.Location = new System.Drawing.Point(803, 161);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(75, 20);
            this.Size.TabIndex = 24;
            this.Size.Text = "Meduim";
            // 
            // Toppings
            // 
            this.Toppings.AutoSize = true;
            this.Toppings.BackColor = System.Drawing.Color.Transparent;
            this.Toppings.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.Toppings.ForeColor = System.Drawing.Color.Navy;
            this.Toppings.Location = new System.Drawing.Point(803, 221);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(109, 40);
            this.Toppings.TabIndex = 25;
            this.Toppings.Text = "No Topping \r\n\r\n";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.TotalPrice.Location = new System.Drawing.Point(803, 446);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(59, 39);
            this.TotalPrice.TabIndex = 26;
            this.TotalPrice.Text = "0 $";
            // 
            // WhereToEat
            // 
            this.WhereToEat.AutoSize = true;
            this.WhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.WhereToEat.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.WhereToEat.ForeColor = System.Drawing.Color.Navy;
            this.WhereToEat.Location = new System.Drawing.Point(803, 353);
            this.WhereToEat.Name = "WhereToEat";
            this.WhereToEat.Size = new System.Drawing.Size(60, 20);
            this.WhereToEat.TabIndex = 27;
            this.WhereToEat.Text = "Eat In";
            // 
            // CrustType
            // 
            this.CrustType.AutoSize = true;
            this.CrustType.BackColor = System.Drawing.Color.Transparent;
            this.CrustType.Font = new System.Drawing.Font("Lucida Calligraphy", 9F);
            this.CrustType.ForeColor = System.Drawing.Color.Navy;
            this.CrustType.Location = new System.Drawing.Point(803, 290);
            this.CrustType.Name = "CrustType";
            this.CrustType.Size = new System.Drawing.Size(52, 20);
            this.CrustType.TabIndex = 28;
            this.CrustType.Text = "Thin ";
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetForm.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnResetForm.ForeColor = System.Drawing.Color.Black;
            this.btnResetForm.Location = new System.Drawing.Point(440, 521);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(157, 58);
            this.btnResetForm.TabIndex = 30;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.UseWaitCursor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrderPizza.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPizza.Location = new System.Drawing.Point(228, 521);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(1);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(157, 58);
            this.btnOrderPizza.TabIndex = 29;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.UseWaitCursor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSize.ForeColor = System.Drawing.Color.Black;
            this.lblSize.Location = new System.Drawing.Point(660, 159);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(57, 22);
            this.lblSize.TabIndex = 31;
            this.lblSize.Text = "Size  :";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Black;
            this.lblToppings.Location = new System.Drawing.Point(660, 225);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(100, 22);
            this.lblToppings.TabIndex = 32;
            this.lblToppings.Text = "Toppings : ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.Black;
            this.lblCrustType.Location = new System.Drawing.Point(660, 290);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(111, 22);
            this.lblCrustType.TabIndex = 33;
            this.lblCrustType.Text = "Crust Type  :";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.lblWhereToEat.Location = new System.Drawing.Point(660, 353);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(127, 22);
            this.lblWhereToEat.TabIndex = 34;
            this.lblWhereToEat.Text = "Where To Eat :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(660, 424);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(105, 22);
            this.lblTotalPrice.TabIndex = 35;
            this.lblTotalPrice.Text = "TotalPrice  :";
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 699);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblWhereToEat);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.CrustType);
            this.Controls.Add(this.WhereToEat);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Toppings);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbWherToEat);
            this.Controls.Add(this.grCrustType);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "PizzaOrder";
            this.Text = "PizzaOrder";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbWherToEat.ResumeLayout(false);
            this.gbWherToEat.PerformLayout();
            this.grCrustType.ResumeLayout(false);
            this.grCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbWherToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox grCrustType;
        private System.Windows.Forms.RadioButton rbCrustThick;
        private System.Windows.Forms.RadioButton rbCrustThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbExtraChees;
        private System.Windows.Forms.CheckBox chbGreenPeppers;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.Label Toppings;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label WhereToEat;
        private System.Windows.Forms.Label CrustType;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}