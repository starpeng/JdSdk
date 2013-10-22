#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.80327 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SafWoOperDTO属性
    /// </summary>
    [Serializable]
    public class SafWoOperDTO : JdObject
    {
        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("oper_user")]
        [JsonProperty("oper_user")]
        public String OperUser
        {
            get;
            set;
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("oper_date")]
        [JsonProperty("oper_date")]
        public Nullable<DateTime> OperDate
        {
            get;
            set;
        }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("oper_type")]
        [JsonProperty("oper_type")]
        public String OperType
        {
            get;
            set;
        }

        /// <summary>
        /// 操作内容
        /// </summary>
        [XmlElement("oper_content")]
        [JsonProperty("oper_content")]
        public String OperContent
        {
            get;
            set;
        }

    }
}
