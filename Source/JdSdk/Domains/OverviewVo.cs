#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26692 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// OverviewVo属性
    /// </summary>
    [Serializable]
    public class OverviewVo : JdObject
    {
        /// <summary>
        /// 时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("order_time")]
        [JsonProperty("order_time")]
        public Nullable<DateTime> OrderTime
        {
            get;
            set;
        }

        /// <summary>
        /// 点击量
        /// </summary>
        [XmlElement("click_num")]
        [JsonProperty("click_num")]
        public Nullable<Int64> ClickNum
        {
            get;
            set;
        }

        /// <summary>
        /// 引入订单量
        /// </summary>
        [XmlElement("introduction_orders")]
        [JsonProperty("introduction_orders")]
        public Nullable<Decimal> IntroductionOrders
        {
            get;
            set;
        }

        /// <summary>
        /// 完成订单量
        /// </summary>
        [XmlElement("complete_orders")]
        [JsonProperty("complete_orders")]
        public Nullable<Decimal> CompleteOrders
        {
            get;
            set;
        }

        /// <summary>
        /// 成交商品件数
        /// </summary>
        [XmlElement("item_num")]
        [JsonProperty("item_num")]
        public Nullable<Int64> ItemNum
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
        /// 佣金
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
