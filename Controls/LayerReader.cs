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
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class LayerReader : Form
    {
        public LayerReader()
        {
            InitializeComponent();
        }

        public LayerReader(string path)
        {
            InitializeComponent();
            if (path.ToLower().EndsWith(".tif") && File.Exists(path))
                OpenFile(path);
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "TIFF地理影像(*.tif)|*.tif";
                ofd.ShowDialog();
                if (File.Exists(ofd.FileName))
                    OpenFile(ofd.FileName);
            }
        }

        private void OpenFile(string path)
        {
            this.Longitude.Text = 0.ToString();
            this.Latitude.Text = 0.ToString();
            this.Altitude.Text = 0.ToString();
            this.Scale.Text = 100.ToString();

            this.FilePath.Text = path;

            Func<string, GDAL.GDAL.GeoBitmap> GetGeoBitmap = (filePath) =>
                {
                    var bitmap = GDAL.GDAL.LoadImageInfo(filePath);
                    Image img = Image.FromHbitmap(bitmap.smallBitmap.GetHbitmap());
                    return bitmap;
                };
            IAsyncResult iar = GetGeoBitmap.BeginInvoke(path, CallbackWhenDone, this);
        }


        private void CallbackWhenDone(IAsyncResult iar)
        {
            AsyncResult ar = (AsyncResult)iar;
            Func<string, GDAL.GDAL.GeoBitmap> geoFunc = (Func<string, GDAL.GDAL.GeoBitmap>)ar.AsyncDelegate;

            geobitmap = geoFunc.EndInvoke(iar);
            if (geobitmap == null)
            {
                IsLoadLayer = false;
                return;
            }
            if (!geobitmap.Rect.IsEmpty)
            {
                IsLoadLayer = true;

                var rect = geobitmap.Rect;
                this.TopLabel.Text = string.Format(TopFormat, rect.Top >= 0 ? rect.Top.ToString("f2") + "N" : (-rect.Top).ToString("f2") + "S");
                this.BottomLabel.Text = string.Format(BottomFormat, rect.Bottom >= 0 ? rect.Bottom.ToString("f2") + "N" : (-rect.Bottom).ToString("f2") + "S");
                this.LeftLabel.Text = string.Format(LeftFormat, rect.Left > 0 ? rect.Left.ToString("f2") + "E" : (-rect.Left).ToString("f2") + "W");
                this.RightLabel.Text = string.Format(RightFormat, rect.Right >= 0 ? rect.Right.ToString("f2") + "E" : (-rect.Right).ToString("f2") + "W");

                this.Longitude.Text = rect.Lng.ToString();
                this.Latitude.Text = rect.Lat.ToString();
                this.Altitude.Text = 0.ToString();

                this.Scale.Text = 100.ToString();

                this.Transparent.Color = geobitmap.smallBitmap.GetPixel(0, 0);

                
                using (Bitmap bitmap = (Bitmap)geobitmap.smallBitmap.Clone())
                {
                    bitmap.MakeTransparent(this.Transparent.Color);

                    Image img = Image.FromHbitmap(bitmap.GetHbitmap());
                    this.LayerPrevView.Image = img;
                    bitmap.Dispose();
                }
            }
            else
            {
                IsLoadLayer = false;
            }
        }

        private void Transparent_ColorChanged(object sender, EventArgs e)
        {
            if (this.LayerPrevView.Image != null)
            {
                using(Bitmap bitmap = (Bitmap)geobitmap.smallBitmap.Clone())
                {
                    bitmap.MakeTransparent(this.Transparent.Color);

                    Image img = Image.FromHbitmap(bitmap.GetHbitmap());
                    this.LayerPrevView.Image = img;
                    bitmap.Dispose();
                }
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (this.IsLoadLayer)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        public string GetLayer()
        {
            if (IsLoadLayer)
            {
                return this.FilePath.Text;
            }
            else
                return null;
        }

        public PointLatLngAlt GetOrigin()
        {
            if (IsLoadLayer)
            {
                return new PointLatLngAlt(
                    System.Convert.ToDouble(this.Latitude.Text),
                    System.Convert.ToDouble(this.Longitude.Text),
                    System.Convert.ToDouble(this.Altitude.Text));
            }
            else
                return null;
        }


        public double GetScale()
        {
            if (IsLoadLayer)
            {
                return System.Convert.ToDouble(this.Scale.Text);
            }
            else
                return 0.0;
        }


        public Color GetTransparentColor()
        {
            if (IsLoadLayer)
            {
                return this.Transparent.Color;
            }
            else
                return Color.Black;
        }



        string TopFormat = "Top：{0}";
        string BottomFormat = "Bottom：{0}";
        string LeftFormat = "Left：\n\n{0}";
        string RightFormat = "Right：\n\n{0}";
        GDAL.GDAL.GeoBitmap geobitmap;
        bool IsLoadLayer = false;
    }
}
