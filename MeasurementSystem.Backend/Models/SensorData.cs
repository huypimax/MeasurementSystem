namespace MeasurementSystem.Backend.Models
{
    public class SensorData
    {
        // Thermistor
        public float Temperature { get; set; }   // °C

        // Laser distance sensor
        public float LaserDistance { get; set; } // cm

        // Potentiometer
        public float Angle { get; set; }         // degree

        // Ultrasonic
        public float UltrasonicDistance { get; set; } // cm
    }
}