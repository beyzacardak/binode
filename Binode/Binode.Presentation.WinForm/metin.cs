using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binode.Presentation.WinForm
{
    public partial class metin : Form
    {
        public metin()
        {
            InitializeComponent();
        }

        private void MtnKaydet_Click(object sender, EventArgs e)
        {
            
        
            try
            {
                saveFileDialog1.Title = "Kayıt Yerinizi Seçiniz";
                saveFileDialog1.Filter = "(*.doc)|*.doc|(*.txt)|*.txt|Tüm dosyalar(*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter Kaydet = new StreamWriter(saveFileDialog1.FileName);
                Kaydet.WriteLine(richTextBox1.Text);
                Kaydet.Close();
                MessageBox.Show("Kaynak metin belgesine yazdırıldı.");
            }
            catch
            {
                MessageBox.Show("Kaynak metin belgesine yazdırılmadı!");
            }
        }
    
    }
}
