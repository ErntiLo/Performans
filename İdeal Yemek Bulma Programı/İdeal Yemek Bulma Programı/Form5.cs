using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İdeal_Yemek_Bulma_Programı
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            int adet = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i <= adet; i++)
            {
                listBox1.Items.Add(ad);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
