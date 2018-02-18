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

namespace SeniorDesign.Classes
{
    public class Setup
    {

        public static bool Connect()
        {
            BluetoothClient client = new BluetoothClient();
            MessageBox.Show("Attempting to connect as client.");
            return false;
        }



    }
}
