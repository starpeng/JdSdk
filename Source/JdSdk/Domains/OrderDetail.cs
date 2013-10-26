#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.74446 +08:00
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
