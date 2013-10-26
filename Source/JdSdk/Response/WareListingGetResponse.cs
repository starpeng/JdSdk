#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:12.68085 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据商品的一些信息查询商品。 Response
    /// </summary>
    public class WareListingGetResponse : JdResponse
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
