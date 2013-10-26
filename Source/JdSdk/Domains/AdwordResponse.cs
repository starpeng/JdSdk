#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 13:02:46.27492 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// adwordResponse属性
    /// </summary>
    [Serializable]
    public class AdwordResponse : JdObject
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        /// <example>String</example>
        [XmlElement("skuId")]
        [JsonProperty("skuId")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品编号
        /// </summary>
        /// <example>String</example>
        [XmlElement("promotionInfoList ")]
        [JsonProperty("promotionInfoList ")]
        public List<PromotionInfo> PromotionInfoList
        {
            get;
            set;
        }

    }
}
