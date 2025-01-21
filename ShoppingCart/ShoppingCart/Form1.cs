namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        Item itemCoffe = new Item();
        Item itemGreenTea = new Item();
        Item itemNoodle = new Item();
        Item itemPizza = new Item();
        public Form1()
        {
            InitializeComponent();

            //add data to object
            itemCoffe.name = "Coffe";
            itemCoffe.price = 175;
            itemCoffe.quantity = 0;

            itemGreenTea.name = "GreenTea";
            itemGreenTea.price = 150;
            itemGreenTea.quantity = 0;

            itemNoodle.name = "Noodle";
            itemNoodle.price = 50;
            itemNoodle.quantity = 0;

            itemPizza.name = "Pizza";
            itemPizza.price = 199;
            itemPizza.quantity = 0;

            //display data
            tbCoffePrice.Text = itemCoffe.price.ToString();
            tbCoffeQuantity.Text = itemCoffe.quantity.ToString();

            tbGreenTeaPrice.Text = itemGreenTea.price.ToString();
            tbGreenTeaQuantity.Text = itemGreenTea.quantity.ToString();
            
            tbNoodlePrice.Text = itemNoodle.price.ToString();
            tbNoodleQuantity.Text = itemNoodle.quantity.ToString();
            
            tbPizzaPrice.Text = itemPizza.price.ToString();
            tbPizzaQuantity.Text = itemPizza.quantity.ToString();
        }


        //Function or Method
        // 1. return data
        // 2. no return data
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double dCash = double.Parse(tbCash.Text);

                double dBeverageTotal = 0;
                double dFoodTotal = 0;

                if (chbCoffe.Checked) 
                {
                    dBeverageTotal += GetItemTotal(tbCoffePrice.Text, tbCoffeQuantity.Text);
                }
                if (chbGreenTea.Checked)
                {
                    dBeverageTotal += GetItemTotal(tbGreenTeaPrice.Text, tbGreenTeaQuantity.Text);
                }

                if (chbNoodle.Checked)
                {
                    dFoodTotal += GetItemTotal(tbNoodlePrice.Text, tbNoodleQuantity.Text);
                }
                if (chbPizza.Checked)
                {
                    dFoodTotal += GetItemTotal(tbPizzaPrice.Text, tbPizzaQuantity.Text);
                }

                double dGrandTotal = dBeverageTotal + dFoodTotal;

                double dTotalDiscount = CalculateTotalDiscount(dBeverageTotal, dFoodTotal, dGrandTotal);

                dGrandTotal -= dTotalDiscount;

                if (dCash < dGrandTotal)
                {
                    MessageBox.Show("เงินสดไม่เพียงพอ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double dChange = dCash - dGrandTotal;

                //Display
                tbTotal.Text = dGrandTotal.ToString("F2");
                tbChange.Text = dChange.ToString("F2");

                CalculateChangeDenominations(dChange);
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกข้อมูลตัวเลขให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetItemTotal(string priceText, string quantityText)
        {
            double price = 0; 
            double quantity = 0;
            try
            {
                price = double.Parse(priceText);
                quantity = double.Parse(quantityText);
            }
            catch (Exception)
            {
                price = 0;
                quantity = 0;
            }
            return price * quantity;
        }
        private double CalculateTotalDiscount(double dBeverageTotal, double dFoodTotal, double dGrandTotal)
        {
            double dDiscountBev = chbDiscountBev.Checked ? double.Parse(tbDiscountBev.Text) : 0;
            double dDiscountFood = chbDiscountFood.Checked ? double.Parse(tbDiscountFood.Text) : 0;
            double dDiscountAll = chbDiscountAll.Checked ? double.Parse(tbDiscountAll.Text) : 0;

            double dTotalDiscount = (dBeverageTotal * dDiscountBev / 100) + (dFoodTotal * dDiscountFood / 100) + (dGrandTotal * dDiscountAll / 100);

            return dTotalDiscount;
        }

        private void CalculateChangeDenominations(double change)
        {
            double[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1, 0.50, 0.25 };
            int[] changeCount = new int[denominations.Length];
            double remainChange = change;

            for (int i = 0; i < denominations.Length; i++)
            {
                changeCount[i] = (int)(remainChange / denominations[i]);
                remainChange %= denominations[i];
            }

            tb1000.Text = changeCount[0].ToString();
            tb500.Text = changeCount[1].ToString();
            tb100.Text = changeCount[2].ToString();
            tb50.Text = changeCount[3].ToString();
            tb20.Text = changeCount[4].ToString();
            tb10.Text = changeCount[5].ToString();
            tb5.Text = changeCount[6].ToString();
            tb1.Text = changeCount[7].ToString();
            tb050.Text = changeCount[8].ToString();
            tb025.Text = changeCount[9].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbCoffe_ChekedChanged(object sender, EventArgs e)
        {
            itemCoffe.isCheck = chbCoffe.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
