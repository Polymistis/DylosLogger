using System;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Net.Sockets;
using System.ComponentModel;
using System.Diagnostics;

namespace DylosDetector
{
	class DylosGraphiteConnection
	{
		private SerialPort particleSensorSerialPort = null;

		private MainForm mainForm = null;
		public string graphiteAddress;
		public int graphitePort;

		

		public DylosGraphiteConnection(MainForm form)
		{
			mainForm = form;
		}

		~DylosGraphiteConnection()
		{
			Disconnect();
		}

		private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
		{
			SerialPort sp = (SerialPort)sender;
			string indata = sp.ReadExisting();
			Debug.Print(indata);
			indata = indata.Trim();
			string[] inDataArray = indata.Split(',');

			DylosGraphiteConnection dylos = sender as DylosGraphiteConnection;

			if (inDataArray.Count<string>() > 1)
			{
				Console.WriteLine("---Data Received--- ");
				Console.WriteLine("Small Particle Count = " + inDataArray[0]);
				Console.WriteLine("Large Particle Count = " + inDataArray[1]);

				Socket sendingSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

				sendingSocket.Connect(graphiteAddress, graphitePort);

				TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
				int currentEpochTime = (int)t.TotalSeconds;
				mainForm.smallParticleMessage = string.Format("lwells.dylos.small_particle {0} {1}\n", inDataArray[0], currentEpochTime);
				mainForm.largeParticleMessage = string.Format("lwells.dylos.large_particle {0} {1}\n", inDataArray[1], currentEpochTime);

				Debug.Print(mainForm.smallParticleMessage);
				Debug.Print(mainForm.largeParticleMessage);

				mainForm.SetLogBoxText(mainForm.smallParticleMessage);
				mainForm.SetLogBoxText(mainForm.largeParticleMessage);

				sendingSocket.Send(Encoding.UTF8.GetBytes(mainForm.smallParticleMessage));
				sendingSocket.Send(Encoding.UTF8.GetBytes(mainForm.largeParticleMessage));

				sendingSocket.Close();

				SendHandshake();
			}
			else if (inDataArray.Count<string>() == 1)
			{
				mainForm.SetLogBoxText(inDataArray[0]);
			}
		}

		public bool Connect()
		{
			string[] serialPortNames = SerialPort.GetPortNames();
			if (serialPortNames.Count<string>() <= 0)
			{
				Debug.Print("Uh, there were no active serial ports... program aborting");
				return false;
			}

			string targetSerialPort = serialPortNames[0]; // Eh, just pick the first one

			particleSensorSerialPort = new SerialPort(targetSerialPort);
			Console.WriteLine("Opening Serial Port: " + targetSerialPort);
			mainForm.logBox.AppendText("Opening Serial Port: " + targetSerialPort + "\n");

			particleSensorSerialPort.BaudRate = 9600;
			particleSensorSerialPort.Parity = Parity.None;
			particleSensorSerialPort.StopBits = StopBits.One;
			particleSensorSerialPort.DataBits = 8;
			particleSensorSerialPort.Handshake = Handshake.None;
			particleSensorSerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

			particleSensorSerialPort.Open();
			SendHandshake();

			return true;
		}

		private void SendHandshake()
		{
			if (particleSensorSerialPort != null)
			{
				//byte[] handshakeByteArray = Encoding.UTF8.GetBytes("Y");
				particleSensorSerialPort.WriteLine("Y");
			}
		}


		public void Disconnect()
		{
			if (particleSensorSerialPort != null && particleSensorSerialPort.IsOpen)
			{
				particleSensorSerialPort.Close();
			}
		}
	}
}
