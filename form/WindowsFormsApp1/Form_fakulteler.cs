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
    public partial class Form_fakulteler : Form
    {
        SqlConnection con;
        public Form_fakulteler()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-DREPCQM\\SQLEXPRESS;Database=TEST_DB;Integrated Security = True");
            loadListBoxContent();
            tbFakulteAdi.Text = "";
            tbFakulteID.Text = "";
        }

        private void loadListBoxContent()
        {
            string query = "SELECT * FROM Fakulte";
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = con;
            cmd.CommandText = query;
            
            SqlDataAdapter da = new SqlDataAdapter();
            
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "FakulteAdi";
            listBox1.ValueMember = "FakulteID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fakulteid = tbFakulteID.Text;
            string fakulteadi = tbFakulteAdi.Text;
            con.Open();
            string sql = "insert into Fakulte values (@FakulteAdi)";
            SqlCommand komut = new SqlCommand(sql, con);
            komut.Parameters.Add(new SqlParameter("@FakulteAdi",fakulteadi));
            int d = komut.ExecuteNonQuery();

            if (d == 1)
                MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
            loadListBoxContent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fakulteid = tbFakulteID.Text;
            string fakulteadi = tbFakulteAdi.Text;
            con.Open();
            string sql = "update Fakulte set FakulteAdi = @FakulteAdi where FakulteID = @FakulteID";
            SqlCommand komut = new SqlCommand(sql, con);
            komut.Parameters.Add(new SqlParameter("@FakulteID", fakulteid));
            komut.Parameters.Add(new SqlParameter("@FakulteAdi", fakulteadi));

            int d = komut.ExecuteNonQuery();

            if (d == 1)
                MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
            loadListBoxContent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFakulteID.Text = listBox1.SelectedValue.ToString();
            tbFakulteAdi.Text = listBox1.GetItemText(listBox1.SelectedItem);

        }
    }
}
