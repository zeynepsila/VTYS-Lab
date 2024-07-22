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
    public partial class ekran1 : Form
    {
        public ekran1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Giriş verilerini al ve doğrula
            string ogrenciID = textogrenciID.Text.Trim();
            string ad = textAd.Text.Trim();
            string soyad = textsoyad.Text.Trim();
            string bolumID = textbolumId.Text.Trim(); // Bölüm ID'sini ekliyoruz

            if (string.IsNullOrWhiteSpace(ogrenciID) || string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(bolumID))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ogrenciID, out int parsedOgrenciID))
            {
                MessageBox.Show("Öğrenci ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(bolumID, out int parsedBolumID))
            {
                MessageBox.Show("Bölüm ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Öğrencinin var olup olmadığını kontrol et
                string checkStudentQuery = "SELECT COUNT(*) FROM tOgrenci WHERE ogrenciID = @ogrenciID";
                using (SqlCommand checkStudentCmd = new SqlCommand(checkStudentQuery, con))
                {
                    checkStudentCmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    int studentCount = (int)checkStudentCmd.ExecuteScalar();
                    if (studentCount > 0)
                    {
                        MessageBox.Show("Bu öğrenci zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Bölüm ID'nin geçerli olup olmadığını kontrol et
                string checkDepartmentQuery = "SELECT COUNT(*) FROM tBolum WHERE bolumID = @bolumID";
                using (SqlCommand checkDepartmentCmd = new SqlCommand(checkDepartmentQuery, con))
                {
                    checkDepartmentCmd.Parameters.AddWithValue("@bolumID", parsedBolumID);
                    int departmentCount = (int)checkDepartmentCmd.ExecuteScalar();
                    if (departmentCount == 0)
                    {
                        MessageBox.Show("Geçersiz bölüm ID.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Öğrenciyi ekleme işlemi
                string insertQuery = "INSERT INTO tOgrenci (ogrenciID, ad, soyad, bolumID) VALUES (@ogrenciID, @ad, @soyad, @bolumID)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@bolumID", parsedBolumID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Öğrenci başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textAd.Clear();
                            textogrenciID.Clear();
                            textbolumId.Clear();
                            textsoyad.Clear(); // Bölüm ID'sini de temizle
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Silme işlemi için öğrenci ID'sini al ve doğrula
            string ogrenciID = textogrenciID.Text.Trim();

            if (string.IsNullOrWhiteSpace(ogrenciID))
            {
                MessageBox.Show("Öğrenci ID'yi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ogrenciID, out int parsedOgrenciID))
            {
                MessageBox.Show("Öğrenci ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Öğrencinin var olup olmadığını kontrol et
                string checkStudentQuery = "SELECT COUNT(*) FROM tOgrenci WHERE ogrenciID = @ogrenciID";
                using (SqlCommand checkStudentCmd = new SqlCommand(checkStudentQuery, con))
                {
                    checkStudentCmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    int studentCount = (int)checkStudentCmd.ExecuteScalar();
                    if (studentCount == 0)
                    {
                        MessageBox.Show("Bu öğrenci bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Öğrenciyi silme işlemi
                string deleteQuery = "DELETE FROM tOgrenci WHERE ogrenciID = @ogrenciID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Silme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Öğrenci başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textogrenciID.Clear();
                            textAd.Clear();
                            textsoyad.Clear();
                            textbolumId.Clear(); // Alanları temizle
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string ogrenciID = textogrenciID.Text.Trim();
            string ad = textAd.Text.Trim();
            string soyad = textsoyad.Text.Trim();
            string bolumID = textbolumId.Text.Trim();

            if (string.IsNullOrWhiteSpace(ogrenciID) || string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(bolumID))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ogrenciID, out int parsedOgrenciID))
            {
                MessageBox.Show("Öğrenci ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(bolumID, out int parsedBolumID))
            {
                MessageBox.Show("Bölüm ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                try
                {
                    con.Open();

                    string query = @"UPDATE tOgrenci 
                                     SET ad = @ad, soyad = @soyad, bolumID = @bolumID 
                                     WHERE ogrenciID = @ogrenciID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@soyad", soyad);
                        cmd.Parameters.AddWithValue("@bolumID", parsedBolumID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Öğrenci bulunamadı veya güncelleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                // Veritabanı bağlantısı
                using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
                {
                    con.Open();

                    // Öğrencileri listeleme işlemi
                    string selectQuery = "SELECT ogrenciID, ad, soyad, bolumID FROM tOgrenci";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Eski veri kaynağını temizle
                        dataGridView1.DataSource = null;

                        // Yeni veri kaynağını ata
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        private void textAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekran1_Load(object sender, EventArgs e)
        {

        }
    }
}
