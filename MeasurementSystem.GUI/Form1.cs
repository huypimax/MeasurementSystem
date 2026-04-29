using System.Windows.Forms;
using MeasurementSystem.GUI.Services;
using MeasurementSystem.Backend.Models;
using System;

namespace MeasurementSystem.GUI
{
    public partial class Form1 : Form
    {
        private UIManager _uiManager;

        public Form1()
        {
            InitializeComponent();

            // Khởi tạo người quản lý giao diện
            _uiManager = new UIManager();

            // Đăng ký nhận dữ liệu từ người quản lý
            _uiManager.OnUiRefreshRequired += UpdateLabels;

            // Bắt đầu chạy
            _uiManager.StartSimulation();
        }

        private void UpdateLabels(SensorData data)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateLabels(data)));
                return;
            }

            // Gán dữ liệu lên các nhãn (Label) bạn đã vẽ
            lblTemperature.Text = data.Temperature.ToString("0.0") + " °C";
            lblLaser.Text = data.LaserDistance.ToString("0.0") + " cm";
            lblAngle.Text = data.Angle.ToString("0.0") + " °";
            lblUltrasonic.Text = data.UltrasonicDistance.ToString("0.0") + " cm";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}