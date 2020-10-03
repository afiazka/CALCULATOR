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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Double Penjumlahan(Double a, Double b)
        {
            return a + b;
        }
        private Double Pengurangan(Double a, Double b)
        {
            return a - b;
        }
        private Double Perkalian(Double a, Double b)
        {
            return a * b;
        }
        private Double Pembagian(Double a, Double b)
        {
            return a / b;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Double nilai1, nilai2, hasils;

            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih Dulu Operasinya!!!");
            }
            else if (comboBox.SelectedIndex == 0)
            {
                nilai1 = Double.Parse(nilaiA.Text);
                nilai2 = Double.Parse(nilaiB.Text);
                hasils = Penjumlahan(nilai1, nilai2);

                hasil.Text = hasils.ToString();
            }
            else if (comboBox.SelectedIndex == 1)
            {
                nilai1 = Double.Parse(nilaiA.Text);
                nilai2 = Double.Parse(nilaiB.Text);
                hasils = Pengurangan(nilai1, nilai2);

                hasil.Text = hasils.ToString();
            }
            else if (comboBox.SelectedIndex == 2)
            {
                nilai1 = Double.Parse(nilaiA.Text);
                nilai2 = Double.Parse(nilaiB.Text);
                hasils = Perkalian(nilai1, nilai2);

                hasil.Text = hasils.ToString();
            }
            else if (comboBox.SelectedIndex == 3)
            {
                nilai1 = Double.Parse(nilaiA.Text);
                nilai2 = Double.Parse(nilaiB.Text);
                hasils = Pembagian(nilai1, nilai2);

                hasil.Text = hasils.ToString();
            }
        }
    }
}
