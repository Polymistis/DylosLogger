using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylosDetector
{
	public partial class MainForm : Form
	{
		private DylosGraphiteConnection dylos = null;

		private bool hasAddress = false;
		private bool hasPort = false;
		
		public MainForm()
		{
			InitializeComponent();
			dylos = new DylosGraphiteConnection(logBox);
		}

		private void startLogging_Click(object sender, EventArgs e)
		{
			bool success = dylos.Connect();
			if (success)
			{
				loggingStatus.ForeColor = Color.Green;
				loggingStatus.Text = "Logging";
			}
		}

		private void stopLogging_Click(object sender, EventArgs e)
		{
			dylos.Disconnect();

			loggingStatus.ForeColor = Color.Red;
			loggingStatus.Text = "Not Logging";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBoxAddress.Text != null && textBoxAddress.Text != "")
			{
				hasAddress = true;
				dylos.graphiteAddress = textBoxAddress.Text;
				testStartButton();
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if (textBoxPort.Text != null && textBoxPort.Text != "")
			{
				if (Int32.TryParse(textBoxPort.Text, out dylos.graphitePort))
				{
					hasPort = true;
					testStartButton();
				}
			}
		}

		private void testStartButton()
		{
			startLogging.Enabled = hasAddress && hasPort;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		
	}
}
