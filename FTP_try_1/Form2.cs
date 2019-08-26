using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_try_1
{
    public partial class Form2 : Form
    {
        Form1 hForm1;

        public string result;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            hForm1 = f;
           // hForm1.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            result = textBox1.Text.ToString();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           // hForm1.Enabled = true;
        }
    }
}
