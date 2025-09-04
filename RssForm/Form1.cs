using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader dr = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa/");
            while(dr.Read())
            {
                if(dr.Name=="title")
                {
                    listBox1.Items.Add(dr.ReadString());
                }
            }
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader dr1 = new XmlTextReader("http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");
            while (dr1.Read())
            {
                if (dr1.Name == "title")
                {
                    listBox1.Items.Add(dr1.ReadString());
                }
            }
        }

        private void btnFotomac_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader dr2 = new XmlTextReader("https://www.fotomac.com.tr/rss/anasayfa.xml");
            while (dr2.Read())
            {
                if (dr2.Name == "title")
                {
                    listBox1.Items.Add(dr2.ReadString());
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string url = txtUrl.Text;
            XmlTextReader dr3 = new XmlTextReader(url);
            while (dr3.Read())
            {
                if (dr3.Name == "title")
                {
                    listBox1.Items.Add(dr3.ReadString());
                }
            }
        }
    }
}
