using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  
        FolderBrowserDialog fb = new FolderBrowserDialog();

        private void btnObzor_Click(object sender, EventArgs e)
        {
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txbxFirstFolder.Text = fb.SelectedPath;
            }
        }

        private void btnObzor2_Click(object sender, EventArgs e)
        {
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txbxSecondFolder.Text = fb.SelectedPath;
            }
        }

        private void btnGoSearch_Click(object sender, EventArgs e)
        {
            Founder f1 = new Founder(txbxFirstFolder.Text);
            Founder f2 = new Founder(txbxSecondFolder.Text);
            txbxRes1.Text+="Количество файлов: "+f1.getCountFiles().ToString()+Environment.NewLine;
            txbxRes2.Text += "Количество файлов: " + f2.getCountFiles().ToString() + Environment.NewLine;
            foreach (string item in f1.fileNames)
            {
                txbxRes1.Text += item + Environment.NewLine;
            }
            foreach (string item in f2.fileNames)
            {
                txbxRes2.Text += item + Environment.NewLine;
            }
        }
    }
}
