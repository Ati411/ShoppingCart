namespace shoppingcart_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chbCoffe = new CheckBox();
            chbGreenTea = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            tbCoffePrice = new TextBox();
            tbCoffeQuantity = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            tbPizzaQuantity = new TextBox();
            chbNoodle = new CheckBox();
            tbPizzaPrice = new TextBox();
            chbPizza = new CheckBox();
            tbNoodleQuantity = new TextBox();
            label4 = new Label();
            tbNoodlePrice = new TextBox();
            groupBox3 = new GroupBox();
            chbDiscountFood = new CheckBox();
            label7 = new Label();
            tbDiscountFood = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbDiscountBev = new TextBox();
            chbDiscountAll = new CheckBox();
            chbDiscountBev = new CheckBox();
            tbDiscountAll = new TextBox();
            button1 = new Button();
            tbCash = new TextBox();
            lbCash = new Label();
            button2 = new Button();
            tbTotal = new TextBox();
            tb025 = new TextBox();
            tb050 = new TextBox();
            tb1 = new TextBox();
            tb5 = new TextBox();
            tb10 = new TextBox();
            tb20 = new TextBox();
            tb50 = new TextBox();
            tb100 = new TextBox();
            tb500 = new TextBox();
            tb1000 = new TextBox();
            tbChange = new TextBox();
            lbTotal = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // chbCoffe
            // 
            chbCoffe.AutoSize = true;
            chbCoffe.Location = new Point(2, 43);
            chbCoffe.Name = "chbCoffe";
            chbCoffe.Size = new Size(55, 19);
            chbCoffe.TabIndex = 0;
            chbCoffe.Text = "Coffe";
            chbCoffe.UseVisualStyleBackColor = true;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(2, 82);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(77, 19);
            chbGreenTea.TabIndex = 1;
            chbGreenTea.Text = "Green Tea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 9);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // tbCoffePrice
            // 
            tbCoffePrice.Location = new Point(91, 41);
            tbCoffePrice.Name = "tbCoffePrice";
            tbCoffePrice.Size = new Size(100, 23);
            tbCoffePrice.TabIndex = 4;
            // 
            // tbCoffeQuantity
            // 
            tbCoffeQuantity.Location = new Point(206, 41);
            tbCoffeQuantity.Name = "tbCoffeQuantity";
            tbCoffeQuantity.Size = new Size(100, 23);
            tbCoffeQuantity.TabIndex = 5;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(91, 78);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 6;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(206, 78);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbGreenTeaQuantity);
            groupBox1.Controls.Add(chbCoffe);
            groupBox1.Controls.Add(tbGreenTeaPrice);
            groupBox1.Controls.Add(chbGreenTea);
            groupBox1.Controls.Add(tbCoffeQuantity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbCoffePrice);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 113);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverage";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbPizzaQuantity);
            groupBox2.Controls.Add(chbNoodle);
            groupBox2.Controls.Add(tbPizzaPrice);
            groupBox2.Controls.Add(chbPizza);
            groupBox2.Controls.Add(tbNoodleQuantity);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbNoodlePrice);
            groupBox2.Location = new Point(14, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 113);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 9);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(206, 78);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(100, 23);
            tbPizzaQuantity.TabIndex = 7;
            // 
            // chbNoodle
            // 
            chbNoodle.AutoSize = true;
            chbNoodle.Location = new Point(2, 43);
            chbNoodle.Name = "chbNoodle";
            chbNoodle.Size = new Size(65, 19);
            chbNoodle.TabIndex = 0;
            chbNoodle.Text = "Noodle";
            chbNoodle.UseVisualStyleBackColor = true;
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(91, 78);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.Size = new Size(100, 23);
            tbPizzaPrice.TabIndex = 6;
            // 
            // chbPizza
            // 
            chbPizza.AutoSize = true;
            chbPizza.Location = new Point(2, 82);
            chbPizza.Name = "chbPizza";
            chbPizza.Size = new Size(52, 19);
            chbPizza.TabIndex = 1;
            chbPizza.Text = "Pizza";
            chbPizza.UseVisualStyleBackColor = true;
            // 
            // tbNoodleQuantity
            // 
            tbNoodleQuantity.Location = new Point(206, 41);
            tbNoodleQuantity.Name = "tbNoodleQuantity";
            tbNoodleQuantity.Size = new Size(100, 23);
            tbNoodleQuantity.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 9);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // tbNoodlePrice
            // 
            tbNoodlePrice.Location = new Point(91, 41);
            tbNoodlePrice.Name = "tbNoodlePrice";
            tbNoodlePrice.Size = new Size(100, 23);
            tbNoodlePrice.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chbDiscountFood);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(tbDiscountFood);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(tbDiscountBev);
            groupBox3.Controls.Add(chbDiscountAll);
            groupBox3.Controls.Add(chbDiscountBev);
            groupBox3.Controls.Add(tbDiscountAll);
            groupBox3.Location = new Point(12, 288);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(324, 182);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Discount";
            // 
            // chbDiscountFood
            // 
            chbDiscountFood.AutoSize = true;
            chbDiscountFood.Location = new Point(2, 124);
            chbDiscountFood.Name = "chbDiscountFood";
            chbDiscountFood.Size = new Size(53, 19);
            chbDiscountFood.TabIndex = 12;
            chbDiscountFood.Text = "Food";
            chbDiscountFood.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(273, 125);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 11;
            label7.Text = "%";
            // 
            // tbDiscountFood
            // 
            tbDiscountFood.Location = new Point(118, 122);
            tbDiscountFood.Name = "tbDiscountFood";
            tbDiscountFood.Size = new Size(147, 23);
            tbDiscountFood.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 83);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 9;
            label6.Text = "%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 43);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 8;
            label5.Text = "%";
            label5.Click += label5_Click;
            // 
            // tbDiscountBev
            // 
            tbDiscountBev.Location = new Point(120, 80);
            tbDiscountBev.Name = "tbDiscountBev";
            tbDiscountBev.Size = new Size(147, 23);
            tbDiscountBev.TabIndex = 7;
            // 
            // chbDiscountAll
            // 
            chbDiscountAll.AutoSize = true;
            chbDiscountAll.Location = new Point(2, 43);
            chbDiscountAll.Name = "chbDiscountAll";
            chbDiscountAll.Size = new Size(40, 19);
            chbDiscountAll.TabIndex = 0;
            chbDiscountAll.Text = "All";
            chbDiscountAll.UseVisualStyleBackColor = true;
            // 
            // chbDiscountBev
            // 
            chbDiscountBev.AutoSize = true;
            chbDiscountBev.Location = new Point(2, 82);
            chbDiscountBev.Name = "chbDiscountBev";
            chbDiscountBev.Size = new Size(74, 19);
            chbDiscountBev.TabIndex = 1;
            chbDiscountBev.Text = "Beverage";
            chbDiscountBev.UseVisualStyleBackColor = true;
            // 
            // tbDiscountAll
            // 
            tbDiscountAll.Location = new Point(120, 41);
            tbDiscountAll.Name = "tbDiscountAll";
            tbDiscountAll.Size = new Size(147, 23);
            tbDiscountAll.TabIndex = 5;
            tbDiscountAll.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(368, 21);
            button1.Name = "button1";
            button1.Size = new Size(125, 449);
            button1.TabIndex = 11;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbCash
            // 
            tbCash.Location = new Point(550, 39);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(100, 23);
            tbCash.TabIndex = 8;
            // 
            // lbCash
            // 
            lbCash.AutoSize = true;
            lbCash.Location = new Point(583, 21);
            lbCash.Name = "lbCash";
            lbCash.Size = new Size(33, 15);
            lbCash.TabIndex = 8;
            lbCash.Text = "Cash";
            // 
            // button2
            // 
            button2.Location = new Point(689, 19);
            button2.Name = "button2";
            button2.Size = new Size(108, 84);
            button2.TabIndex = 12;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(666, 123);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(131, 23);
            tbTotal.TabIndex = 13;
            // 
            // tb025
            // 
            tb025.Location = new Point(666, 442);
            tb025.Name = "tb025";
            tb025.Size = new Size(131, 23);
            tb025.TabIndex = 14;
            // 
            // tb050
            // 
            tb050.Location = new Point(666, 413);
            tb050.Name = "tb050";
            tb050.Size = new Size(131, 23);
            tb050.TabIndex = 15;
            // 
            // tb1
            // 
            tb1.Location = new Point(666, 384);
            tb1.Name = "tb1";
            tb1.Size = new Size(131, 23);
            tb1.TabIndex = 16;
            // 
            // tb5
            // 
            tb5.Location = new Point(666, 355);
            tb5.Name = "tb5";
            tb5.Size = new Size(131, 23);
            tb5.TabIndex = 17;
            // 
            // tb10
            // 
            tb10.Location = new Point(666, 326);
            tb10.Name = "tb10";
            tb10.Size = new Size(131, 23);
            tb10.TabIndex = 18;
            // 
            // tb20
            // 
            tb20.Location = new Point(666, 297);
            tb20.Name = "tb20";
            tb20.Size = new Size(131, 23);
            tb20.TabIndex = 19;
            // 
            // tb50
            // 
            tb50.Location = new Point(666, 268);
            tb50.Name = "tb50";
            tb50.Size = new Size(131, 23);
            tb50.TabIndex = 20;
            // 
            // tb100
            // 
            tb100.Location = new Point(666, 239);
            tb100.Name = "tb100";
            tb100.Size = new Size(131, 23);
            tb100.TabIndex = 21;
            // 
            // tb500
            // 
            tb500.Location = new Point(666, 210);
            tb500.Name = "tb500";
            tb500.Size = new Size(131, 23);
            tb500.TabIndex = 22;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(666, 181);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(131, 23);
            tb1000.TabIndex = 23;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(666, 152);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(131, 23);
            tbChange.TabIndex = 24;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(583, 126);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(32, 15);
            lbTotal.TabIndex = 25;
            lbTotal.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(583, 184);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 26;
            label9.Text = "1000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(583, 155);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 27;
            label10.Text = "Change";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(583, 213);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 28;
            label11.Text = "500";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(583, 242);
            label12.Name = "label12";
            label12.Size = new Size(25, 15);
            label12.TabIndex = 29;
            label12.Text = "100";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(583, 271);
            label13.Name = "label13";
            label13.Size = new Size(19, 15);
            label13.TabIndex = 30;
            label13.Text = "50";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(583, 300);
            label14.Name = "label14";
            label14.Size = new Size(19, 15);
            label14.TabIndex = 31;
            label14.Text = "20";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(583, 329);
            label15.Name = "label15";
            label15.Size = new Size(19, 15);
            label15.TabIndex = 32;
            label15.Text = "10";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(583, 358);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 33;
            label16.Text = "5";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(583, 387);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 34;
            label17.Text = "1";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(583, 416);
            label18.Name = "label18";
            label18.Size = new Size(28, 15);
            label18.TabIndex = 35;
            label18.Text = "0.50";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(583, 445);
            label19.Name = "label19";
            label19.Size = new Size(28, 15);
            label19.TabIndex = 36;
            label19.Text = "0.25";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 494);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lbTotal);
            Controls.Add(tbChange);
            Controls.Add(tb1000);
            Controls.Add(tb500);
            Controls.Add(tb100);
            Controls.Add(tb50);
            Controls.Add(tb20);
            Controls.Add(tb10);
            Controls.Add(tb5);
            Controls.Add(tb1);
            Controls.Add(tb050);
            Controls.Add(tb025);
            Controls.Add(tbTotal);
            Controls.Add(button2);
            Controls.Add(lbCash);
            Controls.Add(tbCash);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbCoffe;
        private CheckBox chbGreenTea;
        private Label label1;
        private Label label2;
        private TextBox tbCoffePrice;
        private TextBox tbCoffeQuantity;
        private TextBox tbGreenTeaPrice;
        private TextBox tbGreenTeaQuantity;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox tbPizzaQuantity;
        private CheckBox chbNoodle;
        private TextBox tbPizzaPrice;
        private CheckBox chbPizza;
        private TextBox tbNoodleQuantity;
        private Label label4;
        private TextBox tbNoodlePrice;
        private GroupBox groupBox3;
        private TextBox tbDiscountBev;
        private CheckBox chbDiscountAll;
        private CheckBox chbDiscountBev;
        private TextBox tbDiscountAll;
        private Label label5;
        private CheckBox chbDiscountFood;
        private Label label7;
        private TextBox tbDiscountFood;
        private Label label6;
        private Button button1;
        private TextBox tbCash;
        private Label lbCash;
        private Button button2;
        private TextBox tbTotal;
        private TextBox tb025;
        private TextBox tb050;
        private TextBox tb1;
        private TextBox tb5;
        private TextBox tb10;
        private TextBox tb20;
        private TextBox tb50;
        private TextBox tb100;
        private TextBox tb500;
        private TextBox tb1000;
        private TextBox tbChange;
        private Label lbTotal;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
    }
}
