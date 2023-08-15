namespace Kuis_Happy
{
    partial class UserManajemen
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
            button1 = new Button();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(222, 379);
            button1.Name = "button1";
            button1.Size = new Size(238, 34);
            button1.TabIndex = 54;
            button1.Text = "Simpan Perubahan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(278, 75);
            label12.Name = "label12";
            label12.Size = new Size(101, 25);
            label12.TabIndex = 53;
            label12.Text = "Daftar User";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(573, 225);
            dataGridView1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Brusher", 10.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(260, 24);
            label1.Name = "label1";
            label1.Size = new Size(152, 31);
            label1.TabIndex = 51;
            label1.Text = "User Manajemen";
            // 
            // UserManajemen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(632, 425);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserManajemen";
            Text = "UserManajemen";
            Load += UserManajemen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label12;
        private DataGridView dataGridView1;
        private Label label1;
    }
}