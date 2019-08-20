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
        DriveInfo[] Drives = DriveInfo.GetDrives();
        string LocalPath = "";

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
                    // Способ 1 
                    /*
            string[] Drives = Environment.GetLogicalDrives();
            foreach (string s in Drives)
            {
                comboBox_Drive.Items.Add(s);
            }       */
                    // Способ 2
            //DriveInfo[] Drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in Drives)
            {
                comboBox_Drive.Items.Add(d.Name);
            }

           
            comboBox_Drive.SelectedIndex = 0;
            // label7.Text += (Drives[comboBox_Drive.SelectedIndex].AvailableFreeSpace) / 1024 / 1024 + " МБайт";
            // ShowLocalFiles(Drives[comboBox_Drive.SelectedIndex].Name);


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


          
           
            dataGridView1.Rows.Add(Properties.Resources.dir, "File_or_folder_name", "size_of_it", "created_date");
                     

        }


        private void ShowLocalFiles(string s)
        {
            dataGridView2.Rows.Clear();

            //string[] filelist = Directory.GetFileSystemEntries(@s);
            string[] filelist = Directory.GetFiles(s);

            foreach (string  current in filelist)
            {
                FileInfo f = new FileInfo(@s);
                dataGridView2.Rows.Add(Properties.Resources.file, f.Name, f.CreationTime);

            }
        }


        private void ShowLocalRootFiles(object sender, EventArgs e)
        {
            label7.Text = "Свободно: " + (Drives[comboBox_Drive.SelectedIndex].AvailableFreeSpace) / 1024 / 1024 + " Мб";
            //обновляем свободное место диска

            LocalPath = comboBox_Drive.Text;
            dataGridView2.Rows.Clear();  // Чистим от старых данных 
            ShowContents(LocalPath);
        }

        private void ShowContents(string path)   //Вывод локальных файлов и папок
        {
            //Выводим папки
            string[] dirlist = Directory.GetDirectories(path);
            foreach (string current in dirlist)
            {
                DirectoryInfo d = new DirectoryInfo(current);
                dataGridView2.Rows.Add(Properties.Resources.dir, d.Name, "<DIR>", d.CreationTime.ToShortDateString());

            }

            //Выводим файлы
            string[] filelist = Directory.GetFiles(path);
            foreach (string current in filelist)
            {
                FileInfo f = new FileInfo(current);
                dataGridView2.Rows.Add(Properties.Resources.file, f.Name, f.Length / 1024, f.CreationTime.ToShortDateString());

            }
        }

        private void DataGridView2_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection sel = dataGridView2.SelectedRows;
            
            string s = sel.Count.ToString();
            string m sel.Contains.local_name;
            MessageBox.Show(s , "asdf", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
