#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26992 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// AdZoneVo属性
    /// </summary>
    [Serializable]
    public class AdZoneVo : JdObject
    {
        /// <summary>
        /// 专柜id
        /// </summary>
        [XmlElement("zone_id")]
        [JsonProperty("zone_id")]
        public Nullable<Int64> ZoneId
        {
            get;
            set;
        }

        /// <summary>
        /// 联盟id
        /// </summary>
        [XmlElement("union_id")]
        [JsonProperty("union_id")]
        public Nullable<Int64> UnionId
        {
            get;
            set;
        }

        /// <summary>
        /// 网站id
        /// </summary>
        [XmlElement("web_id")]
        [JsonProperty("web_id")]
        public Nullable<Int64> WebId
        {
            get;
            set;
        }

        /// <summary>
        /// 网站名称
        /// </summary>
        /// <example>京东商城</example>
        [XmlElement("web_name")]
        [JsonProperty("web_name")]
        public String WebName
        {
            get;
            set;
        }

        /// <summary>
        /// 网站域名
        /// </summary>
        /// <example>http://www.jd.com</example>
        [XmlElement("web_url")]
        [JsonProperty("web_url")]
        public String WebUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 专柜名称
        /// </summary>
        [XmlElement("zone_name")]
        [JsonProperty("zone_name")]
        public String ZoneName
        {
            get;
            set;
        }

        /// <summary>
        /// 专柜宽度
        /// </summary>
        [XmlElement("width")]
        [JsonProperty("width")]
        public Nullable<Decimal> Width
        {
            get;
            set;
        }

        /// <summary>
        /// 专柜高度
        /// </summary>
        [XmlElement("height")]
        [JsonProperty("height")]
        public Nullable<Decimal> Height
        {
            get;
            set;
        }

        /// <summary>
        /// 专柜推广类目
        /// </summary>
        [XmlElement("category")]
        [JsonProperty("category")]
        public List<Category> Category
        {
            get;
            set;
        }

        /// <summary>
        /// 专柜尺寸id
        /// </summary>
        [XmlElement("size_id")]
        [JsonProperty("size_id")]
        public Nullable<Int64> SizeId
        {
            get;
            set;
        }

        /// <summary>
        /// 专柜尺寸名称
        /// </summary>
        [XmlElement("size_name")]
        [JsonProperty("size_name")]
        public String SizeName
        {
            get;
            set;
        }

        /// <summary>
        /// 专柜推广类型
        /// </summary>
        /// <example>1,2</example>
        [XmlElement("promotion_type")]
        [JsonProperty("promotion_type")]
        public Nullable<Int64> PromotionType
        {
            get;
            set;
        }

        /// <summary>
        /// 专柜状态
        /// </summary>
        /// <example>1,2</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Nullable<Int64> Status
        {
            get;
            set;
        }
    }
}
