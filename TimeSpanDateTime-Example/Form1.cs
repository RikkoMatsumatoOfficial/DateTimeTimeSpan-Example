using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpanDateTime_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("h:mm tt");
            timespantext.Text = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(343);
        }
    }
}
