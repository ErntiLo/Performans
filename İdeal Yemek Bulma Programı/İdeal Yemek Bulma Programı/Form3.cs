using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İdeal_Yemek_Bulma_Programı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            button1.Enabled = true;
           
            button3.Enabled = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        
            
                button1.Enabled = false;
                button3.Enabled = true;

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;

            

            listBox1.Items.Clear();
            listBox1.Items.Add(comboBox1.Text);
            if (comboBox1.Text == "Etli")
            {
                radioButton1.Text = "Döş";
                radioButton2.Text = "Pirzola";
                radioButton3.Text = "Kıyma";
                radioButton4.Text = "Biftek";
                radioButton5.Visible = false;
                radioButton6.Visible = false; 
                radioButton7.Visible = false;


            }
            else if (comboBox1.Text == "Sebzeli")
            {
                radioButton1.Text = "Patlıcan";
                radioButton2.Text = "Brokoli";
                radioButton3.Text = "Karnıbahar";
                radioButton4.Text = "Dolma Biber";
                radioButton5.Text = "Kabak";
                radioButton6.Text = "Patates";
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            comboBox2.Text = "";
            button1.Enabled = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            button3.Enabled = false;
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)

        {
            button3.Enabled = false;
            listBox2.Items.Clear();
            if (radioButton1.Checked)
            {
                listBox2.Items.Add(radioButton1.Text);
                if (radioButton1.Text == "Döş")
                {
                    comboBox2.Items.Add("Pastırma Burger");
                    comboBox2.Items.Add("Patlıcanlı Lavaş");
                    comboBox2.Items.Add("İrmikli Çanak Köfte");
                }
                else if (radioButton1.Text == "Patlıcan")
                {
                    
                    comboBox2.Items.Add("Zeytinyağlı Patlıcan Yemeği ");
                    comboBox2.Items.Add("Patlıcan Oturtma");
                    comboBox2.Items.Add("Şehzade Kebabı");

                }
            }
            else if (radioButton2.Checked)
            {
                listBox2.Items.Add(radioButton2.Text);
                if (radioButton2.Text == "Pirzola")
                {
                    comboBox2.Items.Add("Antep Fıstıklı Pirzola");
                    comboBox2.Items.Add("Beğendili Piliç Pirzola");
                    comboBox2.Items.Add("Domates Soslu Kuzu Pirzola");
                }
                else if (radioButton2.Text == "Brokoli")
                {
                    comboBox2.Items.Add("Fırında Beşamel Soslu Tavuklu Brokoli.");
                    comboBox2.Items.Add("Brokoli Graten.");
                    comboBox2.Items.Add(" Zeytinyağlı Brokoli .");
                }
            }
            else if (radioButton3.Checked)
            {
                listBox2.Items.Add(radioButton3.Text);
                if (radioButton3.Text == "Kıyma")
                {
                    comboBox2.Items.Add("Bolonez Soslu ( Kıymalı) Spagetti Makarna.");
                    comboBox2.Items.Add("Pideli Köfte");
                    comboBox2.Items.Add("Patatesli Sulu Köfte Yemeği");
                }
                else if (radioButton3.Text == "Karnıbahar")
                {
                    comboBox2.Items.Add("Karnabahar Biftek..");
                    comboBox2.Items.Add("Fırında Karnabahar");
                    comboBox2.Items.Add("Fırında Karnabahar Köftesi.  ");
                }
            }
            else if (radioButton4.Checked)
            {
                listBox2.Items.Add(radioButton4.Text);
                if (radioButton4.Text == "Biftek")
                {
                    comboBox2.Items.Add("Mantar Soslu Biftek.");
                    comboBox2.Items.Add("Sebzeli Biftek");
                    comboBox2.Items.Add("Enginarlı Dana Biftek");
                }
                else if (radioButton4.Text == "Dolma biber")
                {
                    comboBox2.Items.Add("Biber Dolması ");
                    comboBox2.Items.Add("Zeytin Yağlı biber Dolma");

                }
            }
            else if (radioButton5.Checked)
            {
                listBox2.Items.Add(radioButton5.Text);
                if (radioButton4.Text == "Kabak")
                {
                    comboBox2.Items.Add("Kabak Mücveri ");
                    comboBox2.Items.Add("Pirinçli Kabak Yemeği");
                    comboBox2.Items.Add("Zeytinyağlı Kabak Kavurma");
                }
            }
            else if (radioButton6.Checked)
            {
                listBox2.Items.Add(radioButton6.Text);
                if (radioButton4.Text == "Kabak")
                {
                    comboBox2.Items.Add("Kabak Mücveri ");
                    comboBox2.Items.Add("Pirinçli Kabak Yemeği");
                    comboBox2.Items.Add("Zeytinyağlı Kabak Kavurma");
                }
            }
            else if (radioButton7.Checked)
            {
                listBox2.Items.Add(radioButton7.Text);
                if (radioButton4.Text == "Patates")
                {
                    comboBox2.Items.Add("Çıtır Patates Çubukları ");
                    comboBox2.Items.Add("Fırında Yoğurtlu Patates Kızartması");
                    comboBox2.Items.Add("Fırında Başamel Soslu Patates");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox3.Items.Add(comboBox2.Text);
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
           if(comboBox2.Text =="Pastırma Burger")
            {
                label3.Text= "Pastırmalı Burger: Pastırmalı Hamburger Malzemeleri Köftesi için Malzemeler 500 gr. " +
               "dana döş kıyma 1 adet kırmızı soğan 1 tatlı kaşığı ketçap 5-6 dilim" +
               " pastırmanın dışında ki çemen 2 tutam tuz 1 tutam karabiber Üzeri için Malzemeler" +
               " 1 yemek kaşığı tereyağı 5-6 adet pastırma 3 dilim cheddar peyniri 3 adet hamburger ekmeği";
            } if(comboBox2.Text =="Patlıcanlı Lavaş")
            {
                label3.Text = "PATLICAN KEBABI 🍆\r\n- 500-600 GR KIYMA\r\n- 4-5 PATLICAN\r\n- 4-5 KAPYA BİBER 🌶️\r\n- 4-5 YESİL BİBER \r\n- 1 SOĞAN\r\n- 1 DOMATES 🍅\r\n- TEREYAĞI\r\n- SIVIYAĞ\r\n- BAHARAT\r\n- TUZ\r\nSOS\r\n- 1 KAŞIK DAMATES SALÇA\r\n- 1 KAŞIK BİBER SALCA \r\n- 1 CAY KAŞIĞI TUZ\r\n- BAHARAT\r\n- 1 SU BARDAĞI SU ( YADA AZ FAZLA)\r\nLAVAŞ İCİN\r\n- 1 SU BARDAĞI UN\r\n-  YARİM SU BARDAGINDAN AZ SU\r\n- 1 CAY KAŞIĞINDAN AZ TUZ\r\n";
            }if (comboBox2.Text =="İrmikli Çanak Köfte")
            {
                label3.Text = "🍥İrmikli ÇANAK KÖFTE🍥\r\n Malzemeler\r\n🍥600 gr. Kıyma\r\n🍥1 tane iri kuru soğan\r\n🍥1 tane yumurta\r\n🍥3 yemek kaşığı galeta unu veya irmik\r\n🍥3 yemek kaşığı zeytinyağı\r\n🍥1,5 tatlı kaşığı tuz\r\n🍥2 çay kaşığı karabiber\r\n🍥1 çay kaşığı kimyom\r\n                   Garnitürü için;\r\n🍥1 su bardağı haşlanmış bezelye\r\n🍥1 su bardağı haşlanmış havuç\r\n🍥1 su bardağı haşlanmış patates\r\n                    Üzeri için;\r\n🍥2 tane haşlanmış büyük patates\r\n🍥1 yemek kaşığı tereyağı\r\n🍥1 çay kaşığı tuz\r\nAyrıca dilim kaşar peyniri \r\n                   Sos için;\r\n🍥1 yemek kaşığı salça\r\n🍥2 su bardağı sıcak su\r\n                    YAPILIŞI;\r\n        Derin kabın içine kıymayı,rendelenmiş suyu sıkılmış soğanı,yumurtayı,zeytinyağını,galeta ununu,tuzu ve baharatları ekleyip karıştıralım.Yumurta büyüklüğünde yuvarlayıp üzerine hafif bastıralım.Bardak yardımı ile çanak şekli verelim.Tepsiye dizelim🍥Üzerine garnitürü yerleştirelim.Garnitürün üzerine kaşarları koyalım🍥Haşlamış olduğumuz patatesleri tereyağı ve tuz ile birlikte ezici yardımı ile püre yapalım.Püreyi krema torbasına koyup köfte çanaklarının üzerine sıkalım🍥Salça ve suyu çırpıcı ile karıştıralım.Garnitürlü çanak köftelerin arasına dökelim🍥Önceden ısıtılmış 180 derecelik fırında patates pürelerinin rengi hafif pemeleşene kadar pişirelim.\r\n     🍥🍥🍥AFİYET OLSUN...";
            } if(comboBox2.Text == "Zeytinyağlı Patlıcan Yemeği")
            {
                label3.Text = "5 adet patlıcan\r\n1 adet kuru soğan\r\n3 adet yeşil biber\r\n2 adet kırmızı biber\r\n2 adet domates rendesi (ben 4-5 yemek kaşığı domates sosu kullandım)\r\nYarım çay bardağı zeytinyağı\r\n1 tatlı kaşığı tuz\r\nPatlıcanları bekletmek için;\r\n\r\n1 tatlı kaşığı tuz\r\nSu" +
                    "İlk olarak patlıcanlar alacalı soyularak uzunlamasına 4’e bölelim, sonrasında küp küp dilimleyelim. Patlıcanlar tuzlu suda yaklaşık 20 dakika kadar beklemeye bırakalım.\r\nBu arada soğanları yemeklik doğrayalım. Yeşil biberi de çok kalın olmayacak şekilde doğrayalım.\r\nKırmızı biberin içlerini boşaltarak onları da aynı şekilde doğrayalım.\r\nSebzeleri doğrama işlemi bittikten sonra tencereye zeytinyağını alarak soğanları ekleyelim, kavuralım.\r\nSoğanlar hafif pembeleştikten sonra biberleri de ekleyelim. Diriliği gidene kadar orta ateşte kavurmaya devam edelim.\r\n2-3 dakika kavrulduktan sonra domates sosunu da ekleyerek karıştıralım.\r\nTuzu da ilave ederek yemeğimizi tekrar karıştıralım.\r\nTuzlu suyun içinden almış olduğumuz patlıcanları da ekleyerek dikkatli bir şekilde karıştıralım.\r\nTencerenin kapağını kapatalım ve ara ara karıştırarak yemeğin kendi suyu ile pişmesi sağlayalım. Bu aşamada ocağın yüksek ateşte olmamasına dikkat edelim.\r\nPatlıcanlar yumuşayıp piştikten sonra ocak kapatalım ve servis edelim. Afiyet olsun.\r\nBu yemeği ister soğuk ister sıcak tüketebilirsiniz. Biz soğuk daha çok seviyoruz ama sıcak da güzel oluyor tercih sizin:)\r\n\r\nBu tarifte de domates sosu kullandım özellikle kış döneminde birçoğumuz gibi domates almıyoruz, yazdan hazırlayarak kış boyu tüketiyoruz.  Bu yaz sizde bizimle bu soslardan hazırlayabilirsiniz beğeneceğinize eminim:)";
            }





        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
