#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:51.81153 +08:00
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
    /// 其它入库单查询 Response
    /// </summary>
    public class JingdongLogisticsOtherInstoreQueryResponse : JdResponse
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
        /// josl入库单号
        /// </summary>
        [XmlElement("inbound_no")]
        [JsonProperty("inbound_no")]
        public String InboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// 入库单号
        /// </summary>
        [XmlElement("po_no")]
        [JsonProperty("po_no")]
        public String PoNo
        {
            get;
            set;
        }

        /// <summary>
        /// 入库状态
        /// </summary>
        [XmlElement("inbound_status")]
        [JsonProperty("inbound_status")]
        public String InboundStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("status_update_time")]
        [JsonProperty("status_update_time")]
        public Nullable<DateTime> StatusUpdateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 明细
        /// </summary>
        [XmlElement("task_details")]
        [JsonProperty("task_details")]
        public List<OtherInstoreOrderDetail> TaskDetails
        {
            get;
            set;
        }

    }
}
