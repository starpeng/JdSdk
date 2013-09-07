#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:51.40751 +08:00
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
    /// 获取多订单信息 Response
    /// </summary>
    public class JingdongLogisticsOrderSearchResponse : JdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("orders")]
        [JsonProperty("orders")]
        public List<ResponseOrderStatus> Orders
        {
            get;
            set;
        }

    }
}
