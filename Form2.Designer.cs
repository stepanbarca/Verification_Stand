namespace Test_TextBox_1
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Voltage_button = new System.Windows.Forms.Button();
            this.Current_button = new System.Windows.Forms.Button();
            this.Power_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.Power_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Current_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Voltage_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Power_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Current_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltage_button
            // 
            this.Voltage_button.Location = new System.Drawing.Point(208, 453);
            this.Voltage_button.Name = "Voltage_button";
            this.Voltage_button.Size = new System.Drawing.Size(75, 23);
            this.Voltage_button.TabIndex = 1;
            this.Voltage_button.Text = "U";
            this.Voltage_button.UseVisualStyleBackColor = true;
            this.Voltage_button.Click += new System.EventHandler(this.Voltage_button_Click);
            // 
            // Current_button
            // 
            this.Current_button.Location = new System.Drawing.Point(381, 453);
            this.Current_button.Name = "Current_button";
            this.Current_button.Size = new System.Drawing.Size(75, 23);
            this.Current_button.TabIndex = 2;
            this.Current_button.Text = "I";
            this.Current_button.UseVisualStyleBackColor = true;
            this.Current_button.Click += new System.EventHandler(this.Current_button_Click);
            // 
            // Power_button
            // 
            this.Power_button.Location = new System.Drawing.Point(551, 453);
            this.Power_button.Name = "Power_button";
            this.Power_button.Size = new System.Drawing.Size(75, 23);
            this.Power_button.TabIndex = 3;
            this.Power_button.Text = "P";
            this.Power_button.UseVisualStyleBackColor = true;
            this.Power_button.Click += new System.EventHandler(this.Power_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.Red;
            this.Close_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close_button.Location = new System.Drawing.Point(807, 453);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(35, 30);
            this.Close_button.TabIndex = 4;
            this.Close_button.Text = "X";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Power_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Power_chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Power_chart.Legends.Add(legend1);
            this.Power_chart.Location = new System.Drawing.Point(16, 17);
            this.Power_chart.Name = "Power_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Power_chart.Series.Add(series1);
            this.Power_chart.Size = new System.Drawing.Size(825, 424);
            this.Power_chart.TabIndex = 5;
            this.Power_chart.Text = "chart1";
            // 
            // Current_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Current_chart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.Current_chart.Legends.Add(legend2);
            this.Current_chart.Location = new System.Drawing.Point(17, 17);
            this.Current_chart.Name = "Current_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Current_chart.Series.Add(series2);
            this.Current_chart.Size = new System.Drawing.Size(825, 424);
            this.Current_chart.TabIndex = 6;
            this.Current_chart.Text = "chart1";
            // 
            // Voltage_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Voltage_chart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.Voltage_chart.Legends.Add(legend3);
            this.Voltage_chart.Location = new System.Drawing.Point(17, 17);
            this.Voltage_chart.Name = "Voltage_chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Voltage_chart.Series.Add(series3);
            this.Voltage_chart.Size = new System.Drawing.Size(825, 424);
            this.Voltage_chart.TabIndex = 7;
            this.Voltage_chart.Text = "chart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 488);
            this.ControlBox = false;
            this.Controls.Add(this.Voltage_chart);
            this.Controls.Add(this.Current_chart);
            this.Controls.Add(this.Power_chart);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Power_button);
            this.Controls.Add(this.Current_button);
            this.Controls.Add(this.Voltage_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Power_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Current_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Voltage_button;
        private System.Windows.Forms.Button Current_button;
        private System.Windows.Forms.Button Power_button;
        private System.Windows.Forms.Button Close_button;
        public System.Windows.Forms.DataVisualization.Charting.Chart Power_chart;
        public System.Windows.Forms.DataVisualization.Charting.Chart Current_chart;
        public System.Windows.Forms.DataVisualization.Charting.Chart Voltage_chart;
    }
}