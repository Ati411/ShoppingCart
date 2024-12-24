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
            SuspendLayout();
            // 
            // chbCoffe
            // 
            chbCoffe.AutoSize = true;
            chbCoffe.Location = new Point(12, 27);
            chbCoffe.Name = "chbCoffe";
            chbCoffe.Size = new Size(55, 19);
            chbCoffe.TabIndex = 0;
            chbCoffe.Text = "Coffe";
            chbCoffe.UseVisualStyleBackColor = true;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(12, 56);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(74, 19);
            chbGreenTea.TabIndex = 1;
            chbGreenTea.Text = "GreenTea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // tbCoffePrice
            // 
            tbCoffePrice.Location = new Point(113, 25);
            tbCoffePrice.Name = "tbCoffePrice";
            tbCoffePrice.Size = new Size(100, 23);
            tbCoffePrice.TabIndex = 2;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(113, 54);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 3;
            // 
            // tbCoffeQuantity
            // 
            tbCoffeQuantity.Location = new Point(229, 25);
            tbCoffeQuantity.Name = "tbCoffeQuantity";
            tbCoffeQuantity.Size = new Size(100, 23);
            tbCoffeQuantity.TabIndex = 4;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(229, 54);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 5;
            // 
            // btcheckout
            // 
            btcheckout.Location = new Point(345, 25);
            btcheckout.Name = "btcheckout";
            btcheckout.Size = new Size(120, 178);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 378);
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
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbCoffeQuantity);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(tbCoffePrice);
            Controls.Add(chbGreenTea);
            Controls.Add(chbCoffe);
            Name = "Form1";
            Text = "Ati";
            Load += Form1_Load;
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
    }
}
