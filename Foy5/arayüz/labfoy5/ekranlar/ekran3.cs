using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient; // Add this namespace for SqlCommand and SqlConnection
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace labfoy5.ekranlar
{
    public partial class ekran3 : Form
    {
        public ekran3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Giriş verilerini al ve doğrula
            string bolumID = textbolumId.Text.Trim();
            string bolumAd = textbolumAd.Text.Trim();
            string fakulteID = textfakulteıd.Text.Trim();

            if (string.IsNullOrWhiteSpace(bolumID) || string.IsNullOrWhiteSpace(bolumAd) || string.IsNullOrWhiteSpace(fakulteID))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(bolumID, out int parsedBolumID))
            {
                MessageBox.Show("Bölüm ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(fakulteID, out int parsedFakulteID))
            {
                MessageBox.Show("Fakülte ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Fakülte ID'nin geçerli olup olmadığını kontrol et
                string checkFacultyQuery = "SELECT COUNT(*) FROM tFakulte WHERE FakulteID = @FakulteID";
                using (SqlCommand checkFacultyCmd = new SqlCommand(checkFacultyQuery, con))
                {
                    checkFacultyCmd.Parameters.AddWithValue("@FakulteID", parsedFakulteID);
                    int facultyCount = (int)checkFacultyCmd.ExecuteScalar();
                    if (facultyCount == 0)
                    {
                        MessageBox.Show("Geçersiz fakülte ID.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Bölümü ekleme işlemi
                string insertQuery = "INSERT INTO tBolum (BolumID, BolumAd, FakulteID) VALUES (@BolumID, @BolumAd, @FakulteID)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BolumID", parsedBolumID);
                    cmd.Parameters.AddWithValue("@BolumAd", bolumAd);
                    cmd.Parameters.AddWithValue("@FakulteID", parsedFakulteID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bölüm başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textbolumId.Clear();
                            textbolumAd.Clear();
                            textfakulteıd.Clear(); // Alanları temizle
                        }
                        else
                        {
                            MessageBox.Show("Bölüm eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Silme işlemi için bölüm ID'sini al ve doğrula
            string bolumID = textbolumId.Text.Trim();

            if (string.IsNullOrWhiteSpace(bolumID))
            {
                MessageBox.Show("Bölüm ID'yi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // Bölümün var olup olmadığını kontrol et
                string checkDepartmentQuery = "SELECT COUNT(*) FROM tBolum WHERE BolumID = @bolumID";
                using (SqlCommand checkDepartmentCmd = new SqlCommand(checkDepartmentQuery, con))
                {
                    checkDepartmentCmd.Parameters.AddWithValue("@bolumID", parsedBolumID);
                    int departmentCount = (int)checkDepartmentCmd.ExecuteScalar();
                    if (departmentCount == 0)
                    {
                        MessageBox.Show("Bu bölüm bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Bölümü silme işlemi
                string deleteQuery = "DELETE FROM tBolum WHERE BolumID = @bolumID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@bolumID", parsedBolumID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Silme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bölüm başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textbolumId.Clear();
                            textbolumAd.Clear();
                            textfakultead.Clear();
                            textfakulteıd.Clear(); // Alanları temizle
                        }
                        else
                        {
                            MessageBox.Show("Bölüm silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string bolumID = textbolumId.Text.Trim();
            string bolumAd = textbolumAd.Text.Trim();
            string fakulteID = textfakulteıd.Text.Trim();

            if (string.IsNullOrWhiteSpace(bolumID) || string.IsNullOrWhiteSpace(bolumAd) || string.IsNullOrWhiteSpace(fakulteID))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(bolumID, out int parsedBolumID))
            {
                MessageBox.Show("Bölüm ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(fakulteID, out int parsedFakulteID))
            {
                MessageBox.Show("Fakülte ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                try
                {
                    con.Open();

                    string query = @"UPDATE tBolum 
                             SET BolumAd = @bolumAd, FakulteID = @fakulteID 
                             WHERE BolumID = @bolumID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bolumID", parsedBolumID);
                        cmd.Parameters.AddWithValue("@bolumAd", bolumAd);
                        cmd.Parameters.AddWithValue("@fakulteID", parsedFakulteID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bölüm başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Gerekirse ek işlemler yapılabilir
                            textbolumId.Clear();
                            textbolumAd.Clear();
                            textfakulteıd.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Bölüm bulunamadı veya güncelleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Bölümleri listeleme işlemi
                string selectQuery = "SELECT BolumID, BolumAd, FakulteID FROM tBolum";
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        private void textbolumAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
