using labfoy5.ekranlar.ekran4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labfoy5.ekranlar
{
    public partial class ekrann4 : Form
    {
        public ekrann4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dersatama DersatamaForm = new dersatama();
            DersatamaForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            derssilme DerssilmeForm = new derssilme();
            DerssilmeForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dersdegistirme DersdegistirmeForm = new dersdegistirme();
            DersdegistirmeForm.Show();
        }
    }
}
