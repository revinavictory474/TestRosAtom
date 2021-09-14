﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class Form1 : Form
    {
        Server srv;

        public Form1()
        {
            InitializeComponent();
            srv = new Server();
        }

        private void maskedTextBox1_Validated(object sender, EventArgs e)
        {
            srv.IP = maskedTextBox1.Text;
            Thread thread = new Thread(new ThreadStart(srv.StartServer));
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srv.StartAnimate();
        }
    }
}
