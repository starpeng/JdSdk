#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:12.47783 +08:00
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
    /// 通过api接口，输入单个商品id，得到所有相关商品的全部信息 Response
    /// </summary>
    public class WareGetResponse : JdResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("ware")]
        [JsonProperty("ware")]
        public Ware Ware
        {
            get;
            set;
        }

    }
}
