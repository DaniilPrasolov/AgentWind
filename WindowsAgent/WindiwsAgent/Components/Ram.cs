using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAgent.Components
{
    class Ram
    {
        public int Id { get; set; }
        public string Frequency { get; set; }
        public string Volume { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Частота: {0}\n", Frequency);
            output.AppendFormat("Объем: {0}\n", Volume);
            return output.ToString();
        }
    }
}
