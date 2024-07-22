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
    public partial class ekran5 : Form
    {
        public ekran5()
        {
            InitializeComponent();
        }

        private void ekran5_Load(object sender, EventArgs e)
        {
            LoadYears();
            LoadSemesters();
        }
        private void LoadYears()
        {
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();
                string query = "SELECT DISTINCT yil FROM tOgrenciDers ORDER BY yil";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    YearComboBox.DataSource = dt;
                    YearComboBox.DisplayMember = "yil";
                    YearComboBox.ValueMember = "yil";
                    YearComboBox.SelectedIndex = -1;
                }
            }
        }

        private void LoadSemesters()
        {
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();
                string query = "SELECT DISTINCT yariyil FROM tOgrenciDers ORDER BY yariyil";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    SemesterComboBox.DataSource = dt;
                    SemesterComboBox.DisplayMember = "yariyil";
                    SemesterComboBox.ValueMember = "yariyil";
                    SemesterComboBox.SelectedIndex = -1;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ListeleButon_Click(object sender, EventArgs e)
        {
            // Kullanıcı tarafından seçilen yıl ve yarıyıl bilgisini al
            if (YearComboBox.SelectedItem == null || SemesterComboBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yıl ve yarıyıl seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedYear = YearComboBox.SelectedValue.ToString();
            string selectedSemester = SemesterComboBox.SelectedValue.ToString();

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Yıl ve yarıyıla göre derslerin ve kaç öğrenci tarafından seçildiğinin sorgusu
                string query = "SELECT d.dersAd, COUNT(*) AS OgrenciSayisi " +
                               "FROM tOgrenciDers od " +
                               "INNER JOIN tDers d ON od.dersID = d.dersID " +
                               "WHERE od.yil = @selectedYear AND od.yariyil = @selectedSemester " +
                               "GROUP BY d.dersAd";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear);
                    cmd.Parameters.AddWithValue("@selectedSemester", selectedSemester);

                    // Sorgudan dönen sonuçları al
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);

                        // Sonuçları DataGridView'e yükle
                        dataGridView2.DataSource = table;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrenciID = OgrenciIDTextBox.Text.Trim();

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=ZEYNEPSILA\\SQLEXPRESS;Initial Catalog=veri5;User ID=sa;Password=123456"))
            {
                con.Open();

                // Öğrencinin aldığı ders adlarının veritabanından seçilmesi
                string query = "SELECT d.dersAd FROM tOgrenciDers od INNER JOIN tDers d ON od.dersID = d.dersID WHERE od.ogrenciID = @ogrenciID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Ders adlarının bulunduğu bir liste oluştur
                    List<string> dersAdlari = new List<string>();
                    while (reader.Read())
                    {
                        dersAdlari.Add(reader["dersAd"].ToString());
                    }
                    reader.Close();

                    // Liste içeriğini DataGridView'e yükle
                    dataGridView1.DataSource = dersAdlari.Select(x => new { DersAdi = x }).ToList();
                }
            }
        
            
        }
    }
}
