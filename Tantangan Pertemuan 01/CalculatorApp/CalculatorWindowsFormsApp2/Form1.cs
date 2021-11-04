using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double a, b, hasil;

            if (comboHitung.SelectedIndex == 0)
            {
                a = Double.Parse(txtNilaiA.Text);
                b = Double.Parse(txtNilaiB.Text);
                hasil = a + b;
                txtHasil.Text = hasil.ToString();
            } 
            else if (comboHitung.SelectedIndex == 1)
            {
                a = Double.Parse(txtNilaiA.Text);
                b = Double.Parse(txtNilaiB.Text);
                hasil = a - b;
                txtHasil.Text = hasil.ToString();
            }
            else if (comboHitung.SelectedIndex == 2)
            {
                a = Double.Parse(txtNilaiA.Text);
                b = Double.Parse(txtNilaiB.Text);
                hasil = a * b;
                txtHasil.Text = hasil.ToString();
            }
            else if (comboHitung.SelectedIndex == 3)
            {
                a = Double.Parse(txtNilaiA.Text);
                b = Double.Parse(txtNilaiB.Text);
                hasil = a / b;
                txtHasil.Text = hasil.ToString();
            }
        }
    }
}
