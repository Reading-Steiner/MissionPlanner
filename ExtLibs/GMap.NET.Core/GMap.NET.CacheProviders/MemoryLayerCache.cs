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
            catch
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
                if (!layerInfoInMemory.ContainsKey(key))
                {
                    if (layerInfoInMemory.Add(key, data))
                        selectedLayer = key;
                }
                else if (!data.Equals(GetLayerFromMemoryCache(key).GetValueOrDefault()))
                {
                    if (layerInfoInMemory.Modify(key, data))
                        selectedLayer = key;
                }
                else
                {
                    if (layerInfoInMemory.MoveToLast(key))
                        selectedLayer = key;
                }
            }
            finally
            {
            }
            return true;
        }

        internal static string GetHashCode(LayerInfo data)
        {
            if (data.Layer != null || data.Layer != "")
            {
                return (data.Layer.GetHashCode().ToString());
            }
            else
            {

                return (data.Lng + data.Lat + data.Alt).GetHashCode().ToString();
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
                layerInfoInMemory.FromXML(xmlDoc, out selectedLayer);
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

            xmlDoc.AppendChild(layerInfoInMemory.GetXML(xmlDoc));
            
            //需要保存修改的值
            xmlDoc.Save(".\\plugins\\GMap.NET.CacheProviders.MemoryLayerCache.xml");
            xmlDoc = null;
        }
    }
}
    
