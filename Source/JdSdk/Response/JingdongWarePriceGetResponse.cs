#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:06.83330 +08:00
*/
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    ///  Response
    /// </summary>
    public class JingdongWarePriceGetResponse : JdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("price_changes")]
        [JsonProperty("price_changes")]
        public List<PriceChange> PriceChanges
        {
            get;
            set;
        }

    }
}
