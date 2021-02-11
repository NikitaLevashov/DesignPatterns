using System;
using System.Collections.Generic;
using System.Text;

namespace PatternSingleton
{
    public class OperatingSystem
    {
        private static OperatingSystem _operatingSystem;
        public string Name { get; private set; }
        protected OperatingSystem(string name)
        {
            Name = name;
        }
        public static OperatingSystem getOperatingSystem(string name)
        {
            if (_operatingSystem == null)
                _operatingSystem = new OperatingSystem(name);
            return _operatingSystem;
        } 
    }
}
