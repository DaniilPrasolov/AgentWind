using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAgent.Components
{
    class MotherBoard
    {
        public int Id { get; set; }
        public string Socket { get; set; }
        public string FSBType { get; set; }
        public string FSBFrequncy { get; set; }
        public string RAMConnector { get; set; }
        public int ComputerId { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Разъем: {0}\n", Socket);
            output.AppendFormat("Тип FSB: {0}\n", FSBType);
            output.AppendFormat("Частота шины: {0}\n", FSBFrequncy);
            output.AppendFormat("Коннектор : {0}\n", RAMConnector);
            ComputerId = ComputerInfo.Id;
            return output.ToString();
        }

    }
}
