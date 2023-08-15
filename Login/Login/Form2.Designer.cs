namespace Login
{
    partial class Form2
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
            tabControl1 = new TabControl();
            Penjualan = new TabPage();
            label6 = new Label();
            TbTotalHarga = new TextBox();
            TotalHarga = new Label();
            TbHargaTopping = new TextBox();
            label2 = new Label();
            CbTopping = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            CbSugar = new ComboBox();
            label3 = new Label();
            TbHargaSize = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            LSize = new Label();
            TbHargaMinum = new TextBox();
            LHargaMinum = new Label();
            cmbMinuman = new ComboBox();
            LMinum = new Label();
            LabelTitle = new Label();
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            Penjualan.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Penjualan);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 450);
            tabControl1.TabIndex = 0;
            // 
            // Penjualan
            // 
            Penjualan.Controls.Add(label6);
            Penjualan.Controls.Add(TbTotalHarga);
            Penjualan.Controls.Add(TotalHarga);
            Penjualan.Controls.Add(TbHargaTopping);
            Penjualan.Controls.Add(label2);
            Penjualan.Controls.Add(CbTopping);
            Penjualan.Controls.Add(label4);
            Penjualan.Controls.Add(comboBox2);
            Penjualan.Controls.Add(label5);
            Penjualan.Controls.Add(CbSugar);
            Penjualan.Controls.Add(label3);
            Penjualan.Controls.Add(TbHargaSize);
            Penjualan.Controls.Add(label7);
            Penjualan.Controls.Add(comboBox1);
            Penjualan.Controls.Add(LSize);
            Penjualan.Controls.Add(TbHargaMinum);
            Penjualan.Controls.Add(LHargaMinum);
            Penjualan.Controls.Add(cmbMinuman);
            Penjualan.Controls.Add(LMinum);
            Penjualan.Controls.Add(LabelTitle);
            Penjualan.Location = new Point(4, 34);
            Penjualan.Name = "Penjualan";
            Penjualan.Padding = new Padding(3);
            Penjualan.Size = new Size(795, 412);
            Penjualan.TabIndex = 0;
            Penjualan.Text = "Penjualan";
            Penjualan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 409);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 42;
            label6.Text = "Rp";
            // 
            // TbTotalHarga
            // 
            TbTotalHarga.Location = new Point(407, 359);
            TbTotalHarga.Name = "TbTotalHarga";
            TbTotalHarga.Size = new Size(150, 31);
            TbTotalHarga.TabIndex = 41;
            TbTotalHarga.TextChanged += TbTotalHarga_TextChanged;
            // 
            // TotalHarga
            // 
            TotalHarga.AutoSize = true;
            TotalHarga.Font = new Font("Quicksand Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalHarga.Location = new Point(180, 354);
            TotalHarga.Name = "TotalHarga";
            TotalHarga.Size = new Size(162, 35);
            TotalHarga.TabIndex = 40;
            TotalHarga.Text = "Total Harga";
            // 
            // TbHargaTopping
            // 
            TbHargaTopping.Location = new Point(592, 307);
            TbHargaTopping.Name = "TbHargaTopping";
            TbHargaTopping.Size = new Size(150, 31);
            TbHargaTopping.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 307);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 38;
            label2.Text = "add Harga";
            label2.UseWaitCursor = true;
            // 
            // CbTopping
            // 
            CbTopping.FormattingEnabled = true;
            CbTopping.Items.AddRange(new object[] { "Bubble", "Grass Jelly", "Nata De Coco", "Whipped Cream", "Choco Chip", "Oreo" });
            CbTopping.Location = new Point(235, 305);
            CbTopping.Name = "CbTopping";
            CbTopping.Size = new Size(182, 33);
            CbTopping.TabIndex = 37;
            CbTopping.SelectedIndexChanged += CbTopping_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 305);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 36;
            label4.Text = "Add-on/Topping ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "100 %", "75 %", "50 %", "0 %" });
            comboBox2.Location = new Point(235, 243);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 35;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 243);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 34;
            label5.Text = "Ice Level";
            // 
            // CbSugar
            // 
            CbSugar.FormattingEnabled = true;
            CbSugar.Items.AddRange(new object[] { "100 %", "75 %", "50 %", "0 %" });
            CbSugar.Location = new Point(235, 183);
            CbSugar.Name = "CbSugar";
            CbSugar.Size = new Size(182, 33);
            CbSugar.TabIndex = 33;
            CbSugar.SelectedIndexChanged += CbSugar_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 183);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 32;
            label3.Text = "Sugar Level";
            // 
            // TbHargaSize
            // 
            TbHargaSize.Location = new Point(592, 122);
            TbHargaSize.Name = "TbHargaSize";
            TbHargaSize.Size = new Size(150, 31);
            TbHargaSize.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 122);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 30;
            label7.Text = "add Harga";
            label7.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Medium", "Large" });
            comboBox1.Location = new Point(235, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LSize
            // 
            LSize.AutoSize = true;
            LSize.Location = new Point(52, 120);
            LSize.Name = "LSize";
            LSize.Size = new Size(43, 25);
            LSize.TabIndex = 28;
            LSize.Text = "Size";
            // 
            // TbHargaMinum
            // 
            TbHargaMinum.Location = new Point(592, 58);
            TbHargaMinum.Name = "TbHargaMinum";
            TbHargaMinum.Size = new Size(150, 31);
            TbHargaMinum.TabIndex = 27;
            // 
            // LHargaMinum
            // 
            LHargaMinum.AutoSize = true;
            LHargaMinum.Location = new Point(476, 61);
            LHargaMinum.Name = "LHargaMinum";
            LHargaMinum.Size = new Size(60, 25);
            LHargaMinum.TabIndex = 26;
            LHargaMinum.Text = "Harga";
            LHargaMinum.UseWaitCursor = true;
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Items.AddRange(new object[] { "Espresso", "Latte", "Cappuccino" });
            cmbMinuman.Location = new Point(235, 58);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(182, 33);
            cmbMinuman.TabIndex = 25;
            cmbMinuman.SelectedIndexChanged += cmbMinuman_SelectedIndexChanged;
            // 
            // LMinum
            // 
            LMinum.AutoSize = true;
            LMinum.Location = new Point(52, 58);
            LMinum.Name = "LMinum";
            LMinum.Size = new Size(87, 25);
            LMinum.TabIndex = 24;
            LMinum.Text = "Minuman";
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = SystemColors.GradientInactiveCaption;
            LabelTitle.Font = new Font("Kathen", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelTitle.ForeColor = Color.LightSkyBlue;
            LabelTitle.Location = new Point(278, 3);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(279, 37);
            LabelTitle.TabIndex = 23;
            LabelTitle.Text = "Caffe Poltek SSN ";
            LabelTitle.Click += LabelTitle_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Menu User";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label13, 1, 2);
            tableLayoutPanel1.Controls.Add(label12, 1, 1);
            tableLayoutPanel1.Controls.Add(label10, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(label9, 1, 0);
            tableLayoutPanel1.Controls.Add(label11, 0, 2);
            tableLayoutPanel1.Location = new Point(60, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9230766F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.0769234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(300, 124);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(153, 81);
            label13.Name = "label13";
            label13.Size = new Size(48, 25);
            label13.TabIndex = 7;
            label13.Text = "kasir";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(153, 42);
            label12.Name = "label12";
            label12.Size = new Size(62, 25);
            label12.TabIndex = 6;
            label12.Text = "admin";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 42);
            label10.Name = "label10";
            label10.Size = new Size(62, 25);
            label10.TabIndex = 4;
            label10.Text = "admin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 2;
            label8.Text = "Nama User";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 3;
            label9.Text = "Password";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 81);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 5;
            label11.Text = "kasir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Daftar User";
            label1.Click += label1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 447);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            Penjualan.ResumeLayout(false);
            Penjualan.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Penjualan;
        private TabPage tabPage2;
        private Label label6;
        private TextBox TbTotalHarga;
        private Label TotalHarga;
        private TextBox TbHargaTopping;
        private Label label2;
        private ComboBox CbTopping;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox CbSugar;
        private Label label3;
        private TextBox TbHargaSize;
        private Label label7;
        private ComboBox comboBox1;
        private Label LSize;
        private TextBox TbHargaMinum;
        private Label LHargaMinum;
        private ComboBox cmbMinuman;
        private Label LMinum;
        private Label LabelTitle;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label11;
    }
}