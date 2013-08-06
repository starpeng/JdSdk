#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.24591 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 推广计划对象
    /// </summary>
    [Serializable]
    public class PromotionPlanVO : JdObject
    {
        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("pk")]
        [JsonProperty("pk")]
        public Nullable<Decimal> Pk
        {
            get;
            set;
        }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("pop_id")]
        [JsonProperty("pop_id")]
        public Nullable<Int64> PopId
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
        /// 计划开始时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("start_date")]
        [JsonProperty("start_date")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 计划结束时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("end_date")]
        [JsonProperty("end_date")]
        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 计划状态,1:草稿,11:提交成功,9:推广结束,6:已生效,10:已冻结,-1:已删除
        /// </summary>
        /// <example>1/11/9/6/10/-1</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Nullable<Int64> Status
        {
            get;
            set;
        }

        /// <summary>
        /// 更新时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("update_time")]
        [JsonProperty("update_time")]
        public Nullable<DateTime> UpdateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 插入时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("insert_time")]
        [JsonProperty("insert_time")]
        public Nullable<DateTime> InsertTime
        {
            get;
            set;
        }

        /// <summary>
        /// 类目平均佣金
        /// </summary>
        [XmlElement("average_commision")]
        [JsonProperty("average_commision")]
        public Nullable<Decimal> AverageCommision
        {
            get;
            set;
        }

        /// <summary>
        /// 主推商品总数
        /// </summary>
        [XmlElement("goods_count")]
        [JsonProperty("goods_count")]
        public Nullable<Decimal> GoodsCount
        {
            get;
            set;
        }

        /// <summary>
        /// 推广活动个数
        /// </summary>
        [XmlElement("activity_count")]
        [JsonProperty("activity_count")]
        public Nullable<Decimal> ActivityCount
        {
            get;
            set;
        }

    }
}
