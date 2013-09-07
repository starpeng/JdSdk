#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:34.21152 +08:00
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
    /// Fbp类型商家根据条件检索订单信息 Response
    /// </summary>
    public class OrderFbpSearchResponse : JdResponse
    {
        /// <summary>
        /// 订单数据
        /// </summary>
        [XmlElement("order_search")]
        [JsonProperty("order_search")]
        public OrderSearch OrderSearch
        {
            get;
            set;
        }

    }
}
