using GMap.NET.CacheProviders;
using MissionPlanner.ArduPilot;
using MissionPlanner.Comms;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class LayerManager : Form
    {
        public LayerManager()
        {
            InitializeComponent();
            Init();
        }

        MemoryLayerCache layerCache;
    }
}
