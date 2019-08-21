using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

//using BytesRoad.Net.Ftp;     //Сторонние библиотеки для работы с ФТП. для форка   
//using BytesRoad.Net.Sockets;


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

        private void ShowLocalRootFiles(object sender, EventArgs e)
        {
            try
            {
                label7.Text = "Свободно: " + (Drives[comboBox_Drive.SelectedIndex].AvailableFreeSpace) / 1024 / 1024 + " Мб";
                //обновляем свободное место диска

                LocalPath = comboBox_Drive.Text;
                dataGridView2.Rows.Clear();  // Чистим от старых данных 
                ShowContents(LocalPath);
            }
            catch (System.IO.IOException)
            {
                label7.Text = "Ошибка чтения раздела";
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(Properties.Resources.failure, "Ошибка раздела", "", "");
            }
            
        }

        private void ShowContents(string path)   //Вывод локальных файлов и папок
        {
            //Выводим папки
            try
            {
                string[] dirlist = Directory.GetDirectories(path);
                foreach (string current in dirlist)
                {
                    DirectoryInfo d = new DirectoryInfo(current);
                    dataGridView2.Rows.Add(Properties.Resources.folder, d.Name, "<DIR>", d.CreationTime.ToShortDateString());

                }
                //Выводим файлы
                string[] filelist = Directory.GetFiles(path);
                foreach (string current in filelist)
                {
                    FileInfo f = new FileInfo(current);
                    dataGridView2.Rows.Add(Properties.Resources.file2, f.Name, f.Length / 1024, f.CreationTime.ToShortDateString());
                 
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                dataGridView2.Rows.Add(Properties.Resources.failure, "Ошибка доступа", "", "");

            }
            
        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //// варианты:
            ///выбрана папка - добавляем имя к пути, добавляем \, чистим строки, добавляем ..\ и содержимое папки  W
            ///выбрано на 1ровень вверх - удалить строки - удалить из пути всё после последнего слеша и сам слеш - 
            ///                           если достигнут корень - не показывать ..\
            ///                           если не достигнут - добавить ..\ 
            ///                     вызвать заполнение списком файлов
            ///         выбран файл - ничего не делать, пока...
            ///         

            switch (dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString())
            {
                case ("<DIR>"):
                    {// папка
                        LocalPath += dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "\\";
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add(Properties.Resources.back, "../", "", "");
                        ShowContents(LocalPath);
                        break;
                    }
                case (""):
                    {//назад

                        //Убираем из пути последний каталог
                        LocalPath = LocalPath.Remove(LocalPath.LastIndexOf("\\"));
                        LocalPath = LocalPath.Remove(LocalPath.LastIndexOf("\\") +1);


                        if (LocalPath.LastIndexOf("\\") == 2)
                        {//сверху уже корень     
                            dataGridView2.Rows.Clear();
                            ShowContents(LocalPath);
                        }
                        else
                        {//сверху не корень
                            dataGridView2.Rows.Clear();
                            dataGridView2.Rows.Add(Properties.Resources.back, "../", "", "");
                            ShowContents(LocalPath);
                        }
                        break;
                    }
               
                default:
                    {// файл  - Запускаем файл, на котором клацнули.
                        Process.Start(LocalPath + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
                        break;
                    }
                   
            }
            
        }
    }
}
