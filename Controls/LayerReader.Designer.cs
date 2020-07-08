using System.Windows.Forms;
using System;

namespace MissionPlanner.Controls
{
    partial class LayerReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayerReader));
            this.FileOpen = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.RightLabel = new System.Windows.Forms.Label();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.LayerPrevView = new System.Windows.Forms.PictureBox();
            this.Longitude = new System.Windows.Forms.TextBox();
            this.Latitude = new System.Windows.Forms.TextBox();
            this.Altitude = new System.Windows.Forms.TextBox();
            this.Scale = new System.Windows.Forms.TextBox();
            this.LongitudeLabel = new System.Windows.Forms.Label();
            this.OriginGroup = new System.Windows.Forms.GroupBox();
            this.AltitudeLabel = new System.Windows.Forms.Label();
            this.LatitudeLabel = new System.Windows.Forms.Label();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.Transparent = new DotSpatial.Symbology.Forms.ColorButton();
            this.TransparentLabel = new System.Windows.Forms.Label();
            this.MapGroup = new System.Windows.Forms.GroupBox();
            this.ViewGroup = new System.Windows.Forms.GroupBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LayerPrevView)).BeginInit();
            this.OriginGroup.SuspendLayout();
            this.MapGroup.SuspendLayout();
            this.ViewGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileOpen
            // 
            resources.ApplyResources(this.FileOpen, "FileOpen");
            this.FileOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.UseVisualStyleBackColor = true;
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FilePath
            // 
            resources.ApplyResources(this.FilePath, "FilePath");
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.TabStop = false;
            // 
            // TopLabel
            // 
            resources.ApplyResources(this.TopLabel, "TopLabel");
            this.TopLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TopLabel.Name = "TopLabel";
            // 
            // RightLabel
            // 
            resources.ApplyResources(this.RightLabel, "RightLabel");
            this.RightLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RightLabel.Name = "RightLabel";
            // 
            // BottomLabel
            // 
            resources.ApplyResources(this.BottomLabel, "BottomLabel");
            this.BottomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomLabel.Name = "BottomLabel";
            // 
            // LeftLabel
            // 
            resources.ApplyResources(this.LeftLabel, "LeftLabel");
            this.LeftLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LeftLabel.Name = "LeftLabel";
            // 
            // LayerPrevView
            // 
            resources.ApplyResources(this.LayerPrevView, "LayerPrevView");
            this.LayerPrevView.BackColor = System.Drawing.Color.Transparent;
            this.LayerPrevView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayerPrevView.Name = "LayerPrevView";
            this.LayerPrevView.TabStop = false;
            // 
            // Longitude
            // 
            resources.ApplyResources(this.Longitude, "Longitude");
            this.Longitude.Name = "Longitude";
            // 
            // Latitude
            // 
            resources.ApplyResources(this.Latitude, "Latitude");
            this.Latitude.Name = "Latitude";
            // 
            // Altitude
            // 
            resources.ApplyResources(this.Altitude, "Altitude");
            this.Altitude.Name = "Altitude";
            // 
            // Scale
            // 
            resources.ApplyResources(this.Scale, "Scale");
            this.Scale.Name = "Scale";
            // 
            // LongitudeLabel
            // 
            resources.ApplyResources(this.LongitudeLabel, "LongitudeLabel");
            this.LongitudeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LongitudeLabel.Name = "LongitudeLabel";
            // 
            // OriginGroup
            // 
            resources.ApplyResources(this.OriginGroup, "OriginGroup");
            this.OriginGroup.Controls.Add(this.AltitudeLabel);
            this.OriginGroup.Controls.Add(this.LatitudeLabel);
            this.OriginGroup.Controls.Add(this.Longitude);
            this.OriginGroup.Controls.Add(this.LongitudeLabel);
            this.OriginGroup.Controls.Add(this.Latitude);
            this.OriginGroup.Controls.Add(this.Altitude);
            this.OriginGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginGroup.Name = "OriginGroup";
            this.OriginGroup.TabStop = false;
            // 
            // AltitudeLabel
            // 
            resources.ApplyResources(this.AltitudeLabel, "AltitudeLabel");
            this.AltitudeLabel.Name = "AltitudeLabel";
            // 
            // LatitudeLabel
            // 
            resources.ApplyResources(this.LatitudeLabel, "LatitudeLabel");
            this.LatitudeLabel.Name = "LatitudeLabel";
            // 
            // ScaleLabel
            // 
            resources.ApplyResources(this.ScaleLabel, "ScaleLabel");
            this.ScaleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ScaleLabel.Name = "ScaleLabel";
            // 
            // Transparent
            // 
            resources.ApplyResources(this.Transparent, "Transparent");
            this.Transparent.BevelRadius = 0;
            this.Transparent.Color = System.Drawing.Color.Black;
            this.Transparent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Transparent.LaunchDialogOnClick = true;
            this.Transparent.Name = "Transparent";
            this.Transparent.RoundingRadius = 0;
            this.Transparent.ColorChanged += new System.EventHandler(this.Transparent_ColorChanged);
            // 
            // TransparentLabel
            // 
            resources.ApplyResources(this.TransparentLabel, "TransparentLabel");
            this.TransparentLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TransparentLabel.Name = "TransparentLabel";
            // 
            // MapGroup
            // 
            resources.ApplyResources(this.MapGroup, "MapGroup");
            this.MapGroup.Controls.Add(this.Scale);
            this.MapGroup.Controls.Add(this.ScaleLabel);
            this.MapGroup.Controls.Add(this.label1);
            this.MapGroup.Name = "MapGroup";
            this.MapGroup.TabStop = false;
            // 
            // ViewGroup
            // 
            resources.ApplyResources(this.ViewGroup, "ViewGroup");
            this.ViewGroup.Controls.Add(this.TransparentLabel);
            this.ViewGroup.Controls.Add(this.Transparent);
            this.ViewGroup.Name = "ViewGroup";
            this.ViewGroup.TabStop = false;
            // 
            // Accept
            // 
            resources.ApplyResources(this.Accept, "Accept");
            this.Accept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Accept.Name = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // LayerReader
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.ViewGroup);
            this.Controls.Add(this.MapGroup);
            this.Controls.Add(this.OriginGroup);
            this.Controls.Add(this.LayerPrevView);
            this.Controls.Add(this.LeftLabel);
            this.Controls.Add(this.BottomLabel);
            this.Controls.Add(this.RightLabel);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FileOpen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LayerReader";
            ((System.ComponentModel.ISupportInitialize)(this.LayerPrevView)).EndInit();
            this.OriginGroup.ResumeLayout(false);
            this.OriginGroup.PerformLayout();
            this.MapGroup.ResumeLayout(false);
            this.MapGroup.PerformLayout();
            this.ViewGroup.ResumeLayout(false);
            this.ViewGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileOpen;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label RightLabel;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.PictureBox LayerPrevView;
        private TextBox Longitude;
        private TextBox Latitude;
        private TextBox Altitude;
        private TextBox Scale;
        private Label LongitudeLabel;
        private GroupBox OriginGroup;
        private Label AltitudeLabel;
        private Label LatitudeLabel;
        private Label ScaleLabel;
        private DotSpatial.Symbology.Forms.ColorButton Transparent;
        private Label TransparentLabel;
        private GroupBox MapGroup;
        private GroupBox ViewGroup;
        private Button Accept;
        private Button Cancel;
        private Label label1;
    }
}