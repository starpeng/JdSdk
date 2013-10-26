#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:56.06077 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据促销编号获取促销详细信息 Response
    /// </summary>
    public class JingdongSellerPromotionGetResponse : JdResponse
    {
        /// <summary>
        /// 促销详细信息，包括创建时所有输入的促销信息
        /// </summary>
        [XmlElement("promotion_v_o")]
        [JsonProperty("promotion_v_o")]
        public PromotionVO PromotionVO
        {
            get;
            set;
        }

    }
}
