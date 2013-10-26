#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75646 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ChatSession 属性
    /// </summary>
    [Serializable]
    public class ChatSession : JdObject
    {
        /// <summary>
        /// 咨询的顾客
        /// </summary>
        /// <example></example>
        [XmlElement("customer")]
        [JsonProperty("customer")]
        public String Customer
        {
            get;
            set;
        }

        /// <summary>
        /// 客服账号
        /// </summary>
        /// <example></example>
        [XmlElement("waiter")]
        [JsonProperty("waiter")]
        public String Waiter
        {
            get;
            set;
        }

        /// <summary>
        /// 咨询开始时间
        /// </summary>
        /// <example></example>
        [XmlElement("beginTime")]
        [JsonProperty("beginTime")]
        public DateTime BeginTime
        {
            get;
            set;
        }

        /// <summary>
        /// 客服回复时间，如果未回复此时间为空
        /// </summary>
        /// <example></example>
        [XmlElement("replyTime")]
        [JsonProperty("replyTime")]
        public DateTime ReplyTime
        {
            get;
            set;
        }

        /// <summary>
        /// 会话结束时间，会话结束即会话断开连接时间。
        /// </summary>
        /// <example></example>
        [XmlElement("endTime")]
        [JsonProperty("endTime")]
        public DateTime EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// 会话类型 1：在线会话 2：留言
        /// </summary>
        /// <example></example>
        [XmlElement("sessionType")]
        [JsonProperty("sessionType")]
        public Int64 SessionType
        {
            get;
            set;
        }

        /// <summary>
        /// 是否转接 true: 转接 false：未转接
        /// </summary>
        /// <example></example>
        [XmlElement("transfer")]
        [JsonProperty("transfer")]
        public Boolean Transfer
        {
            get;
            set;
        }

        /// <summary>
        /// 会话ID。保留，暂不支持。
        /// </summary>
        /// <example></example>
        [XmlElement("sid")]
        [JsonProperty("sid")]
        public String Sid
        {
            get;
            set;
        }

        /// <summary>
        /// 顾客咨询的商品编号，为0表示无商品咨询。
        /// </summary>
        /// <example></example>
        [XmlElement("skuId")]
        [JsonProperty("skuId")]
        public Int64 SkuId
        {
            get;
            set;
        }

    }
}
