using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _014___firstWindowsForm
{
    public partial class Products : Form
    {
        private List<Product> products = new List<Product>();
        public Products()
        {
            InitializeComponent();
            dataGridViewProducts.AutoGenerateColumns = true;
            dataGridViewProducts.DataSource = products;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                !int.TryParse(quantityTextBox.Text, out int qty) ||
                !decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Enter valid data!");
                return;
            }

            Product p = new Product()
            {
                Name = nameTextBox.Text,
                Quantity = qty,
                Price = price
            };

            products.Add(p);

            RefreshGrid();
            ClearInputs();
        }

        private void RefreshGrid()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = products;
        }

        private void ClearInputs()
        {
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
                return;

            var selectedProduct = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;
            products.Remove(selectedProduct);

            RefreshGrid();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
                return;

            var selectedProduct = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;

            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                !int.TryParse(quantityTextBox.Text, out int qty) ||
                !decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Enter valid data!");
                return;
            }

            selectedProduct.Name = nameTextBox.Text;
            selectedProduct.Quantity = qty;
            selectedProduct.Price = price;

            RefreshGrid();
            ClearInputs();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            if (File.Exists("products.json"))
            {
                products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText("products.json"));
                RefreshGrid();
            }
        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("products.json", JsonSerializer.Serialize(products));
        }
    }
}
