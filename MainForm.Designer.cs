namespace DylosDetector
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.startLogging = new System.Windows.Forms.Button();
			this.stopLogging = new System.Windows.Forms.Button();
			this.loggingStatus = new System.Windows.Forms.Label();
			this.logBox = new System.Windows.Forms.TextBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startLogging
			// 
			this.startLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.startLogging.Enabled = false;
			this.startLogging.Location = new System.Drawing.Point(115, 270);
			this.startLogging.Name = "startLogging";
			this.startLogging.Size = new System.Drawing.Size(75, 23);
			this.startLogging.TabIndex = 1;
			this.startLogging.Text = "Start";
			this.startLogging.UseVisualStyleBackColor = true;
			this.startLogging.Click += new System.EventHandler(this.startLogging_Click);
			// 
			// stopLogging
			// 
			this.stopLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.stopLogging.Location = new System.Drawing.Point(196, 270);
			this.stopLogging.Name = "stopLogging";
			this.stopLogging.Size = new System.Drawing.Size(75, 23);
			this.stopLogging.TabIndex = 2;
			this.stopLogging.Text = "Stop";
			this.stopLogging.UseVisualStyleBackColor = true;
			this.stopLogging.Click += new System.EventHandler(this.stopLogging_Click);
			// 
			// loggingStatus
			// 
			this.loggingStatus.AutoSize = true;
			this.loggingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loggingStatus.ForeColor = System.Drawing.Color.Red;
			this.loggingStatus.Location = new System.Drawing.Point(12, 9);
			this.loggingStatus.Name = "loggingStatus";
			this.loggingStatus.Size = new System.Drawing.Size(128, 25);
			this.loggingStatus.TabIndex = 3;
			this.loggingStatus.Text = "Not Logging";
			// 
			// logBox
			// 
			this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.logBox.Location = new System.Drawing.Point(17, 89);
			this.logBox.Multiline = true;
			this.logBox.Name = "logBox";
			this.logBox.ReadOnly = true;
			this.logBox.Size = new System.Drawing.Size(254, 175);
			this.logBox.TabIndex = 5;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(94, 37);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(177, 20);
			this.textBoxAddress.TabIndex = 6;
			this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(94, 63);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(177, 20);
			this.textBoxPort.TabIndex = 7;
			this.textBoxPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Port";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 305);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.logBox);
			this.Controls.Add(this.loggingStatus);
			this.Controls.Add(this.stopLogging);
			this.Controls.Add(this.startLogging);
			this.Name = "MainForm";
			this.Text = "Dylos Graphite Logger";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startLogging;
        private System.Windows.Forms.Button stopLogging;
		private System.Windows.Forms.Label loggingStatus;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox logBox;
    }
}