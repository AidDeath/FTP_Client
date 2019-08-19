namespace FTP_try_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_pwdsave = new System.Windows.Forms.CheckBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_hostname = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Object_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Object_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Drive = new System.Windows.Forms.ComboBox();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            toolStripStatusLabel2.Text = "Нет активности";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox_pwdsave);
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.textBox_pwd);
            this.groupBox1.Controls.Add(this.textBox_login);
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.textBox_hostname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение к FTP";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Порт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя хоста \\ IP адрес";
            // 
            // checkBox_pwdsave
            // 
            this.checkBox_pwdsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_pwdsave.AutoSize = true;
            this.checkBox_pwdsave.Location = new System.Drawing.Point(504, 45);
            this.checkBox_pwdsave.Name = "checkBox_pwdsave";
            this.checkBox_pwdsave.Size = new System.Drawing.Size(159, 17);
            this.checkBox_pwdsave.TabIndex = 5;
            this.checkBox_pwdsave.Text = "Сохранять логин и пароль";
            this.checkBox_pwdsave.UseVisualStyleBackColor = true;
            // 
            // button_connect
            // 
            this.button_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_connect.Location = new System.Drawing.Point(504, 16);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(159, 23);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "Подключить";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pwd.Location = new System.Drawing.Point(349, 42);
            this.textBox_pwd.MaximumSize = new System.Drawing.Size(128, 20);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(128, 20);
            this.textBox_pwd.TabIndex = 3;
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // textBox_login
            // 
            this.textBox_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_login.Location = new System.Drawing.Point(349, 20);
            this.textBox_login.MaximumSize = new System.Drawing.Size(128, 20);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(128, 20);
            this.textBox_login.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(172, 42);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(64, 20);
            this.textBox_port.TabIndex = 1;
            // 
            // textBox_hostname
            // 
            this.textBox_hostname.Location = new System.Drawing.Point(6, 42);
            this.textBox_hostname.Name = "textBox_hostname";
            this.textBox_hostname.Size = new System.Drawing.Size(160, 20);
            this.textBox_hostname.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "Нет подключения";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Object_name,
            this.Object_size});
            this.dataGridView1.Location = new System.Drawing.Point(0, 108);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 478);
            this.dataGridView1.TabIndex = 3;
            // 
            // Image
            // 
            this.Image.FillWeight = 30F;
            this.Image.Frozen = true;
            this.Image.HeaderText = "";
            this.Image.MinimumWidth = 40;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 40;
            // 
            // Object_name
            // 
            this.Object_name.HeaderText = "Имя";
            this.Object_name.Name = "Object_name";
            this.Object_name.ReadOnly = true;
            this.Object_name.Width = 220;
            // 
            // Object_size
            // 
            this.Object_size.HeaderText = "Размер";
            this.Object_size.Name = "Object_size";
            this.Object_size.ReadOnly = true;
            this.Object_size.Width = 71;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(381, 108);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(343, 478);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.MinimumWidth = 40;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 220;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Размер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Локальный компьютер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "FTP - сервер";
            // 
            // comboBox_Drive
            // 
            this.comboBox_Drive.FormattingEnabled = true;
            this.comboBox_Drive.Location = new System.Drawing.Point(609, 84);
            this.comboBox_Drive.Name = "comboBox_Drive";
            this.comboBox_Drive.Size = new System.Drawing.Size(54, 21);
            this.comboBox_Drive.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 611);
            this.Controls.Add(this.comboBox_Drive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 650);
            this.MinimumSize = new System.Drawing.Size(740, 650);
            this.Name = "Form1";
            this.Text = "Simple FTP Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_pwdsave;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_hostname;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object_size;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Drive;
    }
}

