using GMap.NET.CacheProviders;
using MissionPlanner.ArduPilot;
using MissionPlanner.Comms;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zone1, zone2;
            double lat1, lng1, lat2, lng2;
            if (Regex.IsMatch(Lat1.Text, @"^[+-]?\d+[.]?\d*$"))
                lat1 = System.Convert.ToDouble(Lat1.Text);
            else
                lat1 = 0;
            if (Regex.IsMatch(Lng1.Text, @"^[+-]?\d+[.]?\d*$"))
                lng1 = System.Convert.ToDouble(Lng1.Text);
            else
                lng1 = 0;

            if (Regex.IsMatch(Lat2.Text, @"^[+-]?\d+[.]?\d*$"))
                lat2 = System.Convert.ToDouble(Lat2.Text);
            else
                lat2 = 0;
            if (Regex.IsMatch(Lng2.Text, @"^[+-]?\d+[.]?\d*$"))
                lng2 = System.Convert.ToDouble(Lng2.Text);
            else
                lng2 = 0;
            PointLatLngAlt point1 = new PointLatLngAlt(lat1, lng1);
            PointLatLngAlt point2 = new PointLatLngAlt(lat2, lng2);


            if (Regex.IsMatch(Zone1.Text, @"^[+-]?\d+[.]?\d*$"))
                zone1 = System.Convert.ToInt32(Zone1.Text);
            else
                zone1 = 31;
            if (Regex.IsMatch(Zone2.Text, @"^[+-]?\d+[.]?\d*$"))
                zone2 = System.Convert.ToInt32(Zone2.Text);
            else
                zone2 = 31;
            var utm1 = point1.ToUTM(zone1);
            var utm2 = point2.ToUTM(zone2);

            X.Text = (utm1[0] - utm2[0]).ToString();
            Y.Text = (utm1[1] - utm2[1]).ToString();

        }

        private void Lng1_TextChanged(object sender, EventArgs e)
        {
            Zone1_TextChanged(sender, e);
        }

        private void Lat1_TextChanged(object sender, EventArgs e)
        {
            Zone1_TextChanged(sender, e);
        }

        private void Zone1_TextChanged(object sender, EventArgs e)
        {
            double lng, lat;
            int zone;
            if (Regex.IsMatch(Lng1.Text, @"^[+-]?\d+[.]?\d*$"))
                lng = System.Convert.ToDouble(Lng1.Text);
            else
                lng = 0;
            if (Regex.IsMatch(Lat1.Text, @"^[+-]?\d+[.]?\d*$"))
                lat = System.Convert.ToDouble(Lat1.Text);
            else
                lat = 0;
            if (Regex.IsMatch(Zone1.Text, @"^[+-]?\d+[.]?\d*$"))
                zone = System.Convert.ToInt32(Zone1.Text);
            else
                zone = 31;
            PointLatLngAlt point = new PointLatLngAlt(lat, lng);
            var utm = point.ToUTM(zone);
            UTMX1.Text = utm[0].ToString();
            UTMY1.Text = utm[1].ToString();
            Refresh();
        }

        private void Lng2_TextChanged(object sender, EventArgs e)
        {
            Zone2_TextChanged(sender, e);
        }

        private void Lat2_TextChanged(object sender, EventArgs e)
        {
            Zone2_TextChanged(sender, e);
        }

        private void Zone2_TextChanged(object sender, EventArgs e)
        {
            double lng, lat;
            int zone;
            if (Regex.IsMatch(Lng2.Text, @"^[+-]?\d+[.]?\d*$"))
                lng = System.Convert.ToDouble(Lng2.Text);
            else
                lng = 0;
            if (Regex.IsMatch(Lat2.Text, @"^[+-]?\d+[.]?\d*$"))
                lat = System.Convert.ToDouble(Lat2.Text);
            else
                lat = 0;
            if (Regex.IsMatch(Zone2.Text, @"^[+-]?\d+[.]?\d*$"))
                zone = System.Convert.ToInt32(Zone2.Text);
            else
                zone = 31;
            PointLatLngAlt point = new PointLatLngAlt(lat, lng);
            var utm = point.ToUTM(zone);
            UTMX2.Text = utm[0].ToString();
            UTMY2.Text = utm[1].ToString();
            Refresh();
        }
    }
}
