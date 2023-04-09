namespace Test_TextBox_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_button = new System.Windows.Forms.Button();
            this.Broken_textBox = new System.Windows.Forms.TextBox();
            this.Alive_textBox = new System.Windows.Forms.TextBox();
            this.Question_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Open_file_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PhaseDuration1 = new System.Windows.Forms.TextBox();
            this.PhaseDuration2 = new System.Windows.Forms.TextBox();
            this.PhaseDuration3 = new System.Windows.Forms.TextBox();
            this.PhaseDuration4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IntervalBetweenSendingData = new System.Windows.Forms.TextBox();
            this.IntervalsBetweenPulse = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ComportBox = new System.Windows.Forms.TextBox();
            this.BaudRateBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Modbus_Port_textBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Modbus_IP_textBox = new System.Windows.Forms.MaskedTextBox();
            this.CurrentLowCritValue = new System.Windows.Forms.TextBox();
            this.CurrentHighCritValue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Pause_button = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.LittleConsole = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Comport_connect_button = new System.Windows.Forms.Button();
            this.Modbus_connect_button = new System.Windows.Forms.Button();
            this.Modbus_status_box = new System.Windows.Forms.PictureBox();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Comport_status_box = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Modbus_status_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comport_status_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Start_button.BackColor = System.Drawing.Color.Lime;
            this.Start_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Start_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_button.Location = new System.Drawing.Point(915, 156);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(121, 54);
            this.Start_button.TabIndex = 10;
            this.Start_button.Text = "СТАРТ";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Broken_textBox
            // 
            this.Broken_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Broken_textBox.BackColor = System.Drawing.Color.LightCyan;
            this.Broken_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Broken_textBox.Location = new System.Drawing.Point(1292, 1025);
            this.Broken_textBox.Name = "Broken_textBox";
            this.Broken_textBox.Size = new System.Drawing.Size(100, 27);
            this.Broken_textBox.TabIndex = 17;
            // 
            // Alive_textBox
            // 
            this.Alive_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Alive_textBox.BackColor = System.Drawing.Color.LightCyan;
            this.Alive_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alive_textBox.Location = new System.Drawing.Point(1425, 1025);
            this.Alive_textBox.Name = "Alive_textBox";
            this.Alive_textBox.Size = new System.Drawing.Size(100, 27);
            this.Alive_textBox.TabIndex = 18;
            // 
            // Question_textBox
            // 
            this.Question_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Question_textBox.BackColor = System.Drawing.Color.LightCyan;
            this.Question_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question_textBox.Location = new System.Drawing.Point(1577, 1025);
            this.Question_textBox.Name = "Question_textBox";
            this.Question_textBox.Size = new System.Drawing.Size(100, 27);
            this.Question_textBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1287, 996);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отказало";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1388, 996);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "Работают штатно";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1555, 996);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Под вопросом";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(1065, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 853);
            this.panel1.TabIndex = 24;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.GreenYellow;
            this.Add_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(417, 324);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(88, 36);
            this.Add_button.TabIndex = 25;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Red;
            this.Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.Exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(1865, 12);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(43, 42);
            this.Exit_button.TabIndex = 26;
            this.Exit_button.Text = "X";
            this.Exit_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Stop_button.BackColor = System.Drawing.Color.Red;
            this.Stop_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Stop_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Stop_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop_button.Location = new System.Drawing.Point(915, 299);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(121, 54);
            this.Stop_button.TabIndex = 28;
            this.Stop_button.Text = "СТОП";
            this.Stop_button.UseVisualStyleBackColor = false;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightCyan;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(478, 477);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(354, 26);
            this.textBox5.TabIndex = 29;
            this.textBox5.Text = "Путь к папке";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Open_file_button
            // 
            this.Open_file_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Open_file_button.Location = new System.Drawing.Point(795, 477);
            this.Open_file_button.Name = "Open_file_button";
            this.Open_file_button.Size = new System.Drawing.Size(37, 26);
            this.Open_file_button.TabIndex = 30;
            this.Open_file_button.UseVisualStyleBackColor = false;
            this.Open_file_button.Click += new System.EventHandler(this.Open_file_button_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(29, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 41);
            this.label9.TabIndex = 31;
            this.label9.Text = "Длительность фаз испытаний, мин";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PhaseDuration1
            // 
            this.PhaseDuration1.BackColor = System.Drawing.Color.LightCyan;
            this.PhaseDuration1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhaseDuration1.Location = new System.Drawing.Point(387, 577);
            this.PhaseDuration1.Name = "PhaseDuration1";
            this.PhaseDuration1.Size = new System.Drawing.Size(80, 26);
            this.PhaseDuration1.TabIndex = 32;
            this.PhaseDuration1.Text = "3";
            this.PhaseDuration1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhaseDuration1.TextChanged += new System.EventHandler(this.PhaseDuration1_TextChanged);
            // 
            // PhaseDuration2
            // 
            this.PhaseDuration2.BackColor = System.Drawing.Color.LightCyan;
            this.PhaseDuration2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhaseDuration2.Location = new System.Drawing.Point(387, 609);
            this.PhaseDuration2.Name = "PhaseDuration2";
            this.PhaseDuration2.Size = new System.Drawing.Size(80, 26);
            this.PhaseDuration2.TabIndex = 33;
            this.PhaseDuration2.Text = "3";
            this.PhaseDuration2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhaseDuration2.TextChanged += new System.EventHandler(this.PhaseDuration2_TextChanged);
            // 
            // PhaseDuration3
            // 
            this.PhaseDuration3.BackColor = System.Drawing.Color.LightCyan;
            this.PhaseDuration3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhaseDuration3.Location = new System.Drawing.Point(388, 641);
            this.PhaseDuration3.Name = "PhaseDuration3";
            this.PhaseDuration3.Size = new System.Drawing.Size(80, 26);
            this.PhaseDuration3.TabIndex = 34;
            this.PhaseDuration3.Text = "3";
            this.PhaseDuration3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhaseDuration3.TextChanged += new System.EventHandler(this.PhaseDuration3_TextChanged);
            // 
            // PhaseDuration4
            // 
            this.PhaseDuration4.BackColor = System.Drawing.Color.LightCyan;
            this.PhaseDuration4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhaseDuration4.Location = new System.Drawing.Point(388, 673);
            this.PhaseDuration4.Name = "PhaseDuration4";
            this.PhaseDuration4.Size = new System.Drawing.Size(80, 26);
            this.PhaseDuration4.TabIndex = 35;
            this.PhaseDuration4.Text = "3";
            this.PhaseDuration4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhaseDuration4.TextChanged += new System.EventHandler(this.PhaseDuration4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(473, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(359, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "Интервал между записью данных, мин";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(473, 609);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 26);
            this.label11.TabIndex = 37;
            this.label11.Text = "Интервал между пульсами, мин";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // IntervalBetweenSendingData
            // 
            this.IntervalBetweenSendingData.BackColor = System.Drawing.Color.LightCyan;
            this.IntervalBetweenSendingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntervalBetweenSendingData.Location = new System.Drawing.Point(956, 577);
            this.IntervalBetweenSendingData.Name = "IntervalBetweenSendingData";
            this.IntervalBetweenSendingData.Size = new System.Drawing.Size(80, 26);
            this.IntervalBetweenSendingData.TabIndex = 38;
            this.IntervalBetweenSendingData.Text = "1000";
            this.IntervalBetweenSendingData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntervalBetweenSendingData.TextChanged += new System.EventHandler(this.IntervalBetweenSendingData_TextChanged);
            // 
            // IntervalsBetweenPulse
            // 
            this.IntervalsBetweenPulse.BackColor = System.Drawing.Color.LightCyan;
            this.IntervalsBetweenPulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntervalsBetweenPulse.Location = new System.Drawing.Point(956, 609);
            this.IntervalsBetweenPulse.Name = "IntervalsBetweenPulse";
            this.IntervalsBetweenPulse.Size = new System.Drawing.Size(80, 26);
            this.IntervalsBetweenPulse.TabIndex = 39;
            this.IntervalsBetweenPulse.Text = "1000";
            this.IntervalsBetweenPulse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntervalsBetweenPulse.TextChanged += new System.EventHandler(this.IntervalsBetweenPulse_TextChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(323, 528);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(419, 37);
            this.label12.TabIndex = 40;
            this.label12.Text = "Параметры испытаний ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(332, 746);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(410, 38);
            this.label13.TabIndex = 41;
            this.label13.Text = "Параметры соединения";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // ComportBox
            // 
            this.ComportBox.BackColor = System.Drawing.Color.LightCyan;
            this.ComportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComportBox.Location = new System.Drawing.Point(397, 853);
            this.ComportBox.Name = "ComportBox";
            this.ComportBox.Size = new System.Drawing.Size(80, 26);
            this.ComportBox.TabIndex = 45;
            this.ComportBox.Text = "COM4";
            this.ComportBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComportBox.TextChanged += new System.EventHandler(this.ComportBox_TextChanged);
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.BackColor = System.Drawing.Color.LightCyan;
            this.BaudRateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BaudRateBox.Location = new System.Drawing.Point(397, 821);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(80, 26);
            this.BaudRateBox.TabIndex = 44;
            this.BaudRateBox.Text = "9600";
            this.BaudRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BaudRateBox.TextChanged += new System.EventHandler(this.BaudRateBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(272, 852);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 26);
            this.label14.TabIndex = 43;
            this.label14.Text = "Порт";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(272, 820);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 26);
            this.label15.TabIndex = 42;
            this.label15.Text = "Бодрейт, б/с";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(345, 784);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 26);
            this.label16.TabIndex = 46;
            this.label16.Text = "Arduino";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(583, 784);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 26);
            this.label17.TabIndex = 51;
            this.label17.Text = "Modbus TCP";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Modbus_Port_textBox
            // 
            this.Modbus_Port_textBox.BackColor = System.Drawing.Color.LightCyan;
            this.Modbus_Port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Modbus_Port_textBox.Location = new System.Drawing.Point(636, 852);
            this.Modbus_Port_textBox.Name = "Modbus_Port_textBox";
            this.Modbus_Port_textBox.Size = new System.Drawing.Size(110, 26);
            this.Modbus_Port_textBox.TabIndex = 50;
            this.Modbus_Port_textBox.Text = "502";
            this.Modbus_Port_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Modbus_Port_textBox.TextChanged += new System.EventHandler(this.Modbus_Port_textBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(524, 853);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 26);
            this.label18.TabIndex = 48;
            this.label18.Text = "Порт";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(524, 820);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 26);
            this.label19.TabIndex = 47;
            this.label19.Text = "IP адрес ";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // Modbus_IP_textBox
            // 
            this.Modbus_IP_textBox.BackColor = System.Drawing.Color.LightCyan;
            this.Modbus_IP_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Modbus_IP_textBox.Location = new System.Drawing.Point(636, 819);
            this.Modbus_IP_textBox.Name = "Modbus_IP_textBox";
            this.Modbus_IP_textBox.Size = new System.Drawing.Size(110, 26);
            this.Modbus_IP_textBox.TabIndex = 52;
            this.Modbus_IP_textBox.Text = "127.0.0.1";
            this.Modbus_IP_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Modbus_IP_textBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Modbus_IP_textBox_MaskInputRejected);
            // 
            // CurrentLowCritValue
            // 
            this.CurrentLowCritValue.BackColor = System.Drawing.Color.LightCyan;
            this.CurrentLowCritValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentLowCritValue.Location = new System.Drawing.Point(957, 674);
            this.CurrentLowCritValue.Name = "CurrentLowCritValue";
            this.CurrentLowCritValue.Size = new System.Drawing.Size(80, 26);
            this.CurrentLowCritValue.TabIndex = 56;
            this.CurrentLowCritValue.Text = "0";
            this.CurrentLowCritValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentLowCritValue.TextChanged += new System.EventHandler(this.CurrentLowCritValue_TextChanged);
            // 
            // CurrentHighCritValue
            // 
            this.CurrentHighCritValue.BackColor = System.Drawing.Color.LightCyan;
            this.CurrentHighCritValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentHighCritValue.Location = new System.Drawing.Point(957, 641);
            this.CurrentHighCritValue.Name = "CurrentHighCritValue";
            this.CurrentHighCritValue.Size = new System.Drawing.Size(80, 26);
            this.CurrentHighCritValue.TabIndex = 55;
            this.CurrentHighCritValue.Text = "20";
            this.CurrentHighCritValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentHighCritValue.TextChanged += new System.EventHandler(this.CurrentHighCritValue_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(474, 673);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(462, 26);
            this.label20.TabIndex = 54;
            this.label20.Text = "Нижнее критическое значение сопротивления, Ом";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(474, 641);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(465, 26);
            this.label21.TabIndex = 53;
            this.label21.Text = "Верхнее критическое значение сопротивления, Ом";
            // 
            // Pause_button
            // 
            this.Pause_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pause_button.BackColor = System.Drawing.Color.Gold;
            this.Pause_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pause_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Pause_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pause_button.Location = new System.Drawing.Point(915, 226);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(121, 54);
            this.Pause_button.TabIndex = 57;
            this.Pause_button.Text = "ПАУЗА";
            this.Pause_button.UseVisualStyleBackColor = false;
            this.Pause_button.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(29, 476);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(419, 26);
            this.label22.TabIndex = 58;
            this.label22.Text = "Путь для сохранения результатов испытаний";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // LittleConsole
            // 
            this.LittleConsole.BackColor = System.Drawing.SystemColors.Control;
            this.LittleConsole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LittleConsole.Location = new System.Drawing.Point(869, 397);
            this.LittleConsole.Name = "LittleConsole";
            this.LittleConsole.ReadOnly = true;
            this.LittleConsole.Size = new System.Drawing.Size(167, 27);
            this.LittleConsole.TabIndex = 59;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(789, 398);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 26);
            this.label23.TabIndex = 60;
            this.label23.Text = "Статус:";
            // 
            // Comport_connect_button
            // 
            this.Comport_connect_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comport_connect_button.Location = new System.Drawing.Point(323, 894);
            this.Comport_connect_button.Name = "Comport_connect_button";
            this.Comport_connect_button.Size = new System.Drawing.Size(103, 27);
            this.Comport_connect_button.TabIndex = 61;
            this.Comport_connect_button.Text = "Соединить";
            this.Comport_connect_button.UseVisualStyleBackColor = true;
            this.Comport_connect_button.Click += new System.EventHandler(this.Comport_connect_button_Click);
            // 
            // Modbus_connect_button
            // 
            this.Modbus_connect_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modbus_connect_button.Location = new System.Drawing.Point(583, 894);
            this.Modbus_connect_button.Name = "Modbus_connect_button";
            this.Modbus_connect_button.Size = new System.Drawing.Size(103, 27);
            this.Modbus_connect_button.TabIndex = 63;
            this.Modbus_connect_button.Text = "Соединить";
            this.Modbus_connect_button.UseVisualStyleBackColor = true;
            this.Modbus_connect_button.Click += new System.EventHandler(this.Modbus_connect_button_Click);
            // 
            // Modbus_status_box
            // 
            this.Modbus_status_box.BackColor = System.Drawing.Color.Red;
            this.Modbus_status_box.Location = new System.Drawing.Point(694, 894);
            this.Modbus_status_box.Name = "Modbus_status_box";
            this.Modbus_status_box.Size = new System.Drawing.Size(26, 26);
            this.Modbus_status_box.TabIndex = 65;
            this.Modbus_status_box.TabStop = false;
            this.Modbus_status_box.Click += new System.EventHandler(this.Modbus_status_box_Click);
            // 
            // Minimize_button
            // 
            this.Minimize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_button.BackColor = System.Drawing.Color.Orange;
            this.Minimize_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Minimize_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_button.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize_button.Location = new System.Drawing.Point(1799, 12);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(43, 42);
            this.Minimize_button.TabIndex = 66;
            this.Minimize_button.Text = "_";
            this.Minimize_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Minimize_button.UseVisualStyleBackColor = false;
            // 
            // Comport_status_box
            // 
            this.Comport_status_box.BackColor = System.Drawing.Color.Red;
            this.Comport_status_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Comport_status_box.Location = new System.Drawing.Point(432, 894);
            this.Comport_status_box.Name = "Comport_status_box";
            this.Comport_status_box.Size = new System.Drawing.Size(26, 26);
            this.Comport_status_box.TabIndex = 67;
            this.Comport_status_box.TabStop = false;
            this.Comport_status_box.Click += new System.EventHandler(this.Comport_status_box_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 121);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label24.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(129, 38);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(1662, 45);
            this.label24.TabIndex = 69;
            this.label24.Text = "ПРОЕКТ 554: Создание стенда верификации показателей надежности типовых групп резе" +
    "рвирования";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество групп резервирования";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(656, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Группа ЭРИ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Резисторы",
            "Конденсаторы"});
            this.comboBox1.Location = new System.Drawing.Point(544, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(34, 180);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(275, 30);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Форсированные испытания";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.LightCyan;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(355, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "5";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(544, 328);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(335, 28);
            this.comboBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(640, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Подгруппа ЭРИ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(34, 274);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(194, 30);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Комбинированная";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(544, 257);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(335, 28);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(34, 225);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(462, 30);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Прекращение испытаний до наступления отказа";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(106, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Методика ускоренных испытаний";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(656, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Класс ЭРИ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Comport_status_box);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Minimize_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Modbus_status_box);
            this.Controls.Add(this.Modbus_connect_button);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Comport_connect_button);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.LittleConsole);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.CurrentLowCritValue);
            this.Controls.Add(this.CurrentHighCritValue);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Modbus_IP_textBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Modbus_Port_textBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ComportBox);
            this.Controls.Add(this.BaudRateBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.IntervalsBetweenPulse);
            this.Controls.Add(this.IntervalBetweenSendingData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PhaseDuration4);
            this.Controls.Add(this.PhaseDuration3);
            this.Controls.Add(this.PhaseDuration2);
            this.Controls.Add(this.PhaseDuration1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Open_file_button);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Question_textBox);
            this.Controls.Add(this.Alive_textBox);
            this.Controls.Add(this.Broken_textBox);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Modbus_status_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comport_status_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.TextBox Broken_textBox;
        private System.Windows.Forms.TextBox Alive_textBox;
        private System.Windows.Forms.TextBox Question_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Open_file_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhaseDuration1;
        private System.Windows.Forms.TextBox PhaseDuration2;
        private System.Windows.Forms.TextBox PhaseDuration3;
        private System.Windows.Forms.TextBox PhaseDuration4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IntervalBetweenSendingData;
        private System.Windows.Forms.TextBox IntervalsBetweenPulse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ComportBox;
        private System.Windows.Forms.TextBox BaudRateBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Modbus_Port_textBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox Modbus_IP_textBox;
        private System.Windows.Forms.TextBox CurrentLowCritValue;
        private System.Windows.Forms.TextBox CurrentHighCritValue;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox LittleConsole;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button Comport_connect_button;
        private System.Windows.Forms.Button Modbus_connect_button;
        public System.Windows.Forms.PictureBox Modbus_status_box;
        private System.Windows.Forms.Button Minimize_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.PictureBox Comport_status_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

