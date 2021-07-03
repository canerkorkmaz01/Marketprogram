namespace License
{
    using System;
    using System.Runtime.CompilerServices;

    public class KeyValuesClass
    {
        public License.Edition Edition { get; set; }

        public DateTime Expiration { get; set; }

        public byte Footer { get; set; }

        public byte Header { get; set; }

        public byte ProductCode { get; set; }

        public LicenseType Type { get; set; }

        public byte Version { get; set; }
    }
}

