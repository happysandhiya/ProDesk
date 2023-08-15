namespace Kuis_Happy
{
    partial class KontrolProduk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Brusher", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(231, 11);
            label1.Name = "label1";
            label1.Size = new Size(183, 34);
            label1.TabIndex = 0;
            label1.Text = "Produk Manajemen";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(628, 213);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(251, 69);
            label12.Name = "label12";
            label12.Size = new Size(123, 25);
            label12.TabIndex = 49;
            label12.Text = "Daftar Produk";
            // 
            // button1
            // 
            button1.Location = new Point(209, 346);
            button1.Name = "button1";
            button1.Size = new Size(238, 34);
            button1.TabIndex = 50;
            button1.Text = "Simpan Perubahan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KontrolProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(650, 423);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "KontrolProduk";
            Text = "KontrolProduk";
            Load += KontrolProduk_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label12;
        private Button button1;
    }
}