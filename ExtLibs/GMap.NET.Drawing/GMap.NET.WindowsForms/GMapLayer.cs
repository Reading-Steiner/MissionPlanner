using System.ComponentModel;
using System.IO;
using GMap.NET.Drawing;

namespace GMap.NET.WindowsForms.Markers
{
    using System.Drawing;
    using System.Collections.Generic;

#if !PocketPC
    using GMap.NET.Drawing.Properties;
    using System;
    using System.Runtime.Serialization;
#else
   using GMap.NET.WindowsMobile.Properties;
#endif

    //可能需要纠偏
    [Serializable]
    public class GMapLayer : GMapPolygon
    {
        PointLatLng LeftBottom;
        PointLatLng RightTop;
        Bitmap bitmap;
        public GMapLayer(PointLatLng p1, PointLatLng p2, Bitmap bitMap)
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