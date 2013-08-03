#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.16979 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// JosSkuInfo属性
    /// </summary>
    [Serializable]
    public class JosSkuInfo : JdObject
    {
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
        /// 商品主图
        /// </summary>
        [XmlElement("sku_url")]
        [JsonProperty("sku_url")]
        public String SkuUrl
        {
            get;
            set;
        }

    }
}
