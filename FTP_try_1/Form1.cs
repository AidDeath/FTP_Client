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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_hostname.Text = Properties.Settings.Default.Hostname;
            textBox_port.Text = Properties.Settings.Default.Port;  // Загружаем сохранённые с прошлого раза данные
            textBox_login.Text = Properties.Settings.Default.Login;
            textBox_pwd.Text = Properties.Settings.Default.Pwd;
            if (Properties.Settings.Default.Savepwd == true)
            {
                checkBox_pwdsave.Checked = true;
            }
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {


            Properties.Settings.Default.Hostname = textBox_hostname.Text;
            Properties.Settings.Default.Port = textBox_port.Text;
            Properties.Settings.Default.Login = textBox_login.Text;
                if (checkBox_pwdsave.Checked)
                {
                Properties.Settings.Default.Pwd = textBox_pwd.Text;
                Properties.Settings.Default.Savepwd = true;
                }
             else
                {
                Properties.Settings.Default.Pwd = "";
                Properties.Settings.Default.Savepwd = false;
                }
            Properties.Settings.Default.Save();   // Сохраняем данные, чтобы не вводить заново

        }
    }
}
