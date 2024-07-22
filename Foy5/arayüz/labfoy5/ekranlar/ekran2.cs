using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Add this namespace for SqlCommand and SqlConnection
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace labfoy5.ekranlar
{
    public partial class ekran2 : Form
    {
        public ekran2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Giriş verilerini al ve doğrula
            string dersID = textdersId.Text.Trim();
            string dersAd = textAd.Text.Trim();

            if (string.IsNullOrWhiteSpace(dersID) || string.IsNullOrWhiteSpace(dersAd))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dersID, out int parsedDersID))
            {
                MessageBox.Show("Ders ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Dersin var olup olmadığını kontrol et
                string checkCourseQuery = "SELECT COUNT(*) FROM tDers WHERE DersID = @DersID";
                using (SqlCommand checkCourseCmd = new SqlCommand(checkCourseQuery, con))
                {
                    checkCourseCmd.Parameters.AddWithValue("@DersID", parsedDersID);
                    int courseCount = (int)checkCourseCmd.ExecuteScalar();
                    if (courseCount > 0)
                    {
                        MessageBox.Show("Bu ders zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Dersi ekleme işlemi
                string insertQuery = "INSERT INTO tDers (DersID, DersAd) VALUES (@DersID, @DersAd)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@DersID", parsedDersID);
                    cmd.Parameters.AddWithValue("@DersAd", dersAd);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textAd.Clear();
                            textdersId.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ders eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Silme işlemi için ders ID'sini al ve doğrula
            string dersID = textdersId.Text.Trim();

            if (string.IsNullOrWhiteSpace(dersID))
            {
                MessageBox.Show("Ders ID'yi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dersID, out int parsedDersID))
            {
                MessageBox.Show("Ders ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Dersin var olup olmadığını kontrol et
                string checkCourseQuery = "SELECT COUNT(*) FROM tDers WHERE DersID = @DersID";
                using (SqlCommand checkCourseCmd = new SqlCommand(checkCourseQuery, con))
                {
                    checkCourseCmd.Parameters.AddWithValue("@DersID", parsedDersID);
                    int courseCount = (int)checkCourseCmd.ExecuteScalar();
                    if (courseCount == 0)
                    {
                        MessageBox.Show("Bu ders bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Dersi silme işlemi
                string deleteQuery = "DELETE FROM tDers WHERE DersID = @DersID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@DersID", parsedDersID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Silme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textAd.Clear();
                            textdersId.Clear(); // Alanları temizle
                        }
                        else
                        {
                            MessageBox.Show("Ders silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TextBox'lardaki değerleri al
            string dersID = textdersId.Text.Trim();
            string dersAd = textAd.Text.Trim(); // Ders adını alacak TextBox'ın ismi textDersAd olarak varsayıldı.

            if (string.IsNullOrWhiteSpace(dersID) || string.IsNullOrWhiteSpace(dersAd))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dersID, out int parsedDersID))
            {
                MessageBox.Show("Ders ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                try
                {
                    con.Open();

                    string query = @"UPDATE tDers 
                         SET DersAd = @DersAd 
                         WHERE DersID = @DersID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DersID", parsedDersID);
                        cmd.Parameters.AddWithValue("@DersAd", dersAd);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // İşlemlerinizin devamını buraya ekleyebilirsiniz
                        }
                        else
                        {
                            MessageBox.Show("Ders bulunamadı veya güncelleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Dersleri listeleme işlemi
                string selectQuery = "SELECT DersID, DersAd FROM tDers";
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        private void ekran2_Load(object sender, EventArgs e)
        {

        }
    }
}
