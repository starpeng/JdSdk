#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.17579 +08:00
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
        public Nullable<Decimal> MaterialId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品skuid
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Nullable<Decimal> SkuId
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
