#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:14.50695 +08:00
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
    /// 根据商品的一些信息进行搜索。 Response
    /// </summary>
    public class WaresSearchResponse : JdResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("wares")]
        [JsonProperty("wares")]
        public List<Ware> Wares
        {
            get;
            set;
        }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("total")]
        [JsonProperty("total")]
        public Nullable<Decimal> Total
        {
            get;
            set;
        }

    }
}