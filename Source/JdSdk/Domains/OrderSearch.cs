#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.74746 +08:00
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
        /// 结果总数,所有订单数
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
