#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.16679 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// BillDetailVO[]属性
    /// </summary>
    [Serializable]
    public class BillDetailVO : JdObject
    {
        /// <summary>
        /// 结算单编号
        /// </summary>
        [XmlElement("bill_no")]
        [JsonProperty("bill_no")]
        public Nullable<Int64> BillNo
        {
            get;
            set;
        }

        /// <summary>
        /// 计划ID
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public String PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("plan_name")]
        [JsonProperty("plan_name")]
        public String PlanName
        {
            get;
            set;
        }

        /// <summary>
        /// 投放模式
        /// </summary>
        [XmlElement("mode")]
        [JsonProperty("mode")]
        public String Mode
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位
        /// </summary>
        [XmlElement("space_site")]
        [JsonProperty("space_site")]
        public String SpaceSite
        {
            get;
            set;
        }

        /// <summary>
        /// 花费
        /// </summary>
        [XmlElement("cost")]
        [JsonProperty("cost")]
        public String Cost
        {
            get;
            set;
        }

    }
}
