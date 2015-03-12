namespace GSMProblem
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        private const int secondsInOneMinute = 60;
        private static readonly GSM Iphone4S = new GSM("Iphone4S", "Apple", new Battery(BatteryType.Li_Ion, 500, 200),
            new Display(4, 16000000));

        private string model;
        private string owner;
        private string manufacturer;
        private decimal price;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM (string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, Battery battery) : this (model, manufacturer)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display) : this(model, manufacturer, battery)
        {
            this.Display = display;
        }

        public static GSM IPhone4S
        {
            get
            {
                return Iphone4S;
            }
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
                    throw new ArgumentException("Model`s name should be longer than 0");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("Owner`s name should be longer than 0");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("Manifacturer name should be longer than 0");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price should be longer than 0");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public List<Call> CallHistory
        {
            get { return new List<Call>(this.callHistory); }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMinute)
        {
            decimal allCallsInSecs = (decimal)(this.callHistory.Select(x => x.Duration).Sum());
            decimal totalPrice = (allCallsInSecs / secondsInOneMinute) * pricePerMinute;

            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder GSMInformation = new StringBuilder();

            GSMInformation.Append(string.Format("Manufacturer: {0}\n", this.manufacturer));
            GSMInformation.Append(string.Format("Model: {0}\n", this.model));
            GSMInformation.Append(string.Format("Battery: {0}\n", this.battery.BatteryType));
            GSMInformation.Append(string.Format("Display: {0} inchs and {1} colors", this.display.Size, this.display.NumberOfColors));

            return GSMInformation.ToString();
        }
    }
}
