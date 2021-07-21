using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAgent.Components
{
    class USBDevices
    {
        public int Id { get; set; }
        public List<string> Names { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Имена: {0}\n", Names);
            return output.ToString();
        }
    }
}
