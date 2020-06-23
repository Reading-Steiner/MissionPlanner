using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews
{
    partial class FlightPlanner
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

            if (currentMarker != null) currentMarker.Dispose();
            if (drawnpolygon != null) drawnpolygon.Dispose();
            if (kmlpolygonsoverlay != null) kmlpolygonsoverlay.Dispose();
            if (layerpolygonsoverlay != null) layerpolygonsoverlay.Dispose();
            if (wppolygon != null) wppolygon.Dispose();
            if (top != null) top.Dispose();
            if (geofencepolygon != null) geofencepolygon.Dispose();
            if (geofenceoverlay != null) geofenceoverlay.Dispose();
            if (drawnpolygonsoverlay != null) drawnpolygonsoverlay.Dispose();
            if (center != null) center.Dispose(); 

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CHK_verifyheight = new System.Windows.Forms.CheckBox();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_writewpfast = new MissionPlanner.Controls.MyButton();
            this.BUT_write = new MissionPlanner.Controls.MyButton();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.lbl_status = new System.Windows.Forms.Label();
            this.panelWaypoints = new System.Windows.Forms.Panel();
            this.but_mincommands = new MissionPlanner.Controls.MyButton();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.BUT_Add = new MissionPlanner.Controls.MyButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelAction = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.lnk_kml = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_wpfile = new System.Windows.Forms.Label();
            this.BUT_loadwpfile = new MissionPlanner.Controls.MyButton();
            this.BUT_saveWPFile = new MissionPlanner.Controls.MyButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelMap = new System.Windows.Forms.Panel();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.trackBar1 = new MissionPlanner.Controls.MyTrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.cmb_missiontype = new System.Windows.Forms.ComboBox();
            this.MainMap = new MissionPlanner.Controls.myGMAP();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.tiffReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.planningWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSHPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();

            this.panelBASE = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripPoly = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripZoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomToVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Commands = new MissionPlanner.Controls.MyDataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frame = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.coordZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordEasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordNorthing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MGRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelWaypoints.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStripMain.SuspendLayout();
            this.panelBASE.SuspendLayout();
            this.contextMenuStripZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.SuspendLayout();
            // 
            // CHK_verifyheight
            // 
            resources.ApplyResources(this.CHK_verifyheight, "CHK_verifyheight");
            this.CHK_verifyheight.Name = "CHK_verifyheight";
            this.toolTip1.SetToolTip(this.CHK_verifyheight, resources.GetString("CHK_verifyheight.ToolTip"));
            this.CHK_verifyheight.UseVisualStyleBackColor = true;
            // 
            // TXT_WPRad
            // 
            resources.ApplyResources(this.TXT_WPRad, "TXT_WPRad");
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.toolTip1.SetToolTip(this.TXT_WPRad, resources.GetString("TXT_WPRad.ToolTip"));
            this.TXT_WPRad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_WPRad_KeyPress);
            this.TXT_WPRad.Leave += new System.EventHandler(this.TXT_WPRad_Leave);
            // 
            // TXT_DefaultAlt
            // 
            resources.ApplyResources(this.TXT_DefaultAlt, "TXT_DefaultAlt");
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            this.toolTip1.SetToolTip(this.TXT_DefaultAlt, resources.GetString("TXT_DefaultAlt.ToolTip"));
            this.TXT_DefaultAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DefaultAlt_KeyPress);
            this.TXT_DefaultAlt.Leave += new System.EventHandler(this.TXT_DefaultAlt_Leave);
            // 
            // LBL_WPRad
            // 
            resources.ApplyResources(this.LBL_WPRad, "LBL_WPRad");
            this.LBL_WPRad.Name = "LBL_WPRad";
            this.toolTip1.SetToolTip(this.LBL_WPRad, resources.GetString("LBL_WPRad.ToolTip"));
            // 
            // LBL_defalutalt
            // 
            resources.ApplyResources(this.LBL_defalutalt, "LBL_defalutalt");
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            this.toolTip1.SetToolTip(this.LBL_defalutalt, resources.GetString("LBL_defalutalt.ToolTip"));
            // 
            // TXT_loiterrad
            // 
            resources.ApplyResources(this.TXT_loiterrad, "TXT_loiterrad");
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            this.toolTip1.SetToolTip(this.TXT_loiterrad, resources.GetString("TXT_loiterrad.ToolTip"));
            this.TXT_loiterrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_loiterrad_KeyPress);
            this.TXT_loiterrad.Leave += new System.EventHandler(this.TXT_loiterrad_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.but_writewpfast);
            this.panel5.Controls.Add(this.BUT_write);
            this.panel5.Controls.Add(this.BUT_read);
            this.panel5.Name = "panel5";
            this.toolTip1.SetToolTip(this.panel5, resources.GetString("panel5.ToolTip"));
            // 
            // but_writewpfast
            // 
            resources.ApplyResources(this.but_writewpfast, "but_writewpfast");
            this.but_writewpfast.Name = "but_writewpfast";
            this.toolTip1.SetToolTip(this.but_writewpfast, resources.GetString("but_writewpfast.ToolTip"));
            this.but_writewpfast.UseVisualStyleBackColor = true;
            this.but_writewpfast.Click += new System.EventHandler(this.but_writewpfast_Click);
            // 
            // BUT_write
            // 
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.Name = "BUT_write";
            this.toolTip1.SetToolTip(this.BUT_write, resources.GetString("BUT_write.ToolTip"));
            this.BUT_write.UseVisualStyleBackColor = true;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // BUT_read
            // 
            resources.ApplyResources(this.BUT_read, "BUT_read");
            this.BUT_read.Name = "BUT_read";
            this.toolTip1.SetToolTip(this.BUT_read, resources.GetString("BUT_read.ToolTip"));
            this.BUT_read.UseVisualStyleBackColor = true;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.TXT_homealt);
            this.panel1.Controls.Add(this.TXT_homelng);
            this.panel1.Controls.Add(this.TXT_homelat);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.TabStop = true;
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            this.label4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label4_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            this.toolTip1.SetToolTip(this.Label1, resources.GetString("Label1.ToolTip"));
            // 
            // TXT_homealt
            // 
            resources.ApplyResources(this.TXT_homealt, "TXT_homealt");
            this.TXT_homealt.Name = "TXT_homealt";
            this.toolTip1.SetToolTip(this.TXT_homealt, resources.GetString("TXT_homealt.ToolTip"));
            this.TXT_homealt.TextChanged += new System.EventHandler(this.TXT_homealt_TextChanged);
            // 
            // TXT_homelng
            // 
            resources.ApplyResources(this.TXT_homelng, "TXT_homelng");
            this.TXT_homelng.Name = "TXT_homelng";
            this.toolTip1.SetToolTip(this.TXT_homelng, resources.GetString("TXT_homelng.ToolTip"));
            this.TXT_homelng.TextChanged += new System.EventHandler(this.TXT_homelng_TextChanged);
            // 
            // TXT_homelat
            // 
            resources.ApplyResources(this.TXT_homelat, "TXT_homelat");
            this.TXT_homelat.Name = "TXT_homelat";
            this.toolTip1.SetToolTip(this.TXT_homelat, resources.GetString("TXT_homelat.ToolTip"));
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            this.TXT_homelat.Enter += new System.EventHandler(this.TXT_homelat_Enter);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // coords1
            // 
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            this.coords1.Name = "coords1";
            this.toolTip1.SetToolTip(this.coords1, resources.GetString("coords1.ToolTip"));
            this.coords1.Vertical = true;
            this.coords1.SystemChanged += new System.EventHandler(this.coords1_SystemChanged);
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            this.toolTip1.SetToolTip(this.lbl_status, resources.GetString("lbl_status.ToolTip"));
            // 
            // panelWaypoints
            // 
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.Controls.Add(this.but_mincommands);
            this.panelWaypoints.Controls.Add(this.CMB_altmode);
            this.panelWaypoints.Controls.Add(this.CHK_splinedefault);
            this.panelWaypoints.Controls.Add(this.label17);
            this.panelWaypoints.Controls.Add(this.TXT_altwarn);
            this.panelWaypoints.Controls.Add(this.LBL_WPRad);
            this.panelWaypoints.Controls.Add(this.label5);
            this.panelWaypoints.Controls.Add(this.TXT_loiterrad);
            this.panelWaypoints.Controls.Add(this.LBL_defalutalt);
            this.panelWaypoints.Controls.Add(this.Commands);
            this.panelWaypoints.Controls.Add(this.TXT_DefaultAlt);
            this.panelWaypoints.Controls.Add(this.CHK_verifyheight);
            this.panelWaypoints.Controls.Add(this.TXT_WPRad);
            this.panelWaypoints.Controls.Add(this.BUT_Add);
            this.panelWaypoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWaypoints.Name = "panelWaypoints";
            this.toolTip1.SetToolTip(this.panelWaypoints, resources.GetString("panelWaypoints.ToolTip"));
            // 
            // but_mincommands
            // 
            resources.ApplyResources(this.but_mincommands, "but_mincommands");
            this.but_mincommands.Name = "but_mincommands";
            this.toolTip1.SetToolTip(this.but_mincommands, resources.GetString("but_mincommands.ToolTip"));
            this.but_mincommands.UseVisualStyleBackColor = true;
            this.but_mincommands.Click += new System.EventHandler(this.but_mincommands_Click);
            // 
            // CMB_altmode
            // 
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.FormattingEnabled = true;
            this.CMB_altmode.Name = "CMB_altmode";
            this.toolTip1.SetToolTip(this.CMB_altmode, resources.GetString("CMB_altmode.ToolTip"));
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.toolTip1.SetToolTip(this.CHK_splinedefault, resources.GetString("CHK_splinedefault.ToolTip"));
            this.CHK_splinedefault.UseVisualStyleBackColor = true;
            this.CHK_splinedefault.CheckedChanged += new System.EventHandler(this.CHK_splinedefault_CheckedChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            this.toolTip1.SetToolTip(this.label17, resources.GetString("label17.ToolTip"));
            // 
            // TXT_altwarn
            // 
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.Name = "TXT_altwarn";
            this.toolTip1.SetToolTip(this.TXT_altwarn, resources.GetString("TXT_altwarn.ToolTip"));
            // 
            // BUT_Add
            // 
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            this.toolTip1.SetToolTip(this.splitter1, resources.GetString("splitter1.ToolTip"));
            // 
            // panelAction
            // 
            resources.ApplyResources(this.panelAction, "panelAction");
            this.panelAction.Controls.Add(this.flowLayoutPanel1);
            this.panelAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAction.Name = "panelAction";
            this.toolTip1.SetToolTip(this.panelAction, resources.GetString("panelAction.ToolTip"));
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.coords1);
            this.panel4.Name = "panel4";
            this.toolTip1.SetToolTip(this.panel4, resources.GetString("panel4.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.chk_grid);
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Controls.Add(this.comboBoxMapType);
            this.panel3.Controls.Add(this.lnk_kml);
            this.panel3.Name = "panel3";
            this.toolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
            // 
            // chk_grid
            // 
            resources.ApplyResources(this.chk_grid, "chk_grid");
            this.chk_grid.Name = "chk_grid";
            this.toolTip1.SetToolTip(this.chk_grid, resources.GetString("chk_grid.ToolTip"));
            this.chk_grid.UseVisualStyleBackColor = true;
            this.chk_grid.CheckedChanged += new System.EventHandler(this.chk_grid_CheckedChanged);
            // 
            // comboBoxMapType
            // 
            resources.ApplyResources(this.comboBoxMapType, "comboBoxMapType");
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.toolTip1.SetToolTip(this.comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            // 
            // lnk_kml
            // 
            resources.ApplyResources(this.lnk_kml, "lnk_kml");
            this.lnk_kml.Name = "lnk_kml";
            this.lnk_kml.TabStop = true;
            this.toolTip1.SetToolTip(this.lnk_kml, resources.GetString("lnk_kml.ToolTip"));
            this.lnk_kml.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_kml_LinkClicked);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.lbl_wpfile);
            this.panel2.Controls.Add(this.BUT_loadwpfile);
            this.panel2.Controls.Add(this.BUT_saveWPFile);
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // lbl_wpfile
            // 
            resources.ApplyResources(this.lbl_wpfile, "lbl_wpfile");
            this.lbl_wpfile.Name = "lbl_wpfile";
            this.toolTip1.SetToolTip(this.lbl_wpfile, resources.GetString("lbl_wpfile.ToolTip"));
            // 
            // BUT_loadwpfile
            // 
            resources.ApplyResources(this.BUT_loadwpfile, "BUT_loadwpfile");
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.toolTip1.SetToolTip(this.BUT_loadwpfile, resources.GetString("BUT_loadwpfile.ToolTip"));
            this.BUT_loadwpfile.UseVisualStyleBackColor = true;
            this.BUT_loadwpfile.Click += new System.EventHandler(this.BUT_loadwpfile_Click);
            // 
            // BUT_saveWPFile
            // 
            resources.ApplyResources(this.BUT_saveWPFile, "BUT_saveWPFile");
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.toolTip1.SetToolTip(this.BUT_saveWPFile, resources.GetString("BUT_saveWPFile.ToolTip"));
            this.BUT_saveWPFile.UseVisualStyleBackColor = true;
            this.BUT_saveWPFile.Click += new System.EventHandler(this.BUT_saveWPFile_Click);
            // 
            // splitter2
            // 
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            this.toolTip1.SetToolTip(this.splitter2, resources.GetString("splitter2.ToolTip"));
            // 
            // panelMap
            // 
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.Controls.Add(this.lbl_homedist);
            this.panelMap.Controls.Add(this.lbl_prevdist);
            this.panelMap.Controls.Add(this.trackBar1);
            this.panelMap.Controls.Add(this.label11);
            this.panelMap.Controls.Add(this.lbl_distance);
            this.panelMap.Controls.Add(this.cmb_missiontype);
            this.panelMap.Controls.Add(this.MainMap);
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            this.toolTip1.SetToolTip(this.panelMap, resources.GetString("panelMap.ToolTip"));
            this.panelMap.Resize += new System.EventHandler(this.panelMap_Resize);
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(this.lbl_homedist, "lbl_homedist");
            this.lbl_homedist.Name = "lbl_homedist";
            this.toolTip1.SetToolTip(this.lbl_homedist, resources.GetString("lbl_homedist.ToolTip"));
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(this.lbl_prevdist, "lbl_prevdist");
            this.lbl_prevdist.Name = "lbl_prevdist";
            this.toolTip1.SetToolTip(this.lbl_prevdist, resources.GetString("lbl_prevdist.ToolTip"));
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 0.005F;
            this.trackBar1.Maximum = 24F;
            this.trackBar1.Minimum = 1F;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 0.001F;
            this.trackBar1.TickFrequency = 1F;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.toolTip1.SetToolTip(this.trackBar1, resources.GetString("trackBar1.ToolTip"));
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.Name = "lbl_distance";
            this.toolTip1.SetToolTip(this.lbl_distance, resources.GetString("lbl_distance.ToolTip"));
            // 
            // cmb_missiontype
            // 
            resources.ApplyResources(this.cmb_missiontype, "cmb_missiontype");
            this.cmb_missiontype.FormattingEnabled = true;
            this.cmb_missiontype.Items.AddRange(new object[] {
            resources.GetString("cmb_missiontype.Items"),
            resources.GetString("cmb_missiontype.Items1"),
            resources.GetString("cmb_missiontype.Items2")});
            this.cmb_missiontype.Name = "cmb_missiontype";
            this.toolTip1.SetToolTip(this.cmb_missiontype, resources.GetString("cmb_missiontype.ToolTip"));
            this.cmb_missiontype.SelectedIndexChanged += new System.EventHandler(this.Cmb_missiontype_SelectedIndexChanged);
            // 
            // MainMap
            // 
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.ContextMenuStrip = this.contextMenuStripMain;
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Gray;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.HoldInvalidation = false;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 19;
            this.MainMap.MinZoom = 0;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = false;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.toolTip1.SetToolTip(this.MainMap, resources.GetString("MainMap.ToolTip"));
            this.MainMap.Zoom = 0D;
            this.MainMap.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMap_Paint);
            // 
            // contextMenuStripMain
            // 
            resources.ApplyResources(this.contextMenuStripMain, "contextMenuStripMain");
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setHomeHereToolStripMenuItem,
            this.toolStripSeparator1,
            this.polygonToolStripMenuItem,
            this.planningWPToolStripMenuItem,
            this.tiffReadToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.ShowImageMargin = false;
            this.toolTip1.SetToolTip(this.contextMenuStripMain, resources.GetString("contextMenuStripMain.ToolTip"));
            this.contextMenuStripMain.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStripMain_Closed);
            this.contextMenuStripMain.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMain_Opening);

            // 
            // setHomeHereToolStripMenuItem
            // 
            resources.ApplyResources(this.tiffReadToolStripMenuItem, "tiffReadToolStripMenuItem");
            this.tiffReadToolStripMenuItem.Name = "tiffReadToolStripMenuItem";
            this.tiffReadToolStripMenuItem.Click += new System.EventHandler(this.TiffOverlayToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            this.setHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // polygonToolStripMenuItem
            // 
            resources.ApplyResources(this.polygonToolStripMenuItem, "polygonToolStripMenuItem");
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem,
            this.clearPolygonToolStripMenuItem,
            this.toolStripSeparator2,
            this.savePolygonToolStripMenuItem,
            this.loadPolygonToolStripMenuItem});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            // 
            // addPolygonPointToolStripMenuItem
            // 
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem, "addPolygonPointToolStripMenuItem");
            this.addPolygonPointToolStripMenuItem.Name = "addPolygonPointToolStripMenuItem";
            this.addPolygonPointToolStripMenuItem.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem
            // 
            resources.ApplyResources(this.clearPolygonToolStripMenuItem, "clearPolygonToolStripMenuItem");
            this.clearPolygonToolStripMenuItem.Name = "clearPolygonToolStripMenuItem";
            this.clearPolygonToolStripMenuItem.Click += new System.EventHandler(this.clearPolygonToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // savePolygonToolStripMenuItem
            // 
            resources.ApplyResources(this.savePolygonToolStripMenuItem, "savePolygonToolStripMenuItem");
            this.savePolygonToolStripMenuItem.Name = "savePolygonToolStripMenuItem";
            this.savePolygonToolStripMenuItem.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem
            // 
            resources.ApplyResources(this.loadPolygonToolStripMenuItem, "loadPolygonToolStripMenuItem");
            this.loadPolygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromPolygonToolStripMenuItem,
            this.fromSHPToolStripMenuItem});
            this.loadPolygonToolStripMenuItem.Name = "loadPolygonToolStripMenuItem";
            // 
            // fromPolygonToolStripMenuItem
            // 
            resources.ApplyResources(this.fromPolygonToolStripMenuItem, "fromPolygonToolStripMenuItem");
            this.fromPolygonToolStripMenuItem.Name = "fromPolygonToolStripMenuItem";
            this.fromPolygonToolStripMenuItem.Click += new System.EventHandler(this.fromPolygonToolStripMenuItem_Click);
            // 
            // fromSHPToolStripMenuItem
            // 
            resources.ApplyResources(this.fromSHPToolStripMenuItem, "fromSHPToolStripMenuItem");
            this.fromSHPToolStripMenuItem.Name = "fromSHPToolStripMenuItem";
            this.fromSHPToolStripMenuItem.Click += new System.EventHandler(this.fromSHPToolStripMenuItem_Click);
            // 
            // autoWPToolStripMenuItem
            // 
            resources.ApplyResources(this.planningWPToolStripMenuItem, "planningWPToolStripMenuItem");
            this.planningWPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surveyGridToolStripMenuItem,
            this.clearMissionToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveWPToolStripMenuItem,
            this.loadWPToolStripMenuItem});
            this.planningWPToolStripMenuItem.Name = "planningWPToolStripMenuItem";
            // 
            // surveyGridToolStripMenuItem
            // 
            resources.ApplyResources(this.surveyGridToolStripMenuItem, "surveyGridToolStripMenuItem");
            this.surveyGridToolStripMenuItem.Name = "surveyGridToolStripMenuItem";
            this.surveyGridToolStripMenuItem.Click += new System.EventHandler(this.surveyGridToolStripMenuItem_Click);
            // 
            // clearMissionToolStripMenuItem
            // 
            resources.ApplyResources(this.clearMissionToolStripMenuItem, "clearMissionToolStripMenuItem");
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // saveWPFileToolStripMenuItem
            // 
            resources.ApplyResources(this.saveWPToolStripMenuItem, "saveWPToolStripMenuItem");
            this.saveWPToolStripMenuItem.Name = "saveWPToolStripMenuItem";
            this.saveWPToolStripMenuItem.Click += new System.EventHandler(this.saveWPFileToolStripMenuItem_Click);
            // 
            // fileLoadSaveToolStripMenuItem
            // 
            resources.ApplyResources(this.loadWPToolStripMenuItem, "loadWPToolStripMenuItem");
            this.loadWPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWPFileToolStripMenuItem,
            this.loadAndAppendToolStripMenuItem,
            this.loadKMLFileToolStripMenuItem,
            this.loadSHPFileToolStripMenuItem});
            this.loadWPToolStripMenuItem.Name = "loadWPToolStripMenuItem";
            // 
            // loadWPFileToolStripMenuItem
            // 
            resources.ApplyResources(this.loadWPFileToolStripMenuItem, "loadWPFileToolStripMenuItem");
            this.loadWPFileToolStripMenuItem.Name = "loadWPFileToolStripMenuItem";
            this.loadWPFileToolStripMenuItem.Click += new System.EventHandler(this.loadWPFileToolStripMenuItem_Click);
            // 
            // loadAndAppendToolStripMenuItem
            // 
            resources.ApplyResources(this.loadAndAppendToolStripMenuItem, "loadAndAppendToolStripMenuItem");
            this.loadAndAppendToolStripMenuItem.Name = "loadAndAppendToolStripMenuItem";
            this.loadAndAppendToolStripMenuItem.Click += new System.EventHandler(this.loadAndAppendToolStripMenuItem_Click);
            // 
            // loadKMLFileToolStripMenuItem
            // 
            resources.ApplyResources(this.loadKMLFileToolStripMenuItem, "loadKMLFileToolStripMenuItem");
            this.loadKMLFileToolStripMenuItem.Name = "loadKMLFileToolStripMenuItem";
            this.loadKMLFileToolStripMenuItem.Click += new System.EventHandler(this.loadKMLFileToolStripMenuItem_Click);
            // 
            // loadSHPFileToolStripMenuItem
            // 
            resources.ApplyResources(this.loadSHPFileToolStripMenuItem, "loadSHPFileToolStripMenuItem");
            this.loadSHPFileToolStripMenuItem.Name = "loadSHPFileToolStripMenuItem";
            this.loadSHPFileToolStripMenuItem.Click += new System.EventHandler(this.loadSHPFileToolStripMenuItem_Click);
            // 
            // panelBASE
            // 
            resources.ApplyResources(this.panelBASE, "panelBASE");
            this.panelBASE.Controls.Add(this.splitter2);
            this.panelBASE.Controls.Add(this.splitter1);
            this.panelBASE.Controls.Add(this.panelMap);
            this.panelBASE.Controls.Add(this.panelWaypoints);
            this.panelBASE.Controls.Add(this.panelAction);
            this.panelBASE.Controls.Add(this.label6);
            this.panelBASE.Name = "panelBASE";
            this.toolTip1.SetToolTip(this.panelBASE, resources.GetString("panelBASE.ToolTip"));
            // 
            // contextMenuStripPoly
            // 
            resources.ApplyResources(this.contextMenuStripPoly, "contextMenuStripPoly");
            this.contextMenuStripPoly.Name = "contextMenuStripPoly";
            this.contextMenuStripPoly.ShowImageMargin = false;
            this.toolTip1.SetToolTip(this.contextMenuStripPoly, resources.GetString("contextMenuStripPoly.ToolTip"));
            this.contextMenuStripPoly.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripPoly_Opening);
            // 
            // contextMenuStripZoom
            // 
            resources.ApplyResources(this.contextMenuStripZoom, "contextMenuStripZoom");
            this.contextMenuStripZoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToVehicleToolStripMenuItem,
            this.zoomToMissionToolStripMenuItem,
            this.zoomToHomeToolStripMenuItem});
            this.contextMenuStripZoom.Name = "contextMenuStripZoom";
            this.toolTip1.SetToolTip(this.contextMenuStripZoom, resources.GetString("contextMenuStripZoom.ToolTip"));
            // 
            // zoomToVehicleToolStripMenuItem
            // 
            resources.ApplyResources(this.zoomToVehicleToolStripMenuItem, "zoomToVehicleToolStripMenuItem");
            this.zoomToVehicleToolStripMenuItem.Name = "zoomToVehicleToolStripMenuItem";
            this.zoomToVehicleToolStripMenuItem.Click += new System.EventHandler(this.zoomToVehicleToolStripMenuItem_Click);
            // 
            // zoomToMissionToolStripMenuItem
            // 
            resources.ApplyResources(this.zoomToMissionToolStripMenuItem, "zoomToMissionToolStripMenuItem");
            this.zoomToMissionToolStripMenuItem.Name = "zoomToMissionToolStripMenuItem";
            this.zoomToMissionToolStripMenuItem.Click += new System.EventHandler(this.zoomToMissionToolStripMenuItem_Click);
            // 
            // zoomToHomeToolStripMenuItem
            // 
            resources.ApplyResources(this.zoomToHomeToolStripMenuItem, "zoomToHomeToolStripMenuItem");
            this.zoomToHomeToolStripMenuItem.Name = "zoomToHomeToolStripMenuItem";
            this.zoomToHomeToolStripMenuItem.Click += new System.EventHandler(this.zoomToHomeToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // testToolStripMenuItem
            // 
            resources.ApplyResources(this.testToolStripMenuItem, "testToolStripMenuItem");
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            // 
            // Commands
            // 
            resources.ApplyResources(this.Commands, "Commands");
            this.Commands.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.Frame,
            this.coordZone,
            this.coordEasting,
            this.coordNorthing,
            this.MGRS,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Angle,
            this.Dist,
            this.AZ,
            this.TagData});
            this.Commands.Name = "Commands";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.toolTip1.SetToolTip(this.Commands, resources.GetString("Commands.ToolTip"));
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            this.Commands.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellEndEdit);
            this.Commands.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Commands_DataError);
            this.Commands.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Commands_DefaultValuesNeeded);
            this.Commands.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Commands_EditingControlShowing);
            this.Commands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_RowEnter);
            this.Commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Commands_RowsAdded);
            this.Commands.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Commands_RowsRemoved);
            this.Commands.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Commands_RowValidating);
            // 
            // Command
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle4;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.Command, "Command");
            this.Command.Name = "Command";
            // 
            // Param1
            // 
            resources.ApplyResources(this.Param1, "Param1");
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            resources.ApplyResources(this.Param2, "Param2");
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            resources.ApplyResources(this.Param3, "Param3");
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            resources.ApplyResources(this.Param4, "Param4");
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            resources.ApplyResources(this.Lat, "Lat");
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            resources.ApplyResources(this.Lon, "Lon");
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            resources.ApplyResources(this.Alt, "Alt");
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Frame
            // 
            resources.ApplyResources(this.Frame, "Frame");
            this.Frame.Name = "Frame";
            // 
            // coordZone
            // 
            resources.ApplyResources(this.coordZone, "coordZone");
            this.coordZone.Name = "coordZone";
            // 
            // coordEasting
            // 
            resources.ApplyResources(this.coordEasting, "coordEasting");
            this.coordEasting.Name = "coordEasting";
            // 
            // coordNorthing
            // 
            resources.ApplyResources(this.coordNorthing, "coordNorthing");
            this.coordNorthing.Name = "coordNorthing";
            // 
            // MGRS
            // 
            resources.ApplyResources(this.MGRS, "MGRS");
            this.MGRS.Name = "MGRS";
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            // 
            // Up
            // 
            this.Up.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.Up, "Up");
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.Name = "Up";
            // 
            // Down
            // 
            this.Down.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.Name = "Down";
            // 
            // Grad
            // 
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Angle
            // 
            resources.ApplyResources(this.Angle, "Angle");
            this.Angle.Name = "Angle";
            this.Angle.ReadOnly = true;
            this.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            resources.ApplyResources(this.Dist, "Dist");
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            resources.ApplyResources(this.AZ, "AZ");
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TagData
            // 
            resources.ApplyResources(this.TagData, "TagData");
            this.TagData.Name = "TagData";
            this.TagData.ReadOnly = true;
            // 
            // FlightPlanner
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBASE);
            this.Name = "FlightPlanner";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanner_FormClosing);
            this.Load += new System.EventHandler(this.FlightPlanner_Load);
            this.Resize += new System.EventHandler(this.Planner_Resize);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWaypoints.ResumeLayout(false);
            this.panelWaypoints.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStripMain.ResumeLayout(false);
            this.panelBASE.ResumeLayout(false);
            this.contextMenuStripZoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        public Panel panelWaypoints;
        public Panel panelAction;
        public Controls.myGMAP MainMap;
        
        public System.Windows.Forms.CheckBox CHK_verifyheight;
        public System.Windows.Forms.TextBox TXT_WPRad;
        public System.Windows.Forms.TextBox TXT_DefaultAlt;
        public System.Windows.Forms.TextBox TXT_loiterrad;
        public System.Windows.Forms.CheckBox CHK_splinedefault;
        public System.Windows.Forms.ComboBox CMB_altmode;
        public MyButton BUT_read;
        public MyButton BUT_write;
        public Panel panel5;
        public Panel panel1;
        public LinkLabel label4;
        public Label label3;
        public Label label2;
        public Label Label1;
        public TextBox TXT_homealt;
        public TextBox TXT_homelng;
        public TextBox TXT_homelat;
        public DataGridViewImageColumn dataGridViewImageColumn1;
        public DataGridViewImageColumn dataGridViewImageColumn2;
        public Label label6;
        public Label lbl_status;
        public MyDataGridView Commands;
        public MyButton BUT_Add;
        public Label LBL_WPRad;
        public Label LBL_defalutalt;
        public Label label5;
        public Panel panelMap;
        public MyTrackBar trackBar1;
        public Label label11;
        public Label lbl_distance;
        public Label lbl_prevdist;
        public Splitter splitter1;
        public Panel panelBASE;
        public Label lbl_homedist;
        public ToolTip toolTip1;

        public System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        public ToolStripMenuItem setHomeHereToolStripMenuItem;
        public ToolStripMenuItem clearMissionToolStripMenuItem;
        public ToolStripSeparator toolStripSeparator1;
        public ToolStripSeparator toolStripSeparator2;
        public ToolStripSeparator toolStripSeparator3;
        public ToolStripMenuItem planningWPToolStripMenuItem;
        public ToolStripMenuItem surveyGridToolStripMenuItem;
        private ToolStripMenuItem polygonToolStripMenuItem;
        public ToolStripMenuItem addPolygonPointToolStripMenuItem;
        public ToolStripMenuItem clearPolygonToolStripMenuItem;
        private ToolStripMenuItem loadPolygonToolStripMenuItem;
        public ToolStripMenuItem fromPolygonToolStripMenuItem;
        public ToolStripMenuItem fromSHPToolStripMenuItem;
        public ToolStripMenuItem tiffReadToolStripMenuItem;

        public ContextMenuStrip contextMenuStripPoly;

        private ContextMenuStrip contextMenuStripZoom;
        private ToolStripMenuItem zoomToVehicleToolStripMenuItem;
        private ToolStripMenuItem zoomToMissionToolStripMenuItem;
        private ToolStripMenuItem zoomToHomeToolStripMenuItem;
        //public ToolStripMenuItem loiterToolStripMenuItem;
        //public ToolStripMenuItem loiterForeverToolStripMenuItem;
        //public ToolStripMenuItem loitertimeToolStripMenuItem;
        //public ToolStripMenuItem loitercirclesToolStripMenuItem;
        //public ToolStripMenuItem jumpToolStripMenuItem;
        //public ToolStripMenuItem jumpstartToolStripMenuItem;
        //public ToolStripMenuItem jumpwPToolStripMenuItem;
        //public ToolStripMenuItem deleteWPToolStripMenuItem;
        public Timer timer1;
        //public ToolStripMenuItem setROIToolStripMenuItem;
        //public ToolStripMenuItem mapToolToolStripMenuItem;
        //public ToolStripMenuItem ContextMeasure;
        //public ToolStripMenuItem rotateMapToolStripMenuItem;
        //public ToolStripMenuItem zoomToToolStripMenuItem;
        //public ToolStripMenuItem prefetchToolStripMenuItem;
        //public ToolStripMenuItem kMLOverlayToolStripMenuItem;
        //public ToolStripMenuItem elevationGraphToolStripMenuItem;
        //public ToolStripMenuItem rTLToolStripMenuItem;
        //public ToolStripMenuItem landToolStripMenuItem;
        //public ToolStripMenuItem takeoffToolStripMenuItem;
        public ComboBox comboBoxMapType;
        public ToolStripMenuItem loadWPToolStripMenuItem;
        public ToolStripMenuItem loadWPFileToolStripMenuItem;
        public ToolStripMenuItem saveWPToolStripMenuItem;
        //public ToolStripMenuItem trackerHomeToolStripMenuItem;
        //public ToolStripMenuItem reverseWPsToolStripMenuItem;
        public ToolStripMenuItem loadAndAppendToolStripMenuItem;
        public ToolStripMenuItem savePolygonToolStripMenuItem;

        public CheckBox chk_grid;
        //public ToolStripMenuItem insertWpToolStripMenuItem;
        public ToolStripMenuItem loadKMLFileToolStripMenuItem;
        public LinkLabel lnk_kml;
        //public ToolStripMenuItem modifyAltToolStripMenuItem;
        //public ToolStripMenuItem prefetchWPPathToolStripMenuItem;
        public Label label17;
        public TextBox TXT_altwarn;
        //public ToolStripMenuItem pOIToolStripMenuItem;
        //public ToolStripMenuItem poiaddToolStripMenuItem;
        //public ToolStripMenuItem poideleteToolStripMenuItem;
        //public ToolStripMenuItem poieditToolStripMenuItem;
        //public ToolStripMenuItem enterUTMCoordToolStripMenuItem;
        public ToolStripMenuItem loadSHPFileToolStripMenuItem;

        public Coords coords1;
        public MyButton BUT_loadwpfile;
        public MyButton BUT_saveWPFile;
        public Panel panel2;
        public Panel panel4;
        public Panel panel3;
        public FlowLayoutPanel flowLayoutPanel1;
        //public ToolStripMenuItem switchDockingToolStripMenuItem;
        public Splitter splitter2;
        //public ToolStripMenuItem insertSplineWPToolStripMenuItem;

        public Label lbl_wpfile;
        //public ToolStripMenuItem areaToolStripMenuItem;

        //public ToolStripMenuItem currentPositionToolStripMenuItem;
        public MyButton but_writewpfast;
        public ComboBox cmb_missiontype;
        
        //public ToolStripMenuItem drawAPolygonToolStripMenuItem;
        //public ToolStripMenuItem fenceInclusionToolStripMenuItem;
        //public ToolStripMenuItem fenceExclusionToolStripMenuItem;
        //public ToolStripMenuItem createWpCircleToolStripMenuItem;
        //public ToolStripMenuItem createSplineCircleToolStripMenuItem;
        //public ToolStripMenuItem areaToolStripMenuItem1;
        //public ToolStripMenuItem textToolStripMenuItem;
        //public ToolStripMenuItem createCircleSurveyToolStripMenuItem;
        //public ToolStripMenuItem geoFenceToolStripMenuItem;
        //public ToolStripMenuItem GeoFenceuploadToolStripMenuItem;
        //public ToolStripMenuItem GeoFencedownloadToolStripMenuItem;
        //public ToolStripMenuItem setReturnLocationToolStripMenuItem;
        //public ToolStripMenuItem loadFromFileToolStripMenuItem;
        //public ToolStripMenuItem saveToFileToolStripMenuItem;
        //public ToolStripMenuItem clearToolStripMenuItem;
        //public ToolStripMenuItem rallyPointsToolStripMenuItem;
        //public ToolStripMenuItem setRallyPointToolStripMenuItem;
        //public ToolStripMenuItem getRallyPointsToolStripMenuItem;
        //public ToolStripMenuItem saveRallyPointsToolStripMenuItem;
        //public ToolStripMenuItem clearRallyPointsToolStripMenuItem;
        //public ToolStripMenuItem saveToFileToolStripMenuItem1;
        //public ToolStripMenuItem loadFromFileToolStripMenuItem1;
        public MyButton but_mincommands;

        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem testToolStripMenuItem;
        //public ToolStripMenuItem addPolygonPointToolStripMenuItem2;
        //public ToolStripMenuItem clearPolygonToolStripMenuItem2;
        //public ToolStripMenuItem savePolygonToolStripMenuItem2;
        //public ToolStripMenuItem loadPolygonToolStripMenuItem2;
        //public ToolStripMenuItem fromSHPToolStripMenuItem2;
        //public ToolStripMenuItem areaToolStripMenuItem2;


        private DataGridViewComboBoxColumn Command;
        private DataGridViewTextBoxColumn Param1;
        private DataGridViewTextBoxColumn Param2;
        private DataGridViewTextBoxColumn Param3;
        private DataGridViewTextBoxColumn Param4;
        private DataGridViewTextBoxColumn Lat;
        private DataGridViewTextBoxColumn Lon;
        private DataGridViewTextBoxColumn Alt;
        private DataGridViewComboBoxColumn Frame;
        private DataGridViewTextBoxColumn coordZone;
        private DataGridViewTextBoxColumn coordEasting;
        private DataGridViewTextBoxColumn coordNorthing;
        private DataGridViewTextBoxColumn MGRS;
        private DataGridViewButtonColumn Delete;
        private DataGridViewImageColumn Up;
        private DataGridViewImageColumn Down;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Angle;
        private DataGridViewTextBoxColumn Dist;
        private DataGridViewTextBoxColumn AZ;
        private DataGridViewTextBoxColumn TagData;
    }
}