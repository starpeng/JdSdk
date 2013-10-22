#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.80327 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SafWorkInfoDTO属性
    /// </summary>
    [Serializable]
    public class SafWorkInfoDTO : JdObject
    {
        /// <summary>
        /// 发起业务类型ID
        /// </summary>
        [XmlElement("send_biztype_id")]
        [JsonProperty("send_biztype_id")]
        public Int64 SendBiztypeId
        {
            get;
            set;
        }

        /// <summary>
        /// 发起业务类型名称
        /// </summary>
        [XmlElement("send_biztype_name")]
        [JsonProperty("send_biztype_name")]
        public String SendBiztypeName
        {
            get;
            set;
        }

        /// <summary>
        /// 回复业务类型名称
        /// </summary>
        [XmlElement("reply_biztype_name")]
        [JsonProperty("reply_biztype_name")]
        public String ReplyBiztypeName
        {
            get;
            set;
        }

        /// <summary>
        /// 二级回复业务类型
        /// </summary>
        [XmlElement("reply_sub_biztype_name")]
        [JsonProperty("reply_sub_biztype_name")]
        public String ReplySubBiztypeName
        {
            get;
            set;
        }

        /// <summary>
        /// 满意度评价
        /// </summary>
        [XmlElement("santisfaction")]
        [JsonProperty("santisfaction")]
        public String Santisfaction
        {
            get;
            set;
        }

        /// <summary>
        /// 工单创建时间
        /// </summary>
        [XmlElement("create_date")]
        [JsonProperty("create_date")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

        /// <summary>
        /// 工单操作记录
        /// </summary>
        [XmlElement("oper_logs")]
        [JsonProperty("oper_logs")]
        public List<SafWoOperDTO> OperLogs
        {
            get;
            set;
        }

    }
}
