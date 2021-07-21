using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAgent.Components
{
    class Programms
    {
        public int Id { get; set; }
        public List<string> Name { get; set; }
        public List<string> Version { get; set; }
        public List<string> FirstDownloadDate { get; set; }
        public List<string> Volume { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Название: {0}\n", Name);
            output.AppendFormat("Версия: {0}\n", Version);
            output.AppendFormat("Первая дата установки: {0}\n", FirstDownloadDate);
            output.AppendFormat("Объем: {0}\n", Volume);
            return output.ToString();
        }
    }
}
