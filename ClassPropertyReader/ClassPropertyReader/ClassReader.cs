using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPropertyReader
{
    public class ClassReader
    {
        public static StringBuilder Read(Object obj)
        {
            // Reading properties of object through reflection
            var props = obj.GetType().GetProperties();
            var sb = new StringBuilder();
            foreach (var p in props)
            {
                sb.Append(p.Name + p.GetValue(obj, null));
            }
            return sb;
            
        }
    }
}
