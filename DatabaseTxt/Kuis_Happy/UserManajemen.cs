using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Kuis_Happy.Order;

namespace Kuis_Happy
{
    public partial class UserManajemen : Form
    {
        private string filePath = "User.txt"; // Path ke file teks dengan daftar produk
        private List<Product> products; // Daftar produk
        public UserManajemen()
        {
            InitializeComponent();
            DisplayFileContents();
        }
        private void DisplayFileContents()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines.Length > 0)
                    {
                        string[] headers = lines[0].Split(',');
                        dataGridView1.Columns.Clear();

                        foreach (string header in headers)
                        {
                            dataGridView1.Columns.Add(header.Trim(), header.Trim());
                        }

                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] values = lines[i].Split(',');

                            if (values.Length == headers.Length)
                            {
                                dataGridView1.Rows.Add(values.Select(v => v.Trim()).ToArray());
                            }
                        }
                    }
                    else
                    {
                        ShowErrorMessage("File kosong.");
                    }
                }
                else
                {
                    ShowErrorMessage("File tidak ditemukan.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error: {ex.Message}");
            }
        }
        private void ShowErrorMessage(string errorMessage)
        {
            /*comboBox1.DataSource = null;
            comboBox2.DataSource = null;*/
            MessageBox.Show(errorMessage);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string filePath = "Produk.txt";

            // Membuka file users.txt untuk menulis data
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                // Menulis header
                writer.WriteLine("Nama Produk, Harga, Stock");

                // Menulis data dari DataGridView ke file
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string nama = row.Cells[0].Value.ToString();
                        string harga = row.Cells[1].Value.ToString();
                        string stock = row.Cells[2].Value.ToString();

                        // Menulis baris data ke file
                        writer.WriteLine($"{nama},{harga},{stock}");
                    }
                }
            }

            MessageBox.Show("Perubahan telah disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UserManajemen_Load(object sender, EventArgs e)
        {
            LoadProductList(sender, e);
        }
        private void LoadProductList(object sender, EventArgs e)
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
        }
    }
}
