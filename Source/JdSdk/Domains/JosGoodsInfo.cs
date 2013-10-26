#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76246 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// JosGoodsInfo属性
    /// </summary>
    [Serializable]
    public class JosGoodsInfo : JdObject
    {
        /// <summary>
        /// -1：内部异常，1:成功获取,2:有这个商品 但是不属于这个商家,3:没有这个商品存在,4:非法popId，直接返回
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code")]
        public Nullable<Int64> Code
        {
            get;
            set;
        }

        /// <summary>
        /// 三级分类名称
        /// </summary>
        [XmlElement("wp_name")]
        [JsonProperty("wp_name")]
        public String WpName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品主图
        /// </summary>
        [XmlElement("image_url")]
        [JsonProperty("image_url")]
        public String ImageUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("w_name")]
        [JsonProperty("w_name")]
        public String WName
        {
            get;
            set;
        }

        /// <summary>
        /// 三级分类id
        /// </summary>
        [XmlElement("wp_id")]
        [JsonProperty("wp_id")]
        public Nullable<Int64> WpId
        {
            get;
            set;
        }

        /// <summary>
        /// 各级分类名称
        /// </summary>
        [XmlElement("class_names")]
        [JsonProperty("class_names")]
        public List<String> ClassNames
        {
            get;
            set;
        }

        /// <summary>
        /// 各级分类id
        /// </summary>
        [XmlElement("class_ids")]
        [JsonProperty("class_ids")]
        public List<String> ClassIds
        {
            get;
            set;
        }

        /// <summary>
        /// 所有图url
        /// </summary>
        [XmlElement("image_urls")]
        [JsonProperty("image_urls")]
        public List<String> ImageUrls
        {
            get;
            set;
        }

        /// <summary>
        /// 该sku相同款式的 skuid 以及     主图
        /// </summary>
        [XmlArray("sku_similars")]
        [XmlArrayItem("sku_similar")]
        [JsonProperty("sku_similars")]
        public List<JosSkuInfo> SkuSimilars
        {
            get;
            set;
        }
    }
}
