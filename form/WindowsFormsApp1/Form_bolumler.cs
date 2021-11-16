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
    public partial class Form_bolumler : Form
    {
        SqlConnection con;
        public Form_bolumler()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-DREPCQM\\SQLEXPRESS;Database=TEST_DB;Integrated Security = True");
            loadListBoxContent();
            loadComboBoxContent();
            tbBolumAdi.Text = "";
            tbBolumID.Text = "";
        }

        private void loadComboBoxContent()
        {
            string query = "SELECT * FROM Fakulte";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cbFakulte.DataSource = dt;
            cbFakulte.DisplayMember = "FakulteAdi";
            cbFakulte.ValueMember = "FakulteID";

        }

        private void loadListBoxContent()
        {
            string query = "SELECT * FROM Bolum";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "BolumAdi";
            listBox1.ValueMember = "BolumID";

        }

        private void Form_bolumler_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView rw = (DataRowView)listBox1.SelectedItem;
            tbBolumID.Text = rw["BolumID"].ToString(); //listBox1.SelectedValue.ToString();
            tbBolumAdi.Text = rw["BolumAdi"].ToString(); //listBox1.GetItemText(listBox1.SelectedItem);
            cbFakulte.SelectedValue = rw["FakulteID"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bolumadi = tbBolumAdi.Text;
            int fakulteid = Convert.ToInt32(cbFakulte.SelectedValue);
            con.Open();
            string sql = "insert into Bolum values (@BolumAdi,@FakulteID)";
            SqlCommand komut = new SqlCommand(sql, con);
            komut.Parameters.Add(new SqlParameter("@BolumAdi", bolumadi));
            komut.Parameters.Add(new SqlParameter("@FakulteID", fakulteid));

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
            int bolumid = Convert.ToInt32(tbBolumID.Text);
            string bolumadi = tbBolumAdi.Text;
            int fakulteid = Convert.ToInt32(cbFakulte.SelectedValue);
            con.Open();
            string sql = "update Fakulte set BolumAdi = @BolumAdi, FakulteID = @FakulteID where BolumID = @BolumID";
            SqlCommand komut = new SqlCommand(sql, con);
            komut.Parameters.Add(new SqlParameter("@BolumAdi", bolumadi));
            komut.Parameters.Add(new SqlParameter("@FakulteID", fakulteid));
            komut.Parameters.Add(new SqlParameter("@BolumID", bolumid));


            int d = komut.ExecuteNonQuery();

            if (d == 1)
                MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
            loadListBoxContent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bolumid = (int) listBox1.SelectedValue;
            con.Open();
            string sql = "delete from Bolum where BolumID = @BolumID";
            SqlCommand komut = new SqlCommand(sql, con);
            komut.Parameters.Add(new SqlParameter("@BolumID", bolumid));

            int d = komut.ExecuteNonQuery();

            if (d == 1)
                MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
            loadListBoxContent();
        }
    }
}
