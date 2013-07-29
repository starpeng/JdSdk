#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:07.03631 +08:00
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
    ///  Response
    /// </summary>
    public class JingdongWarePromotionInfoGetResponse : JdResponse
    {
        /// <summary>
        /// 促销信息返回结构
        /// </summary>
        [XmlElement("promoInfoResponse")]
        [JsonProperty("promoInfoResponse")]
        public AdwordResponse PromoInfoResponse
        {
            get;
            set;
        }

    }
}
