using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300101
{
    public partial class Form1 : Form
    {
        int angka = 0, sum = 0;
        bool duaDigit = false;
        String clikTambah = "";
        string result = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 1;
                duaDigit = true;
            } else
            {
                angka = (angka * 10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 2;
                duaDigit = true;
            } else
            {
                angka = (angka * 10);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 3;
                duaDigit = true;
            } else
            {
                angka = (angka * 10);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 4;
                duaDigit = true;
            } else
            {
                angka = (angka * 10);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 5;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 6;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 7;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 8;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 9;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 0;
                duaDigit = true;
            }
            else
            {
                angka = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sum += angka;
            clikTambah += angka;
            textBox1.Text = clikTambah;
            angka = 0;
            duaDigit = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sum += angka;
            clikTambah += angka;
            textBox1.Text = clikTambah;
            result += "" + sum;
            textBox1.Text = result;
            sum = 0;
            angka = 0;
            duaDigit = false;
        }
    }
}
