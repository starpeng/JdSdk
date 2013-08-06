#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:25.18478 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// AttributeValue结构
    /// </summary>
    [Serializable]
    public class AttributeValue : JdObject
    {
        /// <summary>
        /// 属性值id
        /// </summary>
        /// <example>2323</example>
        [XmlElement("vid")]
        [JsonProperty("vid")]
        public Nullable<Int64> Vid
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值
        /// </summary>
        /// <example>12314</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

    }
}
