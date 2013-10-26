#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:44:196 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据商家设定的sku的外部id获取所对应的sku数据，一个sku的外部id对应一个sku数据。 Response
    /// </summary>
    public class SkuCustomGetResponse : JdResponse
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
