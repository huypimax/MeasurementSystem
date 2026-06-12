using MeasurementSystem.Backend.Models;
using System;
using System.Globalization;

namespace MeasurementSystem.Backend.Services
{
    public class DataService
    {
        private SerialService _serial;
        private CommandService _commandService;

        public event Action<SensorData>? OnDataUpdated;
        public event Action<string>? OnError;

        public DataService(SerialService serial)
        {
            _serial = serial;

            _commandService = new CommandService(serial);

            _serial.OnRawDataReceived += HandleRawData;

            _serial.OnDisconnected += () =>
            {
                OnError?.Invoke("Serial disconnected");
            };
        }

        private void HandleRawData(string raw)
        {
            try
            {
                var data = ParseData(raw);
                if (data != null)
                {
                    OnDataUpdated?.Invoke(data);
                }
            }
            catch (Exception ex)
            {
                OnError?.Invoke("Parse error: " + ex.Message);
            }
        }

        private SensorData ParseData(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
                throw new Exception("Empty data");

            Console.WriteLine("RAW: " + raw);

            var parts = raw.Split(';');

            SensorData data = new SensorData();

            bool hasTherm = false, hasLaser = false, hasPot = false, hasUltra = false;

            foreach (var part in parts)
            {
                var kv = part.Split(':');

                if (kv.Length != 2)
                    throw new Exception($"Invalid format: {part}");

                string key = kv[0].Trim().ToUpper();
                string value = kv[1].Trim();

                if (!float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedValue))
                {
                    throw new Exception($"Invalid number: {value}");
                }

                switch (key)
                {
                    case "THERMISTOR":
                        data.Temperature = parsedValue;
                        hasTherm = true;
                        break;

                    case "LASER":
                        data.LaserDistance = parsedValue;
                        hasLaser = true;
                        break;

                    case "POTENTIOMETER":
                        data.Angle = parsedValue;
                        hasPot = true;
                        break;

                    case "ULTRASONIC":
                        data.UltrasonicDistance = parsedValue;
                        hasUltra = true;
                        break;
                }
            }

            if (!hasTherm || !hasLaser || !hasPot || !hasUltra)
                throw new Exception("Missing sensor data");

            return data;
        }

        public void Connect(string port)
        {
            _serial.Connect(port);
        }

        public void Disconnect()
        {
            _serial.Disconnect();
        }

        public void RequestRaw(string sensor)
        {
            _commandService.RequestRaw(sensor);
        }

        public void CapturePoint1(string sensor)
        {
            _commandService.CapturePoint1(sensor);
        }

        public void CapturePoint2(string sensor)
        {
            _commandService.CapturePoint2(sensor);
        }

        public void SetReference1(string sensor, float value)
        {
            _commandService.SetReference1(sensor, value);
        }

        public void SetReference2(string sensor, float value)
        {
            _commandService.SetReference2(sensor, value);
        }

        public void CalculateCalibration(string sensor)
        {
            _commandService.CalculateCalibration(sensor);
        }

        public void SaveCalibration(string sensor)
        {
            _commandService.SaveCalibration(sensor);
        }
    }
}