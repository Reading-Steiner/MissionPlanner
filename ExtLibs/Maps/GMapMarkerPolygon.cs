using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MissionPlanner.Maps
{
    [Serializable]
    public class GMapMarkerPolygon : GMarkerGoogle
    {
        
        public bool selected = false;
        public GMapMarkerPolygon(PointLatLng p)
            : base(p, GMarkerGoogleType.red)
        {
        }

        public override void OnRender(IGraphics g)
        {
            if (selected)
            {
                g.FillEllipse(Brushes.DeepSkyBlue, new Rectangle(this.LocalPosition, this.Size));
                g.DrawArc(Pens.DeepSkyBlue, new Rectangle(this.LocalPosition, this.Size), 0, 360);
            }

            base.OnRender(g);
        }
    }
}
