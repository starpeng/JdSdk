#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:852 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PromotionSearch结构
    /// </summary>
    [Serializable]
    public class PromotionSearch : JdObject
    {
        /// <summary>
        /// 促销信息
        /// </summary>
        [XmlElement("promotion_list")]
        [JsonProperty("promotion_list")]
        public List< Promotion> PromotionList
        {
            get;
            set;
        }

        /// <summary>
        /// 促销的数量
        /// </summary>
        [XmlElement("promotion_total")]
        [JsonProperty("promotion_total")]
        public String PromotionTotal
        {
            get;
            set;
        }

    }
}
