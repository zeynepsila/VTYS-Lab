namespace labfoy5.ekranlar
{
    partial class ekran1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textogrenciID = new TextBox();
            textbolumId = new TextBox();
            textsoyad = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 100);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(453, 203);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(372, 24);
            label1.Name = "label1";
            label1.Size = new Size(188, 50);
            label1.TabIndex = 1;
            label1.Text = "Öğrenciler";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(93, 374);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 3;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 124);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 178);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci Soyadı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 224);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Bölüm ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 270);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "Öğrenci ID";
            // 
            // textogrenciID
            // 
            textogrenciID.Location = new Point(204, 270);
            textogrenciID.Margin = new Padding(3, 2, 3, 2);
            textogrenciID.Name = "textogrenciID";
            textogrenciID.Size = new Size(110, 23);
            textogrenciID.TabIndex = 8;
            // 
            // textbolumId
            // 
            textbolumId.Location = new Point(204, 224);
            textbolumId.Margin = new Padding(3, 2, 3, 2);
            textbolumId.Name = "textbolumId";
            textbolumId.Size = new Size(110, 23);
            textbolumId.TabIndex = 9;
            // 
            // textsoyad
            // 
            textsoyad.Location = new Point(204, 172);
            textsoyad.Margin = new Padding(3, 2, 3, 2);
            textsoyad.Name = "textsoyad";
            textsoyad.Size = new Size(110, 23);
            textsoyad.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(275, 374);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(130, 46);
            button2.TabIndex = 11;
            button2.Text = "Öğrenci Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(452, 374);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(130, 46);
            button3.TabIndex = 12;
            button3.Text = "Öğrenci Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(671, 374);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(130, 46);
            button4.TabIndex = 13;
            button4.Text = "Öğrenci Listele";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textAd
            // 
            textAd.Location = new Point(204, 119);
            textAd.Margin = new Padding(3, 2, 3, 2);
            textAd.Name = "textAd";
            textAd.Size = new Size(110, 23);
            textAd.TabIndex = 2;
            textAd.TextChanged += textAd_TextChanged;
            // 
            // ekran1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 496);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textsoyad);
            Controls.Add(textbolumId);
            Controls.Add(textogrenciID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textAd);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ekran1";
            Text = "ekran1";
            Load += ekran1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textogrenciID;
        private TextBox textbolumId;
        private TextBox textsoyad;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textAd;
    }
}