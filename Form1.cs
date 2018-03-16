using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THTTHTTHT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 arge = new Form2();
            arge.Show();
            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StajyerAsistanKulübü stajyer = new StajyerAsistanKulübü();
            stajyer.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 kalilinux = new Form4();
            kalilinux.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 smkulübü = new Form5();
            smkulübü.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 alay = new Form6();
            alay.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 islam = new Form7();
            islam.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 tarih = new Form8();
            tarih.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 dergi = new Form9();
            dergi.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 tersine = new Form10();
            tersine.Show();

        }
    }
}
