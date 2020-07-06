
namespace GMap.NET.Internals
{
    using System.Collections.Generic;
    using System.IO;
    using System;
    using System.Diagnostics;
    using System.Xml;

    class LayerInfoCache : Dictionary<string, LayerInfo>
    {
        public LayerInfoCache() : base()
        {
        }

        private int vaildIndex = 0;
        readonly List<string> Queue = new List<string>();

        public new int Count
        {
            get
            {
                return Queue.Count - vaildIndex;
            }
        }

        public LayerInfo this[int index]
        {
            get
            {
                LayerInfo layerInfo;
                base.TryGetValue(Queue[index + vaildIndex], out layerInfo);
                return layerInfo;
            }
        }

        public new bool Add(string key, LayerInfo value)
        {
            base.Add(key, value);
            if (File.Exists(value.Layer))
            {
                Queue.Add(key);
                return true;
            }
            else
            {
                Queue.Insert(0, key);
                vaildIndex++;
                return false;
            }
            
        }


        public bool Modify(string key, LayerInfo value)
        {
            if (Queue.Contains(key))
            {
                Queue.Remove(key);
                base.Remove(key);
            }
            base.Add(key, value);
            if (File.Exists(value.Layer))
            {
                Queue.Add(key);
                return true;
            }
            else
            {
                Queue.Insert(0, key);
                vaildIndex++;
                return false;
            }

        }

        public bool MoveToLast(string key)
        {
            if (Queue.Contains(key))
            {
                if (Queue.IndexOf(key) > vaildIndex)
                {
                    Queue.Remove(key);
                    Queue.Add(key);
                    return true;
                }
            }
            vaildIndex++;
            return false;
        }


        // do not allow directly removal of elements
        private new void Remove(string key)
        {
            base.Remove(key);
        }

        public new void Clear()
        {
            Queue.Clear();
            base.Clear();
        }


        public XmlElement GetXML(XmlDocument xmlDoc)
        {
            XmlElement LayerInfos = xmlDoc.CreateElement("MemoryLayerCache");
            xmlDoc.AppendChild(LayerInfos);

            for (int i = 0; i < Queue.Count; i++)
            {
                // (4)给根节点Books创建第1个子节点
                try
                {
                    base.TryGetValue(Queue[i], out LayerInfo layerInfo);
                    LayerInfos.AppendChild(layerInfo.GetXML(xmlDoc, Queue[i]));
                }
                catch
                {

                }
            }
            return LayerInfos;
        }
        
    }
}
