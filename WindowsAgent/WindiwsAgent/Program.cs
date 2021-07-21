using System;
using WindowsAgent;
using WindowsAgent.Components;
using System.Management;

namespace Agent
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerInfo computerInfo = new ComputerInfo
            {
                OSVersion = Environment.OSVersion.ToString(),
                ComputerName = Environment.MachineName,
                SystemFolder = Environment.SystemDirectory,
                CreationTime = Environment.TickCount/1000/60,
                UpdateTime = Environment.TickCount/1000/60,
                OSName = Environment.OSVersion.ToString()
            };
            Cpu cpu = new Cpu
            {
                Frequncy = Environment.ProcessorCount,
                Bitness = Environment.Is64BitProcess,
                CacheMemory = Environment.ProcessorCount,
               // NumberOfCores = System.Management.
            };
            Gpu gpu = new Gpu
            {
                //Frequency = Environment.,
                //VolumeMemory = Environment.,
                //FrequencyMemory = Environment.,
            };

            ManagementObjectSearcher searcher =
                 new ManagementObjectSearcher("root\\CIMV2",
                 "SELECT * FROM Win32_Volume");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("Объем: {0}", queryObj["Объем"]);
            };


            Console.WriteLine(cpu);
            Console.WriteLine(computerInfo);
            
        }


    }
}
