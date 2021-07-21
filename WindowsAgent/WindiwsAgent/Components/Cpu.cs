using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;

namespace WindowsAgent.Components
{
    class Cpu
    {
        public int Id { get; set; }
        public int Frequncy { get; set; }
        public bool Bitness { get; set; }
        public int CacheMemory { get; set; }
        public string NumberOfCores { get; set; }

        public int ComputerId { get; set; }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Частота: {0}\n", Frequncy);
            output.AppendFormat("Битность 64: {0}\n", Bitness);
            output.AppendFormat("Кэш память: {0}\n", CacheMemory);
            output.AppendFormat("Число ядер: {0}\n", NumberOfCores);
            ComputerId = ComputerInfo.Id;
            return output.ToString();
            
        }
    } 
}

