using MeasurementSystem.Backend.Services;
using MeasurementSystem.Backend.Models;
using System;

namespace MeasurementSystem.GUI.Services
{
    public class UIManager
    {
        private DataService _dataService;

        // Đây là cái "chuông" để báo cho Form1 biết khi nào có data
        public event Action<SensorData> OnUiRefreshRequired;

        public UIManager()
        {
            _dataService = new DataService();
            // Khi Backend có data giả, nó sẽ gọi hàm này
            _dataService.OnDataUpdated += (data) =>
            {
                // Truyền tiếp dữ liệu ra cho Form1
                OnUiRefreshRequired?.Invoke(data);
            };
        }

        public void StartSimulation()
        {
            _dataService.StartFakeData(500); // 500ms một lần
        }
    }
}