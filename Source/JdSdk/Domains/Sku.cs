#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:851 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SKU结构
    /// </summary>
    [Serializable]
    public class Sku : JdObject
    {
        /// <summary>
        /// sku的id
        /// </summary>
        /// <example>2323</example>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺id
        /// </summary>
        /// <example>12314</example>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id")]
        public Nullable<Int64> ShopId
        {
            get;
            set;
        }

        /// <summary>
        /// sku所属商品id
        /// </summary>
        /// <example>123122</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        /// <summary>
        /// sku状态有效：Valid无效：Invalid删除：Delete
        /// </summary>
        /// <example>Valid</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        /// <summary>
        /// sku的销售属性组合字符串（颜色，大小，等等，可通过类目API获取某类目下的销售属性）,格式是aid1:vid1;aid2:vid2
        /// </summary>
        /// <example>1001:1501^1006:1504</example>
        [XmlElement("attributes")]
        [JsonProperty("attributes")]
        public String Attributes
        {
            get;
            set;
        }

        /// <summary>
        /// 库存
        /// </summary>
        /// <example>10</example>
        [XmlElement("stock_num")]
        [JsonProperty("stock_num")]
        public Nullable<Int64> StockNum
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价,精确到2位小数，单位元
        /// </summary>
        /// <example>12.13</example>
        [XmlElement("jd_price")]
        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 进货价, 精确到2位小数，单位元
        /// </summary>
        /// <example>123.13</example>
        [XmlElement("cost_price")]
        [JsonProperty("cost_price")]
        public String CostPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 市场价, 精确到2位小数，单位元
        /// </summary>
        /// <example>123.13</example>
        [XmlElement("market_price")]
        [JsonProperty("market_price")]
        public String MarketPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 外部id,商家设置的外部id
        /// </summary>
        /// <example>Af1315</example>
        [XmlElement("outer_id")]
        [JsonProperty("outer_id")]
        public String OuterId
        {
            get;
            set;
        }

        /// <summary>
        /// sku创建时间时间格式：yyyy-MM-ddHH:mm:ss
        /// </summary>
        /// <example>2011-11-04 15:24:43</example>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        /// <summary>
        /// sku修改时间时间格式：yyyy-MM-ddHH:mm:ss
        /// </summary>
        /// <example>2011-11-04 15:34:43</example>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        /// <summary>
        /// 颜色对应的值
        /// </summary>
        [XmlElement("color_value")]
        [JsonProperty("color_value")]
        public String ColorValue
        {
            get;
            set;
        }

        /// <summary>
        /// 尺码对应的值
        /// </summary>
        [XmlElement("size_value")]
        [JsonProperty("size_value")]
        public String SizeValue
        {
            get;
            set;
        }

    }
}
