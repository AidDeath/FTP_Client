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

using BytesRoad.Net.Ftp;     //Сторонние библиотеки для работы с ФТП. для форка   
using BytesRoad.Net.Sockets;


namespace FTP_try_1
{
 
    public partial class Form1 : Form
    {
        DriveInfo[] Drives = DriveInfo.GetDrives();
        string LocalPath = "";
        FtpClient client = new FtpClient();
        int TimeoutFTP = 30000; //Таймаут.

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

            //FtpClient client = new FtpClient();

            //Задаём параметры клиента.
            client.PassiveMode = true; //Включаем пассивный режим.
            
            string FTP_SERVER = textBox_hostname.Text;
            int FTP_PORT = Convert.ToInt32(textBox_port.Text);
            string FTP_USER = textBox_login.Text;
            string FTP_PASSWORD = textBox_pwd.Text;
            FtpResponse ftpResponse;
            try
            {
                ftpResponse = client.Connect(TimeoutFTP, FTP_SERVER, FTP_PORT);
                if (ftpResponse.Code == 220)
                {
                    toolStripStatusLabel1.Text = "Аутентфикация";
                }
                client.Login(TimeoutFTP, FTP_USER, FTP_PASSWORD);
                toolStripStatusLabel1.Text = "Подключено к " + FTP_SERVER;
                // MessageBox.Show(ftpResponse.Code.ToString(), "Hello!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                ShowFTPContents();

                button_connect.Enabled = false;
                button_disconnect.Enabled = true;

            }
            catch(System.Net.Sockets.SocketException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (BytesRoad.Net.Ftp.FtpErrorException)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка аутентфикации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                client.Disconnect(TimeoutFTP);
                toolStripStatusLabel1.Text += " -- не пройдена";
            }


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

        private void ShowFTPContents()
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(Properties.Resources.back, "..","","");
            FtpItem[] ftpitem = client.GetDirectoryList(TimeoutFTP);
            foreach (FtpItem current in ftpitem)
            {                                         // Выводим папки на фтп
                if (current.ItemType.ToString() == "Directory")
                {
                    dataGridView1.Rows.Add(Properties.Resources.folder, current.Name, "<DIR>", current.Date);
                }
            }
            foreach (FtpItem current in ftpitem)
            {                                            // Выводим файлы на фтп
                if (current.ItemType.ToString() == "File")
                {
                    dataGridView1.Rows.Add(Properties.Resources.file2, current.Name, current.Size / 1024, current.Date);
                }
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
            ///         выбран файл - Запустить его
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



            

         //   MessageBox.Show(s, "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Hand);
           
        }


        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {       //навигация по папкам на фтп

                try
                {


                    switch (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())
                    {
                        case ("<DIR>"):
                            {// папка
                                client.ChangeDirectory(TimeoutFTP, dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                                ShowFTPContents();
                                break;
                            }
                        case (""):
                            {//назад
                                client.ChangeDirectory(TimeoutFTP, "..");
                                ShowFTPContents();
                                break;
                            }

                        default:
                            {// файл

                                break;
                            }

                    }
                }
                catch(System.Net.Sockets.SocketException ex)
                {
                    MessageBox.Show(ex.Message, "Связь потеряна", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toolStripStatusLabel1.Text = "Отключено";
                    dataGridView1.Rows.Clear();
                    button_connect.Enabled = true;
                    button_disconnect.Enabled = false;
                    
                   
                }
            }
        }

        private void Button_disconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect(TimeoutFTP);
            dataGridView1.Rows.Clear();
            toolStripStatusLabel1.Text = "Отключено";
            button_connect.Enabled = true;
            button_disconnect.Enabled = false;
        }
    }
}
