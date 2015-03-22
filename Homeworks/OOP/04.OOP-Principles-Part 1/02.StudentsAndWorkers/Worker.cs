namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;
        private int workDaysInWeek;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay, int workDaysInWeek)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDaysInWeek = workDaysInWeek;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary cannot be negative.");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours per day cannot be negative.");
                }

                this.workHoursPerDay = value;
            }
        }

        public int WorkDaysInWeek
        {
            get
            {
                return this.workDaysInWeek;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work days in week cannot be negative.");
                }

                this.workDaysInWeek = value;
            }
        }

        public decimal MoneyPerHour { get; set; }

        public decimal GetMoneyPerHour()
        {
            decimal moneyPerHour = 0;
            return  moneyPerHour = (this.WeekSalary / this.WorkDaysInWeek) / (decimal)this.WorkHoursPerDay;
        }

        public override string ToString()
        {

            decimal MoneyPerHour = GetMoneyPerHour();
            return string.Format("{0} {1}, Money per hour: {2:F2}", this.FirstName, this.LastName, MoneyPerHour);
        }
    }
}
