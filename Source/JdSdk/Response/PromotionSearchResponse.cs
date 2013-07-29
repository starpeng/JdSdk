#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:44:605 +08:00
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
    /// 根据条件获取促销信息 Response
    /// </summary>
    public class PromotionSearchResponse : JdResponse
    {
        /// <summary>
        /// 促销信息
        /// </summary>
        [XmlElement("promotion_search")]
        [JsonProperty("promotion_search")]
        public PromotionSearch PromotionSearch
        {
            get;
            set;
        }

    }
}
