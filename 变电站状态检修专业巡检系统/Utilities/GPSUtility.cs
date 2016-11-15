using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统.Utilities
{
    public class GPSUtility
    {
        public static SerialPort ComPort { get; set; }
        public static string[] PortNames
        {
            get
            {
                return SerialPort.GetPortNames();
            }
        }

        public static void OpenGPS()
        {
            List<string> ports = new List<string>();
            for (int i = 0; i < PortNames.Length; i++)
            {
                ports.Add(PortNames[i]);
            }
            ports.Sort();
            foreach (string portName in ports)
            {
                try
                {
                    ComPort.BaudRate = 4800;
                    ComPort.PortName = portName;
                    ComPort.ReadTimeout = 2000;
                    ComPort.Open();
                    ComPort.DiscardInBuffer();
                    ComPort.DiscardOutBuffer();
                    ComPort.ReadLine();
                    while (true)
                    {
                        string text = ComPort.ReadLine();
                        if (!text.Contains("$PSRFTXT"))
                        {

                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

    }
}
