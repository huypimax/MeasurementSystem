using System.IO.Ports;

namespace MeasurementSystem.Backend.Services
{
    public class SerialService
    {
        private SerialPort? _serial;

        public bool IsConnected => _serial != null && _serial.IsOpen;

        public void Connect(string portName, int baudRate = 115200)
        {
            _serial = new SerialPort(portName, baudRate);
            _serial.Open();
        }

        public void Disconnect()
        {
            if (_serial != null && _serial.IsOpen)
            {
                _serial.Close();
            }
        }

        public void Send(string message)
        {
            if (IsConnected)
            {
                _serial!.WriteLine(message);
            }
        }

        public string? ReadLine()
        {
            if (IsConnected)
            {
                return _serial!.ReadLine();
            }
            return null;
        }
    }
}