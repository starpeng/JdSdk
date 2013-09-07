#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:57.47485 +08:00
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
    /// 暂停促销，使促销暂不生效，只能对已生效的促销进行暂停 Response
    /// </summary>
    public class JingdongSellerPromotionSuspendResponse : JdResponse
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
