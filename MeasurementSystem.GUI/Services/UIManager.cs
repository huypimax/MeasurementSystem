using MeasurementSystem.Backend.Services;
using MeasurementSystem.Backend.Models;
using System;

namespace MeasurementSystem.GUI.Services
{
    public class UIManager
    {
        private DataService _dataService;
        private SerialService _serialService;

        public event Action<SensorData> OnUiRefreshRequired;

        public UIManager()
        {
            _serialService = new SerialService();
            _dataService = new DataService(_serialService);

            _dataService.OnDataUpdated += (data) =>
            {
                OnUiRefreshRequired?.Invoke(data);
            };
        }

        public void Start()
        {
            _dataService.Connect("COM3");
        }
    }
}