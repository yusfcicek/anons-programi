using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Media;
using Microsoft.Win32;

namespace Anons_Programı
{
    public partial class Form1 : Form
    {
        string program_adi = "Anons Programi";
        static bool karsilastir_deger = false;

        SoundPlayer player = new SoundPlayer();

        OleDbConnection baglanti = new OleDbConnection
            (" Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=anons_sistemi_veri_tabani.accdb");
        

        public Form1()
        {
            InitializeComponent();

            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                String value = (String)key.GetValue(program_adi);

                if (String.IsNullOrEmpty(value))
                {
                    otoBaslat_checkBox.Checked = false;
                }

                else if (value == "\"" + Application.ExecutablePath + "\"")
                {
                    otoBaslat_checkBox.Checked = true;
                }
            }
            catch
            {

            }
        }

        private bool ses_calma(int i)
        {
            try
            {
                string path = dataGridView1.Rows[i].Cells[2].Value.ToString();
                player.SoundLocation = path;
                player.Play();
                return true;
            }
            catch
            {
                MessageBox.Show("Ses Dosyası Bulunamadı ya da Geçerli Değil!");
                return false;
            }
        }

        private void baglantigoruntule()
        {
            string[] Saatler = new string[5];

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();

            komut.Connection = baglanti;
            komut.CommandText = ("Select * From Saatler");
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                Saatler[0] = oku["ID"].ToString();
                Saatler[1] = oku["Saatler"].ToString();
                Saatler[2] = oku["Ses_Dosyasi"].ToString();
                dataGridView1.Rows.Add(Saatler);
            }

            baglanti.Close();
        }

        private void karsilastir()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();

            komut.Connection = baglanti;
            komut.CommandText = ("Select * From Saatler");
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (oku["Saatler"].ToString() == saat_txt.Text.ToString())
                {
                    karsilastir_deger = true;
                    break;
                }
            }

            baglanti.Close();
        }

        private void kontrol_et()
        {

            karsilastir();

            if (karsilastir_deger == true)
            {
                MessageBox.Show("Aynı Saatte Başka Bir Anons Yapılıyor. Lütfen Başka Saat Seçiniz.", "Uyarı!");
                karsilastir_deger = false;
            }

            else
            {
                if (saat_txt.Text != "" && sesDosyasi_txt.Text != "")
                {
                    try
                    {
                        baglanti.Open();

                        string ekle = "insert into Saatler(Saatler,Ses_Dosyasi) values (@Saatler,@Ses_Dosyasi)";
                        OleDbCommand komut = new OleDbCommand(ekle, baglanti);

                        komut.Parameters.AddWithValue("@Saatler", saat_txt.Text);
                        komut.Parameters.AddWithValue("@Ses_Dosyasi", sesDosyasi_txt.Text);

                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Anons Bilgisi Başarıyla Eklendi");
                        saat_txt.Text = "";
                        sesDosyasi_txt.Text = "";
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Geçerli İfade Giriniz!", "Uyarı!");
                        baglanti.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Değerlerden hiçbiri boş bırakılamaz!", "Uyarı!");
                }
            }
        }

        private void kayit_guncelle(int id)
        {
            DialogResult c;
            c = MessageBox.Show("Seçili satırı güncellemek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (c == DialogResult.Yes)
            {
                if (saat_txt.Text != "" && sesDosyasi_txt.Text != "")
                {
                    try
                    {
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand();

                        komut.Connection = baglanti;
                        komut.CommandText = "update Saatler set Saatler='" + saat_txt.Text + "', Ses_Dosyasi='" + sesDosyasi_txt.Text + "'where ID=" + id + "";
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kayıt Başarıyla Güncellendi");
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Geçerli İfade Giriniz!", "Uyarı!");
                        baglanti.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Değerlerden hiçbiri boş bırakılamaz!", "Uyarı!");
                }
            }
        }

        private void kayit_sil(int id)
        {
            DialogResult c;
            c = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();

                komut.Connection = baglanti;
                komut.CommandText = "Delete from Saatler where ID=" + id + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string saat = "";

                if (DateTime.Now.Minute < 10)
                {
                    saat = DateTime.Now.Hour.ToString() + ":0" + DateTime.Now.Minute.ToString();

                }
                else
                {
                    saat = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                }

                if (saat == dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    if (!ses_calma(i))
                    {
                        timer1.Interval = 60000;
                        continue;
                    }
                }

                timer1.Interval = 60000;

            }
        }

        private void otoBaslat_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (otoBaslat_checkBox.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(program_adi, "\"" + Application.ExecutablePath + "\"");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(program_adi);
            }
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            kontrol_et();
            dataGridView1.Rows.Clear();
            baglantigoruntule();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen listeyi güncelleyiniz!", "Uyarı!");
            }

            else
            {
                int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                kayit_guncelle(index);

                dataGridView1.Rows.Clear();
                saat_txt.Text = "";
                sesDosyasi_txt.Text = "";
                baglantigoruntule();
            }
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen listeyi güncelleyiniz!", "Uyarı!");
            }

            else
            {
                int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                kayit_sil(index);

                dataGridView1.Rows.Clear();
                saat_txt.Text = "";
                sesDosyasi_txt.Text = "";
                baglantigoruntule();
            }
        }

        private void dosyaSec_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Ses Dosyası |*.wav";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Ses Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                sesDosyasi_txt.Text = file.FileName;
            }
        }

        private void durdur_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            saat_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sesDosyasi_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglantigoruntule();
            timer1.Start();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            saat_txt.Text = "";
            sesDosyasi_txt.Text = "";
        }
    }
}
