namespace GMap.NET.Internals
{
    using System.IO;
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Drawing;

    public struct LayerInfo
    {
        private string path;
        private readonly Color transparent;
        private double originLng;
        private double originLat;
        private double originAlt;
        private double scale;

       
        public double Lng
        {
            get
            {
                return originLng;
            }
            set
            {
                originLng = value;

            }
        }

        public double Lat
        {
            get
            {
                return originLat;
            }
            set
            {
                originLat = value;

            }
        }

        public double Alt
        {
            get
            {
                    return originAlt;
            }
            set
            {
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

        public Color Transparent
        {
            get
            {
                return transparent;
            }
        }

        public LayerInfo(string path, double lng, double lat, double alt, double scale, System.Drawing.Color transparent)
        {
            this.path = path;
            this.originLng = lng;
            this.originLat = lat;
            this.originAlt = alt;
            this.scale = scale;
            this.transparent = transparent;
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
            if (obj.originLng != originLng || obj.originLat != originLat)
                return false;

            return true;
        }

        public XmlElement GetXML(XmlDocument xmlDoc, string key)
        {

            XmlElement keyIndex = xmlDoc.CreateElement("key");
            keyIndex.InnerText = key;

            XmlElement path = xmlDoc.CreateElement("path");
            path.InnerText = this.Layer;
            keyIndex.AppendChild(path);

            XmlElement originX = xmlDoc.CreateElement("originLng");
            originX.InnerText = this.Lng.ToString();
            keyIndex.AppendChild(originX);

            XmlElement originY = xmlDoc.CreateElement("originLat");
            originY.InnerText = this.Lat.ToString();
            keyIndex.AppendChild(originY);

            XmlElement originZ = xmlDoc.CreateElement("originAlt");
            originZ.InnerText = this.Alt.ToString();
            keyIndex.AppendChild(originZ);

            XmlElement Scale = xmlDoc.CreateElement("scale");
            Scale.InnerText = this.Scale.ToString();
            keyIndex.AppendChild(Scale);

            XmlElement transparent = xmlDoc.CreateElement("transparent");
            keyIndex.AppendChild(transparent);

            XmlElement A = xmlDoc.CreateElement("A");
            A.InnerText = this.Transparent.A.ToString();
            transparent.AppendChild(A);

            XmlElement R = xmlDoc.CreateElement("R");
            R.InnerText = this.Transparent.R.ToString();
            transparent.AppendChild(R);

            XmlElement G = xmlDoc.CreateElement("G");
            G.InnerText = this.Transparent.G.ToString();
            transparent.AppendChild(G);

            XmlElement B = xmlDoc.CreateElement("B");
            B.InnerText = this.Transparent.B.ToString();
            transparent.AppendChild(B);

            return keyIndex;
        }

        static public LayerInfo? FromXML(XmlNode LayerInfoKeys)
        {
            if (LayerInfoKeys.Name == "key")
            {
                string path = "";
                double? originLng = null, originLat = null, originAlt = null;
                double? scale = null;
                Color transparent;
                foreach (XmlNode Info in LayerInfoKeys.ChildNodes)
                {
                    switch (Info.Name)
                    {
                        case "path":
                            path = Info.InnerText;
                            break;
                        case "originLng":
                            originLng = System.Convert.ToDouble(Info.InnerText);
                            break;
                        case "originLat":
                            originLat = System.Convert.ToDouble(Info.InnerText);
                            break;
                        case "originAlt":
                            originAlt = System.Convert.ToDouble(Info.InnerText);
                            break;
                        case "scale":
                            scale = System.Convert.ToDouble(Info.InnerText);
                            break;
                        case "transparent":
                            {
                                int A = 0, R = 0, G = 0, B = 0;
                                foreach (XmlNode channel in Info.ChildNodes)
                                {
                                    switch (channel.Name)
                                    {
                                        case "A":
                                            A = System.Convert.ToUInt16(channel.InnerText);
                                            break;
                                        case "R":
                                            R = System.Convert.ToUInt16(channel.InnerText);
                                            break;
                                        case "G":
                                            G = System.Convert.ToUInt16(channel.InnerText);
                                            break;
                                        case "B":
                                            B = System.Convert.ToUInt16(channel.InnerText);
                                            break;

                                    }
                                }
                                transparent = Color.FromArgb(A, R, G, B);
                            }
                            break;
                    }
                }
                if (path == null)
                    return null;
                if (originLng == null || originLat == null || originAlt == null || scale == null)
                    return null;
                return new LayerInfo(
                    path,
                    originLng.GetValueOrDefault(),
                    originLat.GetValueOrDefault(),
                    originAlt.GetValueOrDefault(),
                    scale.GetValueOrDefault(),
                    transparent);
            }
            else
                return null;
        }
    }

}
