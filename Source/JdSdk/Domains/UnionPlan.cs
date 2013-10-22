#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26292 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 计划列表
    /// </summary>
    [Serializable]
    public class UnionPlan : JdObject
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        [XmlElement("pk")]
        [JsonProperty("pk")]
        public Nullable<Decimal> Pk
        {
            get;
            set;
        }

        /// <summary>
        /// 推广计划名称
        /// </summary>
        [XmlElement("planName")]
        [JsonProperty("planName")]
        public String PlanName
        {
            get;
            set;
        }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [XmlElement("startDate")]
        [JsonProperty("startDate")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [XmlElement("endDate")]
        [JsonProperty("endDate")]
        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 平均类目佣金比率
        /// </summary>
        [XmlElement("averageCommision")]
        [JsonProperty("averageCommision")]
        public Nullable<Decimal> AverageCommision
        {
            get;
            set;
        }

        /// <summary>
        /// 主推商品件数
        /// </summary>
        [XmlElement("goodsCount")]
        [JsonProperty("goodsCount")]
        public Nullable<Decimal> GoodsCount
        {
            get;
            set;
        }

        /// <summary>
        /// 活动推广个数
        /// </summary>
        [XmlElement("activityCount")]
        [JsonProperty("activityCount")]
        public Nullable<Decimal> ActivityCount
        {
            get;
            set;
        }

        /// <summary>
        /// 计划状态
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Nullable<Int64> Status
        {
            get;
            set;
        }

    }
}
