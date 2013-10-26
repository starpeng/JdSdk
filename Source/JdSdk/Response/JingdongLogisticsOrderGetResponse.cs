#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:51.20549 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取订单信息 Response
    /// </summary>
    public class JingdongLogisticsOrderGetResponse : JdResponse
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
