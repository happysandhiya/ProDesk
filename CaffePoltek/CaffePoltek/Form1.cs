namespace CaffePoltek
{
    public partial class Form1 : Form
    {

        private int hargaMin;
        private int hargaSize;
        private int hargaTop;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TbHargaMinum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMinuman.Text == "Espresso")
            {
                hargaMin = 10000;
            }
            else if (cmbMinuman.Text == "Latte")
            {
                hargaMin = 15000;
            }
            else if (cmbMinuman.Text == "Cappuccino")
            {
                hargaMin = 12000;
            }
            MessageBox.Show("Harga minuman " + cmbMinuman.Text + " Rp" + hargaMin.ToString());

            TbHargaMinum.Text = hargaMin.ToString();
            TbTotalHarga_TextChanged(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Medium")
            {
                hargaSize = 0;
            }
            else if (comboBox1.Text == "Large")
            {
                hargaSize = 3000;
            }
            MessageBox.Show("Harga tambahan size " + comboBox1.Text + " Rp" + hargaSize.ToString());

            TbHargaSize.Text = hargaSize.ToString();
            TbTotalHarga_TextChanged(sender, e);
        }

        private void CbSugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Level gula yang dipilih " + CbSugar.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Level ice yang dipilih " + comboBox2.Text);
        }

        private void CbTopping_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTopping.Text == "Bubble")
            {
                hargaTop = 3000;
            }
            else if (CbTopping.Text == "Grass Jelly")
            {
                hargaTop = 3500;
            }
            else if (CbTopping.Text == "Nata De Coco")
            {
                hargaTop = 2500;
            }
            else if (CbTopping.Text == "Whipped Cream")
            {
                hargaTop = 1000;
            }
            else if (CbTopping.Text == "Choco Chip")
            {
                hargaTop = 1500;
            }
            else if (CbTopping.Text == "Oreo")
            {
                hargaTop = 2000;
            }
            MessageBox.Show("Topping yang dipilih " + CbTopping.Text + " dengan tambahan harga Rp" + hargaTop.ToString());

            TbHargaTopping.Text = hargaTop.ToString();
            TbTotalHarga_TextChanged(sender, e);
        }

        private void TbTotalHarga_TextChanged(object sender, EventArgs e)
        {
            int totalHarga = hargaMin + hargaSize + hargaTop;
            TbTotalHarga.Text = totalHarga.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}