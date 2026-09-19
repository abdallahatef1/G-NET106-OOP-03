using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp3
{
    internal class Driver
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public Driver(string name)
        {
            this.name = !string.IsNullOrWhiteSpace(name) ? name : "Unknown";
        }
    }
}
