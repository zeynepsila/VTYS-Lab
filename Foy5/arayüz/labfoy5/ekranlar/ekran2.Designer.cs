namespace labfoy5.ekranlar
{
    partial class ekran2
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            label2 = new Label();
            textAd = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textdersId = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(421, 21);
            label1.Name = "label1";
            label1.Size = new Size(215, 67);
            label1.TabIndex = 2;
            label1.Text = "Dersler";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 142);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Ders Adı";
            // 
            // textAd
            // 
            textAd.Location = new Point(226, 142);
            textAd.Name = "textAd";
            textAd.Size = new Size(125, 27);
            textAd.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(90, 458);
            button1.Name = "button1";
            button1.Size = new Size(148, 62);
            button1.TabIndex = 7;
            button1.Text = "Ders Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(518, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(518, 271);
            dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 228);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 9;
            label3.Text = "Ders ID";
            // 
            // textdersId
            // 
            textdersId.Location = new Point(226, 221);
            textdersId.Name = "textdersId";
            textdersId.Size = new Size(125, 27);
            textdersId.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(313, 458);
            button2.Name = "button2";
            button2.Size = new Size(148, 62);
            button2.TabIndex = 11;
            button2.Text = "Ders Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(505, 458);
            button3.Name = "button3";
            button3.Size = new Size(148, 62);
            button3.TabIndex = 12;
            button3.Text = "Ders Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(776, 458);
            button4.Name = "button4";
            button4.Size = new Size(148, 62);
            button4.TabIndex = 13;
            button4.Text = "Ders Listele";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ekran2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 579);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textdersId);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ekran2";
            Text = "ekran2";
            Load += ekran2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private Label label2;
        private TextBox textAd;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textdersId;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}