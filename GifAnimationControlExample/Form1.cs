using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GifAnimationControlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(button1.Text);
            f.ShowDialog();
        }

        private void gifImageControl1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://loadinggif.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.gif)|*.gif";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(ofd.FileName);
                gifImageControl1.LoadingImage = bitmap;
            }
        }
    }
}
