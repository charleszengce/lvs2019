﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(textBox1.Text);
            webBrowser1.Refresh();
            webBrowser1.WebBrowserShortcutsEnabled = true;
        }
    }
}
