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
    public partial class derssilme : Form
    {
        public derssilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan ders ID'si
            string dersID = DersIDTextBox.Text.Trim();

            // Girişin doğrulanması
            if (string.IsNullOrWhiteSpace(dersID))
            {
                MessageBox.Show("Ders ID alanını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Dersin varlığını kontrol et
                    string checkDersQuery = "SELECT COUNT(*) FROM tDers WHERE dersID = @dersID";
                    using (SqlCommand checkDersCmd = new SqlCommand(checkDersQuery, con))
                    {
                        checkDersCmd.Parameters.AddWithValue("@dersID", parsedDersID);
                        int dersCount = (int)checkDersCmd.ExecuteScalar();

                        if (dersCount == 0)
                        {
                            MessageBox.Show("Belirtilen ders bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Dersin öğrencilere atanmış durumunu sil
                    string deleteDersAtamaQuery = "DELETE FROM tOgrenciDers WHERE dersID = @dersID";
                    using (SqlCommand deleteDersAtamaCmd = new SqlCommand(deleteDersAtamaQuery, con))
                    {
                        deleteDersAtamaCmd.Parameters.AddWithValue("@dersID", parsedDersID);
                        int rowsAffected = deleteDersAtamaCmd.ExecuteNonQuery(); // Silme işlemini gerçekleştir

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders öğrencilerden başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DersIDTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ders öğrenci listesinden silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
