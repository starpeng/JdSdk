#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78827 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ResponseReturnOrder属性
    /// </summary>
    [Serializable]
    public class ResponseReturnOrder : JdObject
    {
        /// <summary>
        /// 查询成功代码 1:成功 其他：失败
        /// </summary>
        /// <example>1</example>
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
        /// <example>SUCCESS</example>
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
        /// <example>无权限查看</example>
        [XmlElement("error_message")]
        [JsonProperty("error_message")]
        public String ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// josl退货入库单号
        /// </summary>
        /// <example>JRI000001</example>
        [XmlElement("josl_inbound_no")]
        [JsonProperty("josl_inbound_no")]
        public String JoslInboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// isv退货单号
        /// </summary>
        /// <example>EDBao1001</example>
        [XmlElement("return_order_no")]
        [JsonProperty("return_order_no")]
        public String ReturnOrderNo
        {
            get;
            set;
        }

        /// <summary>
        /// josl出库单号
        /// </summary>
        /// <example>JOSL0001023</example>
        [XmlElement("josl_outbound_no")]
        [JsonProperty("josl_outbound_no")]
        public String JoslOutboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// 入库状态代码
        /// </summary>
        /// <example>0:初始化，1：拒收，2：完成</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

        /// <summary>
        /// 状态更新时间
        /// </summary>
        /// <example>2013-05-11  12:23:11</example>
        [XmlElement("complete_time")]
        [JsonProperty("complete_time")]
        public String CompleteTime
        {
            get;
            set;
        }

    }
}
