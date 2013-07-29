#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26892 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WindowAdvDetail 类型描述属性
    /// </summary>
    [Serializable]
    public class WindowAdvDetail : JdObject
    {
        /// <summary>
        /// 下单时间
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("orderTime")]
        [JsonProperty("orderTime")]
        public Nullable<DateTime> OrderTime
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位名称
        /// </summary>
        [XmlElement("spaceName")]
        [JsonProperty("spaceName")]
        public String SpaceName
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位尺寸
        /// </summary>
        /// <example>200*300</example>
        [XmlElement("size")]
        [JsonProperty("size")]
        public String Size
        {
            get;
            set;
        }

        /// <summary>
        /// 网站名称
        /// </summary>
        [XmlElement("siteName")]
        [JsonProperty("siteName")]
        public String SiteName
        {
            get;
            set;
        }

        /// <summary>
        /// 点击量
        /// </summary>
        [XmlElement("clickNum")]
        [JsonProperty("clickNum")]
        public Nullable<Decimal> ClickNum
        {
            get;
            set;
        }

        /// <summary>
        /// 引入订单量
        /// </summary>
        [XmlElement("introductionOrders")]
        [JsonProperty("introductionOrders")]
        public Nullable<Decimal> IntroductionOrders
        {
            get;
            set;
        }

        /// <summary>
        /// 完成订单量
        /// </summary>
        [XmlElement("completeOrders")]
        [JsonProperty("completeOrders")]
        public Nullable<Decimal> CompleteOrders
        {
            get;
            set;
        }

        /// <summary>
        /// 成交商品数量
        /// </summary>
        [XmlElement("itemNum")]
        [JsonProperty("itemNum")]
        public Nullable<Decimal> ItemNum
        {
            get;
            set;
        }

        /// <summary>
        /// 成交金额
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount")]
        public Nullable<Decimal> Amount
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金金额
        /// </summary>
        [XmlElement("commission")]
        [JsonProperty("commission")]
        public Nullable<Decimal> Commission
        {
            get;
            set;
        }

    }
}
