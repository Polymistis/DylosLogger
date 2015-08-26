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
    }
}
