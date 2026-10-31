namespace Project__8__Make_a_Pizza
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbextrachees = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtoppings = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbcurst = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbWheretoEat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.buOrder = new System.Windows.Forms.Button();
            this.buReset = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.howmanypizaa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLarge);
            this.groupBox1.Controls.Add(this.rbMeduim);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIZE";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(32, 161);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(88, 30);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "20";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rblarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Location = new System.Drawing.Point(32, 110);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(111, 30);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "15";
            this.rbMeduim.Text = "Medium";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbmeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(32, 49);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(85, 30);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbThick);
            this.groupBox2.Controls.Add(this.rbThin);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox2.Location = new System.Drawing.Point(12, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 190);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Curst Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(32, 111);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(142, 30);
            this.rbThick.TabIndex = 4;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(32, 51);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(127, 30);
            this.rbThin.TabIndex = 3;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "5";
            this.rbThin.Text = "Thin curst";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbGreenPeppers);
            this.groupBox3.Controls.Add(this.chbOlives);
            this.groupBox3.Controls.Add(this.chbOnion);
            this.groupBox3.Controls.Add(this.chbTomatoes);
            this.groupBox3.Controls.Add(this.chbMushrooms);
            this.groupBox3.Controls.Add(this.chbextrachees);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox3.Location = new System.Drawing.Point(314, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 197);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // chbGreenPeppers
            // 
            this.chbGreenPeppers.AutoSize = true;
            this.chbGreenPeppers.Location = new System.Drawing.Point(175, 151);
            this.chbGreenPeppers.Name = "chbGreenPeppers";
            this.chbGreenPeppers.Size = new System.Drawing.Size(181, 30);
            this.chbGreenPeppers.TabIndex = 10;
            this.chbGreenPeppers.Tag = "5";
            this.chbGreenPeppers.Text = "Green Peppers";
            this.chbGreenPeppers.UseVisualStyleBackColor = true;
            this.chbGreenPeppers.CheckedChanged += new System.EventHandler(this.chbGreenPeppers_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(175, 100);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(95, 30);
            this.chbOlives.TabIndex = 9;
            this.chbOlives.Tag = "5";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(178, 53);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(92, 30);
            this.chbOnion.TabIndex = 8;
            this.chbOnion.Tag = "5";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(6, 152);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(130, 30);
            this.chbTomatoes.TabIndex = 7;
            this.chbTomatoes.Tag = "5";
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Location = new System.Drawing.Point(6, 100);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(148, 30);
            this.chbMushrooms.TabIndex = 6;
            this.chbMushrooms.Tag = "5";
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.chbMushrooms_CheckedChanged);
            // 
            // chbextrachees
            // 
            this.chbextrachees.AutoSize = true;
            this.chbextrachees.Location = new System.Drawing.Point(6, 53);
            this.chbextrachees.Name = "chbextrachees";
            this.chbextrachees.Size = new System.Drawing.Size(166, 30);
            this.chbextrachees.TabIndex = 5;
            this.chbextrachees.Tag = "5";
            this.chbextrachees.Text = "Extra Cheese";
            this.chbextrachees.UseVisualStyleBackColor = true;
            this.chbextrachees.CheckedChanged += new System.EventHandler(this.chbextrachees_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbTakeOut);
            this.groupBox4.Controls.Add(this.rbEatin);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox4.Location = new System.Drawing.Point(320, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where TO Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(152, 41);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(121, 30);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbtakeout_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Checked = true;
            this.rbEatin.Location = new System.Drawing.Point(6, 41);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(90, 30);
            this.rbEatin.TabIndex = 0;
            this.rbEatin.TabStop = true;
            this.rbEatin.Text = "Eat In";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(701, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(735, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size:";
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbsize.Location = new System.Drawing.Point(812, 155);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(90, 26);
            this.lbsize.TabIndex = 7;
            this.lbsize.Text = "Medium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(722, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toppings :";
            // 
            // lbtoppings
            // 
            this.lbtoppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lbtoppings.Location = new System.Drawing.Point(724, 231);
            this.lbtoppings.Name = "lbtoppings";
            this.lbtoppings.Size = new System.Drawing.Size(281, 64);
            this.lbtoppings.TabIndex = 9;
            this.lbtoppings.Text = "No Toppings ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(702, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Curst Type :";
            // 
            // lbcurst
            // 
            this.lbcurst.AutoSize = true;
            this.lbcurst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbcurst.Location = new System.Drawing.Point(850, 304);
            this.lbcurst.Name = "lbcurst";
            this.lbcurst.Size = new System.Drawing.Size(111, 26);
            this.lbcurst.TabIndex = 11;
            this.lbcurst.Text = "Thin Curst";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(701, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Where To Eat:";
            // 
            // lbWheretoEat
            // 
            this.lbWheretoEat.AutoSize = true;
            this.lbWheretoEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbWheretoEat.Location = new System.Drawing.Point(851, 399);
            this.lbWheretoEat.Name = "lbWheretoEat";
            this.lbWheretoEat.Size = new System.Drawing.Size(56, 22);
            this.lbWheretoEat.TabIndex = 13;
            this.lbWheretoEat.Text = "Eat In";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(723, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Price";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F);
            this.lbprice.ForeColor = System.Drawing.Color.Lime;
            this.lbprice.Location = new System.Drawing.Point(797, 475);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(83, 59);
            this.lbprice.TabIndex = 15;
            this.lbprice.Text = "0$";
            // 
            // buOrder
            // 
            this.buOrder.Location = new System.Drawing.Point(314, 485);
            this.buOrder.Name = "buOrder";
            this.buOrder.Size = new System.Drawing.Size(136, 49);
            this.buOrder.TabIndex = 16;
            this.buOrder.Text = "Order Pizza";
            this.buOrder.UseVisualStyleBackColor = true;
            this.buOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // buReset
            // 
            this.buReset.Location = new System.Drawing.Point(511, 485);
            this.buReset.Name = "buReset";
            this.buReset.Size = new System.Drawing.Size(147, 49);
            this.buReset.TabIndex = 17;
            this.buReset.Text = "Reset Form";
            this.buReset.UseVisualStyleBackColor = true;
            this.buReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.numericUpDown1.Location = new System.Drawing.Point(432, 440);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 32);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label8.Location = new System.Drawing.Point(264, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "how many :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label9.Location = new System.Drawing.Point(702, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "how many :";
            // 
            // howmanypizaa
            // 
            this.howmanypizaa.AutoSize = true;
            this.howmanypizaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.howmanypizaa.Location = new System.Drawing.Point(832, 344);
            this.howmanypizaa.Name = "howmanypizaa";
            this.howmanypizaa.Size = new System.Drawing.Size(24, 26);
            this.howmanypizaa.TabIndex = 21;
            this.howmanypizaa.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 569);
            this.Controls.Add(this.howmanypizaa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buReset);
            this.Controls.Add(this.buOrder);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbWheretoEat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbcurst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbtoppings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbsize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIZZA FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbGreenPeppers;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbextrachees;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbsize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbtoppings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbcurst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbWheretoEat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Button buOrder;
        private System.Windows.Forms.Button buReset;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label howmanypizaa;
    }
}

