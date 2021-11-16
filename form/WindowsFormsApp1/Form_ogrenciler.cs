using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_ogrenciler : Form
    {
        SqlConnection con;
        public Form_ogrenciler()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConString"].ConnectionString);
            ogrenci_getir();
            bolumleri_getir();
        }

        private void bolumleri_getir()
        {
            string query = "SELECT * FROM Bolum";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_ogrbolum.DataSource = dt;
            cb_ogrbolum.DisplayMember = "BolumAdi";
            cb_ogrbolum.ValueMember = "BolumID";
        }

        private void ogrenci_getir()
        {
            con.Open();
            string sql = "SELECT * from ogrenci";
            
            SqlCommand komut = new SqlCommand(sql, con);
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;
      
            con.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb_ogrno.Text = ID + "";
            tb_ogradi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_ogrsoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_ogrbolum.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            dtp_kayittarihi.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            dtp_dogumtarihi.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            tb_tckimlikno.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_ogrekle_Click(object sender, EventArgs e)
        {
            if (tb_ogrno.Text != "" && tb_ogradi.Text != "" && tb_ogrsoyadi.Text != "" && tb_tckimlikno.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into Ogrenci (OgrenciNo,Adi,Soyadi,BolumID,KayitTarihi,DogumTarihi,TCKimlikNo)" +
                    "values(@OgrenciNo,@Adi,@Soyadi,@BolumID,@KayitTarihi,@DogumTarihi,@TCKimlikNo)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@OgrenciNo", tb_ogrno.Text);
                cmd.Parameters.AddWithValue("@Adi", tb_ogradi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", tb_ogrsoyadi.Text);
                cmd.Parameters.AddWithValue("@BolumID", cb_ogrbolum.SelectedValue);
                cmd.Parameters.AddWithValue("@KayitTarihi", dtp_kayittarihi.Value);
                cmd.Parameters.AddWithValue("@DogumTarihi", dtp_dogumtarihi.Value);
                cmd.Parameters.AddWithValue("@TCKimlikNo", tb_tckimlikno.Text);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarı İle Eklendi.");
                ogrenci_getir();
                veri_temizle();
            }
            else
            {
                MessageBox.Show("Eksik bilgiler var!");
            }
        }

        private void veri_temizle()
        {
            tb_tckimlikno.Text = "";
            tb_ogradi.Text = "";
            tb_ogrsoyadi.Text = "";
            tb_ogrno.Text = "";
            dtp_dogumtarihi.Value = DateTime.Now;
            dtp_kayittarihi.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri_temizle();
        }

        private void btn_ogrencisil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Ogrenci where OgrenciNo = @OgrenciNo", con);
            con.Open();
            cmd.Parameters.AddWithValue("@OgrenciNo", dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarı İle Güncellendi.");
            ogrenci_getir();
            veri_temizle();
        }

        private void btn_ogrguncelle_Click(object sender, EventArgs e)
        {
            if (tb_ogrno.Text != "" && tb_ogradi.Text != "" && tb_ogrsoyadi.Text != "" && tb_tckimlikno.Text != "")
            {
                if (tb_ogrno.Text.Length != 9 || tb_tckimlikno.Text.Length != 11)
                {
                    MessageBox.Show("Öğrenci numarası 9, Kimlik No 11 rakam içerir. ");
                    return;
                }

                SqlCommand cmd = new SqlCommand("update Ogrenci set OgrenciNo = @OgrenciNo, Adi = @Adi,Soyadi = @Soyadi,BolumID=@BolumID,KayitTarihi=@KayitTarihi," +
                    "DogumTarihi=@DogumTarihi,TCKimlikNo=@TCKimlikNo where OgrenciNo = @EOgrenciNo", con);
                con.Open();
                cmd.Parameters.AddWithValue("@EOgrenciNo", dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                cmd.Parameters.AddWithValue("@OgrenciNo", tb_ogrno.Text);
                cmd.Parameters.AddWithValue("@Adi", tb_ogradi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", tb_ogrsoyadi.Text);
                cmd.Parameters.AddWithValue("@BolumID", cb_ogrbolum.SelectedValue);
                cmd.Parameters.AddWithValue("@KayitTarihi", dtp_kayittarihi.Value);
                cmd.Parameters.AddWithValue("@DogumTarihi", dtp_dogumtarihi.Value);
                cmd.Parameters.AddWithValue("@TCKimlikNo", tb_tckimlikno.Text);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarı İle Güncellendi.");
                ogrenci_getir();
                veri_temizle();
            }
            else
            {
                MessageBox.Show("Eksik bilgiler var!");
            }
        }

        private void tb_ogrno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tb_ogrno.Text.Length == 9 && !char.IsControl(e.KeyChar))
            {
                    e.Handled = true;
            }
        }

        private void tb_tckimlikno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tb_ogrno.Text.Length == 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_ogradi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_ogrsoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
