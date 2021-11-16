using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-DREPCQM\\SQLEXPRESS;Database=TEST_DB;Integrated Security = True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string sifre = textBox2.Text;
            con.Open();
            string sql = "select * from Kullanici where KullaniciAdi = @KullaniciAdi and Sifre = @Sifre";
            SqlCommand komut = new SqlCommand(sql,con);
            komut.Parameters.Add(new SqlParameter("@KullaniciAdi", kadi));
            komut.Parameters.Add(new SqlParameter("@Sifre", sifre));

            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
                MessageBox.Show("Hatalı giriş yaptınız!");

            con.Close();


        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { button1_Click(this,new EventArgs()); }
        }
    }
}
