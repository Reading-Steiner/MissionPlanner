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
            }
            finally
            {
            }
            return true;
        }

        internal static string GetHashCode(LayerInfo data)
        {
            if(data.path != null || data.path != "")
            {
                return (data.path.GetHashCode().ToString());
            }
            else
            {
                if (data.IsDefaultOrigin)
                    return null;
                else
                {
                    return (data.originX + data.originY).GetHashCode().ToString();
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
                        double? originX = null;
                        double? originY = null;
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
                                case "originX":
                                    if (Info.InnerText == null)
                                        originX = null;
                                    else
                                        originX = System.Convert.ToDouble(Info.InnerText);
                                    break;
                                case "originY":
                                    if (Info.InnerText == null)
                                        originY = null;
                                    else
                                        originY = System.Convert.ToDouble(Info.InnerText);
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
                        if (originX == null || originY == null)
                            isDefaultOrigin = true;
                        if (isDefaultOrigin)
                        {
                            layerInfoInMemory.Add(key, new LayerInfo(path, (double)scale));
                            selectedLayer = key;
                        }
                        else
                        {
                            layerInfoInMemory.Add(key, new LayerInfo(path, (double)originX, (double)originY, (double)scale));
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
                key.InnerText = layerInfoInMemory[i].path.GetHashCode().ToString();
                LayerInfos.AppendChild(key);

                XmlElement path = xmlDoc.CreateElement("path");
                path.InnerText = layerInfoInMemory[i].path;
                key.AppendChild(path);

                XmlElement isDefaultOrigin = xmlDoc.CreateElement("isDefaultOrigin");
                isDefaultOrigin.InnerXml = layerInfoInMemory[i].IsDefaultOrigin.ToString();
                key.AppendChild(isDefaultOrigin);

                XmlElement originX = xmlDoc.CreateElement("originX");
                originX.InnerText = layerInfoInMemory[i].originX.ToString();
                key.AppendChild(originX);

                XmlElement originY = xmlDoc.CreateElement("originY");
                originY.InnerText = layerInfoInMemory[i].originY.ToString();
                key.AppendChild(originY);

                XmlElement scale = xmlDoc.CreateElement("scale");
                scale.InnerText = layerInfoInMemory[i].scale.ToString();
                key.AppendChild(scale);
            }
            //需要保存修改的值
            xmlDoc.Save(".\\plugins\\GMap.NET.CacheProviders.MemoryLayerCache.xml");
            xmlDoc = null;
        }
    }
}
    
