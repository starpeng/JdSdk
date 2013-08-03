#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.17979 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SpaceInfo属性
    /// </summary>
    [Serializable]
    public class SpaceInfo : JdObject
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Nullable<Decimal> Id
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位描述
        /// </summary>
        [XmlElement("detail")]
        [JsonProperty("detail")]
        public String Detail
        {
            get;
            set;
        }

        /// <summary>
        /// 页面分类id
        /// </summary>
        [XmlElement("page_id")]
        [JsonProperty("page_id")]
        public Nullable<Decimal> PageId
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位宽
        /// </summary>
        [XmlElement("width")]
        [JsonProperty("width")]
        public Nullable<Decimal> Width
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位高
        /// </summary>
        [XmlElement("height")]
        [JsonProperty("height")]
        public Nullable<Decimal> Height
        {
            get;
            set;
        }

        /// <summary>
        /// 日均流量
        /// </summary>
        [XmlElement("traffic")]
        [JsonProperty("traffic")]
        public Nullable<Decimal> Traffic
        {
            get;
            set;
        }

        /// <summary>
        /// 展示形式 :1: 图片 2: 文字3:    图片+文字
        /// </summary>
        [XmlElement("style")]
        [JsonProperty("style")]
        public Nullable<Decimal> Style
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位类型1: 频道页 2: 搜索页
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Nullable<Decimal> Type
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位状态
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Nullable<Decimal> Status
        {
            get;
            set;
        }

    }
}
