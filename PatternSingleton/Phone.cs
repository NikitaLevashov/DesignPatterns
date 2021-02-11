using System;

namespace PatternSingleton
{
    public class Phone
    {
        public OperatingSystem OperatingSystem { get; set; }
        public void Launch(string operatingSystemName)
        {
            OperatingSystem = OperatingSystem.getOperatingSystem(operatingSystemName);
        }
    }
}
