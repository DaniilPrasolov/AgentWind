using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using WindowsAgent.Components;

namespace WindowsAgent
{
    public class AgentModel
    {


        AgentModel(Cpu cpu, Gpu gpu,
                 USBDevices usbDevices, ComputerInfo computerInfo,
                 Hdd hdd, Ssd ssd, MotherBoard motherBoard,
                 Programms programms, Ram ram
             )
        {
            string json = JsonSerializer.Serialize<Cpu>(cpu);
            json += JsonSerializer.Serialize<Gpu>(gpu);
            json += JsonSerializer.Serialize<USBDevices>(usbDevices);
            json += JsonSerializer.Serialize<ComputerInfo>(computerInfo);
            json += JsonSerializer.Serialize<Hdd>(hdd);
            json += JsonSerializer.Serialize<Ssd>(ssd);
            json += JsonSerializer.Serialize<MotherBoard>(motherBoard);
            json += JsonSerializer.Serialize<Programms>(programms);
            json += JsonSerializer.Serialize<Ram>(ram);
        }
    }
}
