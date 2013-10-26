#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:14.71296 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WarePropimg结构
    /// </summary>
    [Serializable]
    public class WarePropimg : JdObject
    {
        /// <summary>
        /// 商品的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 颜色id
        /// </summary>
        [XmlElement("color_id")]
        [JsonProperty("color_id")]
        public String ColorId
        {
            get;
            set;
        }

        /// <summary>
        /// 图片Id
        /// </summary>
        [XmlElement("img_id")]
        [JsonProperty("img_id")]
        public String ImgId
        {
            get;
            set;
        }

        /// <summary>
        /// 图片存储路径
        /// </summary>
        [XmlElement("img_url")]
        [JsonProperty("img_url")]
        public String ImgUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 是否主图
        /// </summary>
        [XmlElement("is_main")]
        [JsonProperty("is_main")]
        public String IsMain
        {
            get;
            set;
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        /// <summary>
        /// 0为正常，其它值参见错误代码一览表
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code")]
        public String Code
        {
            get;
            set;
        }

    }
}
