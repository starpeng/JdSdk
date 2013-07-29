#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:853 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// OrderDetail结构
    /// </summary>
    [Serializable]
    public class OrderDetail : JdObject
    {
        /// <summary>
        /// 订单数据
        /// </summary>
        [XmlElement("OrderInfo")]
        [JsonProperty("OrderInfo")]
        public OrderInfo OrderInfo
        {
            get;
            set;
        }

    }
}
