#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:13.69390 +08:00
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
    /// 通过api 根据ware_id 商品编号 操作商品下架 Response
    /// </summary>
    public class WareUpdateDelistingResponse : JdResponse
    {
        /// <summary>
        /// 更改时间
        /// </summary>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的id
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

    }
}
