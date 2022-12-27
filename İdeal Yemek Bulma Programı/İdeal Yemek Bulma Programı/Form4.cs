using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İdeal_Yemek_Bulma_Programı
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, indeks = 0;
            
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);

            indeks = kilo / (boy * boy);
                MessageBox.Show("indeksiniz " + indeks);
            if (indeks < 18)
            {
                label3.Text=("Zayıf");                 
            }
            else if (indeks >= 18 && indeks < 25)
            {
                label3.Text = ("Normal");
            }
            else if (indeks >= 25 && indeks < 30)
            {
                label3.Text = ("Kilolu");
            }
            else if (indeks >= 30 && indeks < 35)
            {
                label3.Text = ("Obez");
            }
            else 
            {
                label3.Text = ("Ciddi Obez");
            }

            if (boy > 300)
            {
                MessageBox.Show("GEÇERLİ BİR BOY GİRİNİZ");
                label3.Text = ("");
            } if(kilo>700)
            {
                MessageBox.Show("GEÇERLİ BİR KİLO GİRİNİZ");
                label3.Text = ("");
            }
            


        }
    }
}
