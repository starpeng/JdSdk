#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:25.18378 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WareAttribute结构
    /// </summary>
    [Serializable]
    public class WareAttribute : JdObject
    {
        /// <summary>
        /// 属性id
        /// </summary>
        /// <example>2323</example>
        [XmlElement("aid")]
        [JsonProperty("aid")]
        public Nullable<Int64> Aid
        {
            get;
            set;
        }

        /// <summary>
        /// 属性名
        /// </summary>
        /// <example>12314</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值列表
        /// </summary>
        [XmlElement("attributeValues")]
        [JsonProperty("attributeValues")]
        public List< AttributeValue> AttributeValues
        {
            get;
            set;
        }

    }
}
