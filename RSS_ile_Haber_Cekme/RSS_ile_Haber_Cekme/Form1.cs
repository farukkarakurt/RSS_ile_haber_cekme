using System;
using System.Windows.Forms;
using System.Xml;

namespace RSS_ile_Haber_Cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Ortak RSS çekme metodu
        private void RSSCek(string rssUrl)
        {
            try
            {
                XmlTextReader xmloku = new XmlTextReader(rssUrl);
                while (xmloku.Read())
                {
                    if (xmloku.Name == "title")
                    {
                        listBox1.Items.Add(xmloku.ReadString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RSS verisi alınırken bir hata oluştu: " + ex.Message);
            }
        }

        // Milliyet butonu tıklama olayı
        private void Milliyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Önceki sonuçları temizle
            RSSCek("https://www.milliyet.com.tr/rss/rssnew/ekonomi.xml");
        }

        // Cumhuriyet butonu tıklama olayı
        private void cumhuriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Önceki sonuçları temizle
            RSSCek("http://www.cumhuriyet.com.tr/rss/son_dakika.xml");
        }

        // Fotomaç butonu tıklama olayı
        private void fotomac_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Önceki sonuçları temizle
            RSSCek("https://www.fotomac.com.tr/rss/anasayfa.xml");
        }
    }
}
