#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:45:009 +08:00
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
    /// 输入单个订单id，得到所有相关订单信息 Response
    /// </summary>
    public class OrderGetResponse : JdResponse
    {
        /// <summary>
        /// 订单数据
        /// </summary>
        [XmlElement("order")]
        [JsonProperty("order")]
        public OrderDetail Order
        {
            get;
            set;
        }

    }
}
