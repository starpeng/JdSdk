#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78527 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// OrderStatusDetail属性
    /// </summary>
    [Serializable]
    public class OrderStatusDetail : JdObject
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

        /// <summary>
        /// 状态名称
        /// </summary>
        [XmlElement("status_name")]
        [JsonProperty("status_name")]
        public String StatusName
        {
            get;
            set;
        }

        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("complete_time")]
        [JsonProperty("complete_time")]
        public String CompleteTime
        {
            get;
            set;
        }

    }
}
