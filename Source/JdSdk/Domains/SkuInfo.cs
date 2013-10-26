#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:14.71096 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SkuInfo结构
    /// </summary>
    [Serializable]
    public class SkuInfo : JdObject
    {
        /// <summary>
        /// skuid
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// Sku的属性
        /// </summary>
        [XmlElement("attribute")]
        [JsonProperty("attribute")]
        public String Attribute
        {
            get;
            set;
        }

    }
}
