#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:50.63086 +08:00
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
    /// 根据促销编号获取促销的道具列表 Response
    /// </summary>
    public class JingdongSellerPromotionPropListResponse : JdResponse
    {
        /// <summary>
        /// 促销道具列表
        /// </summary>
        [XmlElement("promo_prop_v_o_s")]
        [JsonProperty("promo_prop_v_o_s")]
        public List<PromoPropVO> PromoPropVOS
        {
            get;
            set;
        }

    }
}
