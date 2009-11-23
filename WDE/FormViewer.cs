using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WDE
{
    public partial class FormViewer : Form
    {
        public FormViewer()
        {
            InitializeComponent();
        }

        private void FormViewer_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = toolStripButton1.Checked;
        }

        public void SetText(string filename)
        {
            if (System.IO.File.Exists(filename))
            {
                textBox1.Clear();
                System.IO.StreamReader tr = new System.IO.StreamReader(filename, System.Text.Encoding.Default);
                textBox1.Text = tr.ReadToEnd();
                textBox1.Refresh();
                textBox1.DeselectAll();
                tr.Close();                
            }
        }


    }
}
