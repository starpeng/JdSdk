#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.25091 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 推广商品列表
    /// </summary>
    [Serializable]
    public class JosGoodsVO : JdObject
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
        /// 商品skuid
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 推广商品所属计划id
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        [JsonProperty("goods_name")]
        public String GoodsName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("unitPrice")]
        [JsonProperty("unitPrice")]
        public Nullable<Decimal> UnitPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 商品好评度
        /// </summary>
        [XmlElement("praise_degree")]
        [JsonProperty("praise_degree")]
        public Nullable<Decimal> PraiseDegree
        {
            get;
            set;
        }

        /// <summary>
        /// 商品主图url
        /// </summary>
        [XmlElement("mainimgurl")]
        [JsonProperty("mainimgurl")]
        public String Mainimgurl
        {
            get;
            set;
        }

        /// <summary>
        /// 商品佣金比例
        /// </summary>
        [XmlElement("commision_ratio")]
        [JsonProperty("commision_ratio")]
        public Nullable<Decimal> CommisionRatio
        {
            get;
            set;
        }

        /// <summary>
        /// 商品佣金
        /// </summary>
        [XmlElement("commision")]
        [JsonProperty("commision")]
        public Nullable<Decimal> Commision
        {
            get;
            set;
        }

        /// <summary>
        /// 商品在京东主站的url
        /// </summary>
        [XmlElement("ware_url")]
        [JsonProperty("ware_url")]
        public String WareUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 最近30天推广量
        /// </summary>
        [XmlElement("recent_sales")]
        [JsonProperty("recent_sales")]
        public String RecentSales
        {
            get;
            set;
        }

        /// <summary>
        /// 累计推广量
        /// </summary>
        [XmlElement("total_sales")]
        [JsonProperty("total_sales")]
        public Nullable<Decimal> TotalSales
        {
            get;
            set;
        }

        /// <summary>
        /// 商品推广开始时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("start_time")]
        [JsonProperty("start_time")]
        public Nullable<DateTime> StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 商品推广结束时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("plan_endtime")]
        [JsonProperty("plan_endtime")]
        public Nullable<DateTime> PlanEndtime
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
        /// 修改时间,格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("update_time")]
        [JsonProperty("update_time")]
        public Nullable<DateTime> UpdateTime
        {
            get;
            set;
        }

    }
}
