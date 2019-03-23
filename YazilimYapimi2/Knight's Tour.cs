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
    public partial class Knight_s_Tour : Form
    {
        public Knight_s_Tour()
        {
            InitializeComponent();
        }
        int asayisi, bsayisi;
        int mavi;
        public int boyut { get; set; }
        public void Mavi(int a, int b)
        {
            mavi = 0;
            if (a + 2 < boyut && b + 1 < boyut)
            {
                
                if(s[a+2,b+1].Text=="")
                {
                    s[a + 2, b + 1].BackColor = Color.Blue;
                    mavi++;
                }
               
            }
            if (a + 2 < boyut && b - 1 >= 0)
            {
                if(s[a + 2, b - 1].Text=="")
                {
                    s[a + 2, b - 1].BackColor = Color.Blue;
                    mavi++;
                }
                
            }
            if (a - 2 >= 0 && b - 1 >= 0)
            {
                if(s[a-2,b-1].Text=="")
                {
                    s[a - 2, b - 1].BackColor = Color.Blue;
                    mavi++;
                }
                
            }
            if (a - 2 >= 0 && b + 1 < boyut)
            {
                if(s[a-2,b+1].Text=="")
                {
                    s[a - 2, b + 1].BackColor = Color.Blue;
                    mavi++;
                }
               
            }
            if (a + 1 < boyut && b + 2 < boyut)
            {
                if(s[a+1,b+2].Text=="")
                {
                    s[a + 1, b + 2].BackColor = Color.Blue;
                    mavi++;
                }
                
            }
            if (a + 1 < boyut && b - 2 >= 0)
            {
                if(s[a + 1, b - 2].Text=="")
                {
                    s[a + 1, b - 2].BackColor = Color.Blue;
                    mavi++;
                }
                
            }
            if (a - 1 >= 0 && b - 2 >= 0)
            {
                if(s[a - 1, b - 2].Text=="")
                {
                    s[a - 1, b - 2].BackColor = Color.Blue;
                    mavi++;
                }
               
            }
            if (a - 1 >= 0 && b + 2 < boyut)
            {
                if(s[a - 1, b + 2].Text=="")
                {
                    s[a - 1, b + 2].BackColor = Color.Blue;
                    mavi++;
                }
                
            }
            if(mavi==0)
            {
                MessageBox.Show("Gidebilecegin hiçbir yer yok hamle sayin= "+(rakam-1));
                Application.Exit();
            }
            label2.Text = "Gidebilecegin "+mavi.ToString()+" Yer Var ";
        }
        int i = 0;
        Color p;
        int sayac = 5;
        int rakam = 1;
        Button[,] s = new Button[9, 9];
        private void Knight_s_Tour_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = boyut * 30;
            flowLayoutPanel1.Height = boyut * 30;
            
            for (int i = 0; i < boyut; i++)
            {


                for (int j = 0; j < boyut; j++)
                {
                    Button btn = new Button();
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Margin = new Padding(0);
                    btn.Click += Btn_Click;     
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Tag = i;
                    s[i, j] = btn;
                }
            }


           





        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;          
            p = tiklanan.BackColor;
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    s[i, j].BackColor = Color.White;
                }
            }
            if (i == 0)
            {   
                int a = tiklanan.Location.Y / 30;
                int b = tiklanan.Location.X / 30;
                asayisi = a;
                bsayisi = b;
                tiklanan.BackColor = Color.Red;
                tiklanan.Text = rakam.ToString();
                s[a, b].Enabled = false;
                label1.Text = "Hamle Sayisi "+rakam.ToString();
                
                rakam++;
                Mavi(a, b);
                
            }
            i++;

            if (p == Color.Blue && i != 0)
            {
                
                int a = tiklanan.Location.Y / 30;
                int b = tiklanan.Location.X / 30;
                asayisi = a;
                bsayisi = b;
                tiklanan.BackColor = Color.Red;
                tiklanan.Text = rakam.ToString();
                s[a, b].Enabled = false;
                label1.Text = "Hamle Sayısı " + rakam.ToString();
              
                if(rakam==boyut*boyut)
                {
                    MessageBox.Show("you win");
                    Application.Exit();
                }
                rakam++;
                Mavi(a, b);
            }
            if(p==Color.White)
            {
                Mavi(asayisi, bsayisi);
                MessageBox.Show("Yanlış  Yere Bastın Sadece Mavi Yerlere Oynuyabilirsin");
            }
        }
    }
}
