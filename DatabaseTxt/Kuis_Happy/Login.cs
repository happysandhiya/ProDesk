namespace Kuis_Happy
{
    public partial class Login : Form
    {
        private const string FilePath = "User.txt";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string level = CheckCredentials(username, password);

            if (level == "admin")
            {

                MessageBox.Show("Login berhasil!");
                Order order = new(username, level);
                this.Hide();
                order.Show();
                order.Closed += (s, args) => this.Close();

                // Tambahkan logika lanjutan setelah login berhasil

            }
            else if (level == "kasir")
            {

                MessageBox.Show("Login berhasil!");
                Order order = new(username, level);
                this.Hide();
                order.Show();
                order.Closed += (s, args) => this.Close();
                // Tambahkan logika lanjutan setelah login berhasil

            }
            else if (level == "manager")
            {
                MessageBox.Show("Login berhasil!");
                Order order = new(username, level);
                this.Hide();
                order.Show();
                order.Closed += (s, args) => this.Close();
                // Tambahkan logika lanjutan setelah login berhasil

            }
            else if (level == "gagal")
            {
                MessageBox.Show("Username atau password salah.");
            }
            else
            {
                level = "user";
                MessageBox.Show("Login berhasil!");
                Order order = new(username, level);
                this.Hide();
                order.Show();
                order.Closed += (s, args) => this.Close();
            }
        }

        private String CheckCredentials(string username, string password)
        {
            string[] lines = File.ReadAllLines(FilePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                string storedUsername = parts[0].Trim();
                string storedPassword = parts[1].Trim();
                string storedLevel = parts[2].Trim();

                if (username == storedUsername && password == storedPassword)
                {

                    return storedLevel;
                }
            }

            return "gagal";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}