#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:14.30394 +08:00
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
    /// 通过api接口，输入多个商品id（多个id用逗号分隔），批量得到所有相关商品的全部信息 Response
    /// </summary>
    public class WaresListGetResponse : JdResponse
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

    }
}
