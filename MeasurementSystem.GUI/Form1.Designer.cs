namespace MeasurementSystem.GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTemperature = new Label();
            lblLaser = new Label();
            lblAngle = new Label();
            lblUltrasonic = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label = new Label();
            lblStatus = new Label();
            chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartLaser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartAngle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartUltra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartLaser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAngle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartUltra).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 26);
            label2.Name = "label2";
            label2.Size = new Size(247, 38);
            label2.TabIndex = 1;
            label2.Text = "Khoảng cách Laser";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(33, 24);
            label3.Name = "label3";
            label3.Size = new Size(133, 38);
            label3.TabIndex = 2;
            label3.Text = "Góc quay";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 26);
            label4.Name = "label4";
            label4.Size = new Size(279, 38);
            label4.TabIndex = 3;
            label4.Text = "Khoảng cách siêu âm";
            label4.Click += label4_Click;
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 12F);
            lblTemperature.Location = new Point(32, 64);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(53, 38);
            lblTemperature.TabIndex = 4;
            lblTemperature.Text = "0.0";
            lblTemperature.Click += label1_Click;
            // 
            // lblLaser
            // 
            lblLaser.AutoSize = true;
            lblLaser.Font = new Font("Segoe UI", 12F);
            lblLaser.Location = new Point(33, 65);
            lblLaser.Name = "lblLaser";
            lblLaser.Size = new Size(53, 38);
            lblLaser.TabIndex = 5;
            lblLaser.Text = "0.0";
            lblLaser.Click += label5_Click;
            // 
            // lblAngle
            // 
            lblAngle.AutoSize = true;
            lblAngle.Font = new Font("Segoe UI", 12F);
            lblAngle.Location = new Point(33, 63);
            lblAngle.Name = "lblAngle";
            lblAngle.Size = new Size(53, 38);
            lblAngle.TabIndex = 6;
            lblAngle.Text = "0.0";
            // 
            // lblUltrasonic
            // 
            lblUltrasonic.AutoSize = true;
            lblUltrasonic.Font = new Font("Segoe UI", 12F);
            lblUltrasonic.Location = new Point(30, 64);
            lblUltrasonic.Name = "lblUltrasonic";
            lblUltrasonic.Size = new Size(53, 38);
            lblUltrasonic.TabIndex = 7;
            lblUltrasonic.Text = "0.0";
            lblUltrasonic.Click += label7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAngle);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(611, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 133);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Góc quay";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblUltrasonic);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(850, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 130);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khoảng cách siêu âm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblLaser);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(286, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 136);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khoảng cách Laser";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTemperature);
            groupBox4.Controls.Add(label);
            groupBox4.Location = new Point(67, 92);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(197, 136);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nhiệt độ";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F);
            label.Location = new Point(32, 25);
            label.Name = "label";
            label.Size = new Size(125, 38);
            label.TabIndex = 0;
            label.Text = "Nhiệt độ";
            label.Click += label_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(12, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(210, 38);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Đang kiểm tra...";
            lblStatus.Click += label1_Click_1;
            // 
            // chartTemp
            // 
            chartArea1.Name = "ChartArea1";
            chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTemp.Legends.Add(legend1);
            chartTemp.Location = new Point(41, 287);
            chartTemp.Name = "chartTemp";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTemp.Series.Add(series1);
            chartTemp.Size = new Size(784, 441);
            chartTemp.TabIndex = 13;
            chartTemp.Text = "chart1";
            // 
            // chartLaser
            // 
            chartArea2.Name = "ChartArea1";
            chartLaser.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartLaser.Legends.Add(legend2);
            chartLaser.Location = new Point(850, 287);
            chartLaser.Name = "chartLaser";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartLaser.Series.Add(series2);
            chartLaser.Size = new Size(784, 441);
            chartLaser.TabIndex = 14;
            chartLaser.Text = "chart1";
            // 
            // chartAngle
            // 
            chartArea3.Name = "ChartArea1";
            chartAngle.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartAngle.Legends.Add(legend3);
            chartAngle.Location = new Point(41, 756);
            chartAngle.Name = "chartAngle";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartAngle.Series.Add(series3);
            chartAngle.Size = new Size(784, 441);
            chartAngle.TabIndex = 15;
            chartAngle.Text = "chartAngle";
            // 
            // chartUltra
            // 
            chartArea4.Name = "ChartArea1";
            chartUltra.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartUltra.Legends.Add(legend4);
            chartUltra.Location = new Point(850, 756);
            chartUltra.Name = "chartUltra";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartUltra.Series.Add(series4);
            chartUltra.Size = new Size(784, 441);
            chartUltra.TabIndex = 16;
            chartUltra.Text = "chartUltra";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1743, 1764);
            Controls.Add(chartUltra);
            Controls.Add(chartAngle);
            Controls.Add(chartLaser);
            Controls.Add(chartTemp);
            Controls.Add(lblStatus);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartLaser).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAngle).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartUltra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTemperature;
        private Label lblLaser;
        private Label lblAngle;
        private Label lblUltrasonic;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblStatus;
        private Label label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLaser;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAngle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUltra;
    }
}
