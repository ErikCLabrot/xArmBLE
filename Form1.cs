using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;
using Windows.UI.Composition;

namespace xArmBLE
{
    public partial class Form1 : Form
    {
        //Defs and Boilerplate BLE code from microsoft docs
        static DeviceInformation xarm_info = null;
        public static int XARM_UART_SERVICE_HANDLE = 24;
        static bool connected = false;
        static bool detected = false;
        BluetoothLEDevice xarm = null;
        GattCharacteristic UART_Characteristic = null;

        // Query for extra properties you want returned
        static string[] requestedProperties = { "System.Devices.Aep.DeviceAddress", "System.Devices.Aep.IsConnected" };

        DeviceWatcher deviceWatcher =
                    DeviceInformation.CreateWatcher(
                            BluetoothLEDevice.GetDeviceSelectorFromPairingState(false),
                            requestedProperties,
                            DeviceInformationKind.AssociationEndpoint);

        public Form1()
        {
            InitializeComponent();

            ValueBox1.Text = "0";
            ValueBox2.Text = "0";
            ValueBox3.Text = "0";
            ValueBox4.Text = "0";
            ValueBox5.Text = "0";
            ValueBox6.Text = "0";

            // Register event handlers before starting the watcher.
            // Added, Updated and Removed are required to get all nearby devices
            deviceWatcher.Added += DeviceWatcher_Added;
            deviceWatcher.Updated += DeviceWatcher_Updated;
            deviceWatcher.Removed += DeviceWatcher_Removed;

            // EnumerationCompleted and Stopped are optional to implement.
            deviceWatcher.EnumerationCompleted += DeviceWatcher_EnumerationCompleted;
            deviceWatcher.Stopped += DeviceWatcher_Stopped;

            // Start the watcher.
            deviceWatcher.Start();
        }

        //Basic Scrollbar + Textbox code
        private void ServoBar1_Scroll(object sender, EventArgs e)
        {
            ValueBox1.Text = "" + ServoBar1.Value;
        }

        private void ServoBar2_Scroll(object sender, EventArgs e)
        {
            ValueBox2.Text = "" + ServoBar2.Value;
        }

        private void ServoBar3_Scroll(object sender, EventArgs e)
        {
            ValueBox3.Text = "" + ServoBar3.Value;
        }

        private void ServoBar4_Scroll(object sender, EventArgs e)
        {
            ValueBox4.Text = "" + ServoBar4.Value;
        }

        private void ServoBar5_Scroll(object sender, EventArgs e)
        {
            ValueBox5.Text = "" + ServoBar5.Value;
        }

        private void ServoBar6_Scroll(object sender, EventArgs e)
        {
            ValueBox6.Text = "" + ServoBar6.Value;
        }

        //We do mostly nothing with these callbacks. Service is a dummy that writes to without response
        private static void Characteristic_ValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
        {
        }

        private static void DeviceWatcher_Stopped(DeviceWatcher sender, object args)
        {
        }

        private static void DeviceWatcher_EnumerationCompleted(DeviceWatcher sender, object args)
        {
        }

        private static void DeviceWatcher_Removed(DeviceWatcher sender, DeviceInformationUpdate args)
        {
        }

        private static void DeviceWatcher_Updated(DeviceWatcher sender, DeviceInformationUpdate args)
        {
        }

        private static void DeviceWatcher_Added(DeviceWatcher sender, DeviceInformation args)
        {
            if (args.Name == "xArm")
            {
                xarm_info = args;
                detected = true;
            }
        }

        async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (detected)
            {
                ConnStatusBox.Text = "Attempting to connect...";
                //Perform Basic Connection
                xarm = await BluetoothLEDevice.FromIdAsync(xarm_info.Id);
                if (xarm != null)
                {
                    connected = true;

                    //While we're here, snag the characteristic info for the UART topic 
                    if (connected)
                    {
                        if (UART_Characteristic != null)
                            ConnStatusBox.Text = "xArm Connected!";
                        else
                        {
                            GattDeviceServicesResult result = await xarm.GetGattServicesAsync();
                            if (result.Status == GattCommunicationStatus.Success)
                            {
                                var services = result.Services;
                                foreach (var service in services)
                                {
                                    GattCharacteristicsResult cr = await service.GetCharacteristicsAsync();
                                    if (cr.Status == GattCommunicationStatus.Success)
                                    {
                                        var characteristics = cr.Characteristics;
                                        foreach (var characteristic in characteristics)
                                        {
                                            var handle = characteristic.AttributeHandle;
                                            if (handle == 24)
                                            {
                                                UART_Characteristic = characteristic;
                                                ConnStatusBox.Text = "xArm Connected!";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    ConnStatusBox.Text = "Error locating xArm!";
                    connected = false;
                }
            }
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            TxStatusBox.Text = "";

            //   byte[] barr = { 0x55, 0x55, 0x08, 0x03, 0x01, 0xE8, 0x03, 0x01, 0x00, 0x00 };
            if (connected)
            {
                List<Byte> message = CalculateServoMessage();
                byte[] barr = message.ToArray();
                var writer = new DataWriter();
                writer.WriteBytes(barr);

                for (int i = 0; i < barr.Length; i++)
                {
                    System.Diagnostics.Debug.WriteLine(barr[i]);
                }

                if (UART_Characteristic != null)
                {
                    GattCommunicationStatus gcs = await UART_Characteristic.WriteValueAsync(writer.DetachBuffer());
                    if (gcs == GattCommunicationStatus.Success)
                        TxStatusBox.Text = "Communication Succeeded!";
                }
            }
            else
                TxStatusBox.Text = "Please Connect First!";
        }

        List<Byte> CalculateServoMessage()
        {
            //Declare LSC Series Servo Header + Message Length + Time
            List<Byte> msg = new List<byte>() { 0x55, 0x55, 0x17, 0x03, 0x06, 0xDC, 0x05 };

            //PreFetch Bar Values
            int[] servoAngles = new int[6];
            servoAngles[0] = (ServoBar1.Value);
            servoAngles[1] = ServoBar2.Value;
            servoAngles[2] = ServoBar3.Value;
            servoAngles[3] = ServoBar4.Value;
            servoAngles[4] = ServoBar5.Value;
            servoAngles[5] = ServoBar6.Value;

            //Stuff Servo Message with Calcuated Servo Positions
            for(int i = 0; i < 6; i++ )
            {
                int temp = (servoAngles[i] + 120)*1000/240;

                byte[] servoArray = BitConverter.GetBytes(Convert.ToByte(i + 1));
                for (int j = 0; j < servoArray.Length/2; j++)
                {
                    msg.Add(servoArray[j*2]);
                }

                byte[] servoAngle = BitConverter.GetBytes(Convert.ToUInt16(temp));
                for(int k = 0;  k < servoAngle.Length; k++)
                    msg.Add(servoAngle[k]);
            }

            return msg;
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                ConnStatusBox.Text = "xArm Disconnected";
                connected = false;
            }

        }

        private void ValueBox1_TextChanged(object sender, EventArgs e)
        {        
        }

        private void ValueBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void ValueBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void ValueBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void ValueBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void ValueBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void ConnStatusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxStatusBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}