using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4;

namespace Login
{
    static class Program
    {
        // Deklarasi list pengguna
        static List<Users> users = new List<Users>();

        [STAThread]
        static void Main()
        {
            // Menambahkan pengguna ke list
            users.Add(new Users("admin", "admin", "admin"));
            users.Add(new Users("kasir", "kasir", "kasir"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Fungsi untuk memeriksa login
        public static bool CheckLogin(string username, string password, out string role)
        {
            foreach (Users user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    role = user.Rule;
                    return true;
                }
            }
            role = "";
            return false;
        }
    }
}
