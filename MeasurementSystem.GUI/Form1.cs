using System.Windows.Forms;
using MeasurementSystem.GUI.Services;
using MeasurementSystem.Backend.Models;
using System;
// Thêm thư viện vẽ biểu đồ
using System.Drawing;

namespace MeasurementSystem.GUI
{
    public partial class Form1 : Form
    {
        private UIManager _uiManager;
        private DisplayManager _display;
        private StatusManager _status;
        private ChartManager _ctTemp, _ctLaser, _ctAngle, _ctUltra;
        public Form1()
        {
            InitializeComponent();

            // Khởi tạo người quản lý giao diện
            _uiManager = new UIManager();
            _display = new DisplayManager(lblTemperature, lblLaser, lblAngle, lblUltrasonic);
            _status = new StatusManager(lblStatus);
            // Khởi tạo 4 biểu đồ với tên tương ứng
            _ctTemp = new ChartManager(chartTemp, "Nhiệt độ");
            _ctLaser = new ChartManager(chartLaser, "Laser");
            _ctAngle = new ChartManager(chartAngle, "Góc quay");
            _ctUltra = new ChartManager(chartUltra, "Siêu âm");

            // Đăng ký nhận dữ liệu từ người quản lý
            _uiManager.OnUiRefreshRequired += (data) =>
            {
                _display.UpdateAll(data);
                _ctTemp.AddDataPoint(data.Temperature);
                _ctLaser.AddDataPoint(data.LaserDistance);
                _ctAngle.AddDataPoint(data.Angle);
                _ctUltra.AddDataPoint(data.UltrasonicDistance);
            };

            // Đăng ký nhận thông báo trạng thái kết nối
            _uiManager.OnConnectionStatusChanged += (connected) =>
            {
                _status.SetStatus(connected);
            };

            _uiManager.ConnectDevice("COM3"); // Thay COM3 bằng cổng của bạn
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}