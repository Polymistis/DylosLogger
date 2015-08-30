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
		// This delegate enables asynchronous calls for setting
		// the text property on a TextBox control.
		delegate void SetTextCallback(string text);

		public string smallParticleMessage;
		public string largeParticleMessage;

		private DylosGraphiteConnection dylos = null;

		private bool hasAddress = false;
		private bool hasPort = false;
		
		public MainForm()
		{
			InitializeComponent();
			dylos = new DylosGraphiteConnection(this);
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


		public void SetLogBoxText(string text)
		{
			if (logBox.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetLogBoxText);
				this.Invoke(d, new object[] {text});
			}
			else
			{
				logBox.AppendText(text);
			}
		}
	}
}
