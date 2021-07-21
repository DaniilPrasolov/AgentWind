using System;
using System.Management;
using System.Text;


namespace WindowsAgent.Components
{
    class Gpu
    {
        public int Id { get; set; }
        public string Frequency { get; set; }
        public string VolumeMemory { get; set; }
        public string FrequencyMemory { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Частота: {0}\n", Frequency);
            output.AppendFormat("Объем памяти: {0}\n", VolumeMemory);
            output.AppendFormat("Frequency Memory: {0}\n", FrequencyMemory);
            return output.ToString();
        }


    }
}
