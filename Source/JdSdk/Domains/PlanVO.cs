#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 13:02:46.25791 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 计划详情对象属性
    /// </summary>
    [Serializable]
    public class PlanVO : JdObject
    {
        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("planName")]
        [JsonProperty("planName")]
        public String PlanName
        {
            get;
            set;
        }

        /// <summary>
        /// 开始时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("startDate")]
        [JsonProperty("startDate")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 结束时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("endDate")]
        [JsonProperty("endDate")]
        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 说明
        /// </summary>
        [XmlElement("notes")]
        [JsonProperty("notes")]
        public String Notes
        {
            get;
            set;
        }

        /// <summary>
        /// 类目对象列表
        /// </summary>
        [XmlElement("categoryCommision")]
        [JsonProperty("categoryCommision")]
        public UnionCategoryCommision[] CategoryCommision
        {
            get;
            set;
        }

        /// <summary>
        /// 商品对象列表
        /// </summary>
        [XmlElement("planGoods")]
        [JsonProperty("planGoods")]
        public GoodsVO[] PlanGoods
        {
            get;
            set;
        }

        /// <summary>
        /// 活动对象列表
        /// </summary>
        [XmlElement("planActivity")]
        [JsonProperty("planActivity")]
        public UnionPlanActivity[] PlanActivity
        {
            get;
            set;
        }

    }
}
