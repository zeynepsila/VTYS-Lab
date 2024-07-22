namespace labfoy5.ekranlar
{
    partial class ekran6
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
            label2 = new Label();
            DersIDComboBox = new ComboBox();
            ListeleButon = new Button();
            KaydetButon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1078, 271);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 45);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "ders Adı";
            // 
            // DersIDComboBox
            // 
            DersIDComboBox.FormattingEnabled = true;
            DersIDComboBox.Location = new Point(377, 78);
            DersIDComboBox.Name = "DersIDComboBox";
            DersIDComboBox.Size = new Size(151, 28);
            DersIDComboBox.TabIndex = 6;
            DersIDComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ListeleButon
            // 
            ListeleButon.Location = new Point(644, 78);
            ListeleButon.Name = "ListeleButon";
            ListeleButon.Size = new Size(148, 62);
            ListeleButon.TabIndex = 14;
            ListeleButon.Text = "Dersi Alan Öğrencileri Listele";
            ListeleButon.UseVisualStyleBackColor = true;
            ListeleButon.Click += button4_Click;
            // 
            // KaydetButon
            // 
            KaydetButon.Location = new Point(980, 471);
            KaydetButon.Name = "KaydetButon";
            KaydetButon.Size = new Size(148, 62);
            KaydetButon.TabIndex = 15;
            KaydetButon.Text = "Kaydet";
            KaydetButon.UseVisualStyleBackColor = true;
            KaydetButon.Click += button1_Click;
            // 
            // ekran6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 560);
            Controls.Add(KaydetButon);
            Controls.Add(ListeleButon);
            Controls.Add(DersIDComboBox);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "ekran6";
            Text = "ekran6";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox DersIDComboBox;
        private Button ListeleButon;
        private Button KaydetButon;
    }
}