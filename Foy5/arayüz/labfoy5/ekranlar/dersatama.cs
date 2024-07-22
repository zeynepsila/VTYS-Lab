using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace labfoy5.ekranlar.ekran4
{
    public partial class dersatama : Form
    {
        public dersatama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan giriş verileri
            string ogrenciID = OgrenciIDTextBox.Text.Trim();
            string dersID = DersIDTextBox.Text.Trim(); // DersIDTextBox olmalı
            string yil = YilTextBox.Text.Trim();
            string yariyil = YariyilTextBox.Text.Trim();

            // Girişlerin doğrulanması
            if (string.IsNullOrWhiteSpace(ogrenciID) || string.IsNullOrWhiteSpace(dersID) ||
                string.IsNullOrWhiteSpace(yil) || string.IsNullOrWhiteSpace(yariyil))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ogrenciID, out int parsedOgrenciID) ||
                !int.TryParse(dersID, out int parsedDersID))
            {
                MessageBox.Show("Öğrenci ID ve Ders ID geçerli sayılar olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Öğrencinin varlığını kontrol et
                string checkOgrenciQuery = "SELECT COUNT(*) FROM tOgrenci WHERE ogrenciID = @ogrenciID";
                using (SqlCommand checkOgrenciCmd = new SqlCommand(checkOgrenciQuery, con))
                {
                    checkOgrenciCmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    int ogrenciCount = (int)checkOgrenciCmd.ExecuteScalar();

                    if (ogrenciCount == 0)
                    {
                        MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Dersin varlığını kontrol et
                string checkDersQuery = "SELECT COUNT(*) FROM tDers WHERE dersID = @dersID";
                using (SqlCommand checkDersCmd = new SqlCommand(checkDersQuery, con))
                {
                    checkDersCmd.Parameters.AddWithValue("@dersID", parsedDersID);
                    int dersCount = (int)checkDersCmd.ExecuteScalar();

                    if (dersCount == 0)
                    {
                        MessageBox.Show("Ders bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Öğrenci-Ders atama işlemi
                string insertQuery = "INSERT INTO tOgrenciDers (ogrenciID, dersID, yil, yariyil) VALUES (@ogrenciID, @dersID, @yil, @yariyil)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    cmd.Parameters.AddWithValue("@dersID", parsedDersID);
                    cmd.Parameters.AddWithValue("@yil", yil);
                    cmd.Parameters.AddWithValue("@yariyil", yariyil);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders başarıyla atandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OgrenciIDTextBox.Clear();
                            DersIDTextBox.Clear(); // DersIDTextBox olmalı
                            YilTextBox.Clear();
                            YariyilTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ders atanırken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
