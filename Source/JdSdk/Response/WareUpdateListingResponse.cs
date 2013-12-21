#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:18.30102 +08:00
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
    /// 通过api 根据ware_id 商品编号 操作商品上架 Response
    /// </summary>
    public class WareUpdateListingResponse : JdResponse
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
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

    }
}
