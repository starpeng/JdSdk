#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:40:555 +08:00
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
    /// 通过api 根据sku_id 修改sku Response
    /// </summary>
    public class WareSkuUpdateResponse : JdResponse
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
