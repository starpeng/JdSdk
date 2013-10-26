#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76346 +08:00
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
        public Int64 SkuId
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
