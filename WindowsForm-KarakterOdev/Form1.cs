using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_KarakterOdev
{
    public partial class Form1 : Form
    {
        BackCode backCode;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbGirdi.Text))
            {
                MessageBox.Show("Lütfen metin giriniz!");
                return;
            }
            else
            {
                rtbSonuc.Text = backCode.KarakterKontrol(rtbGirdi.Text);
                rtbSonuc.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backCode = new BackCode();//Burda newlenme sebebi butona her basıldığında hafızada yeni bir işlem yapmaması için
        }
    }
}
