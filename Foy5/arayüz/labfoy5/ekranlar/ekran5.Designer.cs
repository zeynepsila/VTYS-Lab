namespace labfoy5.ekranlar
{
    partial class ekran5
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
            label2 = new Label();
            OgrenciIDTextBox = new TextBox();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            ListeleButon = new Button();
            YearComboBox = new ComboBox();
            label5 = new Label();
            SemesterComboBox = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(355, 47);
            label1.TabIndex = 2;
            label1.Text = "Öğrenci Bazlı Listeleme";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(355, 204);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 160);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Numarası";
            // 
            // OgrenciIDTextBox
            // 
            OgrenciIDTextBox.Location = new Point(144, 160);
            OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            OgrenciIDTextBox.Size = new Size(100, 23);
            OgrenciIDTextBox.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(533, 295);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(355, 204);
            dataGridView2.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(512, 28);
            label4.Name = "label4";
            label4.Size = new Size(355, 47);
            label4.TabIndex = 7;
            label4.Text = "Yıl Bazlı Listeleme";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // ListeleButon
            // 
            ListeleButon.Location = new Point(758, 175);
            ListeleButon.Margin = new Padding(3, 2, 3, 2);
            ListeleButon.Name = "ListeleButon";
            ListeleButon.Size = new Size(130, 46);
            ListeleButon.TabIndex = 17;
            ListeleButon.Text = "Listele";
            ListeleButon.UseVisualStyleBackColor = true;
            ListeleButon.Click += ListeleButon_Click;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Location = new Point(613, 153);
            YearComboBox.Margin = new Padding(3, 2, 3, 2);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(133, 23);
            YearComboBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(552, 161);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 15;
            label5.Text = "Yıl";
            // 
            // SemesterComboBox
            // 
            SemesterComboBox.FormattingEnabled = true;
            SemesterComboBox.Location = new Point(613, 218);
            SemesterComboBox.Margin = new Padding(3, 2, 3, 2);
            SemesterComboBox.Name = "SemesterComboBox";
            SemesterComboBox.Size = new Size(133, 23);
            SemesterComboBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 226);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "Yarıyıl";
            // 
            // button1
            // 
            button1.Location = new Point(260, 153);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 20;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ekran5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 549);
            Controls.Add(button1);
            Controls.Add(SemesterComboBox);
            Controls.Add(label3);
            Controls.Add(ListeleButon);
            Controls.Add(YearComboBox);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(OgrenciIDTextBox);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ekran5";
            Text = "ekran5";
            Load += ekran5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox OgrenciIDTextBox;
        private DataGridView dataGridView2;
        private Label label4;
        private Button ListeleButon;
        private ComboBox YearComboBox;
        private Label label5;
        private ComboBox SemesterComboBox;
        private Label label3;
        private Button button1;
    }
}