
namespace GMap.NET.Internals
{
    using System.Collections.Generic;
    using System.IO;
    using System;
    using System.Diagnostics;
    class LayerInfoCache : Dictionary<string, LayerInfo>
    {
        public LayerInfoCache() : base()
        {
        }

        readonly List<string> Queue = new List<string>();

        public int Size
        {
            get
            {
                return Queue.Count;
            }
        }

        public LayerInfo this[int index]
        {
            get
            {
                LayerInfo layerInfo;
                base.TryGetValue(Queue[index], out layerInfo);
                return layerInfo;
            }
        }

        public new void Add(string key, LayerInfo value)
        {
            Queue.Add(key);
            base.Add(key, value);
        }


        public new void Modify(string key, LayerInfo value)
        {
            if (Queue.Contains(key))
            {
                base.Remove(key);
            }
            else
            {
                Queue.Add(key);
            }
            base.Add(key, value);
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

        
    }
}
