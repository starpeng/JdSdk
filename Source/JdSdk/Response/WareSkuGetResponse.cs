#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:44:807 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据sku_id获取所对应的sku数据，sku_id对应的sku要属于传入的vender_id对应的商家 Response
    /// </summary>
    public class WareSkuGetResponse : JdResponse
    {
        /// <summary>
        /// Sku
        /// </summary>
        [XmlElement("sku")]
        [JsonProperty("sku")]
        public Sku Sku
        {
            get;
            set;
        }

    }
}
