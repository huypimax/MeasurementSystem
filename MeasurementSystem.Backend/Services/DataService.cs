using System;
using System.Timers;
using MeasurementSystem.Backend.Models;

namespace MeasurementSystem.Backend.Services
{
    public class DataService
    {
        public event Action<SensorData>? OnDataUpdated;

        private System.Timers.Timer? _timer;
        private readonly Random _rand = new Random();

        public void StartFakeData(int intervalMs = 500)
        {
            _timer?.Stop();

            _timer = new System.Timers.Timer(intervalMs);
            _timer.Elapsed += (s, e) =>
            {
                var data = GenerateFakeData();
                OnDataUpdated?.Invoke(data);
            };

            _timer.Start();
        }

        public void Stop()
        {
            _timer?.Stop();
        }

        private SensorData GenerateFakeData()
        {
            return new SensorData
            {
                Temperature = 20 + (float)_rand.NextDouble() * 10,      // 20–30°C
                LaserDistance = (float)_rand.NextDouble() * 200,        // 0–200 cm
                Angle = (float)_rand.NextDouble() * 300,                // 0–300 deg
                UltrasonicDistance = (float)_rand.NextDouble() * 400    // 0–400 cm
            };
        }
    }
}