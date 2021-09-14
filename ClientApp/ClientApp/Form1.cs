using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        Client client;

        public Form1()
        {
            InitializeComponent();
            client = new Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(client.StartConnection));
            thread.Start();
        }

        private void maskedTextBox1_Validated(object sender, EventArgs e)
        {
            client.address = maskedTextBox1.Text;
        }
    }
}