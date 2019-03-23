using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            
            int boyut;

            if (rdb5x5.Checked)
            {
                MessageBox.Show("25 hamlede oyunu bitirmeye çalış");
                boyut = 5;
                Knight_s_Tour frm2 = new Knight_s_Tour();
                frm2.boyut = boyut;
                this.Hide();
                frm2.Show();

            }
            if (rdb6x6.Checked)
            {
                MessageBox.Show("36 hamlede oyunu bitirmeye çalış");
                boyut = 6;
                Knight_s_Tour frm2 = new Knight_s_Tour();
                frm2.boyut = boyut;
                this.Hide();
                frm2.Show();
            }
            if (rdb7x7.Checked)
            {
                MessageBox.Show("49 hamlede oyunu bitirmeye çalış");
                boyut = 7;
                Knight_s_Tour frm2 = new Knight_s_Tour();
                frm2.boyut = boyut;
                this.Hide();
                frm2.Show();

            }
            if (rdb8x8.Checked)
            {
                MessageBox.Show("64 hamlede oyunu bitirmeye çalış");
                boyut = 8;
                Knight_s_Tour frm2 = new Knight_s_Tour();
                frm2.boyut = boyut;
                this.Hide();
                frm2.Show();

            }
            if (rdb9x9.Checked)
            {
                MessageBox.Show("81 hamlede oyunu bitirmeye çalış");
                boyut = 9;
                Knight_s_Tour frm2 = new Knight_s_Tour();
                frm2.boyut = boyut;
                this.Hide();
                frm2.Show();

            }
        }
    }
}
