#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.13972 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 搜索商品信息。 Response
    /// </summary>
    public class JingdongWareGetResponse : JdResponse
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
