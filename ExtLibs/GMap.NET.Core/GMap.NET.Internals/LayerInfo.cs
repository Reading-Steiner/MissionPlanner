namespace GMap.NET.Internals
{
    using System.IO;
    using System;
    using System.Collections.Generic;
    using System.Xml;

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

        public XmlElement GetXML(XmlDocument xmlDoc, string key)
        {

            XmlElement keyIndex = xmlDoc.CreateElement("key");
            keyIndex.InnerText = key;

            XmlElement path = xmlDoc.CreateElement("path");
            path.InnerText = Layer;
            keyIndex.AppendChild(path);

            XmlElement isDefaultOrigin = xmlDoc.CreateElement("isDefaultOrigin");
            isDefaultOrigin.InnerXml = IsDefaultOrigin.ToString();
            keyIndex.AppendChild(isDefaultOrigin);

            if (!IsDefaultOrigin)
            {
                XmlElement originX = xmlDoc.CreateElement("originLng");
                originX.InnerText = Lng.ToString();
                keyIndex.AppendChild(originX);

                XmlElement originY = xmlDoc.CreateElement("originLat");
                originY.InnerText = Lat.ToString();
                keyIndex.AppendChild(originY);

                XmlElement originZ = xmlDoc.CreateElement("originAlt");
                originY.InnerText = Alt.ToString();
                keyIndex.AppendChild(originZ);
            }

            GetDefaultOrigin(out double lng, out double lat, out double alt);

            XmlElement defaultX = xmlDoc.CreateElement("defaultLng");
            defaultX.InnerText = lng.ToString();
            keyIndex.AppendChild(defaultX);

            XmlElement defaultY = xmlDoc.CreateElement("defaultLat");
            defaultY.InnerText = lat.ToString();
            keyIndex.AppendChild(defaultY);

            XmlElement defaultZ = xmlDoc.CreateElement("defaultAlt");
            defaultZ.InnerText = alt.ToString();
            keyIndex.AppendChild(defaultZ);

            XmlElement scale = xmlDoc.CreateElement("scale");
            scale.InnerText = Scale.ToString();
            keyIndex.AppendChild(scale);

            return keyIndex;
        }
    }

}
