#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.21555 +08:00
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
    /// 其它出库单查询 Response
    /// </summary>
    public class JingdongLogisticsOtherOutstoreQueryResponse : JdResponse
    {
        /// <summary>
        /// 查询成功代码 1:成功其他：失败
        /// </summary>
        [XmlElement("process_code")]
        [JsonProperty("process_code")]
        public Int64 ProcessCode
        {
            get;
            set;
        }

        /// <summary>
        /// 查询是否成功名称
        /// </summary>
        [XmlElement("process_status")]
        [JsonProperty("process_status")]
        public String ProcessStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        [JsonProperty("error_message")]
        public String ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// josl出库单号
        /// </summary>
        [XmlElement("josl_outbound_no")]
        [JsonProperty("josl_outbound_no")]
        public String JoslOutboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// ISV出库单号
        /// </summary>
        [XmlElement("isv_outbound_no")]
        [JsonProperty("isv_outbound_no")]
        public String IsvOutboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL出库状态
        /// </summary>
        [XmlElement("josl_status")]
        [JsonProperty("josl_status")]
        public String JoslStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 状态更新时间
        /// </summary>
        [XmlElement("complete_time")]
        [JsonProperty("complete_time")]
        public Nullable<DateTime> CompleteTime
        {
            get;
            set;
        }

        /// <summary>
        /// 其它出库单明细
        /// </summary>
        [XmlElement("order_details")]
        [JsonProperty("order_details")]
        public List<ResponseOrderOtherDetail> OrderDetails
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL承运商编号
        /// </summary>
        [XmlElement("carriers_id")]
        [JsonProperty("carriers_id")]
        public String CarriersId
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL承运商名称
        /// </summary>
        [XmlElement("carriers_name")]
        [JsonProperty("carriers_name")]
        public String CarriersName
        {
            get;
            set;
        }

        /// <summary>
        /// 运单号列表
        /// </summary>
        [XmlElement("delivery_no_list")]
        [JsonProperty("delivery_no_list")]
        public List<String> DeliveryNoList
        {
            get;
            set;
        }

    }
}
