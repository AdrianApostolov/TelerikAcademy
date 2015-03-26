namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end)
            : this(string.Empty, null, start, end)
        {

        }

        public InvalidRangeException(string message, Exception innerException, T start, T end)
            : base(message, innerException)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get
            {
                return this.start;
            }

            private set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }

            private set
            {
                this.end = value;
            }
        }

        public override string Message
        {
            get
            {
                return string.Format("Invalid range. Parameters must be between: [{0} - {1}].", this.Start, this.End); ;
            }
        }
    }
}
