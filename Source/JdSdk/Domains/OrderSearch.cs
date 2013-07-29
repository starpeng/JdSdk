#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:857 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// OrderSearch结构
    /// </summary>
    [Serializable]
    public class OrderSearch : JdObject
    {
        /// <summary>
        /// 订单数据
        /// </summary>
        [XmlElement("order_info_list")]
        [JsonProperty("order_info_list")]
        public List<OrderInfo> OrderInfoList
        {
            get;
            set;
        }

        /// <summary>
        /// 查询订单的数量
        /// </summary>
        [XmlElement("order_total")]
        [JsonProperty("order_total")]
        public Int32 OrderTotal
        {
            get;
            set;
        }

    }
}
