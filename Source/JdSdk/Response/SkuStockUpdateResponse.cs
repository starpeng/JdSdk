#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:40:757 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 通过api 根据sku_id /outer_id修改库存接口，skuId和outerId 至少填一个，如果都有则以sku_id为准。 Response
    /// </summary>
    public class SkuStockUpdateResponse : JdResponse
    {
        /// <summary>
        /// Sku id
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// outer_id
        /// </summary>
        [XmlElement("outer_id")]
        [JsonProperty("outer_id")]
        public String OuterId
        {
            get;
            set;
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

    }
}
