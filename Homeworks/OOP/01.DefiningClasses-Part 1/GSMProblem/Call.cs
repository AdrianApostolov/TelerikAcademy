namespace GSMProblem
{
    using System;

    public class Call
    {
        private DateTime dateTime;
        private string dialledPhone;
        private int duration;

        public Call(string dialledPhone, int duration)
        {
            this.DialledPhone = dialledPhone;
            this.Duration = duration;
        }

        public Call(DateTime dateTime, string dialledPhone, int duration)
            : this(dialledPhone, duration)
        {
            this.DataTime = dateTime;
        }

        public DateTime DataTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public string DialledPhone
        {
            get
            {
                return this.dialledPhone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Dailed number cannot be empty.");
                }
                else
                {
                    this.dialledPhone = value;
                }
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Duration negative.");
                }
                else
                {
                    this.duration = value;
                }
                
            }
        }

        public override string ToString()
        {
            return string.Format("Time of call: {0} | Dialled phone number: {1} | Duration: {2}sec", 
                this.dateTime, this.dialledPhone, this.duration);
        }
    }
}
