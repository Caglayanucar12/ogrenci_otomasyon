using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_fakulteler frm_f = new Form_fakulteler();
            frm_f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_bolumler frm_b = new Form_bolumler();
            frm_b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_ogrenciler frm_o = new Form_ogrenciler();
            frm_o.Show();
        }
    }
}
