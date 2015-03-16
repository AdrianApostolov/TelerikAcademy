namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | 
                    AttributeTargets.Enum | AttributeTargets.Method)]
    class VersionAttribute : Attribute
    {
        private string version;

        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version
        {
            get
            {
                return this.version;
            }

            private set
            {
                this.version = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Version: {0}", this.Version);
        }
    }
}
