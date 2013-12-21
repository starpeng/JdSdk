#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:15.85591 +08:00
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
    /// 通过api   增加sku信息 Response
    /// </summary>
    public class WareSkuAddResponse : JdResponse
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
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

    }
}
