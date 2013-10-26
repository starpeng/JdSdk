#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.77147 +08:00
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
        public Int64 Id
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
        public Int64 PageId
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位宽
        /// </summary>
        [XmlElement("width")]
        [JsonProperty("width")]
        public Int64 Width
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位高
        /// </summary>
        [XmlElement("height")]
        [JsonProperty("height")]
        public Int64 Height
        {
            get;
            set;
        }

        /// <summary>
        /// 日均流量
        /// </summary>
        [XmlElement("traffic")]
        [JsonProperty("traffic")]
        public Int64 Traffic
        {
            get;
            set;
        }

        /// <summary>
        /// 展示形式 :1: 图片 2: 文字3:    图片+文字
        /// </summary>
        [XmlElement("style")]
        [JsonProperty("style")]
        public Int64 Style
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位类型1: 频道页 2: 搜索页
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位状态 1:能投放 2:不能投放
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

    }
}
