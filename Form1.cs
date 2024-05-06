using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BestOilHomework
{
    public partial class BestOilForm : Form
    {
        private decimal totalIncome = 0;
        private List<Product> gasolines =
            [
                new Product() { Name = "А-95", Price = 9.35m },
                new Product() { Name = "А-92", Price = 8.98m },
                new Product() { Name = "ДТ", Price = 10.20m }
            ];
        private List<Product> products =
            [
                new Product() { Name = "Хот-Дог", Price = 4.00m },
                new Product() { Name = "Гамбургер", Price = 5.40m },
                new Product() { Name = "Картошка", Price = 7.20m },
                new Product() { Name = "Кока-Кола", Price = 4.40m }
            ];
        private Cart cart = new Cart();
        public BestOilForm()
        {
            InitializeComponent();

            FillMiniCafe();
        }
        private void FillMiniCafe()
        {
            int top = 60;
            int left = 20;
            for (int i = 0; i < products.Count; i++)
            {
                CheckBox checkBox = new CheckBox()
                {
                    Name = $"CheckBox-{products[i].Id}",
                    Text = products[i].Name,
                    Location = new Point(left, top)
                };

                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                TextBox textBox = new TextBox()
                {
                    Text = products[i].Price.ToString(),
                    Enabled = false,
                    Width = 40,
                    Location = new Point(left + checkBox.Width + 10, top)
                };

                NumericUpDown numericUpDown = new NumericUpDown()
                {
                    Name = $"Numeric-{products[i].Id}",
                    Minimum = 0,
                    Enabled = false,
                    Width = 40,
                    Location = new Point(left + checkBox.Width + textBox.Width + 35, top)
                };

                numericUpDown.ValueChanged += NumericUpDown_ValueChanged;

                miniCafeGroupBox.Controls.Add(checkBox);
                miniCafeGroupBox.Controls.Add(textBox);
                miniCafeGroupBox.Controls.Add(numericUpDown);

                top += checkBox.Height + 5;
            }
        }

        private void NumericUpDown_ValueChanged(object? sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;
            string id = numeric.Name.Substring(numeric.Name.IndexOf('-') + 1);
            cart.ChangeAmount(id, (int)numeric.Value);
            totalMiniCafePriceLabel.Text = cart.TotalMiniCafe.ToString();
            totalToPayLabel.Text = cart.TotalToPay.ToString();
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string id = checkBox.Name.Substring(checkBox.Name.IndexOf('-') + 1);
            var numeric = miniCafeGroupBox.Controls.OfType<NumericUpDown>().FirstOrDefault(e => e.Name.Equals($"Numeric-{id}"));
            if (checkBox.Checked)
            {
                numeric.Enabled = true;
                numeric.Value = 1;
                cart.AddProduct(products.FirstOrDefault(e => e.Id.Equals(id)));
            }
            else
            {
                numeric.Enabled = false;
                numeric.Value = 0;
                cart.RemoveProduct(products.FirstOrDefault(e => e.Id.Equals(id)));
            }
            totalMiniCafePriceLabel.Text = cart.TotalMiniCafe.ToString();
            totalToPayLabel.Text = cart.TotalToPay.ToString();
        }

        private void BestOilForm_Load(object sender, EventArgs e)
        {
            gasolinesComboBox.DataSource = gasolines;
            gasolinesComboBox.SelectedIndex = 0;
            var gasoline = gasolinesComboBox.SelectedValue as Product;
            priceTextBox.Text = gasoline?.Price.ToString();

        }

        private void gasolinesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gasoline = gasolinesComboBox.SelectedValue as Product;
            priceTextBox.Text = gasoline?.Price.ToString();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton.Text.Equals("Сума"))
            {
                gasolinePayGroupBox.Text = "К выдаче :";
                unitsLabel.Text = "л.";
                totalGasolineUnitsLabel.Text = (sumGasolineNumericUpDown.Value / gasolines[gasolinesComboBox.SelectedIndex].Price).ToString("0.00");
                countGasolineNumericUpDown.Enabled = false;
                sumGasolineNumericUpDown.Enabled = true;
            }
            else
            {
                gasolinePayGroupBox.Text = "К оплате :";
                unitsLabel.Text = "грн.";
                totalGasolineUnitsLabel.Text = (countGasolineNumericUpDown.Value * gasolines[gasolinesComboBox.SelectedIndex].Price).ToString();
                countGasolineNumericUpDown.Enabled = true;
                sumGasolineNumericUpDown.Enabled = false;
            }
            totalToPayLabel.Text = cart.TotalToPay.ToString();
        }

        private void countGasolineNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalGasolineUnitsLabel.Text = (countGasolineNumericUpDown.Value * gasolines[gasolinesComboBox.SelectedIndex].Price).ToString();
            cart.TotalGasStation = countGasolineNumericUpDown.Value * gasolines[gasolinesComboBox.SelectedIndex].Price;
            totalToPayLabel.Text = cart.TotalToPay.ToString();
        }

        private void sumGasolineNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalGasolineUnitsLabel.Text = (sumGasolineNumericUpDown.Value / gasolines[gasolinesComboBox.SelectedIndex].Price).ToString("0.00");
            cart.TotalGasStation = countGasolineNumericUpDown.Value;
            totalToPayLabel.Text = cart.TotalToPay.ToString();
        }

        private void BestOilForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Сумма выручки за день: {totalIncome} грн.", "Конец дня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await Task.Delay(1000);
                var dialogResult = MessageBox.Show("Вы уверены в своем выборе?", "Очистка", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    totalIncome += cart.TotalToPay;
                    await Task.Delay(1000);
                    MessageBox.Show($"Вы заплатили: {cart.TotalToPay}", "Оплата", MessageBoxButtons.OK);
                    Clear();
                }
            });
        }

        private void Clear()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                gasolinesComboBox.SelectedIndex = 0;
                countRadioButton.Checked = true;
                sumRadioButton.Checked = false;
                sumGasolineNumericUpDown.Value = 0;
                countGasolineNumericUpDown.Value = 0;
                foreach (var item in miniCafeGroupBox.Controls.OfType<NumericUpDown>())
                {
                    item.Value = 0;
                    item.Enabled = false;
                }
                foreach (var item in miniCafeGroupBox.Controls.OfType<CheckBox>())
                {
                    item.Checked = false;
                }
            }));
            cart = new Cart();
        }
    }


    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; } = 1;
        public override string ToString()
        {
            return Name;
        }
    }

    public class Cart
    {
        private List<Product> products;

        public Cart()
        {
            products = new List<Product>();
        }
        public List<Product> GetProducts() => new List<Product>(products);
        public decimal TotalGasStation { get; set; }
        public decimal TotalMiniCafe
        {
            get
            {
                return products.Sum(e => e.Price * e.Count);
            }
        }
        public decimal TotalToPay
        {
            get
            {
                return TotalGasStation + TotalMiniCafe;
            }
        }
        public void RemoveProduct(Product product)
        {
            products = products.Where(e => e.Id != product.Id).ToList();
        }
        public void AddProduct(Product product)
        {
            if (products.Any(e => e.Id.Equals(product.Id)))
            {
                products.FirstOrDefault(e => e.Id.Equals(product.Id)).Count += 1;
            }
            else
            {
                product.Count = 1;
                products.Add(product);
            }
        }
        public void ChangeAmount(string productId, int count)
        {
            if (products.Any(e => e.Id.Equals(productId)))
            {
                products.FirstOrDefault(e => e.Id.Equals(productId)).Count = count;
            }
        }

    }
}
