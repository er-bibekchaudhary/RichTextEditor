using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWordPad
{
    public partial class MyWordPad : Form
    {
        public MyWordPad()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MyWordPad_Load(object sender, EventArgs e)
        {
            TxtDateTime.Text = DateTime.Today.ToLongDateString();
            TxtWordCount.Text = "0";
        }

        private void WordProcessingarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtWordCount.Text = (WordProcessingarea.TextLength + 1).ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordProcessingarea.Text = "";
            TxtWordCount.Text = "0";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DilOpenFile.ShowDialog();
            
        }

        private void SaveFile_FileOk(object sender, CancelEventArgs e)
        {
            string FileName = SaveFile.FileName;
            WordProcessingarea.SaveFile(FileName);
        }

        

        
    }
}
