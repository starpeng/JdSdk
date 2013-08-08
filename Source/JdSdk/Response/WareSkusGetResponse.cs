#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:42:781 +08:00
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
    /// 获取多个商品下的所有sku。 Response
    /// </summary>
    public class WareSkusGetResponse : JdResponse
    {
        /// <summary>
        /// Sku
        /// </summary>
        [XmlElement("skus")]
        [JsonProperty("skus")]
        public List<Sku> Skus
        {
            get;
            set;
        }

    }
}
