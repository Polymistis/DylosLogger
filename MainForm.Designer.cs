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
            this.SuspendLayout();
            // 
            // startLogging
            // 
            this.startLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.logBox.Location = new System.Drawing.Point(17, 37);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(254, 227);
            this.logBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 305);
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
        private System.Windows.Forms.TextBox logBox;
    }
}