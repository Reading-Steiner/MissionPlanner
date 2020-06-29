using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace GMap.NET.WindowsForms.Markers
{
    //可能需要纠偏
    [Serializable]
    public class GMapMarkerLayer : GMapPolygon
    {
        PointLatLng LeftBottom;
        PointLatLng RightTop;
        Bitmap bitmap;
        public GMapMarkerLayer(PointLatLng p1, PointLatLng p2, Bitmap bitMap)
         : base(new List<PointLatLng>(), p1.ToString() + p2.ToString())
        {
            double maxLat = p1.Lat > p2.Lat ? p1.Lat : p2.Lat;
            double minLat = p1.Lat < p2.Lat ? p1.Lat : p2.Lat;
            double maxLng = p1.Lng > p2.Lng ? p1.Lng : p2.Lng;
            double minLng = p1.Lng < p2.Lng ? p1.Lng : p2.Lng;
            this.Points.Add(new PointLatLng(maxLat, minLng));
            this.Points.Add(new PointLatLng(maxLat, maxLng));
            this.Points.Add(new PointLatLng(minLat, maxLng));
            this.Points.Add(new PointLatLng(minLat, minLng));
            this.bitmap = bitMap;
        }

        public override void OnRender(IGraphics g)
        {
#if !PocketPC
            if (IsVisible)
            {
                if (IsVisible)
                {
                    GPoint pos1 = this.LocalPoints[0];
                    GPoint pos2 = this.LocalPoints[2];
                    if (this.bitmap != null)
                    {
                        //g.DrawImageUnscaled(this.bitmap, (int)pos1.X, (int)pos1.Y);
                        g.DrawImage(this.bitmap, pos1.X, pos1.Y, pos2.X - pos1.X, pos2.Y - pos1.Y);
                    }
                }
            }
#else
            if (this.bitmap != null)
            {
                DrawImageUnscaled(g, this.bitmap, LocalPosition.X, LocalPosition.Y);
            }
#endif
        }

    }
}
