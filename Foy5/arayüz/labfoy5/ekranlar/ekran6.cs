using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient; // Add this namespace for SqlCommand and SqlConnection
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace labfoy5.ekranlar
{
    public partial class ekran6 : Form
    {
        public ekran6()
        {
            InitializeComponent();
            LoadDersAd();
        }

        private void LoadDersAd()
        {
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();
                string query = "SELECT dersID, dersAd FROM tDers ORDER BY dersID";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DersIDComboBox.DataSource = dt;
                    DersIDComboBox.DisplayMember = "dersAd"; // Ders adını görüntülemek için dersAd alanını kullan
                    DersIDComboBox.ValueMember = "dersID"; // Ancak seçilen dersin ID'sini almak için hala dersID kullan
                    DersIDComboBox.SelectedIndex = -1; // İlk başta boş olmasını sağlar
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (DersIDComboBox.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir ders seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı tarafından seçilen ders ID'sini al
            string selectedDersID = DersIDComboBox.SelectedValue.ToString();

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Seçilen ders ID'sine göre sorgu
                string query = "SELECT ogrenciID, dersID, vize, final FROM tOgrenciDers WHERE dersID = @selectedDersID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@selectedDersID", selectedDersID);

                    // Sorgudan dönen sonuçları al
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);

                        // DataGridView'e veri yüklerken sütunlar otomatik olarak oluşturulsun
                        dataGridView1.AutoGenerateColumns = true;

                        // Sonuçları DataGridView'e yükle
                        dataGridView1.DataSource = table;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string ogrenciID = row.Cells["ogrenciID"].Value.ToString();
                    string dersID = row.Cells["dersID"].Value.ToString();
                    object vizeValue = row.Cells["vize"].Value ?? DBNull.Value;
                    object finalValue = row.Cells["final"].Value ?? DBNull.Value;

                    // Notları güncelleme sorgusu
                    string query = "UPDATE tOgrenciDers SET vize = @vize, final = @final WHERE ogrenciID = @ogrenciID AND dersID = @dersID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                        cmd.Parameters.AddWithValue("@dersID", dersID);
                        cmd.Parameters.AddWithValue("@vize", vizeValue);
                        cmd.Parameters.AddWithValue("@final", finalValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Notlar başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

