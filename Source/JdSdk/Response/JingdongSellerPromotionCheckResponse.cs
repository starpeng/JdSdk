#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:55.45374 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 促销审核，只能对人工审核状态的促销进行审核 Response
    /// </summary>
    public class JingdongSellerPromotionCheckResponse : JdResponse
    {
        /// <summary>
        /// 影响的条数
        /// </summary>
        /// <example>1</example>
        [XmlElement("count")]
        [JsonProperty("count")]
        public Int64 Count
        {
            get;
            set;
        }

    }
}
