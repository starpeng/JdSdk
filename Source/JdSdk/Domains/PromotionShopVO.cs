#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.24791 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 推广店铺对象
    /// </summary>
    [Serializable]
    public class PromotionShopVO : JdObject
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
        public Nullable<Decimal> PopId
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id")]
        public Nullable<Decimal> ShopId
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺推广所属计划id
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Nullable<Decimal> PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        [JsonProperty("shop_name")]
        public String ShopName
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺主图url
        /// </summary>
        [XmlElement("shop_mainurl")]
        [JsonProperty("shop_mainurl")]
        public String ShopMainurl
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺主营类目
        /// </summary>
        [XmlElement("main_categories")]
        [JsonProperty("main_categories")]
        public String MainCategories
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺链接
        /// </summary>
        [XmlElement("shop_url")]
        [JsonProperty("shop_url")]
        public String ShopUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 平均类目佣金
        /// </summary>
        [XmlElement("average_commision")]
        [JsonProperty("average_commision")]
        public Nullable<Decimal> AverageCommision
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺商品数量
        /// </summary>
        [XmlElement("goods_volume")]
        [JsonProperty("goods_volume")]
        public Nullable<Decimal> GoodsVolume
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺累计推广商品数量
        /// </summary>
        [XmlElement("accumulative_total")]
        [JsonProperty("accumulative_total")]
        public Nullable<Decimal> AccumulativeTotal
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺好评度
        /// </summary>
        [XmlElement("praise_degree")]
        [JsonProperty("praise_degree")]
        public Nullable<Decimal> PraiseDegree
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

    }
}
