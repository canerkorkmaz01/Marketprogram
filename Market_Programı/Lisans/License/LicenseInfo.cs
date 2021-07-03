namespace License
{
    using System;
    using System.Runtime.CompilerServices;

    public class LicenseInfo
    {
        public DateTime CheckDate
        {
            get
            {
                DateTime time = new DateTime(this.Year, this.Month, this.Day);
                return time.Date;
            }
        }

        public string Data =>
            $"{this.FullName}#{this.ProductKey}#{this.Day}#{this.Month}#{this.Year}";

        public int Day { get; set; }

        public string FullName { get; set; }

        public int Month { get; set; }

        public string ProductKey { get; set; }

        public int Year { get; set; }
    }
}

