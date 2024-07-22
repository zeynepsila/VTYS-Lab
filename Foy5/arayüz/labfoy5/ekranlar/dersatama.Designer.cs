namespace labfoy5.ekranlar.ekran4
{
    partial class dersatama
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
            YariyilTextBox = new TextBox();
            YilTextBox = new TextBox();
            DersIDTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            OgrenciIDTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // YariyilTextBox
            // 
            YariyilTextBox.Location = new Point(571, 196);
            YariyilTextBox.Name = "YariyilTextBox";
            YariyilTextBox.Size = new Size(125, 27);
            YariyilTextBox.TabIndex = 18;
            // 
            // YilTextBox
            // 
            YilTextBox.Location = new Point(571, 265);
            YilTextBox.Name = "YilTextBox";
            YilTextBox.Size = new Size(125, 27);
            YilTextBox.TabIndex = 17;
            // 
            // DersIDTextBox
            // 
            DersIDTextBox.Location = new Point(571, 326);
            DersIDTextBox.Name = "DersIDTextBox";
            DersIDTextBox.Size = new Size(125, 27);
            DersIDTextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 326);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 15;
            label5.Text = "Ders ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 265);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 14;
            label4.Text = "Yıl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 203);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 13;
            label3.Text = "Yarıyıl";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 132);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 12;
            label2.Text = "Öğrenci ID";
            // 
            // OgrenciIDTextBox
            // 
            OgrenciIDTextBox.Location = new Point(571, 125);
            OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            OgrenciIDTextBox.Size = new Size(125, 27);
            OgrenciIDTextBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(509, 401);
            button1.Name = "button1";
            button1.Size = new Size(145, 67);
            button1.TabIndex = 19;
            button1.Text = "Ders Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dersatama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 529);
            Controls.Add(button1);
            Controls.Add(YariyilTextBox);
            Controls.Add(YilTextBox);
            Controls.Add(DersIDTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OgrenciIDTextBox);
            Name = "dersatama";
            Text = "dersatama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox YariyilTextBox;
        private TextBox YilTextBox;
        private TextBox DersIDTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox OgrenciIDTextBox;
        private Button button1;
    }
}