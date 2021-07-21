using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsAgent.Components
{
    class ComputerInfo
    {
        public static int Id { get; set; }
        public string OSVersion { get; set; }
        public string ComputerName { get; set; }
        public string SystemFolder { get; set; }
        public int CreationTime { get; set; }
        public int UpdateTime { get; set; }
        public string OSName { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Версия Windows: {0}\n", OSVersion);
            output.AppendFormat("Имя компьютера: {0}\n", ComputerName);
            output.AppendFormat("SystemFolder: {0}\n", SystemFolder);
            output.AppendFormat("Creation time : {0}\n", CreationTime);
            output.AppendFormat("Update time : {0}\n", UpdateTime);
            output.AppendFormat("Операционная система : {0}\n", OSName);
            return output.ToString();
        }

    }
}
