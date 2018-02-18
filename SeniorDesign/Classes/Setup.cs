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
        public BluetoothDeviceInfo deviceInfo;

        Guid mUUID = new Guid("00001101-0000-1000-8000-00805F9B34FB");

        public bool ClientConnect()
        {
            BluetoothClient client = new BluetoothClient();
            MessageBox.Show("Attempting to connect as client.");
            client.BeginConnect(deviceInfo.DeviceAddress, mUUID, this.BluetoothClientConnectCallback, client);
            return false;

        }

        void BluetoothClientConnectCallback(IAsyncResult result)
        {
            BluetoothClient client = (BluetoothClient)result.AsyncState;
            client.EndConnect(result);

            Stream stream = client.GetStream();
        }

    }
}
