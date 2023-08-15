using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuis_Happy
{
    public partial class Order : Form
    {
        private string filePath = "Produk.txt"; // Path ke file teks dengan daftar produk
        private List<Product> products; // Daftar produk
        private string username;
        private string level;
        public Order(string username, string level)
        {
            this.username = username;
            this.level = level;
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadProductList();
            if (level == "manager")
            {
                pictureBox2.Visible = false;
            }
            else if (level == "kasir")
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
            }
            else if (level == "user")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

        }
        private void LoadProductList()
        {
            // Membaca file teks untuk mendapatkan daftar produk
            string[] lines = File.ReadAllLines(filePath);

            products = new List<Product>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    string productName = parts[0];
                    decimal productPrice;

                    if (decimal.TryParse(parts[1], out productPrice))
                    {
                        Product product = new Product(productName, productPrice);
                        products.Add(product);
                    }
                }
            }
            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "Name";
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Product(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mendapatkan produk yang dipilih dan jumlah pesanan
            Product selectedProduct = (Product)comboBox1.SelectedItem;
            int quantity = (int)numericUpDown1.Value;
            string toRupiah = selectedProduct.Price.ToString("C", new CultureInfo("id-ID"));

            string orderData = $"{DateTime.Now}; {username};{selectedProduct.Name};{toRupiah};{quantity}";

            try
            {
                // Menulis data pesanan ke file
                using (StreamWriter writer = new StreamWriter("Transaksi.txt", true))
                {
                    writer.WriteLine(orderData);
                }
                MessageBox.Show("Pesanan berhasil disimpan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan pesanan: {ex.Message}");
            }

            MessageBox.Show($"Pesanan {username}:\n {selectedProduct.Name}\n (Harga: {toRupiah})\n Jumlah: {quantity}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transaksi user = new();
            user.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KontrolProduk user = new();
            user.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserManajemen user = new();
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
