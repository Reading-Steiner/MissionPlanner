namespace GMap.NET.Internals
{
    using System.IO;
    using System;
    using System.Collections.Generic;

    public struct LayerInfo
    {
        public string path;
        public bool IsDefaultOrigin;
        public double originX;
        public double originY;
        public double scale;

        public LayerInfo(string path, double Zoom)
        {
            this.path = path;
            IsDefaultOrigin = true;
            originX = 0;
            originY = 0;
            scale = Zoom;
        }

        public LayerInfo(string path, double x, double y, double Zoom)
        {
            this.path = path;
            IsDefaultOrigin = false;
            originX = x;
            originY = y;
            scale = Zoom;
        }

        public override string ToString()
        {
            return path + " with origin (" + originX + "," + originY + "), scale (:"+ scale.ToString("N") + ")";
        }

        public bool Equals(LayerInfo obj)
        {
            if (obj.path != path)
                return false;
            if (obj.scale != scale)
                return false;
            if (obj.IsDefaultOrigin != IsDefaultOrigin)
            {
                if (!obj.IsDefaultOrigin)
                    return false;
            }
            else
            {
                if (!obj.IsDefaultOrigin)
                {
                    if (obj.originX != originX || obj.originY != originY)
                        return false;
                }
            }
            return true;
        }
    }




    internal class LayerInfoComparer : IEqualityComparer<LayerInfo>
    {
        public bool Equals(LayerInfo x, LayerInfo y)
        {
            return x.path == y.path;
        }

        public int GetHashCode(LayerInfo obj)
        {
            return obj.path.GetHashCode();
        }
    }
}
