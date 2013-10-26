#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76947 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// CommoditySpu属性
    /// </summary>
    [Serializable]
    public class CommoditySpu : JdObject
    {
        /// <summary>
        /// 对应素材Id
        /// </summary>
        [XmlElement("material_id")]
        [JsonProperty("material_id")]
        public Int64 MaterialId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品skuid
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品图片url
        /// </summary>
        [XmlElement("image_url")]
        [JsonProperty("image_url")]
        public String ImageUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 商品图片服务器域名
        /// </summary>
        [XmlElement("domain")]
        [JsonProperty("domain")]
        public String Domain
        {
            get;
            set;
        }

    }
}
