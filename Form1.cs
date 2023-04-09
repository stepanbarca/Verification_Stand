using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using ClosedXML.Excel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using ClosedXML;
using EasyModbus;
using Timer = System.Windows.Forms.Timer;
using EasyModbus.Exceptions;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Drawing;

namespace Test_TextBox_1
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        System.Windows.Forms.Timer phase_timer;
        System.Diagnostics.Stopwatch phase_stopwatch;
        Form2 f2 = new Form2();
        SerialPort serialPort;
        ModbusClient modbusClient;
        

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            phase_timer = new System.Windows.Forms.Timer();
            phase_stopwatch = new System.Diagnostics.Stopwatch();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            phase_timer.Tick += new EventHandler(phase_timer_Tick);

            modbusClient = new EasyModbus.ModbusClient();
            modbusClient.ConnectedChanged += new EasyModbus.ModbusClient.ConnectedChangedHandler(Modbus_Changed);
            serialPort = new SerialPort();
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            int Alive_count = 0; int Question_count = 0; int Broken_count = 0;

            if (!inProcess)
            {
                //if (modbusClient != null) { Modbus_status = modbusClient.Connected; }
                //else { Modbus_status = false; }
                if (serialPort != null) { Comport_status = serialPort.IsOpen; }
                else { Comport_status = false; }
                //MessageBox.Show(Modbus_status.ToString());
                if (!Modbus_status) { Modbus_status_box.BackColor = System.Drawing.Color.Red; }
                else { Modbus_status_box.BackColor = System.Drawing.Color.Green; }
                if (!Comport_status) { Comport_status_box.BackColor = System.Drawing.Color.Red; }
                else { Comport_status_box.BackColor = System.Drawing.Color.Green; }
                //if
            }
            else
            {
                GetData(serialPort);
            }
            for (int i = 0; i < N ; i++ )
            {
                if (Res_Status[i * 3] == 1) { (panel1.Controls["Status_Res_1_Group_" + (i + 1).ToString()] as System.Windows.Forms.PictureBox).BackColor = System.Drawing.Color.Orange; }
                else if (Res_Status[i * 3] == 0) { (panel1.Controls["Status_Res_1_Group_" + (i + 1).ToString()] as System.Windows.Forms.PictureBox).BackColor = System.Drawing.Color.Red; }
                
                if (Res_Status[i * 3 + 1] == 1) { (panel1.Controls["Status_Res_2_Group_" + (i + 1).ToString()] as System.Windows.Forms.PictureBox).BackColor = System.Drawing.Color.Orange; }
                else if (Res_Status[i * 3 + 1] == 0) { (panel1.Controls["Status_Res_2_Group_" + (i + 1).ToString()] as System.Windows.Forms.PictureBox).BackColor = System.Drawing.Color.Red; }
                
                if (Res_Status[i * 3 + 2] == 1) { (panel1.Controls["Status_Res_3_Group_" + (i + 1).ToString()] as System.Windows.Forms.PictureBox).BackColor = System.Drawing.Color.Orange; }
                else if (Res_Status[i * 3 + 2] == 0) { (panel1.Controls["Status_Res_3_Group_" + (i + 1).ToString()] as System.Windows.Forms.PictureBox).BackColor = System.Drawing.Color.Red; }

                if (Res_Status[i * 3] + Res_Status[i * 3 + 1] + Res_Status[i * 3 + 2] < 6)
                {
                    if (Res_Status[i * 3] + Res_Status[i * 3 + 1] + Res_Status[i * 3 + 2] < 1) { Broken_count++; }
                    else { Question_count++; }
                }
                else { Alive_count++; }
                Alive_textBox.Text = Alive_count.ToString();
                Question_textBox.Text = Question_count.ToString();
                Broken_textBox.Text = Broken_count.ToString();
            }
        }

        private void phase_timer_Tick(object sender, EventArgs e)
        {
            if (phase_number < 3)
            {
                phase_number++;
                phase_timer.Interval = phaseDuration[phase_number];
                
            }
            else 
            {
                final();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            f2.Show();
            f2.Visible = false;
            label3.Visible = false;
            comboBox2.Visible = false;
            label4.Visible = false;
            comboBox3.Visible = false;
            //Start_button.Enabled = false; Pause_button.Enabled = false; Stop_button.Enabled = false;

            Modbus_IP_textBox.PromptChar = ' ';
            Modbus_IP_textBox.ValidatingType = typeof(IPAddress);
        }

         
        string Start_Time;
        int phase_number = 0;
        string xlsxPath;
        int timeout = 400; // Время между проверками
        bool inProcess = false;
        bool over = false;
        bool first_time = true; // Первое нажатие кнопки старт (нужно ли?)
        int[] phaseDuration = new int[4] { 60000, 60000, 60000, 60000 };
        int N = 0; // Текущее количество ячеек
        public int chosen_Res = 0;
        public int N_Res;
        string filename;
        public bool Modbus_status = false; public bool Comport_status = false;
        public int[] Res_Status = new int[16] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }; // 0 - Отказ, 1 - под вопросом, 2 - Штатно

        
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            comboBox2.Items.Clear();
            comboBox2.ResetText();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.Items.Add("Постоянные непроволочные");
                    comboBox2.Items.Add("Постоянные проволочные и фольговые");
                    comboBox2.Items.Add("Переменные непроволочные");
                    comboBox2.Items.Add("Переменные проволочные");
                    comboBox2.Items.Add("Терморезисторы");
                    comboBox2.Items.Add("Микросхемы резисторные пленочные");
                    comboBox2.Items.Add("Наборы резисторов тонкопленочные");
                    comboBox2.Items.Add("Наборы резисторов толстопленочные");
                    comboBox2.Items.Add("Резисторные сборки");
                    comboBox2.Items.Add("Поглотители");
                    break;
                case 1:
                    comboBox2.Items.Add("Конденсаторы постоянной емкости");
                    comboBox2.Items.Add("Конденсаторы подстроечные");
                    comboBox2.Items.Add("Сборки на основе конденсаторов");
                    comboBox2.Items.Add("Конденсаторы и фильтры помехоподавляющие");
                    break;
            }

            label3.Visible = true;
            comboBox2.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.ResetText();
            label4.Visible = true;
            comboBox3.Visible = true;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            comboBox3.Items.Add("Металлодиэлектрические (кроме прец.)");
                            comboBox3.Items.Add("Металлодиэлектрические прецизионные");
                            comboBox3.Items.Add("Металлизированные");
                            comboBox3.Items.Add("Композиционные пленочные");
                            comboBox3.Items.Add("Композиционные объемные");
                            break;
                        case 1:
                            comboBox3.Items.Add("Нагрузочные");
                            comboBox3.Items.Add("Прецизионные");
                            comboBox3.Items.Add("Особостабильные");
                            comboBox3.Items.Add("Фольговые");
                            break;
                        case 2:
                            comboBox3.Items.Add("Металлоокисные");
                            comboBox3.Items.Add("Керметные");
                            comboBox3.Items.Add("Композиционные пленочные");
                            comboBox3.Items.Add("Композиционные объемные");
                            comboBox3.Items.Add("Потенциометры");
                            break;
                        case 3:
                            comboBox3.Items.Add("Подстроечные");
                            comboBox3.Items.Add("Регулировочные");
                            break;
                        default:
                            label4.Visible = false;
                            comboBox3.Visible = false;
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            comboBox3.Items.Add("Керам. на номинальное напряжение менее 1600 В");
                            comboBox3.Items.Add("Керам. на номинальное напряжение 1600 В и выше");
                            comboBox3.Items.Add("Тонкопленочные с неорганическим диэлектриком");
                            comboBox3.Items.Add("Стеклянные");
                            comboBox3.Items.Add("Слюдяные");
                            break;
                        case 1:
                            comboBox3.Items.Add("Нагрузочные");
                            comboBox3.Items.Add("Прецизионные");
                            comboBox3.Items.Add("Особостабильные");
                            comboBox3.Items.Add("Фольговые");
                            break;
                        case 2:
                            comboBox3.Items.Add("Металлоокисные");
                            comboBox3.Items.Add("Керметные");
                            comboBox3.Items.Add("Композиционные пленочные");
                            comboBox3.Items.Add("Композиционные объемные");
                            comboBox3.Items.Add("Потенциометры");
                            break;
                        case 3:
                            comboBox3.Items.Add("Подстроечные");
                            comboBox3.Items.Add("Регулировочные");
                            break;
                        default :
                            label4.Visible = false;
                            comboBox3.Visible = false;
                            break;
                    }
                    break;
            }
            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int result);
            N_Res = result;
            create(N_Res);
        }
        private void labelClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lb = sender as System.Windows.Forms.Label;
            int.TryParse(string.Join("", lb.Name.Where(c => char.IsDigit(c))), out int lb_number);
            chosen_Res = lb_number;
            Buffering_data(chosen_Res);
            f2.Live = true;
            
            Console.WriteLine(DateTime.Parse(Start_Time)+"xx");
            Console.WriteLine(DateTime.Parse(Start_Time).ToOADate());
            f2.Visible = true;
            f2.Show();
            //f2.Start_time = DateTime.Parse(Start_Time);
            f2.Voltage_chart.ChartAreas[0].AxisX.Minimum = DateTime.Parse(Start_Time).ToOADate();
            f2.Current_chart.ChartAreas[0].AxisX.Minimum = DateTime.Parse(Start_Time).ToOADate();
            f2.Power_chart.ChartAreas[0].AxisX.Minimum = DateTime.Parse(Start_Time).ToOADate();
            f2.Text = "Резистор " + lb_number.ToString();
        }

        public void create(int N)
        {
            
            int W = panel1.Width;
            for (int i = 0; i < N; i++)
            {
                System.Windows.Forms.Label lb = new System.Windows.Forms.Label();
                lb.Name = "Label_R_" + (i + 1).ToString(); lb.Location = new System.Drawing.Point(W / 42, 10 + 30 * i); lb.Size = new Size(4 * W / 42, 25); lb.Text = "R" + (i + 1).ToString(); lb.TextAlign = ContentAlignment.MiddleLeft; lb.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                panel1.Controls.Add(lb);
                lb.Click += new EventHandler(labelClick);
                panel1.Controls.Add(new System.Windows.Forms.Label() { Name = "Label_V_" + (i + 1).ToString(), Location = new System.Drawing.Point(12 * W / 42, 10 + 30 * i), Size = new Size(2 * W / 42, 25), Text = "В", TextAlign = ContentAlignment.MiddleLeft, Font = new System.Drawing.Font("Calibri", 12, FontStyle.Regular) });
                panel1.Controls.Add(new System.Windows.Forms.Label(){ Name = "Label_A_" + (i + 1).ToString(), Location = new System.Drawing.Point(21 * W / 42, 10 + 30 * i), Size = new Size(2 * W / 42, 25), Text = "A", TextAlign = ContentAlignment.MiddleLeft, Font = new System.Drawing.Font("Calibri", 12, FontStyle.Regular) });
                panel1.Controls.Add(new System.Windows.Forms.Label(){ Name = "Label_P_" + (i + 1).ToString(), Location = new System.Drawing.Point(30 * W / 42, 10 + 30 * i), Size = new Size(2 * W / 42, 25), Text = "Вт", TextAlign = ContentAlignment.MiddleLeft, Font = new System.Drawing.Font("Calibri", 12, FontStyle.Regular) });
                
                panel1.Controls.Add(new System.Windows.Forms.TextBox(){ Name = "textBox_V_" + (i + 1).ToString(), Location = new System.Drawing.Point(5 * W / 42, 10 + 30 * i), Size = new Size(7 * W / 42, 30), Font = new System.Drawing.Font("Calibri", 12, FontStyle.Regular), TextAlign = HorizontalAlignment.Center });
                panel1.Controls.Add(new System.Windows.Forms.TextBox(){ Name = "textBox_A_" + (i + 1).ToString(), Location = new System.Drawing.Point(14 * W / 42, 10 + 30 * i), Size = new Size(7 * W / 42, 30), Font = new System.Drawing.Font("Calibri", 12, FontStyle.Regular), TextAlign = HorizontalAlignment.Center });
                panel1.Controls.Add(new System.Windows.Forms.TextBox(){ Name = "textBox_P_" + (i + 1).ToString(), Location = new System.Drawing.Point(23 * W / 42, 10 + 30 * i), Size = new Size(7 * W / 42, 30), Font = new System.Drawing.Font("Calibri", 12, FontStyle.Regular), TextAlign = HorizontalAlignment.Center });

                panel1.Controls.Add(new PictureBox() { Name = "Status_Res_1_Group_" + (i + 1).ToString(), Location = new System.Drawing.Point(32 * W / 42, 10 + 30 * i), Size = new Size(2 * W / 42, 20), BackColor = System.Drawing.Color.Green });
                panel1.Controls.Add(new PictureBox() { Name = "Status_Res_2_Group_" + (i + 1).ToString(), Location = new System.Drawing.Point(35 * W / 42, 10 + 30 * i), Size = new Size(2 * W / 42, 20), BackColor = System.Drawing.Color.Green });
                panel1.Controls.Add(new PictureBox() { Name = "Status_Res_3_Group_" + (i + 1).ToString(), Location = new System.Drawing.Point(38 * W / 42, 10 + 30 * i), Size = new Size(2 * W / 42, 20), BackColor = System.Drawing.Color.Green });
            }
        }

        public void Start_button_Click(object sender, EventArgs e)
        {
            inProcess = true;
            if (first_time)
            {
                serialPort.DiscardOutBuffer();
                xl.Book = new XLWorkbook();
                xl.Book.AddWorksheet("List 1");
                xl.Sheet = xl.Book.Worksheet(1); // Первый лист
                first_time = false;
                phaseDuration[0] = Convert.ToInt32(PhaseDuration1.Text) * 60000;
                phaseDuration[1] = Convert.ToInt32(PhaseDuration2.Text) * 60000;
                phaseDuration[2] = Convert.ToInt32(PhaseDuration3.Text) * 60000;
                phaseDuration[3] = Convert.ToInt32(PhaseDuration4.Text) * 60000;

                serialPort.DiscardInBuffer(); // Очищаем буффер от предыдущего запуска
                serialPort.Write("START;"); // Начало работы ардуино
                for (int i = 0; i < 4; i++)
                {
                    serialPort.Write(Convert.ToString(phaseDuration[i]) + ";");
                }
                serialPort.Write(Convert.ToString(Convert.ToDouble(IntervalsBetweenPulse.Text) /* * 60000 */) + ";");
                serialPort.Write(Convert.ToString(Convert.ToDouble(IntervalBetweenSendingData.Text) /* * 60000 */) + ";");
                serialPort.Write(Convert.ToString(CurrentLowCritValue.Text) + ";"); // передаем нижний порог тока
                serialPort.Write(Convert.ToString(CurrentHighCritValue.Text) + ";"); // верхний
                timer.Interval = Convert.ToInt32(IntervalBetweenSendingData.Text);
                phase_timer.Interval = phaseDuration[0];
                phase_timer.Start();
                phase_stopwatch.Start();
                timer.Start();
                LittleConsole.Text = "STARTED";
                Start_Time = DateTime.Now.ToString();
            }
            else
            {
                serialPort.Write("RESUME;"); // Начало работы ардуино
                timer.Start();
                phase_timer.Start();    
                LittleConsole.Text = "RESUMED";
            }
            if (xl.Sheet.IsEmpty())
            {
                xl.lastRow = 0;
            }
            else
            {
                xl.lastRow = xl.Sheet.LastRowUsed().RowNumber();
            }

        }
        
        private void Temperature_control(int phase_number)
        {
            switch(phase_number)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true) { timer.Stop(); phase_timer.Stop(); }
            Close();
        }

        private void Pause_button_Click(object sender, EventArgs e)
        {
            inProcess = false;
            serialPort.Write("PAUSE;"); // Ардуино ставится на паузу
            while (serialPort.BytesToRead > 0)
            {
                GetData(serialPort);
            }
            LittleConsole.Text = "PAUSED";
            phase_stopwatch.Stop();
            phaseDuration[phase_number] -= (int)phase_stopwatch.ElapsedMilliseconds;
            phase_stopwatch.Reset();
            phase_timer.Stop();
            timer.Stop();
            Start_button.Text = "ПРОДОЛЖИТЬ";
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            string fullname;
            inProcess = false;
            Start_button.Text = "СТАРТ";
            phase_number = 0;
            phase_stopwatch.Reset();
            timer.Stop();
           
            phase_timer.Stop();
            LittleConsole.Text = "STOPPED";
            fullname = "\\Незаконченное_Исследование_" + Start_Time;
            fullname = fullname.Replace(' ', '_');
            fullname = fullname.Replace(':', '_');
            fullname = fullname.Replace('.', '_');
            fullname += ".xlsx";
            xlsxPath += fullname;
            Console.WriteLine(xlsxPath);
            xl.Book.SaveAs(xlsxPath);
            xlsxPath = xlsxPath.Remove(0);
            Console.WriteLine(xlsxPath);
        }

        public void Show_Data()
        {
            var rand = new Random();

            double Y_U;
            double Y_I;
            double Y_P;
            /*
            iY_U = Sheet.Cells[Sheet.Rows.Count, "B"].End[Excel.XlDirection.xlUp].Row;
            iY_I = Sheet.Cells[Sheet.Rows.Count, "C"].End[Excel.XlDirection.xlUp].Row;
            iY_P = Sheet.Cells[Sheet.Rows.Count, "D"].End[Excel.XlDirection.xlUp].Row;
            
            X = Convert.ToDouble(Sheet.Cells[i, 1].Value);
            */
            
                for (int i = 1; i <= N_Res; i++)
            {
                int current_resistor = i * 3;
                Y_U = Convert.ToDouble(xl.Sheet.Cell(xl.lastRow, current_resistor - 1).Value.ToString());
                Y_I = Convert.ToDouble(xl.Sheet.Cell(xl.lastRow, current_resistor).Value.ToString());
                Y_P = Convert.ToDouble(xl.Sheet.Cell(xl.lastRow, current_resistor + 1).Value.ToString());

                if (Y_U / Y_I > 13)
                {
                    if (Y_U / Y_I > 19)
                    {
                        if (Y_U / Y_I > 38)
                        {
                            Res_Status[i - 1] = 0;
                            Res_Status[i] = 0;
                            Res_Status[i + 1] = 0;

                        }
                        else
                        {
                            Res_Status[i - 1] = 0;
                            Res_Status[i] = 0; 
                            Res_Status[i - 1] = 1;
                        }
                    }
                    else
                    {
                        Res_Status[i - 1] = 0;
                        Res_Status[i] = 1;
                        Res_Status[i + 1] = 1;
                    }
                }

                (panel1.Controls["textBox_V_" + i.ToString()] as System.Windows.Forms.TextBox).Text = Y_U.ToString();
                (panel1.Controls["textBox_A_" + i.ToString()] as System.Windows.Forms.TextBox).Text = Y_I.ToString();
                (panel1.Controls["textBox_P_" + i.ToString()] as System.Windows.Forms.TextBox).Text = Y_P.ToString();
                if (current_resistor / 3 == chosen_Res && f2.Live == true)
                {
                    Console.WriteLine(xl.Sheet.Cell(xl.lastRow, 1).Value.ToString());
                    f2.Voltage_chart.Series[0].Points.AddXY(DateTime.Parse(xl.Sheet.Cell(xl.lastRow, 1).Value.ToString()).ToOADate(), Y_U);
                    f2.Current_chart.Series[0].Points.AddXY(DateTime.Parse(xl.Sheet.Cell(xl.lastRow, 1).Value.ToString()).ToOADate(), Y_I);
                    f2.Power_chart.Series[0].Points.AddXY(DateTime.Parse(xl.Sheet.Cell(xl.lastRow, 1).Value.ToString()).ToOADate(), Y_P);
                    if (xl.lastRow > f2.Voltage_chart.ChartAreas[0].AxisX.ScaleView.Size)//начать скролл при выходе за границу
                    {
                        f2.Voltage_chart.ChartAreas[0].AxisX.ScaleView.Scroll(xl.lastRow);//скрол
                        f2.Current_chart.ChartAreas[0].AxisX.ScaleView.Scroll(xl.lastRow);//скрол
                        f2.Power_chart.ChartAreas[0].AxisX.ScaleView.Scroll(xl.lastRow);//скрол
                    }
                }
                /*if (InvokeRequired)
                {
                    (panel1.Controls["textBox_V_" + i.ToString()] as System.Windows.Forms.TextBox).Invoke(new System.Action(() => { (panel1.Controls["textBox_V_" + i.ToString()] as System.Windows.Forms.TextBox).Text = Y_U.ToString(); }));
                    (panel1.Controls["textBox_A_" + i.ToString()] as System.Windows.Forms.TextBox).Invoke(new System.Action(() => { (panel1.Controls["textBox_A_" + i.ToString()] as System.Windows.Forms.TextBox).Text = Y_I.ToString(); }));
                    (panel1.Controls["textBox_P_" + i.ToString()] as System.Windows.Forms.TextBox).Invoke(new System.Action(() => { (panel1.Controls["textBox_P_" + i.ToString()] as System.Windows.Forms.TextBox).Text = Y_P.ToString(); }));
                    
                }*/
            }
        }
        
        private void Open_file_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                xlsxPath = folderBrowserDialog1.SelectedPath;
                xlsxPath.Replace('\\', '/');
                textBox5.Text = xlsxPath;
            }
            Console.WriteLine(xlsxPath);
        }

        private void Buffering_data(int chosen_Res)
        {
            DateTime Row;
            
            int Column = chosen_Res * 3; //Ошибка выбора файла
            
            for (int i = 1; i <= xl.lastRow; i++)
            {
                Row = DateTime.Parse(xl.Sheet.Cell(i, 1).Value.ToString());
                /*if (InvokeRequired)
                {
                    f2.Voltage_chart.Invoke(new System.Action(() => { f2.Voltage_chart.Series[0].Points.AddXY(Row, Convert.ToDouble(Sheet.Cells[i, Column - 1].Value)); }));
                    f2.Current_chart.Invoke(new System.Action(() => { f2.Current_chart.Series[0].Points.AddXY(Row, Convert.ToDouble(Sheet.Cells[i, Column].Value)); }));
                    f2.Power_chart.Invoke(new System.Action(() => { f2.Power_chart.Series[0].Points.AddXY(Row, Convert.ToDouble(Sheet.Cells[i, Column + 1].Value)); }));
                }
                */
                f2.Voltage_chart.Series[0].Points.AddXY(Row.ToOADate(), Convert.ToDouble(xl.Sheet.Cell(i, Column - 1).Value.ToString()));
                f2.Current_chart.Series[0].Points.AddXY(Row.ToOADate(), Convert.ToDouble(xl.Sheet.Cell(i, Column).Value.ToString()));
                f2.Power_chart.Series[0].Points.AddXY(Row.ToOADate(), Convert.ToDouble(xl.Sheet.Cell(i, Column + 1).Value.ToString()));
                //Console.WriteLine(Row.ToString());
            }
        }
        private void ExcelWrite(SerialPort serialPort)
        {
            
            string msg = serialPort.ReadLine().TrimEnd();
            if (msg == "over")
            {
                over = true;
                return;
            }
            xl.Sheet.Cell(xl.lastRow + 1, 1).Value = DateTime.Now.ToString(); // Установка номера строки, нужно время (переделать)

            int col = 2;
            int cnt = 0;
            //Потоковое считывание
            while (msg != "end")
            {

                cnt++;
                if (cnt % 4 == 0)
                {
                    if (msg == "0")
                    {
                        xl.Sheet.Cell(xl.lastRow + 1, col - 3).Style.Fill.SetBackgroundColor(XLColor.Red);
                        xl.Sheet.Cell(xl.lastRow + 1, col - 1).Style.Fill.SetBackgroundColor(XLColor.Red);
                        xl.Sheet.Cell(xl.lastRow + 1, col - 2).Style.Fill.SetBackgroundColor(XLColor.Red);
                    }
                }
                else
                {
                    xl.Sheet.Cell(xl.lastRow + 1, col++).Value = msg.Replace(".", ",");
                }

                msg = serialPort.ReadLine().TrimEnd();
            }
            
            xl.lastRow++;
            //xl.Book.Save();
        }
        private void GetData(SerialPort serialPort)
        {
            if (serialPort.BytesToRead > 0)
            {
                ExcelWrite(serialPort);
                if (!over)
                {
                    LittleConsole.Text = "Data saved at " + DateTime.Now.ToString("HH:mm:ss");
                    Show_Data();
                }
                else
                {
                    LittleConsole.Text = "OVER";
                }

            }
        }

        private void Comport_connect_button_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = ComportBox.Text;
                serialPort.BaudRate = Convert.ToInt32(BaudRateBox.Text);
                serialPort.Open(); // Открываем порт
                serialPort.DiscardOutBuffer();
            }
        }

        public void Modbus_connect_button_Click(object sender, EventArgs e)
        {
            try { modbusClient.Connect(Modbus_IP_textBox.Text, Convert.ToInt32(Modbus_Port_textBox.Text)); }
            catch (ConnectionException) { Modbus_status = false; }
            catch (System.FormatException) { Modbus_IP_textBox.BackColor = System.Drawing.Color.LightCoral; Modbus_Port_textBox.BackColor = System.Drawing.Color.LightCoral; }
            finally { Modbus_IP_textBox.BackColor = System.Drawing.Color.White; Modbus_Port_textBox.BackColor = System.Drawing.Color.White; }
        }

        public void Modbus_Changed(object sender)
        {
            Modbus_status = !Modbus_status;
        }

        private void final()
        {
            string fullname;
            serialPort.Close();
            LittleConsole.Text = "COMPLETE";
            //modbusClient.Disconnect();
            Start_button.Text = "СТАРТ";
            phase_number = 0;
            phase_stopwatch.Reset();
            MessageBox.Show("Исследование завершено!");
            timer.Stop();
            phase_timer.Stop();

            fullname = "\\Исследование_" + Start_Time;
            fullname = fullname.Replace(' ', '_');
            fullname = fullname.Replace(':', '_');
            fullname = fullname.Replace('.', '_');
            fullname += ".xlsx";
            xlsxPath += fullname;
            Console.WriteLine(xlsxPath);
            xl.Book.SaveAs(xlsxPath);
            xlsxPath = xlsxPath.Remove(0);

        }

        private void IntervalBetweenSendingData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modbus_status_box_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Modbus_IP_textBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Modbus_Port_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ComportBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BaudRateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PhaseDuration4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhaseDuration3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhaseDuration2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhaseDuration1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Comport_status_box_Click(object sender, EventArgs e)
        {

        }

        private void CurrentLowCritValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentHighCritValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void IntervalsBetweenPulse_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    class xl
    {
        static public XLWorkbook Book;
        static public IXLWorksheet Sheet;
        static public int lastRow = 0;
    }

}