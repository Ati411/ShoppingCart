namespace ShoppingCart
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
            tbCoffePrice = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbCoffeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            btcheckout = new Button();
            tbTotal = new TextBox();
            lbTotal = new Label();
            tbCash = new TextBox();
            tb1000 = new TextBox();
            tbChange = new TextBox();
            lbCash = new Label();
            tb500 = new TextBox();
            tb100 = new TextBox();
            tb50 = new TextBox();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            lbChange = new Label();
            lb1000 = new Label();
            lb500 = new Label();
            lb100 = new Label();
            lb50 = new Label();
            lb20 = new Label();
            lb10 = new Label();
            lb5 = new Label();
            lb1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            chbNoodle = new CheckBox();
            chbPizza = new CheckBox();
            tbNoodlePrice = new TextBox();
            tbPizzaPrice = new TextBox();
            tbNoodleQuantity = new TextBox();
            tbPizzaQuantity = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chbDiscountAll = new CheckBox();
            tbDiscountFood = new TextBox();
            chbDiscountBev = new CheckBox();
            chbDiscountFood = new CheckBox();
            tbDiscountAll = new TextBox();
            tbDiscountBev = new TextBox();
            tb025 = new TextBox();
            tb050 = new TextBox();
            lb025 = new Label();
            lb050 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // chbCoffe
            // 
            chbCoffe.AutoSize = true;
            chbCoffe.Location = new Point(0, 22);
            chbCoffe.Name = "chbCoffe";
            chbCoffe.Size = new Size(55, 19);
            chbCoffe.TabIndex = 0;
            chbCoffe.Text = "Coffe";
            chbCoffe.UseVisualStyleBackColor = true;
            chbCoffe.CheckedChanged += chbCoffe_ChekedChanged;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(0, 51);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(74, 19);
            chbGreenTea.TabIndex = 1;
            chbGreenTea.Text = "GreenTea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // tbCoffePrice
            // 
            tbCoffePrice.Location = new Point(101, 20);
            tbCoffePrice.Name = "tbCoffePrice";
            tbCoffePrice.ReadOnly = true;
            tbCoffePrice.Size = new Size(100, 23);
            tbCoffePrice.TabIndex = 2;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(101, 49);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.ReadOnly = true;
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 3;
            // 
            // tbCoffeQuantity
            // 
            tbCoffeQuantity.Location = new Point(217, 20);
            tbCoffeQuantity.Name = "tbCoffeQuantity";
            tbCoffeQuantity.Size = new Size(100, 23);
            tbCoffeQuantity.TabIndex = 4;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(217, 49);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 5;
            // 
            // btcheckout
            // 
            btcheckout.Location = new Point(368, 12);
            btcheckout.Name = "btcheckout";
            btcheckout.Size = new Size(120, 386);
            btcheckout.TabIndex = 6;
            btcheckout.Text = "Check Out";
            btcheckout.UseVisualStyleBackColor = true;
            btcheckout.Click += button1_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(579, 27);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 7;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(510, 28);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(32, 15);
            lbTotal.TabIndex = 8;
            lbTotal.Text = "Total";
            // 
            // tbCash
            // 
            tbCash.Location = new Point(579, 56);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(100, 23);
            tbCash.TabIndex = 10;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(579, 114);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(100, 23);
            tb1000.TabIndex = 11;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(579, 85);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(100, 23);
            tbChange.TabIndex = 12;
            // 
            // lbCash
            // 
            lbCash.AutoSize = true;
            lbCash.Location = new Point(510, 59);
            lbCash.Name = "lbCash";
            lbCash.Size = new Size(33, 15);
            lbCash.TabIndex = 13;
            lbCash.Text = "Cash";
            lbCash.Click += label1_Click;
            // 
            // tb500
            // 
            tb500.Location = new Point(579, 143);
            tb500.Name = "tb500";
            tb500.Size = new Size(100, 23);
            tb500.TabIndex = 14;
            // 
            // tb100
            // 
            tb100.Location = new Point(579, 172);
            tb100.Name = "tb100";
            tb100.Size = new Size(100, 23);
            tb100.TabIndex = 15;
            // 
            // tb50
            // 
            tb50.Location = new Point(579, 201);
            tb50.Name = "tb50";
            tb50.Size = new Size(100, 23);
            tb50.TabIndex = 16;
            // 
            // tb20
            // 
            tb20.Location = new Point(579, 230);
            tb20.Name = "tb20";
            tb20.Size = new Size(100, 23);
            tb20.TabIndex = 17;
            // 
            // tb10
            // 
            tb10.Location = new Point(579, 259);
            tb10.Name = "tb10";
            tb10.Size = new Size(100, 23);
            tb10.TabIndex = 18;
            // 
            // tb5
            // 
            tb5.Location = new Point(579, 288);
            tb5.Name = "tb5";
            tb5.Size = new Size(100, 23);
            tb5.TabIndex = 19;
            // 
            // tb1
            // 
            tb1.Location = new Point(579, 317);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 20;
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.Location = new Point(510, 88);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(48, 15);
            lbChange.TabIndex = 21;
            lbChange.Text = "Change";
            // 
            // lb1000
            // 
            lb1000.AutoSize = true;
            lb1000.Location = new Point(510, 117);
            lb1000.Name = "lb1000";
            lb1000.Size = new Size(31, 15);
            lb1000.TabIndex = 22;
            lb1000.Text = "1000";
            // 
            // lb500
            // 
            lb500.AutoSize = true;
            lb500.Location = new Point(510, 146);
            lb500.Name = "lb500";
            lb500.Size = new Size(25, 15);
            lb500.TabIndex = 23;
            lb500.Text = "500";
            // 
            // lb100
            // 
            lb100.AutoSize = true;
            lb100.Location = new Point(510, 175);
            lb100.Name = "lb100";
            lb100.Size = new Size(25, 15);
            lb100.TabIndex = 24;
            lb100.Text = "100";
            // 
            // lb50
            // 
            lb50.AutoSize = true;
            lb50.Location = new Point(510, 204);
            lb50.Name = "lb50";
            lb50.Size = new Size(19, 15);
            lb50.TabIndex = 25;
            lb50.Text = "50";
            // 
            // lb20
            // 
            lb20.AutoSize = true;
            lb20.Location = new Point(510, 233);
            lb20.Name = "lb20";
            lb20.Size = new Size(19, 15);
            lb20.TabIndex = 26;
            lb20.Text = "20";
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new Point(510, 262);
            lb10.Name = "lb10";
            lb10.Size = new Size(19, 15);
            lb10.TabIndex = 27;
            lb10.Text = "10";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(510, 291);
            lb5.Name = "lb5";
            lb5.Size = new Size(13, 15);
            lb5.TabIndex = 28;
            lb5.Text = "5";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(510, 320);
            lb1.Name = "lb1";
            lb1.Size = new Size(13, 15);
            lb1.TabIndex = 29;
            lb1.Text = "1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chbCoffe);
            groupBox1.Controls.Add(chbGreenTea);
            groupBox1.Controls.Add(tbCoffePrice);
            groupBox1.Controls.Add(tbGreenTeaPrice);
            groupBox1.Controls.Add(tbCoffeQuantity);
            groupBox1.Controls.Add(tbGreenTeaQuantity);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 91);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverage";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chbNoodle);
            groupBox2.Controls.Add(chbPizza);
            groupBox2.Controls.Add(tbNoodlePrice);
            groupBox2.Controls.Add(tbPizzaPrice);
            groupBox2.Controls.Add(tbNoodleQuantity);
            groupBox2.Controls.Add(tbPizzaQuantity);
            groupBox2.Location = new Point(12, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(317, 91);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // chbNoodle
            // 
            chbNoodle.AutoSize = true;
            chbNoodle.Location = new Point(0, 22);
            chbNoodle.Name = "chbNoodle";
            chbNoodle.Size = new Size(65, 19);
            chbNoodle.TabIndex = 0;
            chbNoodle.Text = "Noodle";
            chbNoodle.UseVisualStyleBackColor = true;
            // 
            // chbPizza
            // 
            chbPizza.AutoSize = true;
            chbPizza.Location = new Point(0, 51);
            chbPizza.Name = "chbPizza";
            chbPizza.Size = new Size(52, 19);
            chbPizza.TabIndex = 1;
            chbPizza.Text = "Pizza";
            chbPizza.UseVisualStyleBackColor = true;
            // 
            // tbNoodlePrice
            // 
            tbNoodlePrice.Location = new Point(101, 20);
            tbNoodlePrice.Name = "tbNoodlePrice";
            tbNoodlePrice.ReadOnly = true;
            tbNoodlePrice.Size = new Size(100, 23);
            tbNoodlePrice.TabIndex = 2;
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(101, 49);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.ReadOnly = true;
            tbPizzaPrice.Size = new Size(100, 23);
            tbPizzaPrice.TabIndex = 3;
            // 
            // tbNoodleQuantity
            // 
            tbNoodleQuantity.Location = new Point(217, 20);
            tbNoodleQuantity.Name = "tbNoodleQuantity";
            tbNoodleQuantity.Size = new Size(100, 23);
            tbNoodleQuantity.TabIndex = 4;
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(217, 49);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(100, 23);
            tbPizzaQuantity.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(chbDiscountAll);
            groupBox3.Controls.Add(tbDiscountFood);
            groupBox3.Controls.Add(chbDiscountBev);
            groupBox3.Controls.Add(chbDiscountFood);
            groupBox3.Controls.Add(tbDiscountAll);
            groupBox3.Controls.Add(tbDiscountBev);
            groupBox3.Location = new Point(12, 220);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 120);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 81);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 35;
            label3.Text = "%";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 54);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 34;
            label2.Text = "%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 26);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 33;
            label1.Text = "%";
            // 
            // chbDiscountAll
            // 
            chbDiscountAll.AutoSize = true;
            chbDiscountAll.Location = new Point(61, 22);
            chbDiscountAll.Name = "chbDiscountAll";
            chbDiscountAll.Size = new Size(40, 19);
            chbDiscountAll.TabIndex = 7;
            chbDiscountAll.Text = "All";
            chbDiscountAll.UseVisualStyleBackColor = true;
            chbDiscountAll.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // tbDiscountFood
            // 
            tbDiscountFood.Location = new Point(217, 78);
            tbDiscountFood.Name = "tbDiscountFood";
            tbDiscountFood.Size = new Size(100, 23);
            tbDiscountFood.TabIndex = 6;
            // 
            // chbDiscountBev
            // 
            chbDiscountBev.AutoSize = true;
            chbDiscountBev.Location = new Point(61, 53);
            chbDiscountBev.Name = "chbDiscountBev";
            chbDiscountBev.Size = new Size(74, 19);
            chbDiscountBev.TabIndex = 0;
            chbDiscountBev.Text = "Beverage";
            chbDiscountBev.UseVisualStyleBackColor = true;
            // 
            // chbDiscountFood
            // 
            chbDiscountFood.AutoSize = true;
            chbDiscountFood.Location = new Point(61, 80);
            chbDiscountFood.Name = "chbDiscountFood";
            chbDiscountFood.Size = new Size(53, 19);
            chbDiscountFood.TabIndex = 1;
            chbDiscountFood.Text = "Food";
            chbDiscountFood.UseVisualStyleBackColor = true;
            chbDiscountFood.CheckedChanged += chbCoffe_ChekedChanged;
            // 
            // tbDiscountAll
            // 
            tbDiscountAll.Location = new Point(217, 20);
            tbDiscountAll.Name = "tbDiscountAll";
            tbDiscountAll.Size = new Size(100, 23);
            tbDiscountAll.TabIndex = 4;
            // 
            // tbDiscountBev
            // 
            tbDiscountBev.Location = new Point(217, 49);
            tbDiscountBev.Name = "tbDiscountBev";
            tbDiscountBev.Size = new Size(100, 23);
            tbDiscountBev.TabIndex = 5;
            // 
            // tb025
            // 
            tb025.Location = new Point(579, 375);
            tb025.Name = "tb025";
            tb025.Size = new Size(100, 23);
            tb025.TabIndex = 33;
            // 
            // tb050
            // 
            tb050.Location = new Point(579, 346);
            tb050.Name = "tb050";
            tb050.Size = new Size(100, 23);
            tb050.TabIndex = 34;
            // 
            // lb025
            // 
            lb025.AutoSize = true;
            lb025.Location = new Point(510, 378);
            lb025.Name = "lb025";
            lb025.Size = new Size(28, 15);
            lb025.TabIndex = 35;
            lb025.Text = "0.25";
            // 
            // lb050
            // 
            lb050.AutoSize = true;
            lb050.Location = new Point(510, 349);
            lb050.Name = "lb050";
            lb050.Size = new Size(28, 15);
            lb050.TabIndex = 36;
            lb050.Text = "0.50";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 414);
            Controls.Add(lb050);
            Controls.Add(lb025);
            Controls.Add(tb050);
            Controls.Add(tb025);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lb1);
            Controls.Add(lb5);
            Controls.Add(lb10);
            Controls.Add(lb20);
            Controls.Add(lb50);
            Controls.Add(lb100);
            Controls.Add(lb500);
            Controls.Add(lb1000);
            Controls.Add(lbChange);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(lbCash);
            Controls.Add(tbChange);
            Controls.Add(tb1000);
            Controls.Add(tbCash);
            Controls.Add(lbTotal);
            Controls.Add(tbTotal);
            Controls.Add(btcheckout);
            Name = "Form1";
            Text = "Ati";
            Load += Form1_Load;
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
        private TextBox tbCoffePrice;
        private TextBox tbGreenTeaPrice;
        private TextBox tbCoffeQuantity;
        private TextBox tbGreenTeaQuantity;
        private Button btcheckout;
        private TextBox tbTotal;
        private Label lbTotal;
        private TextBox tbCash;
        private TextBox tb1000;
        private TextBox tbChange;
        private Label lbCash;
        private TextBox tb500;
        private TextBox tb100;
        private TextBox tb50;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb5;
        private TextBox tb1;
        private Label lbChange;
        private Label lb1000;
        private Label lb500;
        private Label lb100;
        private Label lb50;
        private Label lb20;
        private Label lb10;
        private Label lb5;
        private Label lb1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chbNoodle;
        private CheckBox chbPizza;
        private TextBox tbNoodlePrice;
        private TextBox tbPizzaPrice;
        private TextBox tbNoodleQuantity;
        private TextBox tbPizzaQuantity;
        private GroupBox groupBox3;
        private TextBox tbDiscountFood;
        private CheckBox chbDiscountBev;
        private CheckBox chbDiscountFood;
        private TextBox tbDiscountAll;
        private TextBox tbDiscountBev;
        private CheckBox chbDiscountAll;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb025;
        private TextBox tb050;
        private Label lb025;
        private Label lb050;
    }
}
