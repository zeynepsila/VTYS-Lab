using labfoy5.ekranlar;

namespace labfoy5
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekran1 Ekran1Form = new ekran1();
            Ekran1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ekran2 Ekran2Form = new ekran2();
            Ekran2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ekran3 Ekran3Form = new ekran3();
            Ekran3Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ekrann4 Ekran4Form = new ekrann4();
            Ekran4Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekran5 Ekran5Form = new ekran5();
            Ekran5Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ekran6 Ekran6Form = new ekran6();
            Ekran6Form.Show();
        }
    }
}