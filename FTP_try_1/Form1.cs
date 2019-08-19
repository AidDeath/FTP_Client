using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace FTP_try_1
{
 
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            // Загружаем сохранённые с прошлого раза данные
            textBox_hostname.Text = Properties.Settings.Default.Hostname;
            textBox_port.Text = Properties.Settings.Default.Port;  
            textBox_login.Text = Properties.Settings.Default.Login;
            textBox_pwd.Text = Properties.Settings.Default.Pwd;
            if (Properties.Settings.Default.Savepwd == true)
            {
                checkBox_pwdsave.Checked = true;
            }


            // Получаем список дисков локальной машины и заносим в comboBox
            string[] Drives = Environment.GetLogicalDrives();
            foreach (string s in Drives)
            {
                comboBox_Drive.Items.Add(s);
            }
            comboBox_Drive.SelectedIndex = 0;
           

 
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {

            // Сохраняем данные, чтобы не вводить заново
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
            Properties.Settings.Default.Save();   // Сохранено


          
           
            dataGridView1.Rows.Add(Properties.Resources.dir, "File_or_folder_name", "size_of_it");

                           
            // ((DataGridViewImageCell)dataGridView1.Rows[0].Cells[0]).Value =  Fileicon;
            // dataGridView1.Rows[0].Cells[0].Value         

        }

    }
}
