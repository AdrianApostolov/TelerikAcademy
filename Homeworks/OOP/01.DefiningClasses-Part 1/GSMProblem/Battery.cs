namespace GSMProblem
{
    using System;

    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(BatteryType batteryType, double hoursIdle, double hoursTalk)
        {
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;

        }

        public string Model 
        {
            get 
            { 
                return this.model; 
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentOutOfRangeException("Model name should be longer than");
                }
                else
                {
                    this.model = value;   
                }
            }
        }

        public double HoursIdle
        {
            get 
            { 
                return this.hoursIdle; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle should be longe than 0");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double HoursTalk
        {
            get 
            { 
                return this.hoursTalk; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours talk should be longer than 0");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                this.batteryType = value;
            }
        }
    }
}
