using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAgent.Components
{
    class Hdd
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public string MaxSpeedWrite { get; set; }
        public string MaxSpeedRead { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Объем: {0}\n", Amount);
            output.AppendFormat("Скорость записи: {0}\n", MaxSpeedWrite);
            output.AppendFormat("Скорость чтения: {0}\n", MaxSpeedRead);
            return output.ToString();
        }
    }
}
