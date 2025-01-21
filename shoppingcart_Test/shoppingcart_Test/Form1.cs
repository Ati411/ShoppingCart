namespace shoppingcart_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate total price from selected items
        double getPriceFromSelectedItems()
        {
            // Retrieve prices and quantities
            double coffeePrice = chbCoffe.Checked ? double.Parse(tbCoffePrice.Text) : 0;
            double coffeeQuantity = chbCoffe.Checked ? double.Parse(tbCoffeQuantity.Text) : 0;
            double greenTeaPrice = chbGreenTea.Checked ? double.Parse(tbGreenTeaPrice.Text) : 0;
            double greenTeaQuantity = chbGreenTea.Checked ? double.Parse(tbGreenTeaQuantity.Text) : 0;
            double noodlePrice = chbNoodle.Checked ? double.Parse(tbNoodlePrice.Text) : 0;
            double noodleQuantity = chbNoodle.Checked ? double.Parse(tbNoodleQuantity.Text) : 0;
            double pizzaPrice = chbPizza.Checked ? double.Parse(tbPizzaPrice.Text) : 0;
            double pizzaQuantity = chbPizza.Checked ? double.Parse(tbPizzaQuantity.Text) : 0;

            // Calculate totals
            double totalCoffee = coffeePrice * coffeeQuantity;
            double totalGreenTea = greenTeaPrice * greenTeaQuantity;
            double totalNoodle = noodlePrice * noodleQuantity;
            double totalPizza = pizzaPrice * pizzaQuantity;

            double total = totalCoffee + totalGreenTea + totalNoodle + totalPizza;

            // Display the total
            tbTotal.Text = total.ToString("F2");
            return total;
        }

        // Calculate final price after discount
        double getDiscountPrice(double total)
        {
            double discountAll = chbDiscountAll.Checked ? double.Parse(tbDiscountAll.Text) : 0;
            double discountBeverage = chbDiscountBev.Checked ? double.Parse(tbDiscountBev.Text) : 0;
            double discountFood = chbDiscountFood.Checked ? double.Parse(tbDiscountFood.Text) : 0;

            double beverageTotal = (chbCoffe.Checked ? double.Parse(tbCoffePrice.Text) * double.Parse(tbCoffeQuantity.Text) : 0) +
                                   (chbGreenTea.Checked ? double.Parse(tbGreenTeaPrice.Text) * double.Parse(tbGreenTeaQuantity.Text) : 0);

            double foodTotal = (chbNoodle.Checked ? double.Parse(tbNoodlePrice.Text) * double.Parse(tbNoodleQuantity.Text) : 0) +
                               (chbPizza.Checked ? double.Parse(tbPizzaPrice.Text) * double.Parse(tbPizzaQuantity.Text) : 0);


            double discountedBeverage = beverageTotal - (beverageTotal * discountBeverage / 100);
            double discountedFood = foodTotal - (foodTotal * discountFood / 100);


            double discountedTotal = (discountedBeverage + discountedFood) - ((discountedBeverage + discountedFood) * discountAll / 100);

            return discountedTotal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTotal.Text = getPriceFromSelectedItems().ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double total = getPriceFromSelectedItems();
                double discountedTotal = getDiscountPrice(total);
                double cash = double.Parse(tbCash.Text);

                if (cash < discountedTotal)
                {
                    MessageBox.Show("Insufficient cash provided.");
                    return;
                }

                double change = cash - discountedTotal;

                // Calculate change in denominations
                double[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1, 0.50, 0.25 };
                TextBox[] denominationTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1, tb050, tb025 };

                foreach (var textBox in denominationTextBoxes)
                {
                    textBox.Text = "0";
                }

                for (int i = 0; i < denominations.Length; i++)
                {
                    int count = (int)(change / denominations[i]);
                    if (count > 0)
                    {
                        denominationTextBoxes[i].Text = count.ToString();
                        change %= denominations[i];
                    }
                }

                tbChange.Text = (cash - discountedTotal).ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
