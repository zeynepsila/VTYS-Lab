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
    public partial class dersdegistirme : Form
    {
        public dersdegistirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan verileri al
            string ogrenciID = OgrenciIDTextBox.Text.Trim();
            string yil = YilTextBox.Text.Trim(); // Combobox'tan seçilen değeri al
            string yariyil = YariyilTextBox.Text.Trim(); // Combobox'tan seçilen değeri al
            string eskiDersID = SDersIDTextBox.Text.Trim(); // Kullanıcıdan alınan eski ders ID'si
            string yeniDersID = EDersIDTextBox.Text.Trim(); // Kullanıcıdan alınan yeni ders ID'si

            // Verilerin doğruluğunu kontrol et
            if (string.IsNullOrWhiteSpace(ogrenciID) || string.IsNullOrWhiteSpace(yil) ||
                string.IsNullOrWhiteSpace(yariyil) || string.IsNullOrWhiteSpace(eskiDersID) ||
                string.IsNullOrWhiteSpace(yeniDersID))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    // Öğrencinin aldığı dersi kontrol et ve varsa sil
                    string deleteQuery = "DELETE FROM tOgrenciDers WHERE ogrenciID = @ogrenciID AND dersID = @eskiDersID AND yil = @yil AND yariyil = @yariyil";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con, transaction))
                    {
                        deleteCmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                        deleteCmd.Parameters.AddWithValue("@eskiDersID", eskiDersID);
                        deleteCmd.Parameters.AddWithValue("@yil", yil);
                        deleteCmd.Parameters.AddWithValue("@yariyil", yariyil);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Öğrencinin aldığı ders bulunamadı.");
                        }
                    }

                    // Yeni dersi öğrenciye ata
                    string insertQuery = "INSERT INTO tOgrenciDers (ogrenciID, dersID, yil, yariyil) VALUES (@ogrenciID, @yeniDersID, @yil, @yariyil)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                        insertCmd.Parameters.AddWithValue("@yeniDersID", yeniDersID);
                        insertCmd.Parameters.AddWithValue("@yil", yil);
                        insertCmd.Parameters.AddWithValue("@yariyil", yariyil);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Öğrencinin yeni dersiyle ilişkilendirilirken bir hata oluştu.");
                        }
                    }

                    transaction.Commit();

                    MessageBox.Show("Ders değişikliği başarıyla gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OgrenciIDTextBox.Clear();
                    YilTextBox.Clear();
                    YariyilTextBox.Clear();
                    SDersIDTextBox.Clear();
                    EDersIDTextBox.Clear();
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        MessageBox.Show("İşlem geri alınırken bir hata oluştu: " + rollbackEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
