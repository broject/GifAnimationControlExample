using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GifAnimationControlExample
{
    public partial class Form2 : Form
    {
        private string _Title;

        public Form2(string title)
        {
            InitializeComponent();

            _Title = title;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Text = _Title;
        }
    }
}
