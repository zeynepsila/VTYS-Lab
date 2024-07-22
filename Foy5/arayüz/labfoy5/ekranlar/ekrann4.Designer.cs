namespace labfoy5.ekranlar
{
    partial class ekrann4
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 71);
            label1.Name = "label1";
            label1.Size = new Size(402, 163);
            label1.TabIndex = 8;
            label1.Text = "DERS İŞLEMLERİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(484, 459);
            button3.Name = "button3";
            button3.Size = new Size(158, 61);
            button3.TabIndex = 7;
            button3.Text = "Ders Değiştirme";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(484, 357);
            button2.Name = "button2";
            button2.Size = new Size(158, 61);
            button2.TabIndex = 6;
            button2.Text = "Ders Silme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(484, 254);
            button1.Name = "button1";
            button1.Size = new Size(158, 61);
            button1.TabIndex = 5;
            button1.Text = "Ders Atama";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ekrann4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 590);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ekrann4";
            Text = "ekran4";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}