#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:03.74121 +08:00
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
    /// 获取商品公开的详细数据 Response
    /// </summary>
    public class JingdongWaresSearchResponse : JdResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("wareInfos")]
        [JsonProperty("wareInfos")]
        public List<Ware> WareInfos
        {
            get;
            set;
        }

    }
}
