using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using static System.Windows.Forms.DataFormats;

namespace Kuis_Happy
{
    public partial class Transaksi : Form
    {
        private string filePath = "Transaksi.txt";
        public Transaksi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Transaksi_Load(object sender, EventArgs e)
        {
            DisplayFileContents();
        }

        private void DisplayFileContents()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (TextFieldParser parser = new TextFieldParser(filePath))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(";");

                        bool isFirstRow = true;

                        while (!parser.EndOfData)
                        {
                            string[] fields = parser.ReadFields();

                            if (isFirstRow)
                            {
                                dataGridView1.Columns.Clear();
                                dataGridView1.Columns.AddRange(fields.Select(h => new DataGridViewTextBoxColumn { HeaderText = h.Trim() }).ToArray());
                                isFirstRow = false;
                            }
                            else
                            {
                                dataGridView1.Rows.Add(fields.Select(f => f.Trim()).ToArray());
                            }
                        }
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



        private void ShowFileContents(string fileContents)
        {
            string[] lines = fileContents.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            dataGridView1.Rows.Clear();

            foreach (string line in lines)
            {
                dataGridView1.Rows.Add(line);
            }
        }

        private void ShowErrorMessage(string errorMessage)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            MessageBox.Show(errorMessage);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Transaksi order = new Transaksi();*//*
            order.Show();*/
            this.Close(); // Menutup form Transaksi saat tombol diklik
        }

    }
}
