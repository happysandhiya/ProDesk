namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role;

            if (Program.CheckLogin(username, password, out role))
            {
                MessageBox.Show("Login successful! Role: " + role, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Panggil Form2 atau tindakan lain yang diinginkan setelah login berhasil
                this.Hide();
                Form2 form2 = new Form2(role);
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}