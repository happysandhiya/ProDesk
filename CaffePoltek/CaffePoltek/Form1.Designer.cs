namespace CaffePoltek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTitle = new Label();
            LMinum = new Label();
            cmbMinuman = new ComboBox();
            LHargaMinum = new Label();
            TbHargaMinum = new TextBox();
            comboBox1 = new ComboBox();
            LSize = new Label();
            TbHargaSize = new TextBox();
            label1 = new Label();
            CbSugar = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            TbHargaTopping = new TextBox();
            label2 = new Label();
            CbTopping = new ComboBox();
            label4 = new Label();
            TotalHarga = new Label();
            TbTotalHarga = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = SystemColors.GradientInactiveCaption;
            LabelTitle.Font = new Font("Kathen", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelTitle.ForeColor = Color.LightSkyBlue;
            LabelTitle.Location = new Point(272, 20);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(279, 37);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Caffe Poltek SSN ";
            // 
            // LMinum
            // 
            LMinum.AutoSize = true;
            LMinum.Location = new Point(46, 103);
            LMinum.Name = "LMinum";
            LMinum.Size = new Size(87, 25);
            LMinum.TabIndex = 2;
            LMinum.Text = "Minuman";
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Items.AddRange(new object[] { "Espresso", "Latte", "Cappuccino" });
            cmbMinuman.Location = new Point(229, 103);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(182, 33);
            cmbMinuman.TabIndex = 3;
            cmbMinuman.SelectedIndexChanged += cmbMinuman_SelectedIndexChanged;
            // 
            // LHargaMinum
            // 
            LHargaMinum.AutoSize = true;
            LHargaMinum.Location = new Point(470, 106);
            LHargaMinum.Name = "LHargaMinum";
            LHargaMinum.Size = new Size(60, 25);
            LHargaMinum.TabIndex = 4;
            LHargaMinum.Text = "Harga";
            LHargaMinum.UseWaitCursor = true;
            // 
            // TbHargaMinum
            // 
            TbHargaMinum.Location = new Point(586, 103);
            TbHargaMinum.Name = "TbHargaMinum";
            TbHargaMinum.Size = new Size(150, 31);
            TbHargaMinum.TabIndex = 5;
            TbHargaMinum.TextChanged += TbHargaMinum_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Medium", "Large" });
            comboBox1.Location = new Point(229, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LSize
            // 
            LSize.AutoSize = true;
            LSize.Location = new Point(46, 165);
            LSize.Name = "LSize";
            LSize.Size = new Size(43, 25);
            LSize.TabIndex = 6;
            LSize.Text = "Size";
            // 
            // TbHargaSize
            // 
            TbHargaSize.Location = new Point(586, 167);
            TbHargaSize.Name = "TbHargaSize";
            TbHargaSize.Size = new Size(150, 31);
            TbHargaSize.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 167);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 8;
            label1.Text = "add Harga";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // CbSugar
            // 
            CbSugar.FormattingEnabled = true;
            CbSugar.Items.AddRange(new object[] { "100 %", "75 %", "50 %", "0 %" });
            CbSugar.Location = new Point(229, 228);
            CbSugar.Name = "CbSugar";
            CbSugar.Size = new Size(182, 33);
            CbSugar.TabIndex = 11;
            CbSugar.SelectedIndexChanged += CbSugar_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 228);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 10;
            label3.Text = "Sugar Level";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "100 %", "75 %", "50 %", "0 %" });
            comboBox2.Location = new Point(229, 288);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 288);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 14;
            label5.Text = "Ice Level";
            // 
            // TbHargaTopping
            // 
            TbHargaTopping.Location = new Point(586, 352);
            TbHargaTopping.Name = "TbHargaTopping";
            TbHargaTopping.Size = new Size(150, 31);
            TbHargaTopping.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 352);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 18;
            label2.Text = "add Harga";
            label2.UseWaitCursor = true;
            // 
            // CbTopping
            // 
            CbTopping.FormattingEnabled = true;
            CbTopping.Items.AddRange(new object[] { "Bubble", "Grass Jelly", "Nata De Coco", "Whipped Cream", "Choco Chip", "Oreo" });
            CbTopping.Location = new Point(229, 350);
            CbTopping.Name = "CbTopping";
            CbTopping.Size = new Size(182, 33);
            CbTopping.TabIndex = 17;
            CbTopping.SelectedIndexChanged += CbTopping_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 350);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 16;
            label4.Text = "Add-on/Topping ";
            // 
            // TotalHarga
            // 
            TotalHarga.AutoSize = true;
            TotalHarga.Font = new Font("Quicksand Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalHarga.Location = new Point(157, 446);
            TotalHarga.Name = "TotalHarga";
            TotalHarga.Size = new Size(162, 35);
            TotalHarga.TabIndex = 20;
            TotalHarga.Text = "Total Harga";
            // 
            // TbTotalHarga
            // 
            TbTotalHarga.Location = new Point(401, 451);
            TbTotalHarga.Name = "TbTotalHarga";
            TbTotalHarga.Size = new Size(150, 31);
            TbTotalHarga.TabIndex = 21;
            TbTotalHarga.TextChanged += TbTotalHarga_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 454);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 22;
            label6.Text = "Rp";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(label6);
            Controls.Add(TbTotalHarga);
            Controls.Add(TotalHarga);
            Controls.Add(TbHargaTopping);
            Controls.Add(label2);
            Controls.Add(CbTopping);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(CbSugar);
            Controls.Add(label3);
            Controls.Add(TbHargaSize);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(LSize);
            Controls.Add(TbHargaMinum);
            Controls.Add(LHargaMinum);
            Controls.Add(cmbMinuman);
            Controls.Add(LMinum);
            Controls.Add(LabelTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private Label LMinum;
        private ComboBox cmbMinuman;
        private Label LHargaMinum;
        private TextBox TbHargaMinum;
        private ComboBox comboBox1;
        private Label LSize;
        private TextBox TbHargaSize;
        private Label label1;
        private ComboBox CbSugar;
        private Label label3;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox TbHargaTopping;
        private Label label2;
        private ComboBox CbTopping;
        private Label label4;
        private Label TotalHarga;
        private TextBox TbTotalHarga;
        private Label label6;
    }
}