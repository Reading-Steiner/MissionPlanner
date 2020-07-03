namespace GMap.NET.CacheProviders
{
    using System.Diagnostics;
    using GMap.NET.Internals;
    using System;
    using System.Xml;
 

    public class MemoryLayerCache
    {
        static readonly LayerInfoCache layerInfoInMemory = new LayerInfoCache();
        static string selectedLayer;

        static MemoryLayerCache()
        {
            ReadLayerInfoConfig();
        }

        ~MemoryLayerCache()
        {
            SaveLayerInfoConfig();
        }

        public void Clear()
        {
            try
            {
                layerInfoInMemory.Clear();
            }
            finally
            {
            }
        }

        public int Count
        {
            get
            {
                return layerInfoInMemory.Count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    return layerInfoInMemory.Count > 0 ? false : true;
                }
                finally
                {
                }
            }
        }

        public LayerInfo? GetLayerFromMemoryCache(string key)
        {
            try
            {
                LayerInfo ret;
                if (layerInfoInMemory.TryGetValue(key, out ret))
                {
                    return ret;
                }
            }
            finally
            {

            }
            return null;
        }

        public LayerInfo? GetLayerFromMemoryCache(int index)
        {
            try
            {
                if (index >= layerInfoInMemory.Count || index < 0)
                    return null;
                return layerInfoInMemory[index];
            }
            finally
            {
            }
        }

        public LayerInfo? GetSelectedLayerFromMemoryCache()
        {
            try
            {
                if (layerInfoInMemory.Count <= 0)
                    return null;
                return GetLayerFromMemoryCache(selectedLayer);
            }
            finally
            {
            }
        }

        public bool AddLayerToMemoryCache(LayerInfo data)
        {

            try
            {
                string key = GetHashCode(data);
                if (key == null)
                    return false;
                selectedLayer = key;
                if (!layerInfoInMemory.ContainsKey(key))
                {
                    layerInfoInMemory.Add(key, data);
                }
                else if (!data.Equals(GetLayerFromMemoryCache(key).GetValueOrDefault()))
                {
                    layerInfoInMemory.Modify(key, data);
                }
                else
                {
                    layerInfoInMemory.MoveToLast(key);
                }
            }
            finally
            {
            }
            return true;
        }

        internal static string GetHashCode(LayerInfo data)
        {
            if(data.Layer != null || data.Layer != "")
            {
                return (data.Layer.GetHashCode().ToString());
            }
            else
            {
                if (data.IsDefaultOrigin)
                    return null;
                else
                {
                    return (data.Lng + data.Lat + data.Alt).GetHashCode().ToString();
                }
            }
        }

        internal static void ReadLayerInfoConfig()
        {
            if (!System.IO.File.Exists(".\\plugins\\GMap.NET.CacheProviders.MemoryLayerCache.xml"))
                return;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(".\\plugins\\GMap.NET.CacheProviders.MemoryLayerCache.xml");
            try
            {
                XmlNode root = xmlDoc.SelectSingleNode("MemoryLayerCache");
                foreach (XmlNode LayerInfoKeys in root)
                {
                    if (LayerInfoKeys.Name == "key")
                    {
                        string key = LayerInfoKeys.FirstChild.Value;
                        string path = null;
                        bool isDefaultOrigin = true;
                        double? originLng = null;
                        double? originLat = null;
                        double? originAlt = null;
                        double? defaultLng = null;
                        double? defaultLat = null;
                        double? defaultAlt = null;
                        double? scale = null;
                        foreach (XmlNode Info in LayerInfoKeys.ChildNodes)
                        {
                            switch (Info.Name)
                            {
                                case "path":
                                    path = Info.InnerText;
                                    break;
                                case "isDefaultOrigin":
                                    isDefaultOrigin = System.Convert.ToBoolean(Info.InnerText);
                                    break;
                                case "originLng":
                                    if (Info.InnerText == null)
                                        originLng = null;
                                    else
                                        originLng = System.Convert.ToDouble(Info.InnerText);
                                    break;
                                case "originLat":
                                    if (Info.InnerText == null)
                                        originLat = null;
                                    else
                                        originLat = System.Convert.ToDouble(Info.InnerText);
                                    break;
                                case "originAlt":
                                    if (Info.InnerText == null)
                                        originAlt = null;
                                    else
                                        originAlt = System.Convert.ToDouble(Info.InnerText);
                                    break;
                                case "defaultLng":
                                    if (Info.InnerText == null)
                                        defaultLng = null;
                                    else
                                        defaultLng = System.Convert.ToDouble(Info.InnerText);
                                    break;
                                case "defaultLat":
                                    if (Info.InnerText == null)
                                        defaultLat = null;
                                    else
                                        defaultLat = System.Convert.ToDouble(Info.InnerText);
                                    break;
                                case "defaultAlt":
                                    if (Info.InnerText == null)
                                        defaultAlt = null;
                                    else
                                        defaultAlt = System.Convert.ToDouble(Info.InnerText);
                                    break;
                                case "scale":
                                    if (Info.InnerText == null)
                                        scale = null;
                                    else
                                        scale = System.Convert.ToDouble(Info.InnerText);
                                    break;
                            }
                        }
                        if (path == null || scale == null)
                            continue;
                        if (originLng == null || originLat == null)
                            isDefaultOrigin = true;
                        if (isDefaultOrigin)
                        {
                            var layer = new LayerInfo(path, (double)scale);
                            layer.SetDefaultOrigin(defaultLng.GetValueOrDefault(), defaultLat.GetValueOrDefault(), defaultAlt.GetValueOrDefault());
                            layerInfoInMemory.Add(key, layer);
                            selectedLayer = key;
                        }
                        else
                        {
                            var layer = new LayerInfo(path, (double)originLng, (double)originLat, (double)originAlt, (double)scale);
                            layer.SetDefaultOrigin(defaultLng.GetValueOrDefault(), defaultLat.GetValueOrDefault(), defaultAlt.GetValueOrDefault());
                            layerInfoInMemory.Add(key, layer);
                            selectedLayer = key;
                        }
                    }
                }
            }
            finally
            {
            }
        }

        internal static void SaveLayerInfoConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlDeclaration dec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(dec);

            XmlElement LayerInfos = xmlDoc.CreateElement("MemoryLayerCache");
            xmlDoc.AppendChild(LayerInfos);

            for (int i = 0; i < layerInfoInMemory.Count; i++)
            {
                // (4)给根节点Books创建第1个子节点
                XmlElement key = xmlDoc.CreateElement("key");
                key.InnerText = GetHashCode(layerInfoInMemory[i]);
                LayerInfos.AppendChild(key);

                XmlElement path = xmlDoc.CreateElement("path");
                path.InnerText = layerInfoInMemory[i].Layer;
                key.AppendChild(path);

                XmlElement isDefaultOrigin = xmlDoc.CreateElement("isDefaultOrigin");
                isDefaultOrigin.InnerXml = layerInfoInMemory[i].IsDefaultOrigin.ToString();
                key.AppendChild(isDefaultOrigin);

                if (!layerInfoInMemory[i].IsDefaultOrigin)
                {
                    XmlElement originX = xmlDoc.CreateElement("originLng");
                    originX.InnerText = layerInfoInMemory[i].Lng.ToString();
                    key.AppendChild(originX);

                    XmlElement originY = xmlDoc.CreateElement("originLat");
                    originY.InnerText = layerInfoInMemory[i].Lat.ToString();
                    key.AppendChild(originY);

                    XmlElement originZ = xmlDoc.CreateElement("originAlt");
                    originY.InnerText = layerInfoInMemory[i].Lat.ToString();
                    key.AppendChild(originZ);
                }

                layerInfoInMemory[i].GetDefaultOrigin(out double lng, out double lat, out double alt);

                XmlElement defaultX = xmlDoc.CreateElement("defaultLng");
                defaultX.InnerText = lng.ToString();
                key.AppendChild(defaultX);

                XmlElement defaultY = xmlDoc.CreateElement("defaultLat");
                defaultY.InnerText = lat.ToString();
                key.AppendChild(defaultY);

                XmlElement defaultZ = xmlDoc.CreateElement("defaultAlt");
                defaultZ.InnerText = alt.ToString();
                key.AppendChild(defaultZ);

                XmlElement scale = xmlDoc.CreateElement("scale");
                scale.InnerText = layerInfoInMemory[i].Scale.ToString();
                key.AppendChild(scale);
            }
            //需要保存修改的值
            xmlDoc.Save(".\\plugins\\GMap.NET.CacheProviders.MemoryLayerCache.xml");
            xmlDoc = null;
        }
    }
}
    
