#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:12.07081 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 通过api 根据ware_id 商品编号 删除商品 Response
    /// </summary>
    public class WareDeleteResponse : JdResponse
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
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
