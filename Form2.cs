using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Test_TextBox_1
{
    public partial class Form2 : Form
    {
        //static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        
        
        public Form2()
        {
            InitializeComponent();
            
        }
        public const int scroll = 60;//количество точек до скрола 
        //public DateTime Start_time;
        //public double start_t;

        public void Form2_Load(object sender, EventArgs e)
        {
            Voltage_chart_Init();
            Current_chart_Init();
            Power_chart_Init();
        }

        public bool Live = false;
        // 1 - U, 2 - I, 3 - P

        private void Voltage_button_Click(object sender, EventArgs e)
        {
            Voltage_chart.Visible = true;
            Current_chart.Visible = false;
            Power_chart.Visible = false;
        }

        private void Current_button_Click(object sender, EventArgs e)
        {
            Voltage_chart.Visible = false;
            Current_chart.Visible = true;
            Power_chart.Visible = false;
            // Show(f1.chosen_Res, 2);
        }

        private void Power_button_Click(object sender, EventArgs e)
        {
            Voltage_chart.Visible = false;
            Current_chart.Visible = false;
            Power_chart.Visible = true;
            //  Show(f1.chosen_Res, 3);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Visible = false;
            Live = false;
            Voltage_chart.Series[0].Points.Clear();
            Current_chart.Series[0].Points.Clear();
            Power_chart.Series[0].Points.Clear();
            //Close();
        }

        private void Voltage_chart_Init()
        {
            Voltage_chart.ChartAreas[0].AxisY.Maximum = 5;
            Voltage_chart.ChartAreas[0].AxisY.Minimum = 0;
            Voltage_chart.Series[0].XValueType = ChartValueType.DateTime;
            Voltage_chart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            //Voltage_chart.ChartAreas[0].AxisX.Interval =160;
            Voltage_chart.Series[0].Color = System.Drawing.Color.Blue;
            Voltage_chart.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Seconds;

            Voltage_chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;//скрол над цифрами
            Voltage_chart.ChartAreas[0].AxisX.ScaleView.Size = scroll;//размер скрола
            Voltage_chart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;//только полоса
            Voltage_chart.ChartAreas[0].AxisX.ScrollBar.BackColor = System.Drawing.Color.DarkGray; //цвета
            Voltage_chart.ChartAreas[0].AxisX.ScrollBar.ButtonColor = System.Drawing.Color.DimGray; //цвета
        }

        private void Current_chart_Init()
        {
            Current_chart.ChartAreas[0].AxisY.Maximum = 40;
            Current_chart.ChartAreas[0].AxisY.Minimum = 0;
            Current_chart.Series[0].XValueType = ChartValueType.DateTime;
            Current_chart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            //Voltage_chart.ChartAreas[0].AxisX.Interval =160;
            Current_chart.Series[0].Color = System.Drawing.Color.Blue;
            Current_chart.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Seconds;

            Current_chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;//скрол над цифрами
            Current_chart.ChartAreas[0].AxisX.ScaleView.Size = scroll;//размер скрола
            Current_chart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;//только полоса
            Current_chart.ChartAreas[0].AxisX.ScrollBar.BackColor = System.Drawing.Color.DarkGray; //цвета
            Current_chart.ChartAreas[0].AxisX.ScrollBar.ButtonColor = System.Drawing.Color.DimGray; //цвета
        }

        private void Power_chart_Init()
        {
            Power_chart.ChartAreas[0].AxisY.Maximum = 40;
            Power_chart.ChartAreas[0].AxisY.Minimum = 0;
            Power_chart.Series[0].XValueType = ChartValueType.DateTime;
            Power_chart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            //Voltage_chart.ChartAreas[0].AxisX.Interval =160;
            Power_chart.Series[0].Color = System.Drawing.Color.Blue;
            Power_chart.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Seconds;

            Power_chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;//скрол над цифрами
            Power_chart.ChartAreas[0].AxisX.ScaleView.Size = scroll;//размер скрола
            Power_chart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;//только полоса
            Power_chart.ChartAreas[0].AxisX.ScrollBar.BackColor = System.Drawing.Color.DarkGray; //цвета
            Power_chart.ChartAreas[0].AxisX.ScrollBar.ButtonColor = System.Drawing.Color.DimGray; //цвета
        }


        /* public void Show(int chosen_Res, int Value)
         {
             chart1.Series[0].Color = Color.Blue;
             chart1.Series[1].Color = Color.White;
             chart1.Series[2].Color = Color.White;
         }*/
    }
}
