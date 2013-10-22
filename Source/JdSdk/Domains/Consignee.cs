#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:845 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// Consignee结构
    /// </summary>
    [Serializable]
    public class Consignee : JdObject
    {
        /// <summary>
        /// 客户姓名
        /// </summary>
        [XmlElement("cons_name")]
        [JsonProperty("cons_name")]
        public String ConsName
        {
            get;
            set;
        }

        /// <summary>
        /// 客户电话
        /// </summary>
        [XmlElement("cons_phone")]
        [JsonProperty("cons_phone")]
        public String ConsPhone
        {
            get;
            set;
        }

        /// <summary>
        /// 客户地址
        /// </summary>
        [XmlElement("cons_address")]
        [JsonProperty("cons_address")]
        public String ConsAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 客户手机
        /// </summary>
        [XmlElement("cons_handset")]
        [JsonProperty("cons_handset")]
        public String ConsHandset
        {
            get;
            set;
        }

    }
}
