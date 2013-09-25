#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:12.27582 +08:00
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
    /// 根据商品的一些信息查询商品。 Response
    /// </summary>
    public class WareDelistingGetResponse : JdResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("ware_infos")]
        [JsonProperty("ware_infos")]
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
        public Int64 Total
        {
            get;
            set;
        }

    }
}
