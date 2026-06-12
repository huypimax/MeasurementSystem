namespace MeasurementSystem.Backend.Services
{
    public class CommandService
    {
        private readonly SerialService _serial;

        public CommandService(SerialService serial)
        {
            _serial = serial;
        }

        // Yêu cầu firmware gửi raw hiện tại
        public void RequestRaw(string sensor)
        {
            _serial.Send($"GET_RAW,{sensor}");
        }

        // Ghi nhận điểm calibration thứ 1
        public void CapturePoint1(string sensor)
        {
            _serial.Send($"CALIB,{sensor},POINT1");
        }

        // Ghi nhận điểm calibration thứ 2
        public void CapturePoint2(string sensor)
        {
            _serial.Send($"CALIB,{sensor},POINT2");
        }

        // Giá trị chuẩn của điểm 1
        public void SetReference1(string sensor, float value)
        {
            _serial.Send($"CALIB,{sensor},REAL1,{value}");
        }

        // Giá trị chuẩn của điểm 2
        public void SetReference2(string sensor, float value)
        {
            _serial.Send($"CALIB,{sensor},REAL2,{value}");
        }

        // Firmware tính toán hệ số
        public void CalculateCalibration(string sensor)
        {
            _serial.Send($"CALIB,{sensor},CALCULATE");
        }

        // Lưu xuống Flash/EEPROM
        public void SaveCalibration(string sensor)
        {
            _serial.Send($"CALIB,{sensor},SAVE");
        }

        // Reset calibration
        public void ResetCalibration(string sensor)
        {
            _serial.Send($"CALIB,{sensor},RESET");
        }
    }
}