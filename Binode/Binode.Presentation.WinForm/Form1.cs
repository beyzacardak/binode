using Binode.Data.Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var kategoriler = DemoData.DemoKategoriGetir();
            KategoriyiTreeviewAEkle(kategoriler, null);
        }

        private void KategoriyiTreeviewAEkle(List<Kategori> kategoriler, TreeNode node)
        {
            foreach (var kategori in kategoriler)
            {
                if(node == null)
                {
                    var nnode = new TreeNode(kategori.Isim);
                    nnode.ContextMenuStrip = contextMenuStrip1;
                    treeKategori.Nodes.Add(nnode);
                    nnode.Tag = kategori;

                    if(kategori.AltKategori != null)
                    {
                        KategoriyiTreeviewAEkle(kategori.AltKategori, nnode);
                    }
                }
                else
                {
                    var nnode = node.Nodes.Add(kategori.Isim);
                    nnode.ContextMenuStrip = contextMenuStrip1;

                    nnode.Tag = kategori;
                    if (kategori.AltKategori != null)
                    {
                        KategoriyiTreeviewAEkle(kategori.AltKategori,nnode);
                    }
                }
            }

        }

        private void treeKategori_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();

            ListViewDoldur(e.Node);
        }

        private void ListViewDoldur(TreeNode node)
        {
            var kategori = node.Tag as Kategori;

            //Hatalı olabilir
            if(kategori?.Icerik?.Count == null)
            {
                return;
            }

            var group = new ListViewGroup();
            group.Name = kategori.Isim;
            group.Header = kategori.Isim;

            listView1.Groups.Add(group);
            foreach (var icerik in kategori.Icerik)
            {
                var li = new ListViewItem(new[] { icerik.Isim, kategori.Isim });
                li.Group = group;
                listView1.Items.Add(li);
            }

            //listView1.Groups.Add(group);

            if(node.Nodes != null)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    ListViewDoldur(subNode);
                }
            }
        }

        private void metinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metin mtn = new metin();
            mtn.Show();
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Kayıt Yerinizi Seçiniz";
                saveFileDialog1.Filter = "(*.pdf)|*.pdf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter Kaydet = new StreamWriter(saveFileDialog1.FileName);
                Kaydet.WriteLine(@""+(saveFileDialog1.FileName)+""+DateTime.Now);
                Kaydet.Close();
                MessageBox.Show("Kaynak oluşturuldu.");
            }
            catch
            {
                MessageBox.Show("Kaynak oluşturulamadı!");
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (toolStripMenuItem1.Text == null)
                return;
            else
            {
                treeKategori.SelectedNode.Text = toolStripTextBox1.Text;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;
            TreeNode secilen;
            secilen = treeKategori.SelectedNode;
            secilen.Nodes.Add(textBox.Text);

        }

        private void toolStripTextBox2_Enter(object sender, EventArgs e)
        {
            //TreeNode secilen;
            //secilen = treeKategori.SelectedNode;
            //secilen.Nodes.Add(toolStripTextBox2.Text);
        }

        //private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        //{
        //    TreeNode secilen;
        //    secilen = treeKategori.SelectedNode;
        //    secilen.Nodes.Add(toolStripTextBox2.Text);

        //}

        //private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        //{
        //    TreeNode secilen;
        //    secilen = treeKategori.SelectedNode;
        //    secilen.Nodes.Add(toolStripTextBox2.Text);

        //}

    }
}
