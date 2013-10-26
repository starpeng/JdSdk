#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:56.86882 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 重启促销，使暂停的促销重新生效，只能对暂停的促销进行重启操作。 Response
    /// </summary>
    public class JingdongSellerPromotionResumeResponse : JdResponse
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
