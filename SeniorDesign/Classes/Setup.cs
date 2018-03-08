using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Ports;
using InTheHand.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.IO.Ports;

namespace SeniorDesign.Classes
{
    public static class Setup
    {
        static SerialPort SP = new SerialPort("COM4");
        public static void Send(string message)
        {
            StringComparer stringComp = StringComparer.OrdinalIgnoreCase;
            SP.BaudRate = 9600;
            SP.Parity = Parity.None;
            SP.StopBits = StopBits.One;
            SP.DataBits = 8;
            SP.Handshake = Handshake.None;
            SP.RtsEnable = true;
            if (SP != null)
            {
                if (SP.IsOpen)
                {
                    SP.WriteLine(message);
                }
                else
                {
                    SP.Open();
                    //SP.ReadTimeout = 1000;
                    SP.WriteLine(message);
                }
            }
        }
        public static void OnApplicationQuit()
        {
            SP.Close();
        }


    }
}
