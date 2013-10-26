#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76046 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// IncomeExpenseVO属性
    /// </summary>
    [Serializable]
    public class IncomeExpenseVO : JdObject
    {
        /// <summary>
        /// 流水单号
        /// </summary>
        [XmlElement("swift_number")]
        [JsonProperty("swift_number")]
        public Int64 SwiftNumber
        {
            get;
            set;
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("creat_time")]
        [JsonProperty("creat_time")]
        public String CreatTime
        {
            get;
            set;
        }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount")]
        public Int64 Amount
        {
            get;
            set;
        }

        /// <summary>
        /// 收支类型
        /// </summary>
        [XmlElement("in_out_type")]
        [JsonProperty("in_out_type")]
        public Int64 InOutType
        {
            get;
            set;
        }

        /// <summary>
        /// 单据来源（计划ID）
        /// </summary>
        [XmlElement("order_from")]
        [JsonProperty("order_from")]
        public String OrderFrom
        {
            get;
            set;
        }

        /// <summary>
        /// 备注（计划名称，充值）
        /// </summary>
        [XmlElement("remark")]
        [JsonProperty("remark")]
        public String Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 播放日期
        /// </summary>
        [XmlElement("show_date")]
        [JsonProperty("show_date")]
        public String ShowDate
        {
            get;
            set;
        }

    }
}
