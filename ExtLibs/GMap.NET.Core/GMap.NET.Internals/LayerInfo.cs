namespace GMap.NET.Internals
{
    using System.IO;
    using System;
    using System.Collections.Generic;

    public struct LayerInfo
    {
        private string path;
        private bool isDefaultOrigin;
        private double originLng;
        private double originLat;
        private double originAlt;
        private double scale;
        public double? defaultLng;
        public double? defaultLat;
        public double? defaultAlt;

        public bool IsDefaultOrigin
        {
            get
            {
                return isDefaultOrigin;
            }
            set
            {
                isDefaultOrigin = value;
            }
        }
        public double Lng
        {
            get
            {
                if (isDefaultOrigin)
                    return defaultLng.GetValueOrDefault();
                else
                    return originLng;
            }
            set
            {
                if (isDefaultOrigin) ;
                else
                    originLng = value;

            }
        }

        public double Lat
        {
            get
            {
                if (isDefaultOrigin)
                    return defaultLat.GetValueOrDefault();
                else
                    return originLat;
            }
            set
            {
                if (isDefaultOrigin) ;
                else
                    originLat = value;

            }
        }

        public double Alt
        {
            get
            {
                if (isDefaultOrigin)
                    return defaultAlt.GetValueOrDefault();
                else
                    return originAlt;
            }
            set
            {
                if (isDefaultOrigin) ;
                else
                    originAlt = value;

            }
        }

        public double Scale
        {
            get
            {
                return scale;
            }
            set
            {
                scale = value;
            }
        }

        public string ScaleFormat
        {
            get
            {
                return "1:" + scale.ToString();
            }
        }

        public string Layer
        {
            get
            {
                return path;
            }
        }


        public LayerInfo(string path, double scale)
        {
            this.path = path;
            this.isDefaultOrigin = true;
            this.originLng = 0;
            this.originLat = 0;
            this.originAlt = 0;
            this.scale = scale;
            this.defaultLng = null;
            this.defaultLat = null;
            this.defaultAlt = null;
        }

        public LayerInfo(string path, double lng, double lat, double alt, double scale)
        {
            this.path = path;
            this.isDefaultOrigin = false;
            this.originLng = lng;
            this.originLat = lat;
            this.originAlt = alt;
            this.scale = scale;
            this.defaultLng = null;
            this.defaultLat = null;
            this.defaultAlt = null;
        }

        public void SetDefaultOrigin(double lng,double lat,double alt)
        {
            this.defaultLng = lng;
            this.defaultLat = lat;
            this.defaultAlt = alt;
        }

        public void GetDefaultOrigin(out double lng, out double lat, out double alt)
        {
            lng = this.defaultLng.GetValueOrDefault();
            lat = this.defaultLat.GetValueOrDefault();
            alt = this.defaultAlt.GetValueOrDefault();
        }

        public override string ToString()
        {
            return Layer + " with origin (" + Lng + "," + Lat + "), scale ("+ ScaleFormat + ")";
        }

        public bool Equals(LayerInfo obj)
        {
            if (obj.path != path)
                return false;
            if (obj.scale != scale)
                return false;
            if (obj.isDefaultOrigin != isDefaultOrigin)
            {
                if (!obj.isDefaultOrigin)
                    return false;
            }
            else
            {
                if (!obj.isDefaultOrigin)
                {
                    if (obj.originLng != originLng || obj.originLat != originLat)
                        return false;
                }
            }
            return true;
        }
    }

}
