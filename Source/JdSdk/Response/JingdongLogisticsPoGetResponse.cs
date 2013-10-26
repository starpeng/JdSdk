#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.62058 +08:00
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
    /// 获取采购单信息 Response
    /// </summary>
    public class JingdongLogisticsPoGetResponse : JdResponse
    {
        /// <summary>
        /// JOSL唯一采购入库单号
        /// </summary>
        [XmlElement("inboundNo")]
        [JsonProperty("inboundNo")]
        public String InboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// 外部系统传入入库单号
        /// </summary>
        [XmlElement("poNo")]
        [JsonProperty("poNo")]
        public String PoNo
        {
            get;
            set;
        }

        /// <summary>
        /// 采购入库单状态
        /// </summary>
        [XmlElement("receivingStatus")]
        [JsonProperty("receivingStatus")]
        public String ReceivingStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("task_details")]
        [JsonProperty("task_details")]
        public List<ReceivingTask> TaskDetails
        {
            get;
            set;
        }

    }
}
