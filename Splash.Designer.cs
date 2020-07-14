namespace MissionPlanner
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.Log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.AutoSize = true;
            this.Log.BackColor = System.Drawing.Color.Transparent;
            this.Log.Location = new System.Drawing.Point(97, 315);
            this.Log.MinimumSize = new System.Drawing.Size(400, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(400, 12);
            this.Log.TabIndex = 0;
            this.Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Splash
            // 
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.启动界面1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.ControlBox = false;
            this.Controls.Add(this.Log);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 375);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRS";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Log;

        public void SetLog(string log)
        {
            Log.Text = log;
        }
    }
}