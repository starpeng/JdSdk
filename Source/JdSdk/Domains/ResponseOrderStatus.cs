#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78627 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ResponseOrderStatus属性
    /// </summary>
    [Serializable]
    public class ResponseOrderStatus : JdObject
    {
        /// <summary>
        /// JOSL唯一采购出库单号
        /// </summary>
        [XmlElement("receipt_no")]
        [JsonProperty("receipt_no")]
        public String ReceiptNo
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("order_status_details")]
        [JsonProperty("order_status_details")]
        public List<OrderStatusDetail> OrderStatusDetails
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("order_package_details")]
        [JsonProperty("order_package_details")]
        public List<OrderPackageDetail> OrderPackageDetails
        {
            get;
            set;
        }

    }
}
